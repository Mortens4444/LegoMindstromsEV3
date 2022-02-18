﻿using Mindstorms.Core.Commands;
using Mindstorms.Core.Commands.Button;
using Mindstorms.Core.Commands.File;
using Mindstorms.Core.Commands.Input;
using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.Commands.LED;
using Mindstorms.Core.Commands.Motor;
using Mindstorms.Core.Commands.PowerControl;
using Mindstorms.Core.Commands.Program;
using Mindstorms.Core.Commands.Speaker;
using Mindstorms.Core.Commands.System;
using Mindstorms.Core.Drawing;
using Mindstorms.Core.Enums;
using Mindstorms.Core.Music;
using Mindstorms.Core.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mindstorms.Core.EV3
{
    public class Brick : IDisposable
    {
        #region Members

        private readonly SerialPort comPort = null;
        private const int ReadWriteTimeout = 6000;
        private int sendingData = 0;
        private ushort messageCounter = 1;
        private readonly object soundPlayLock = new object();
        private bool disposed;
        private CancellationTokenSource musicPlayerCancellationTokenSource;

        #endregion

        #region Properties

        public bool IsConnected { get; private set; }

        public OutputPort LeftMotor { get; }

        public OutputPort RightMotor { get; }

        public OutputPort LeverMotor { get; }

        public OutputPort Motors
        {
            get
            {
                return LeftMotor | RightMotor;
            }
        }

        public Melody CurrentlyPlayedMelody { get; set; }

        #endregion

        #region Constructor

        public Brick(string port, OutputPort leftMotor, OutputPort rightMotor, OutputPort leverMotor)
        {
            comPort = new SerialPort(port)
            {
                WriteTimeout = ReadWriteTimeout,
                ReadTimeout = ReadWriteTimeout
            };
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
                comPort.Open();
                IsConnected = true;
            }
        }

        public void Disconnect()
        {
            if (IsConnected)
            {
                comPort.Close();
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
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
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
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
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
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
        }

        public string GetOperatingSystemBuild()
        {
            var response = Execute(new GetOperatingSystemBuild());
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
        }

        public string GetHardwareVersion()
        {
            var response = Execute(new GetHardwareVersion());
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
        }

        public string GetFirmwareVersion()
        {
            var response = Execute(new GetFirmwareVersion());
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
        }

        public string GetFirmwareBuild()
        {
            var response = Execute(new GetFirmwareBuild());
            return Constants.DefaultEncoding.GetString(response.RawResponseData, 3, Constants.DefaultResponseLength);
        }

        #endregion

        #region Sensor

        public byte[] GetSensorType(SensorPort sensorPort)
        {
            var result = Execute(new GetSensorType(sensorPort));
            return result.RawResponseData;
        }

        public SensorPort GetSensor(SensorType searchedSensorType)
        {
            var sensorPorts = Enum.GetValues(typeof(SensorPort));
            foreach (SensorPort sensorPort in sensorPorts)
            {
                var response = GetSensorType(sensorPort);

                var sensorType = response[3];
                //var sensorMode = response[4];

                if (sensorType == (byte)searchedSensorType)
                {
                    return sensorPort;
                }
            }
            return (SensorPort)sensorPorts.GetValue(0);
        }

        public byte[] ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode)
        {
            var response = Execute(new ReadGyroSensor(sensorPort, sensorMode));
            return response.RawResponseData;
        }

        public byte[] ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode)
        {
            var response = Execute(new ReadLightSensor(sensorPort, sensorMode));
            return response.RawResponseData;
        }

        public byte[] ReadTouchSensor(SensorPort sensorPort, TouchSensorMode sensorMode)
        {
            var response = Execute(new ReadTouchSensor(sensorPort, sensorMode));
            return response.RawResponseData;
        }

        public byte[] ReadUltrasonicSensor(SensorPort sensorPort, UltrasonicSensorMode sensorMode)
        {
            var response = Execute(new ReadUltrasonicSensor(sensorPort, sensorMode));
            return response.RawResponseData;
        }

        public byte[] ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode)
        {
            var response = Execute(new ReadInfraredSensor(sensorPort, sensorMode));
            return response.RawResponseData;
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

        public void Beep(byte volume, ushort frequency, ushort duration)
        {
            Execute(new Beep(volume, frequency, duration));
        }

        public void BeepAndWait(byte volume, ushort frequency, ushort duration)
        {
            ExecuteAndWait(new Beep(volume, frequency, duration));
        }

        public void Silence()
        {
            if (musicPlayerCancellationTokenSource != null)
            {
                musicPlayerCancellationTokenSource.Cancel();
            }
            Execute(new Silence());
        }

        public bool SpeakerIsBusy()
        {
            var response = Execute(new SpeakerIsBusy());
            return response.RawResponseData[response.RawResponseData.Length - 1] != 0;
        }

        public void PlaySound(string soundFilePath)
        {
            Execute(new PlaySound(soundFilePath));
        }

        public void PlayNote(string note)
        {
            Execute(new PlayNote(note));
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

                            ShowOnMiddleOfScreen(note, FontType.Big);
                            ExecuteAndWait(new PlayNote(note));
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
                                ShowOnMiddleOfScreen(note.Name, FontType.Big);
                                ExecuteAndWait(new Beep(note, duration));
                            }
                        }
                    }

                    CurrentlyPlayedMelody = null;
                }
            }, musicPlayerCancellationTokenSource.Token);
        }

        #endregion

        #region LED, LCD

        public void ShowOnMiddleOfScreen(string text, FontType fontType = FontType.Normal, byte verticalDelta = 0)
        {
            var horizontalDelta = text.Length * 10;
            ClearScreen();
            var x = (byte)(LCDCommand.HorizontalCenter - horizontalDelta);
            var y = (byte)(LCDCommand.VerticalCenter + verticalDelta);
            DrawString(x, y, text, LCDColor.Black, fontType);
            UpdateScreen();
        }

        public void ChangeLedsState(LedPattern ledPattern)
        {
            Execute(new ChangeLedsState(ledPattern));
        }

        public void PutPixel(EV3Point point, LCDColor color = LCDColor.Black)
        {
            PutPixel(point.X, point.Y, color);
        }

        public void PutPixel(byte x, byte y, LCDColor color = LCDColor.Black)
        {
            Execute(new PutPixel(x, y, color));
        }

        public void DrawLine(EV3Line line, LCDColor color = LCDColor.Black)
        {
            DrawLine(line.X1, line.Y1, line.X2, line.Y2, color);
        }

        public void DrawLine(byte x1, byte y1, byte x2, byte y2, LCDColor color = LCDColor.Black)
        {
            Execute(new DrawLine(x1, y1, x2, y2, color));
        }

        public void DrawCircle(EV3Circle circle, LCDColor color = LCDColor.Black, bool fill = false)
        {
            DrawCircle(circle.Center.X, circle.Center.Y, circle.Radius, color, fill);
        }

        public void DrawCircle(byte x, byte y, byte radius, LCDColor color = LCDColor.Black, bool fill = false)
        {
            Execute(new DrawCircle(x, y, radius, color, fill));
        }

        public void Draw(IEV3DrawingElement element, LCDColor color = LCDColor.Black, bool fill = false)
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
                    DrawCircle(circle, color, fill);
                    break;
                case EV3Text text:
                    DrawString(text);
                    break;
                case EV3InverseRectangle inverseRectangle:
                    InverseRectangle(inverseRectangle);
                    break;
                case EV3Rectangle rectangle:
                    DrawRectangle(rectangle, color, fill);
                    break;
                default:
                    break;
            }
        }

        public void DrawRectangle(EV3Rectangle rectangle, LCDColor color = LCDColor.Black, bool fill = false)
        {
            DrawRectangle(rectangle.TopLeftCorner.X, rectangle.TopLeftCorner.Y, rectangle.Width, rectangle.Height, color, fill);
        }

        public void DrawRectangle(byte x, byte y, byte width, byte height, LCDColor color = LCDColor.Black, bool fill = false)
        {
            Execute(new DrawRectangle(x, y, width, height, color, fill));
        }

        public void DrawString(EV3Text text)
        {
            DrawString(text.X, text.Y, text.Text);
        }

        public void DrawString(byte x, byte y, string text, LCDColor color = LCDColor.Black, FontType fontType = FontType.Normal)
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

        public void ShowImage(byte x, byte y, string imageFilePath, LCDColor color = LCDColor.Black)
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
        public byte SystemCall(string command)
        {
            var response = Execute(new SystemCall(command));
            return response.RawResponseData[3];
        }

        #endregion

        #region Motor

        public byte[] GetMotorPosition(OutputPort outputPort, MotorType motorType)
        {
            var response = Execute(new GetMotorPosition(outputPort, motorType));
            return response.RawResponseData;
        }

        public void SetMediumMotorSpeed(params SetMotorSpeedParams[] motorSpeedChanges)
        {
            foreach (var motorSpeedChange in motorSpeedChanges)
            {
                Execute(new SetMediumMotorSpeed(motorSpeedChange));
            }
        }

        public void SetLargeMotorSpeed(params SetMotorSpeedParams[] motorSpeedChanges)
        {
            foreach (var motorSpeedChange in motorSpeedChanges)
            {
                Execute(new SetLargeMotorSpeed(motorSpeedChange));
            }
        }

        #endregion

        #region Filesystem

        public IEnumerable<string> GetFolderContent(string path)
        {
            var response = Execute(new ListFiles(path));

            var rawDataWithOffset = response.RawResponseData.Skip(SystemCommandReply.SystemCommandResponseHeaderLength).ToArray();
            var folderContent = Encoding.UTF8.GetString(rawDataWithOffset).Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

#warning Fix folder listing.
            //while (reply.ListSize > ListFilesCommand.MaxListSize)
            //{
            //    Execute(new ContinueListFilesCommand(reply.Handle));
            //    rawDataWithOffset = rawData.Skip(SystemCommandReply.ContinueSystemCommandResponseHeaderLength).ToArray();
            //    //folderContent += Encoding.UTF8.GetString(rawDataWithOffset).Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //    reply.ListSize -= ListFilesCommand.MaxListSize;
            //}

            Array.Sort(folderContent);
            return folderContent;
        }

        public void CopyFileToBrick(string sourceFilePath, string destinationFilePath)
        {
            var fileContentToSend = File.ReadAllBytes(sourceFilePath);
            var fileSize = fileContentToSend.Length;

            var bytesToSend = Math.Min(fileSize, UploadFileToBrick.MaxChunkSize);

            var reply = Execute(new UploadFileToBrick(destinationFilePath, fileContentToSend.Take(bytesToSend))) as SystemCommandReply;
            var fileHandle = reply.Handle;

            int skippedBytes = 0;
            while ((fileSize -= bytesToSend) > 0)
            {
                skippedBytes += bytesToSend;
                bytesToSend = Math.Min(fileSize, UploadFileToBrick.MaxChunkSize);
                var dataBytes = fileContentToSend.Skip(skippedBytes).Take(bytesToSend);
                _ = Execute(new ContinueUploadFileToBrick(fileHandle, dataBytes)) as SystemCommandReply;
            }
        }

        public void CopyFileFromBrick(string sourceFilePath, string destinationFilePath, int fileSize)
        {
            var reply = Execute(new DownloadFileFromBrick(sourceFilePath)) as SystemCommandReply;
            var fileHandle = reply.Handle;

            if (reply.RawResponseData.Length == SystemCommandReply.ContinueSystemCommandResponseHeaderLength)
            {
                reply = Execute(new ContinueDownloadFileFromBrick(fileHandle)) as SystemCommandReply;
            }

            using (var fileStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                var chunkSize = Math.Min(fileSize, DownloadFileFromBrick.MaxChunkSize);
                fileStream.Write(reply.RawResponseData, SystemCommandReply.SystemCommandResponseHeaderLength, chunkSize);

                while ((fileSize -= DownloadFileFromBrick.MaxChunkSize) > 0)
                {
                    reply = Execute(new ContinueDownloadFileFromBrick(fileHandle)) as SystemCommandReply;
                    chunkSize = Math.Min(fileSize, DownloadFileFromBrick.MaxChunkSize);
                    fileStream.Write(reply.RawResponseData, SystemCommandReply.ContinueSystemCommandResponseHeaderLength, chunkSize);
                }
            }
        }

        public void CreateDirectory(string fullPathDirectoryName)
        {
            Execute(new CreateDirectory(fullPathDirectoryName));
        }

        public void DeleteFile(string fullPathFileName)
        {
            Execute(new DeleteFile(fullPathFileName));
        }

        #endregion

        #region General

        public ICommandReply Execute(Command command)
        {
            ICommandReply result = null;
            var hasError = false;
            try
            {
                if (Interlocked.Exchange(ref sendingData, 1) == 0)
                {
                    var messageCounterBytes = BitConverter.GetBytes(messageCounter);
                    var dataToSendLength = BitConverter.GetBytes((ushort)(command.Data.Length + messageCounterBytes.Length));

                    comPort.Write(dataToSendLength, 0, dataToSendLength.Length);
                    comPort.Write(messageCounterBytes, 0, messageCounterBytes.Length);
                    comPort.Write(command.Data, 0, command.Data.Length);
                    sendingData = 0;

                    if ((command.Data[0] & (byte)Response.NotExpected) == 0)
                    {
                        var rawResponseData = Receive();

                        result = (command.Data[0] & (byte)CommandType.SystemCommand) == 1 ? (ICommandReply)
                                new SystemCommandReply(rawResponseData) :
                                new DirectCommandReply(rawResponseData);

                        if (result.MessageCounter != messageCounter)
                        {
                            hasError = true;
                            throw new Exception($"Expected message: #{messageCounter}, arrived message: {result}");
                        }
                        if (result.TypeOfMessage == CommandType.SystemCommandReplyWithError || result.TypeOfMessage == CommandType.DirectCommandReplyWithError)
                        {
                            hasError = true;
                            throw new Exception($"Error occurred: {result}");
                        }
                    }
                    messageCounter++;
                }
            }
            finally
            {
                sendingData = 0;
                if (hasError)
                {
                    Dispose();
                }
            }
            return result;
        }

        public void ExecuteAndWait(AwaitableCommand command)
        {
            Execute(command);
            Thread.Sleep(command.DurationMs);
        }

        private byte[] Receive()
        {
            var data = new byte[2];
            _ = comPort.Read(data, 0, 2);
            var expectedlength = (ushort)(0x0000 | data[0] | (data[1] << 8));
            var payload = new byte[expectedlength];
            _ = comPort.Read(payload, 0, expectedlength);
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
                    comPort.Dispose();
                }

                disposed = true;
            }
        }

        #endregion
    }
}
