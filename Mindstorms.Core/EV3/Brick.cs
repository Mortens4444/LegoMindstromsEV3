﻿using Mindstorms.Core.Commands;
using Mindstorms.Core.Commands.Button;
using Mindstorms.Core.Commands.Error;
using Mindstorms.Core.Commands.File;
using Mindstorms.Core.Commands.Input;
using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.Commands.LED;
using Mindstorms.Core.Commands.Mathematics.Arithmetic;
using Mindstorms.Core.Commands.Motor;
using Mindstorms.Core.Commands.PowerControl;
using Mindstorms.Core.Commands.Program;
using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Commands.Speaker;
using Mindstorms.Core.Commands.System;
using Mindstorms.Core.Drawing;
using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;
using Mindstorms.Core.FileWriter;
using Mindstorms.Core.Music;
using Mindstorms.Core.Resources;
using Mindstorms.Core.Responses;
using System.Globalization;
using System.Text;
using Utils;

namespace Mindstorms.Core.EV3;

public class Brick : IDisposable
{
    #region Members

    private readonly IDeviceConnection deviceConnection;

    private ushort messageCounter = 1;
    private readonly object soundPlayLock = new();
    private bool disposed;
    private readonly object commandSendingSync = new();
    private CancellationTokenSource musicPlayerCancellationTokenSource = new();

    #endregion

    #region Properties

    public byte Volume { get; set; }

    public bool IsConnected { get; private set; }

    public OutputPort LeftMotor { get; private set; } = OutputPort.B;

    public OutputPort RightMotor { get; private set; } = OutputPort.C;

    public OutputPort LeverMotor { get; private set; } = OutputPort.A;

    public OutputPort Motors
    {
        get
        {
            return LeftMotor | RightMotor;
        }
    }

    public Melody? CurrentlyPlayedMelody { get; set; }

    #endregion

    #region Constructor

    public Brick(string port)
    {
        deviceConnection = new ComDeviceConnection(port);
    }

    public Brick(string machine, string pipeName)
    {
        deviceConnection = new NamedPipeClientStreamDeviceConnection(machine, pipeName);
    }
    
    public void SetMotors(OutputPort leftMotor, OutputPort rightMotor, OutputPort leverMotor)
    {
        LeftMotor = leftMotor;
        RightMotor = rightMotor;
        LeverMotor = leverMotor;
    }

    #endregion

    #region Connect / Disconnect

    public void Connect()
    {
        if (!IsConnected)
        {
            deviceConnection.Connect();
            IsConnected = true;

            var reply = Execute(new GetVolume());
            Volume = reply.RawResponseData[3];
        }
    }

    public void Disconnect()
    {
        if (IsConnected)
        {
            SetLargeMotorSpeed(DaisyChainLayer.EV3, new SetMotorSpeedParams(Motors, 0));
            SetLargeMotorSpeed(DaisyChainLayer.First, new SetMotorSpeedParams(Motors, 0));
            SetLargeMotorSpeed(DaisyChainLayer.Second, new SetMotorSpeedParams(Motors, 0));
            SetLargeMotorSpeed(DaisyChainLayer.Third, new SetMotorSpeedParams(Motors, 0));
            Silence();

            deviceConnection.Disconnect();
            IsConnected = false;
        }
    }

    #endregion

    #region Device

    public void KeepAlive(byte minutes)
    {
        Execute(new KeepAlive(minutes));
    }

    public string GetBrickName()
    {
        var response = Execute(new GetBrickName());
        return response.GetResponseAsString();
    }

    public bool IsActive(CommunicationInterface communicationInterface)
    {
        var response = Execute(new IsActive(communicationInterface));
        return Convert.ToBoolean(response.RawResponseData[3]);
    }

    public void SetBrickName(string brickName)
    {
        Execute(new SetBrickName(brickName));
    }

    public string GetPin(CommunicationInterface communicationInterface, string brickName)
    {
        var response = Execute(new GetPin(communicationInterface, brickName));
        return response.GetResponseAsString();
    }

    public void SetPin(CommunicationInterface communicationInterface, string brickName, string pinCode)
    {
        Execute(new SetPin(communicationInterface, brickName, pinCode));
    }
    
    public float GetBatteryVoltage()
    {
        var response = Execute(new GetBatteryVoltage());
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }
    
