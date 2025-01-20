﻿#if USE_JOYSTICK
using Mtf.Joystick;
using LargeLanguageModelClient.ChatGpt;
using LargeLanguageModelClient.ChatGpt.Dto;
#endif
using Microsoft.Extensions.Configuration;
using Mindstorms.Controller.SensorRead;
using Mindstorms.Core;
using Mindstorms.Core.Commands.MailBox;
using Mindstorms.Core.Commands.Motor;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Extensions;
#if USE_SPEECH_RECOGNITION
using Mindstorms.Core.Music.Melodies;
#endif
using Mindstorms.Core.Signaling;
using Mindstorms.Game.Snake;
#if USE_SPEECH_RECOGNITION
using SpeechRecognition;
#endif
using System;
#if USE_SPEECH_RECOGNITION
using System.Collections.Generic;
#endif
using System.IO.Ports;
#if USE_SPEECH_RECOGNITION
using System.Speech.Recognition;
#endif
using System.Threading;
#if USE_JOYSTICK
using System.Threading.Tasks;
#endif
using System.Windows.Forms;
using Utils;
#if USE_JOYSTICK
using Action = System.Action;
using Mtf.MessageBoxes;
#endif

namespace Mindstorms.Controller;

public partial class MainForm : Form
{
    private Brick? brick;
    private const string EnumsNamespace = "Mindstorms.Core.Enums";

#if USE_SPEECH_RECOGNITION
    private SpeechRecognitionEngine? speechRecognitionEngine;
#endif
    public IConfiguration Configuration { get; set; }

    public MainForm()
    {
        var assembly = typeof(ButtonEvent).Assembly;
        assembly.InitializeStaticObjects(EnumsNamespace);

        InitializeComponent();
        tscbLeverMotor.ComboBox.FillAndSelect(OutputPort.GetValues(), OutputPort.D.GetIndex());
        tscbLeftMotor.ComboBox.FillAndSelect(OutputPort.GetValues(), OutputPort.B.GetIndex());
        tscbRightMotor.ComboBox.FillAndSelect(OutputPort.GetValues(), OutputPort.C.GetIndex());
        cbPort.ComboBox.FillAndSelectLast(SerialPort.GetPortNames());
        cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());
        cbChatGptModelName.SafeSelect(13);

        Configuration = new ConfigurationBuilder()
            .AddUserSecrets("2B00990C-D8D5-4CAC-9F94-810E5B9FE4B5")
            .Build();
    }

    ~MainForm()
    {
        brick?.Dispose();
    }

    private void BtnConnectOrDisconnect_Click(object sender, EventArgs e)
    {
        if (brick == null || !brick.IsConnected)
        {
            Connect();
        }
        else
        {
            Disconnect();
        }
    }

    private void Connect()
    {
        if (cbPort.Items.Count == 0)
        {
            ErrorBox.Show("No ports found", "Please check if your Lego Mindstorm EV3 Bluetooth is enabled");
            return;
        }

        brick = new Brick((string)cbPort.SelectedItem);
        brick.SetMotors((OutputPort)tscbLeftMotor.SelectedItem, (OutputPort)tscbRightMotor.SelectedItem, (OutputPort)tscbLeverMotor.SelectedItem);
        brick.Connect();

        btnConnectOrDisconnect.Image = Properties.Resources.disconnect;
        SetControlsEnableProperty(false);
    }

    private void Disconnect()
    {
        brick?.Disconnect();
        btnConnectOrDisconnect.Image = Properties.Resources.connect;
        SetControlsEnableProperty(true);

        WindowState = FormWindowState.Minimized; // Workaround to fix second connection to the serial port
    }

    private void SetControlsEnableProperty(bool enable)
    {
        cbPort.Enabled = enable;
        tscbLeftMotor.ComboBox.Enabled = enable;
        tscbRightMotor.ComboBox.Enabled = enable;
        tscbLeverMotor.ComboBox.Enabled = enable;
        gbControl.Enabled = !enable;
        gbMorse.Enabled = !enable;
        tsmiButtons.Enabled = !enable;
        tsmiFileSystem.Enabled = !enable;
        tsmiGyroSensor.Enabled = !enable;
        tsmiJoystick.Enabled = !enable;
        tsmiLightSensor.Enabled = !enable;
        tsmiMotors.Enabled = !enable;
        tsmiScreen.Enabled = !enable;
        tsmiSpeaker.Enabled = !enable;
        tsmiTouchSensor.Enabled = !enable;
        tsmiInfraredSensor.Enabled = !enable;
        tsmiUltrasonicSensor.Enabled = !enable;
        tsmiVoiceControl.Enabled = !enable;
        tsmiSnake.Enabled = !enable;
        tsmiDeviceInfo.Enabled = !enable;
        tsmiCircles.Enabled = !enable;
        tsmiBehaveLikeADog.Enabled = !enable;
    }

    private void BtnStop_Click(object sender, EventArgs e)
    {
        StopMotors((DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
    }

    private void StopMotors(DaisyChainLayer daisyChainLayer)
    {
        brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.Motors, 0));
    }

    private void BtnNorthWest_MouseDown(object sender, MouseEventArgs e)
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeftMotor, 0), new SetMotorSpeedParams(brick.RightMotor, 100));
    }

    private void BtnNorth_MouseDown(object sender, MouseEventArgs e)
    {
        MoveNorth();
    }

    private void MoveNorth()
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.Motors, 100));
    }

    private void BtnNorthEast_MouseDown(object sender, MouseEventArgs e)
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeftMotor, 100), new SetMotorSpeedParams(brick.RightMotor, 0));
    }

    private void TurnEast()
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeftMotor, 100), new SetMotorSpeedParams(brick.RightMotor, -100));
    }

    private void BtnWest_MouseDown(object sender, MouseEventArgs e)
    {
        TurnWest();
    }

    private void TurnWest()
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeftMotor, -100), new SetMotorSpeedParams(brick.RightMotor, 100));
    }

    private void BtnEast_MouseDown(object sender, MouseEventArgs e)
    {
        TurnEast();
    }

    private void BtnSouthWest_MouseDown(object sender, MouseEventArgs e)
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeftMotor, 0), new SetMotorSpeedParams(brick.RightMotor, -100));
    }

    private void BtnSouth_MouseDown(object sender, MouseEventArgs e)
    {
        MoveSouth();
    }

    private void MoveSouth()
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.Motors, -100));
    }

    private void BtnSouthEast_MouseDown(object sender, MouseEventArgs e)
    {
        brick?.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeftMotor, -100), new SetMotorSpeedParams(brick.RightMotor, 0));
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyData)
        {
            case Keys.Left:
                TurnWest();
                break;
            case Keys.Up:
                MoveNorth();
                break;
            case Keys.Right:
                TurnEast();
                break;
            case Keys.Down:
                MoveSouth();
                break;
        }
    }

    private void MainForm_KeyUp(object sender, KeyEventArgs e)
    {
        StopMotors((DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
    }

    private void ChkVoiceControl_CheckedChanged(object sender, EventArgs e)
    {
        if (tsmiVoiceControl.Checked)
        {
#if USE_SPEECH_RECOGNITION
            var voiceCommands = new List<VoiceCommand>
            {
                new("Ok Lego, go ahead", () => { MoveNorth(); }),
                new("Ok Lego, go forward", () => { MoveNorth(); }),
                new("Ok Lego, go backward", () => { MoveSouth(); }),
                new("Ok Lego, turn left", () => { TurnWest(); }),
                new("Ok Lego, turn right", () => { TurnEast(); }),
                new("Ok Lego, stop", () => { StopMotors((DaisyChainLayer)cbDaisyChainLayer.SelectedItem); }),
                new("Ok Lego, play some music", () => { brick?.PlayMusic(new KisKeceLányom()); }),
            };

            speechRecognitionEngine = VoiceControl.InitializeVoiceControl(voiceCommands);
        }
        else
        {
            VoiceControl.StopVoiceControl(ref speechRecognitionEngine);
#endif
        }
    }

    private void ChkJoystick_CheckedChanged(object sender, EventArgs e)
    {
#if USE_JOYSTICK
        gbJoystick.Enabled = tsmiJoystick.Checked;
        if (tsmiJoystick.Checked)
        {
            var daisyChainLayer = cbDaisyChainLayer.GetSelectedItemThreadSafe() as DaisyChainLayer ?? DaisyChainLayer.EV3;
            JoystickHandler.InitializeJoystick(() =>
                {
                    return 0;
                },
                () =>
                {
                    return !this.IsDisposingOrDisposed() && (brick?.IsConnected ?? false);
                },
                () =>
                {
                    return Invoke(delegate
                    {
                        return tbDeltaModifier.Value;
                    });
                },
                () =>
                {
                    return Invoke(delegate
                    {
                        return tbMinimumDelta.Value;
                    });
                },
                (int deltaX, int deltaY) =>
                {
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.Motors, 0));
                },
                (int deltaX, int deltaY) =>
                {
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.Motors, (sbyte)deltaY));
                },
                (int deltaX, int deltaY) =>
                {
                    var leftMotorSpeed = (sbyte)Math.Abs(deltaY + deltaX);
                    var rightMotorSpeed = (sbyte)deltaY;
                    if (leftMotorSpeed > rightMotorSpeed)
                    {
                        SByteUtils.Swap(ref leftMotorSpeed, ref rightMotorSpeed);
                    }
                    Console.WriteLine($"Forward with left turn. Left: {leftMotorSpeed}, Right: {rightMotorSpeed}");
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));
                },
                (int deltaX, int deltaY) =>
                {
                    var leftMotorSpeed = (sbyte)deltaY;
                    var rightMotorSpeed = (sbyte)Math.Abs(deltaY - deltaX);
                    if (rightMotorSpeed > leftMotorSpeed)
                    {
                        SByteUtils.Swap(ref leftMotorSpeed, ref rightMotorSpeed);
                    }
                    Console.WriteLine($"Forward with right turn. Left: {leftMotorSpeed}, Right: {rightMotorSpeed}");
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));
                },
                (int deltaX, int deltaY) =>
                {
                    var leftMotorSpeed = (sbyte)deltaY;
                    var rightMotorSpeed = (sbyte)(deltaY + deltaX);
                    Console.WriteLine($"Backward with left turn. Left: {leftMotorSpeed}, Right: {rightMotorSpeed}");
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));
                },
                (int deltaX, int deltaY) =>
                {
                    var leftMotorSpeed = (sbyte)(deltaY - deltaX);
                    var rightMotorSpeed = (sbyte)deltaY;
                    Console.WriteLine($"Backward with right turn. Left: {leftMotorSpeed}, Right: {rightMotorSpeed}");
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));
                },
                (int deltaX, int deltaY) =>
                {
                    var leftMotorSpeed = (sbyte)deltaX;
                    var rightMotorSpeed = (sbyte)-deltaX;
                    Console.WriteLine($"Turn. Left: {leftMotorSpeed}, Right: {rightMotorSpeed}");
                    brick?.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));
                },
                () =>
                {
                    Invoke(new Action(() => { tsmiJoystick.Checked = false; }));
                },
                new Action[]
                {
                    () =>
                    {
                        brick?.PlayMusic(new BociBoci());
                    },
                    () =>
                    {
                        brick?.PlayMusic(new NeverGonnaGiveYouUp());
                    },
                    () =>
                    {
                        brick?.PlayMusic(new JingleBells());
                    },
                    () =>
                    {
                        brick?.PlayMusic(new KisKeceLányom());
                    },
                    () =>
                    {
                        brick?.PlayMusic(new ImperialMarch());
                    }
                }
            );
        }
        else
        {
            JoystickHandler.StopJoystick();
        }