    public float GetBatteryCurrent()
    {
        var response = Execute(new GetBatteryCurrent());
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public byte GetBatteryLevel()
    {
        var response = Execute(new GetBatteryLevel());
        return response.RawResponseData[3];
    }

    public float GetBatteryTemperatureRise()
    {
        var response = Execute(new GetBatteryTemperatureRise());
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public string GetOperatingSystemVersion()
    {
        var response = Execute(new GetOperatingSystemVersion());
        return response.GetResponseAsString();
    }

    public string GetOperatingSystemBuild()
    {
        var response = Execute(new GetOperatingSystemBuild());
        return response.GetResponseAsString();
    }

    public string GetHardwareVersion()
    {
        var response = Execute(new GetHardwareVersion());
        return response.GetResponseAsString();
    }

    public string GetFirmwareVersion()
    {
        var response = Execute(new GetFirmwareVersion());
        return response.GetResponseAsString();
    }

    public string GetFirmwareBuild()
    {
        var response = Execute(new GetFirmwareBuild());
        return response.GetResponseAsString();
    }

    public string GetLastError()
    {
        var reply = Execute(new GetError());
        var errorCode = reply.RawResponseData[3];
        reply = Execute(new GetErrorMessage(errorCode));
        var message = Constants.DefaultEncoding.GetString(reply.RawResponseData, 3, Constants.DefaultResponseLength);
        if (String.IsNullOrEmpty(message))
        {
            message = "N/A";
        }
        return $"{errorCode}: {message}";
    }

    #endregion

    #region Sensor

    public string GetSensorName(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
    {
        var response = Execute(new GetName(sensorPort, daisyChainLayer));
        return response.GetResponseAsString();
    }

    public void FollowLine(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
    {
        var result = Execute(new InputRead(daisyChainLayer, sensorPort));
        if (result.RawResponseData != null && result.RawResponseData.Length > 1)
        {
            var lv0 = result.RawResponseData[^1];
            lv0 /= 2;
            lv0 += 15;

            byte lv1;
            while (true)
            {
                result = Execute(new InputRead(daisyChainLayer, sensorPort));
                lv1 = result.RawResponseData[^1];

                lv1 -= lv0;
                lv1 /= 2;

                var lv2 = (byte)(40 + lv1);
                var lv3 = (byte)(40 - lv1);

                Execute(new OutputPower(daisyChainLayer, LeftMotor, lv3));
                Execute(new OutputPower(daisyChainLayer, RightMotor, lv2));
                Execute(new OutputStart(daisyChainLayer, Motors));
            }
        }
    }

    public byte[] GetSensorType(SensorPort sensorPort, DaisyChainLayer daisyChainLayer)
    {
        var result = Execute(new GetSensorType(sensorPort, daisyChainLayer));
        return result.RawResponseData;
    }

    public SensorPort GetSensor(SensorType searchedSensorType, DaisyChainLayer daisyChainLayer)
    {
        var sensorPorts = SensorPort.GetValues();
        foreach (SensorPort sensorPort in sensorPorts)
        {
            var response = GetSensorType(sensorPort, daisyChainLayer);

            var sensorType = response[3];
            //var sensorMode = response[4];

            if (sensorType == searchedSensorType)
            {
                return sensorPort;
            }
        }
        return (SensorPort)sensorPorts[0]!;
    }

    public float ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadGyroSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadLightSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadTouchSensor(SensorPort sensorPort, TouchSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadTouchSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadUltrasonicSensor(SensorPort sensorPort, UltrasonicSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadUltrasonicSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadInfraredSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    private float ExecuteSensorCommand(SensorRead sensorReadCommand)
    {
        var response = Execute(sensorReadCommand);
        return sensorReadCommand.GetResult(response.RawResponseData);
    }

    #endregion

    #region Button

    public ButtonStates GetButtonStates()
    {
        var response = Execute(new GetButtonStates());
        return new ButtonStates(response.RawResponseData);
    }

    public void PressButton(ButtonType button)
    {
        Execute(new PressButton(button));
    }

    public void PressAndReleaseButton(ButtonType button)
    {
        Execute(new PressAndReleaseButton(button));
    }

    public void ReleaseButton(ButtonType button)
    {
        Execute(new ReleaseButton(button));
    }
    
    public void Flush()
    {
        Execute(new Flush());
    }

    public void Shutdown()
    {
        Execute(new Shutdown());
    }

    #endregion

    #region Sound

    public void Beep(ushort frequency, ushort duration)
    {
        Execute(new Beep(Volume, frequency, duration));
    }

    public void BeepAndWait(ushort frequency, ushort duration)
    {
        ExecuteAndWait(new Beep(Volume, frequency, duration));
    }

    public void Silence()
    {
        musicPlayerCancellationTokenSource.Cancel();
        Execute(new Silence());
    }

    public bool SpeakerIsBusy()
    {
        var response = Execute(new SpeakerIsBusy());
        return response.RawResponseData[^1] != 0;
    }

    public void PlayNote(string note, ushort durationMs = Constants.DefaultNoteDurationMs)
    {
        Execute(new PlayNote(Volume, note, durationMs));
    }

    public void PlayMusic(Melody melody)
    {
        if (CurrentlyPlayedMelody != null)
        {
            return;
        }

        musicPlayerCancellationTokenSource = new CancellationTokenSource();
        Task.Factory.StartNew(() =>
        {
            lock (soundPlayLock)
            {
                CurrentlyPlayedMelody = melody;

                if (melody.Notes != null)
                {
                    foreach (var note in melody.Notes)
                    {
                        if (musicPlayerCancellationTokenSource.IsCancellationRequested)
                        {
                            break;
                        }

                        ClearScreen();
                        ShowOnMiddleOfScreen(note, FontType.Big, 0);
                        ExecuteAndWait(new PlayNote(Volume, note));
                    }
                }
                else
                {
                    foreach (var note in melody)
                    {
                        if (musicPlayerCancellationTokenSource.IsCancellationRequested)
                        {
                            break;
                        }

                        var duration = melody.GetNoteLength(note.NoteType);
                        if (note is Fermata)
                        {
                            Thread.Sleep(duration);
                        }
                        else
                        {
                            ClearScreen();
                            ShowOnMiddleOfScreen(note.Name, FontType.Big, 0);
                            ExecuteAndWait(new Beep(Volume, note, duration));
                        }
                    }
                }

                CurrentlyPlayedMelody = null;
            }
        }, musicPlayerCancellationTokenSource.Token);
    }

    public void PlaySound(string soundFilePath, bool repeat = false)
    {
        Execute(new PlaySound(Volume, soundFilePath, repeat));
    }

    public void PlaySound(EmbeddedSound embeddedSound, PlayType playType)
    {
        var description = embeddedSound.GetDescription();
        var file = ResourceUploader.UploadSound(this, $"{description}{Constants.SoundFileExtension}");
        var repeat = playType == PlayType.Repeat;
        Execute(new PlaySound(Volume, file, repeat));
        if (playType == PlayType.WaitForCompletion)
        {
            while (SpeakerIsBusy())
            {
                Thread.Sleep(300);
            }
        }
    }

    #endregion

    #region LED, LCD

    public void ShowOnMiddleOfScreen(string text, FontType fontType, byte verticalDelta)
    {
        double modifier = fontType == FontType.Normal ? 4 : fontType == FontType.Big ? 8 : 2.5;
        var horizontalDelta = text.Length * modifier;

        var x = (byte)(LCDCommand.HorizontalCenter - horizontalDelta);
        var y = (byte)(LCDCommand.VerticalCenter + verticalDelta - modifier);
        DrawString(x, y, text, LCDColor.Black, fontType);
        UpdateScreen();
    }

    public void ChangeLEDsState(LedPattern ledPattern)
    {
        Execute(new ChangeLedsState(ledPattern));
    }

    public void PutPixel(EV3Point point, LCDColor color)
    {
        PutPixel(point.X, point.Y, color);
    }

    public void PutPixel(byte x, byte y, LCDColor color)
    {
        Execute(new PutPixel(x, y, color));
    }

    public void DrawLine(EV3Line line, LCDColor color)
    {
        DrawLine(line.X1, line.Y1, line.X2, line.Y2, color);
    }

    public void DrawLine(byte x1, byte y1, byte x2, byte y2, LCDColor color)
    {
        Execute(new DrawLine(x1, y1, x2, y2, color));
    }

    public void DrawCircle(EV3Circle circle, LCDColor color)
    {
        DrawCircle(circle.Center.X, circle.Center.Y, circle.Radius, color, circle.Fill);
    }

    public void DrawCircle(byte x, byte y, byte radius, LCDColor color, bool fill = false)
    {
        Execute(new DrawCircle(x, y, radius, color, fill));
    }

    public void Draw(IEV3DrawingElement element, LCDColor color)
    {
        switch (element)
        {
            case EV3Point point:
                PutPixel(point.X, point.Y, color);
                break;
            case EV3Line line:
                DrawLine(line, color);
                break;
            case EV3Circle circle:
                DrawCircle(circle, color);
                break;
            case EV3Text text:
                DrawString(text);
                break;
            case EV3InverseRectangle inverseRectangle:
                InverseRectangle(inverseRectangle);
                break;
            case EV3Rectangle rectangle:
                DrawRectangle(rectangle, color);
                break;
            default:
                break;
        }
    }

    public void DrawRectangle(EV3Rectangle rectangle, LCDColor color)
    {
        DrawRectangle(rectangle.TopLeftCorner.X, rectangle.TopLeftCorner.Y, rectangle.Width, rectangle.Height, color, rectangle.Fill);
    }

    public void DrawRectangle(byte x, byte y, byte width, byte height, LCDColor color, bool fill = false)
    {
        Execute(new DrawRectangle(x, y, width, height, color, fill));
    }

    public void DrawString(EV3Text text)
    {
        DrawString(text.X, text.Y, text.Text, LCDColor.Black, FontType.Normal);
    }

    public void DrawString(byte x, byte y, string text, LCDColor color, FontType fontType)
    {
        Execute(new DrawString(x, y, text, color, fontType));
    }

    public void ChangeFontType(FontType fontType)
    {
        Execute(new ChangeFontType(fontType));
    }

    public void InverseRectangle(EV3InverseRectangle rectangle)
    {
        InverseRectangle(rectangle.TopLeftCorner.X, rectangle.TopLeftCorner.Y, rectangle.Width, rectangle.Height);
    }

    public void InverseRectangle(byte x, byte y, byte width, byte height)
    {
        Execute(new InverseRectangle(x, y, width, height));
    }

    public void ShowImage(EmbeddedImage embeddedImage)
    {
        var description = embeddedImage.GetDescription();
        var file = ResourceUploader.UploadImage(this, $"{description}{Constants.GraphicsFileExtension}");
        Execute(new ShowImage(0, 0, file, LCDColor.Black));
    }

    public void ShowImage(byte x, byte y, string imageFilePath, LCDColor color)
    {
        Execute(new ShowImage(x, y, imageFilePath, color));
    }

    public void ClearScreen()
    {
        Execute(new Clean());
    }

    public void RestoreScreen(byte level)
    {
        Execute(new Restore(level));
    }

    public void GraphDraw(byte view)
    {
        Execute(new GraphDraw(view));
    }

    public void ChangeTopLine(State state)
    {
        Execute(new ChangeTopLine(state));
    }

    public void UpdateScreen()
    {
        Execute(new Update());
    }

    public void ScreenBlock(bool set)
    {
        Execute(new ScreenBlock(set));
    }

    #endregion

    #region Program

    public void Start(string command)
    {
        Execute(new Start(command));
    }

    public byte[] GetProgramInfo(ushort programSlotId)
    {
        var response = Execute(new GetInfo(programSlotId));
        return response.RawResponseData;
    }

    public void StopApplication()
    {
        Execute(new Stop());
    }

    public void StopCurrent()
    {
        Execute(new StopCurrent());
    }

    /// <summary>
    /// Execute a command.
    /// </summary>
    /// <param name="command">The command to be executed.</param>
    /// <returns>Return code of the command.</returns>
    public int SystemCall(string command)
    {
        var response = Execute(new SystemCall(command));
        return BitConverter.ToInt32(response.RawResponseData, 3);
    }

    #endregion

    #region Motor

    public byte[] GetMotorPosition(OutputPort outputPort, MotorType motorType, DaisyChainLayer daisyChainLayer)
    {
        var response = Execute(new GetMotorPosition(outputPort, motorType, daisyChainLayer));
        return response.RawResponseData;
    }

    public void SetMediumMotorSpeed(DaisyChainLayer daisyChainLayer, params SetMotorSpeedParams[] motorSpeedChanges)
    {
        foreach (var motorSpeedChange in motorSpeedChanges)
        {
            Execute(new SetMotorSpeed(motorSpeedChange, daisyChainLayer, MotorType.Medium));
        }
    }

    public void SetLargeMotorSpeed(DaisyChainLayer daisyChainLayer, params SetMotorSpeedParams[] motorSpeedChanges)
    {
        foreach (var motorSpeedChange in motorSpeedChanges)
        {
            Execute(new SetMotorSpeed(motorSpeedChange, daisyChainLayer, MotorType.Large));
        }
    }

    public void StopMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort, BreakType breakType)
    {
        Execute(new StopMotor(daisyChainLayer, outputPort, breakType));
    }

    public void ChangeMotorPolarity(DaisyChainLayer daisyChainLayer, OutputPort outputPort, Polarity polarity)
    {
        Execute(new ChangeMotorPolarity(daisyChainLayer, outputPort, polarity));
    }

    public void ResetMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        Execute(new ResetMotor(daisyChainLayer, outputPort));
    }

    public bool MotorIsBusy(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        var response = Execute(new MotorIsBusy(daisyChainLayer, outputPort));
        return response.RawResponseData[^1] != 0;
    }

    public (byte Speed, int TachoCountLevel) GetSpeedAndTachoCountLevel(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        var response = Execute(new GetSpeedAndTachoCountLevel(daisyChainLayer, outputPort));
        var speed = response.RawResponseData[3];
        var tachoCountLevel = BitConverter.ToInt32(response.RawResponseData, 4);
        return (speed, tachoCountLevel);
    }

    #endregion

    #region Filesystem

    public IEnumerable<string> GetFolderContent(string path)
    {
        var response = ExecuteSystemCommand(new ListFiles(path));
        var rawDataWithOffset = response.RawResponseData.Skip(SystemCommandReply.SystemCommandResponseHeaderLength).ToArray();
        var folderContentStringBuilder = new StringBuilder(Encoding.UTF8.GetString(rawDataWithOffset));

        while (response.CommandReplyStatus != CommandReplyStatus.EndOfFile)
        {
            response = ExecuteSystemCommand(new ContinueListFiles(response.Handle));
            rawDataWithOffset = response.RawResponseData.Skip(SystemCommandReply.ContinueSystemCommandResponseHeaderLength).ToArray();
            folderContentStringBuilder.Append(Encoding.UTF8.GetString(rawDataWithOffset));
        }

        return folderContentStringBuilder.ToString().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }

    public int GetSize(string filePath)
    {
        var folder = filePath[..filePath.LastIndexOf('/')];
        var fileName = Path.GetFileName(filePath);
        var folderContent = GetFolderContent(folder);
        foreach (var item in folderContent)
        {
            var properties = item.Split(' ');
            if ((properties.Length > 2) && (fileName == String.Join(" ", properties.Skip(2))))
            {
                return Int32.Parse(properties[1], NumberStyles.HexNumber);
            }
        }

        throw new FileNotFoundException($"Can't find file: {filePath}");
    }

    public bool IsExists(string filePath)
    {
        var result = Execute(new IsExists(filePath));
        return Convert.ToBoolean(result.RawResponseData[3]);
    }

    public void CopyFileToBrick(string sourceFilePath, string destinationFilePath)
    {
        var fileContentToSend = File.ReadAllBytes(sourceFilePath);
        var fileSize = fileContentToSend.Length;

        var uploadFileToBrick = new UploadFileToBrick(destinationFilePath, fileSize);
        var reply = ExecuteSystemCommand(uploadFileToBrick);
        var fileHandle = reply.Handle;

        var bytesToSend = 0;
        var skippedBytes = 0;

        while ((fileSize -= bytesToSend) > 0)
        {
            skippedBytes += bytesToSend;
            bytesToSend = Math.Min(fileSize, Constants.ChunkSize);
            var dataBytes = fileContentToSend.Skip(skippedBytes).Take(bytesToSend);
            Execute(new ContinueUploadFileToBrick(fileHandle, dataBytes));
        }
    }

    public bool CopyFileFromBrick(string sourceFilePath, int fileSize, IWriter writer)
    {
        int chunkSize = 0;
        byte fileHandle = 0;
        SystemCommandReply? reply;

        while ((fileSize -= chunkSize) > 0)
        {
            var notFirstChunk = chunkSize != 0;
            if (notFirstChunk)
            {
                reply = ExecuteSystemCommand(new ContinueDownloadFileFromBrick(fileHandle));
            }
            else
            {
                reply = ExecuteSystemCommand(new DownloadFileFromBrick(sourceFilePath, fileSize));
                fileHandle = reply?.Handle ?? 0;
            }

            if (reply != null)
            {
                chunkSize = GetChunkSize(fileSize, reply.RawResponseData.Length, notFirstChunk);
                writer.Write(reply.RawResponseData, SystemCommandReply.ContinueSystemCommandResponseHeaderLength, chunkSize);
            }
        }

        return true;
    }

    private static int GetChunkSize(int fileSize, int rawResponseDataLength, bool @continue)
    {
        var modifier = @continue ? SystemCommandReply.ContinueSystemCommandResponseHeaderLength : SystemCommandReply.SystemCommandResponseHeaderLength;
        return Math.Min(Math.Min(fileSize, Constants.ChunkSize), rawResponseDataLength - modifier);
    }

    public void CreateDirectory(string fullPathDirectoryName)
    {
        Execute(new CreateDirectory(fullPathDirectoryName));
    }

    public bool DeleteFile(string fullPathFileName)
    {
        var result = Execute(new DeleteFile(fullPathFileName));
        return result?.CommandReplyStatus == CommandReplyStatus.Success;
    }

    #endregion

    #region Mathematics

    public float Add(float value1, float value2)
    {
        var response = Execute(new Add(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float Subtract(float value1, float value2)
    {
        var response = Execute(new Subtract(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float Multiply(float value1, float value2)
    {
        var response = Execute(new Multiply(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float Divide(float value1, float value2)
    {
        var response = Execute(new Divide(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    #endregion

    #region General

    public ICommandReply Execute(Command command)
    {
        ICommandReply? result = null;
        using var cancellationTokenSource = new CancellationTokenSource(Constants.CommandExecutionTimeout);
        var cancellationToken = cancellationTokenSource.Token;

        lock (commandSendingSync)
        {
            try
            {
                var messageCounterBytes = BitConverter.GetBytes(messageCounter);
                var dataToSendLength = BitConverter.GetBytes((ushort)(command.Data.Length + messageCounterBytes.Length));

                deviceConnection.Write(dataToSendLength, 0, dataToSendLength.Length);
                deviceConnection.Write(messageCounterBytes, 0, messageCounterBytes.Length);
                deviceConnection.Write(command.Data, 0, command.Data.Length);

                if (command.IsResponseRequired())
                {
                    do
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        var rawResponseData = Receive();

                        if (rawResponseData != null && rawResponseData.Length > 0)
                        {
                            result = command.Data[0].IsSystemCommand() ?
                                    new SystemCommandReply(rawResponseData) :
                                    new DirectCommandReply(rawResponseData);

                            if (result.CommandType.HasError())
                            {
                                throw new InvalidOperationException($"Error occurred: {result}");
                            }
                        }
                    } while (result?.MessageCounter != messageCounter);
                }
                messageCounter++;
            }
            catch (OperationCanceledException)
            {
                throw new TimeoutException($"The operation has timed out: {command}");
            }
        }
        return result!;
    }

    public void ExecuteAndWait(AwaitableCommand command)
    {
        Execute(command);
        Thread.Sleep(command.DurationMs);
    }

    private SystemCommandReply ExecuteSystemCommand(Command command)
    {
        var reply = Execute(command) as SystemCommandReply;
        return reply ?? throw new InvalidCastException($"Response cannot be cast to {nameof(SystemCommandReply)}.");
    }

    private byte[] Receive()
    {
        var data = new byte[2];
        _ = deviceConnection.Read(data, 0, 2);
        var expectedLength = (ushort)(data[0] | (data[1] << 8));
        var payload = new byte[expectedLength];
        _ = deviceConnection.Read(payload, 0, expectedLength);
        return payload;
    }

    #endregion

    #region IDisposable pattern

    ~Brick()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        Disconnect();
        if (!disposed)
        {
            if (disposing)
            {
                musicPlayerCancellationTokenSource.Dispose();
                deviceConnection.Dispose();
            }

            disposed = true;
        }
    }

    #endregion
}