#else
        gbJoystick.Enabled = false;
#endif
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
#if USE_JOYSTICK
        JoystickHandler.StopJoystick();
#endif
        if (brick?.IsConnected ?? false)
        {
            brick.Execute(new ProgramStop());
        }
    }

    private void BtnMouseUp(object sender, MouseEventArgs e)
    {
        StopMotors((DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
    }

    private void TsmiMotors_Click(object sender, EventArgs e)
    {
        var motorForm = new MotorForm(brick);
        motorForm.Show();
    }

    private void TsmiSpeaker_Click(object sender, EventArgs e)
    {
        var speakerForm = new SpeakerForm(brick);
        speakerForm.Show();
    }

    private void TsmiFileSystem_Click(object sender, EventArgs e)
    {
        var fileSystemForm = new FileSystemForm(brick);
        fileSystemForm.Show();
    }

    private void TsmiScreen_Click(object sender, EventArgs e)
    {
        var screenForm = new ScreenForm(brick);
        screenForm.Show();
    }

    private void TsmiGyroSensor_Click(object sender, EventArgs e)
    {
        var gyroSensorForm = new GyroSensorForm(brick);
        gyroSensorForm.Show();
    }

    private void TsmiLightSensor_Click(object sender, EventArgs e)
    {
        var lightSensorForm = new LightSensorForm(brick);
        lightSensorForm.Show();
    }

    private void TsmiTouchSensor_Click(object sender, EventArgs e)
    {
        var touchSensorForm = new TouchSensorForm(brick);
        touchSensorForm.Show();
    }

    private void TsmiUltrasonicSensor_Click(object sender, EventArgs e)
    {
        var ultrasonicSensorForm = new UltrasonicSensorForm(brick);
        ultrasonicSensorForm.Show();
    }

    private void BtnMorse_Click(object sender, EventArgs e)
    {
        var morse = new Morse(brick);
        morse.Text(rtbMorse.Text);
        if (tbRobotPartner.Text != String.Empty)
        {
            brick?.Execute(new SendMail(tbRobotPartner.Text, rtbMorse.Text));
        }
    }

    private void TsmiButtons_Click(object sender, EventArgs e)
    {
        var buttonForm = new ButtonForm(brick);
        buttonForm.Show();
    }

    private void TsmiSnake_Click(object sender, EventArgs e)
    {
        var snakeGameEngine = new SnakeGameEngine(brick);
        snakeGameEngine.GameLoop();
    }

    private void TsmiDeviceInfo_Click(object sender, EventArgs e)
    {
        var deviceInfo = new DeviceInfo(brick);
        deviceInfo.Show();
    }

    private void TsmiCircles_Click(object sender, EventArgs e)
    {
        var circlesGameEngine = new CirclesGameEngine(brick);
        circlesGameEngine.GameLoop();
    }

    private void TsmiInfraredSensor_Click(object sender, EventArgs e)
    {
        var infraredSensorForm = new InfraredSensorForm(brick);
        infraredSensorForm.Show();
    }

    private void TsmiImageConverter_Click(object sender, EventArgs e)
    {
        var imageConverter = new ImageConverterForm();
        imageConverter.Show();
    }

    private void TsmiBehaveLikeADog_Click(object sender, EventArgs e)
    {
        brick?.ShowImage(EmbeddedImage.Neutral);
        brick?.PlaySound(EmbeddedSound.DogSniff, PlayType.WaitForCompletion);
        brick?.ShowImage(EmbeddedImage.Angry);
        brick?.PlaySound(EmbeddedSound.DogGrowl, PlayType.WaitForCompletion);
        brick?.PlaySound(EmbeddedSound.DogBark1, PlayType.PlayOnce);

        for (int i = 0; i < 3; i++)
        {
            brick?.ShowImage(EmbeddedImage.Mouth2Open);
            Thread.Sleep(300);
            brick?.ShowImage(EmbeddedImage.Mouth2Shut);
            Thread.Sleep(300);
        }

        brick?.PlaySound(EmbeddedSound.DogBark1, PlayType.PlayOnce);
        brick?.ShowImage(EmbeddedImage.Evil);
    }

    private void TsmiSoundRecorder_Click(object sender, EventArgs e)
    {
        var soundRecorder = new SoundRecorderForm();
        soundRecorder.Show();
    }

    private async void BtnAskChatGpt_Click(object sender, EventArgs e)
    {
        var client = new ChatGptClient(cbChatGptModelName.Text);
        var keyName = "OpenAI:ApiKey";
        var keyValue = "openai-api-key";
#if DEBUG
        string? apiKey = Configuration[keyName];
#else
        string? apiKey = Environment.GetEnvironmentVariable(keyName, EnvironmentVariableTarget.User);
#endif

        if (apiKey != null)
        {
            if (apiKey == keyValue)
            {
                ErrorBox.Show("OpenAI API Key is wrong", $"To get a valid Open AI API Key, please visit https://platform.openai.com/docs/api-reference");
            }
            else
            {
                try
                {
                    rtbChatGpt.Text = await client.SendMessage(rtbChatGpt.Text, apiKey, tbTemperature.Value / 10.0);
                }
                catch (Exception ex)
                {
                    ErrorBox.Show(ex);
                }
            }
        }
        else
        {
#if DEBUG
            ErrorBox.Show("OpenAI API Key is missing", $"dotnet user-secrets set \"{keyName}\" \"{keyValue}\"");
#else
            ErrorBox.Show("OpenAI API Key is missing", $"Please create an environment variable named {keyName} with your {keyValue}");
#endif
        }
    }
}
