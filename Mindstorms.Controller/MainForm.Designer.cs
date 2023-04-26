
namespace Mindstorms.Controller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            toolStrip = new ToolStrip();
            cbPort = new ToolStripComboBox();
            btnConnectOrDisconnect = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tslLeftMotor = new ToolStripLabel();
            tscbLeftMotor = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            tslRightMotor = new ToolStripLabel();
            tscbRightMotor = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            tslLeverMotor = new ToolStripLabel();
            tscbLeverMotor = new ToolStripComboBox();
            menuStrip = new MenuStrip();
            tsmiControl = new ToolStripMenuItem();
            tsmiButtons = new ToolStripMenuItem();
            tsmiFileSystem = new ToolStripMenuItem();
            tsmiMotors = new ToolStripMenuItem();
            tsmiScreen = new ToolStripMenuItem();
            tsmiSpeaker = new ToolStripMenuItem();
            separator = new ToolStripSeparator();
            tsmiJoystick = new ToolStripMenuItem();
            tsmiVoiceControl = new ToolStripMenuItem();
            separator2 = new ToolStripSeparator();
            tsmiDeviceInfo = new ToolStripMenuItem();
            tsmiSensors = new ToolStripMenuItem();
            tsmiGyroSensor = new ToolStripMenuItem();
            tsmiLightSensor = new ToolStripMenuItem();
            tsmiTouchSensor = new ToolStripMenuItem();
            tsmiInfraredSensor = new ToolStripMenuItem();
            tsmiUltrasonicSensor = new ToolStripMenuItem();
            tsmiGames = new ToolStripMenuItem();
            tsmiSnake = new ToolStripMenuItem();
            tsmiCircles = new ToolStripMenuItem();
            separator3 = new ToolStripSeparator();
            tsmiBehaveLikeADog = new ToolStripMenuItem();
            tsmiTools = new ToolStripMenuItem();
            tsmiImageConverter = new ToolStripMenuItem();
            tsmiSoundRecorder = new ToolStripMenuItem();
            pMain = new Panel();
            tbTemperature = new TrackBar();
            rtbChatGpt = new RichTextBox();
            btnAskChatGpt = new Button();
            lblDaisyChainLayer = new Label();
            cbDaisyChainLayer = new ComboBox();
            gbMorse = new GroupBox();
            tbRobotPartner = new TextBox();
            rtbMorse = new RichTextBox();
            btnMorse = new Button();
            gbJoystick = new GroupBox();
            tbMinimumDelta = new TrackBar();
            tbDeltaModifier = new TrackBar();
            gbControl = new GroupBox();
            btnSouthEast = new Button();
            btnSouth = new Button();
            btnSouthWest = new Button();
            btnEast = new Button();
            btnWest = new Button();
            btnNorthEast = new Button();
            btnNorth = new Button();
            btnNorthWest = new Button();
            btnStop = new Button();
            toolTip = new ToolTip(components);
            toolStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTemperature).BeginInit();
            gbMorse.SuspendLayout();
            gbJoystick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbMinimumDelta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDeltaModifier).BeginInit();
            gbControl.SuspendLayout();
            SuspendLayout();
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "cs";
            saveFileDialog.Filter = "C# files|*.cs";
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "cs";
            openFileDialog.Filter = "C# files|*.cs";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { cbPort, btnConnectOrDisconnect, toolStripSeparator1, tslLeftMotor, tscbLeftMotor, toolStripSeparator2, tslRightMotor, tscbRightMotor, toolStripSeparator3, tslLeverMotor, tscbLeverMotor });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(722, 25);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // cbPort
            // 
            cbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPort.Name = "cbPort";
            cbPort.Size = new Size(140, 25);
            // 
            // btnConnectOrDisconnect
            // 
            btnConnectOrDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConnectOrDisconnect.Image = (Image)resources.GetObject("btnConnectOrDisconnect.Image");
            btnConnectOrDisconnect.ImageTransparentColor = Color.Magenta;
            btnConnectOrDisconnect.Name = "btnConnectOrDisconnect";
            btnConnectOrDisconnect.Size = new Size(23, 22);
            btnConnectOrDisconnect.ToolTipText = "Connect/Disconnect";
            btnConnectOrDisconnect.Click += BtnConnectOrDisconnect_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tslLeftMotor
            // 
            tslLeftMotor.Name = "tslLeftMotor";
            tslLeftMotor.Size = new Size(63, 22);
            tslLeftMotor.Text = "Left motor";
            // 
            // tscbLeftMotor
            // 
            tscbLeftMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbLeftMotor.Name = "tscbLeftMotor";
            tscbLeftMotor.Size = new Size(87, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tslRightMotor
            // 
            tslRightMotor.Name = "tslRightMotor";
            tslRightMotor.Size = new Size(71, 22);
            tslRightMotor.Text = "Right motor";
            // 
            // tscbRightMotor
            // 
            tscbRightMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbRightMotor.Name = "tscbRightMotor";
            tscbRightMotor.Size = new Size(87, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // tslLeverMotor
            // 
            tslLeverMotor.Name = "tslLeverMotor";
            tslLeverMotor.Size = new Size(71, 22);
            tslLeverMotor.Text = "Lever motor";
            // 
            // tscbLeverMotor
            // 
            tscbLeverMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbLeverMotor.Name = "tscbLeverMotor";
            tscbLeverMotor.Size = new Size(87, 25);
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { tsmiControl, tsmiSensors, tsmiGames, tsmiTools });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(722, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // tsmiControl
            // 
            tsmiControl.DropDownItems.AddRange(new ToolStripItem[] { tsmiButtons, tsmiFileSystem, tsmiMotors, tsmiScreen, tsmiSpeaker, separator, tsmiJoystick, tsmiVoiceControl, separator2, tsmiDeviceInfo });
            tsmiControl.Name = "tsmiControl";
            tsmiControl.Size = new Size(59, 20);
            tsmiControl.Text = "Control";
            // 
            // tsmiButtons
            // 
            tsmiButtons.Enabled = false;
            tsmiButtons.Image = Properties.Resources.button;
            tsmiButtons.Name = "tsmiButtons";
            tsmiButtons.Size = new Size(143, 22);
            tsmiButtons.Text = "Buttons";
            tsmiButtons.Click += TsmiButtons_Click;
            // 
            // tsmiFileSystem
            // 
            tsmiFileSystem.Enabled = false;
            tsmiFileSystem.Image = (Image)resources.GetObject("tsmiFileSystem.Image");
            tsmiFileSystem.Name = "tsmiFileSystem";
            tsmiFileSystem.Size = new Size(143, 22);
            tsmiFileSystem.Text = "File system";
            tsmiFileSystem.Click += TsmiFileSystem_Click;
            // 
            // tsmiMotors
            // 
            tsmiMotors.Enabled = false;
            tsmiMotors.Image = (Image)resources.GetObject("tsmiMotors.Image");
            tsmiMotors.Name = "tsmiMotors";
            tsmiMotors.Size = new Size(143, 22);
            tsmiMotors.Text = "Motors";
            tsmiMotors.Click += TsmiMotors_Click;
            // 
            // tsmiScreen
            // 
            tsmiScreen.Enabled = false;
            tsmiScreen.Image = (Image)resources.GetObject("tsmiScreen.Image");
            tsmiScreen.Name = "tsmiScreen";
            tsmiScreen.Size = new Size(143, 22);
            tsmiScreen.Text = "Screen";
            tsmiScreen.Click += TsmiScreen_Click;
            // 
            // tsmiSpeaker
            // 
            tsmiSpeaker.Enabled = false;
            tsmiSpeaker.Image = (Image)resources.GetObject("tsmiSpeaker.Image");
            tsmiSpeaker.Name = "tsmiSpeaker";
            tsmiSpeaker.Size = new Size(143, 22);
            tsmiSpeaker.Text = "Speaker";
            tsmiSpeaker.Click += TsmiSpeaker_Click;
            // 
            // separator
            // 
            separator.Name = "separator";
            separator.Size = new Size(140, 6);
            // 
            // tsmiJoystick
            // 
            tsmiJoystick.CheckOnClick = true;
            tsmiJoystick.Enabled = false;
            tsmiJoystick.Image = (Image)resources.GetObject("tsmiJoystick.Image");
            tsmiJoystick.Name = "tsmiJoystick";
            tsmiJoystick.Size = new Size(143, 22);
            tsmiJoystick.Text = "Joystick";
            tsmiJoystick.CheckedChanged += ChkJoystick_CheckedChanged;
            // 
            // tsmiVoiceControl
            // 
            tsmiVoiceControl.CheckOnClick = true;
            tsmiVoiceControl.Enabled = false;
            tsmiVoiceControl.Image = (Image)resources.GetObject("tsmiVoiceControl.Image");
            tsmiVoiceControl.Name = "tsmiVoiceControl";
            tsmiVoiceControl.Size = new Size(143, 22);
            tsmiVoiceControl.Text = "Voice control";
            tsmiVoiceControl.CheckedChanged += ChkVoiceControl_CheckedChanged;
            // 
            // separator2
            // 
            separator2.Name = "separator2";
            separator2.Size = new Size(140, 6);
            // 
            // tsmiDeviceInfo
            // 
            tsmiDeviceInfo.Enabled = false;
            tsmiDeviceInfo.Name = "tsmiDeviceInfo";
            tsmiDeviceInfo.Size = new Size(143, 22);
            tsmiDeviceInfo.Text = "Device info";
            tsmiDeviceInfo.Click += TsmiDeviceInfo_Click;
            // 
            // tsmiSensors
            // 
            tsmiSensors.DropDownItems.AddRange(new ToolStripItem[] { tsmiGyroSensor, tsmiLightSensor, tsmiTouchSensor, tsmiInfraredSensor, tsmiUltrasonicSensor });
            tsmiSensors.Name = "tsmiSensors";
            tsmiSensors.Size = new Size(59, 20);
            tsmiSensors.Text = "Sensors";
            // 
            // tsmiGyroSensor
            // 
            tsmiGyroSensor.Enabled = false;
            tsmiGyroSensor.Name = "tsmiGyroSensor";
            tsmiGyroSensor.Size = new Size(164, 22);
            tsmiGyroSensor.Text = "Gyro sensor";
            tsmiGyroSensor.Click += TsmiGyroSensor_Click;
            // 
            // tsmiLightSensor
            // 
            tsmiLightSensor.Enabled = false;
            tsmiLightSensor.Name = "tsmiLightSensor";
            tsmiLightSensor.Size = new Size(164, 22);
            tsmiLightSensor.Text = "Light sensor";
            tsmiLightSensor.Click += TsmiLightSensor_Click;
            // 
            // tsmiTouchSensor
            // 
            tsmiTouchSensor.Enabled = false;
            tsmiTouchSensor.Name = "tsmiTouchSensor";
            tsmiTouchSensor.Size = new Size(164, 22);
            tsmiTouchSensor.Text = "Touch sensor";
            tsmiTouchSensor.Click += TsmiTouchSensor_Click;
            // 
            // tsmiInfraredSensor
            // 
            tsmiInfraredSensor.Enabled = false;
            tsmiInfraredSensor.Name = "tsmiInfraredSensor";
            tsmiInfraredSensor.Size = new Size(164, 22);
            tsmiInfraredSensor.Text = "Infrared sensor";
            tsmiInfraredSensor.Click += TsmiInfraredSensor_Click;
            // 
            // tsmiUltrasonicSensor
            // 
            tsmiUltrasonicSensor.Enabled = false;
            tsmiUltrasonicSensor.Name = "tsmiUltrasonicSensor";
            tsmiUltrasonicSensor.Size = new Size(164, 22);
            tsmiUltrasonicSensor.Text = "Ultrasonic sensor";
            tsmiUltrasonicSensor.Click += TsmiUltrasonicSensor_Click;
            // 
            // tsmiGames
            // 
            tsmiGames.DropDownItems.AddRange(new ToolStripItem[] { tsmiSnake, tsmiCircles, separator3, tsmiBehaveLikeADog });
            tsmiGames.Name = "tsmiGames";
            tsmiGames.Size = new Size(55, 20);
            tsmiGames.Text = "Games";
            // 
            // tsmiSnake
            // 
            tsmiSnake.Enabled = false;
            tsmiSnake.Name = "tsmiSnake";
            tsmiSnake.Size = new Size(120, 22);
            tsmiSnake.Text = "Snake";
            tsmiSnake.Click += TsmiSnake_Click;
            // 
            // tsmiCircles
            // 
            tsmiCircles.Enabled = false;
            tsmiCircles.Name = "tsmiCircles";
            tsmiCircles.Size = new Size(120, 22);
            tsmiCircles.Text = "Circles";
            tsmiCircles.Click += TsmiCircles_Click;
            // 
            // separator3
            // 
            separator3.Name = "separator3";
            separator3.Size = new Size(117, 6);
            // 
            // tsmiBehaveLikeADog
            // 
            tsmiBehaveLikeADog.Enabled = false;
            tsmiBehaveLikeADog.Name = "tsmiBehaveLikeADog";
            tsmiBehaveLikeADog.Size = new Size(120, 22);
            tsmiBehaveLikeADog.Text = "Be a dog";
            tsmiBehaveLikeADog.Click += TsmiBehaveLikeADog_Click;
            // 
            // tsmiTools
            // 
            tsmiTools.DropDownItems.AddRange(new ToolStripItem[] { tsmiImageConverter, tsmiSoundRecorder });
            tsmiTools.Name = "tsmiTools";
            tsmiTools.Size = new Size(46, 20);
            tsmiTools.Text = "Tools";
            // 
            // tsmiImageConverter
            // 
            tsmiImageConverter.Name = "tsmiImageConverter";
            tsmiImageConverter.Size = new Size(160, 22);
            tsmiImageConverter.Text = "Image converter";
            tsmiImageConverter.Click += TsmiImageConverter_Click;
            // 
            // tsmiSoundRecorder
            // 
            tsmiSoundRecorder.Name = "tsmiSoundRecorder";
            tsmiSoundRecorder.Size = new Size(160, 22);
            tsmiSoundRecorder.Text = "Sound recorder";
            tsmiSoundRecorder.Click += TsmiSoundRecorder_Click;
            // 
            // pMain
            // 
            pMain.Controls.Add(tbTemperature);
            pMain.Controls.Add(rtbChatGpt);
            pMain.Controls.Add(btnAskChatGpt);
            pMain.Controls.Add(lblDaisyChainLayer);
            pMain.Controls.Add(cbDaisyChainLayer);
            pMain.Controls.Add(gbMorse);
            pMain.Controls.Add(gbJoystick);
            pMain.Controls.Add(gbControl);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 49);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(722, 166);
            pMain.TabIndex = 6;
            // 
            // tbTemperature
            // 
            tbTemperature.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbTemperature.Location = new Point(534, 117);
            tbTemperature.Maximum = 20;
            tbTemperature.Minimum = 1;
            tbTemperature.Name = "tbTemperature";
            tbTemperature.Size = new Size(70, 45);
            tbTemperature.TabIndex = 18;
            tbTemperature.Value = 1;
            // 
            // rtbChatGpt
            // 
            rtbChatGpt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbChatGpt.Location = new Point(523, 46);
            rtbChatGpt.Name = "rtbChatGpt";
            rtbChatGpt.Size = new Size(185, 65);
            rtbChatGpt.TabIndex = 17;
            rtbChatGpt.Text = "";
            // 
            // btnAskChatGpt
            // 
            btnAskChatGpt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAskChatGpt.Location = new Point(608, 121);
            btnAskChatGpt.Name = "btnAskChatGpt";
            btnAskChatGpt.Size = new Size(100, 23);
            btnAskChatGpt.TabIndex = 16;
            btnAskChatGpt.Text = "Ask Chat GPT";
            btnAskChatGpt.UseVisualStyleBackColor = true;
            btnAskChatGpt.Click += BtnAskChatGpt_Click;
            // 
            // lblDaisyChainLayer
            // 
            lblDaisyChainLayer.AutoSize = true;
            lblDaisyChainLayer.Location = new Point(523, 16);
            lblDaisyChainLayer.Margin = new Padding(4, 0, 4, 0);
            lblDaisyChainLayer.Name = "lblDaisyChainLayer";
            lblDaisyChainLayer.Size = new Size(95, 15);
            lblDaisyChainLayer.TabIndex = 15;
            lblDaisyChainLayer.Text = "Daisy chain layer";
            // 
            // cbDaisyChainLayer
            // 
            cbDaisyChainLayer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDaisyChainLayer.FormattingEnabled = true;
            cbDaisyChainLayer.Location = new Point(626, 13);
            cbDaisyChainLayer.Margin = new Padding(4, 3, 4, 3);
            cbDaisyChainLayer.Name = "cbDaisyChainLayer";
            cbDaisyChainLayer.Size = new Size(82, 23);
            cbDaisyChainLayer.TabIndex = 14;
            // 
            // gbMorse
            // 
            gbMorse.Controls.Add(tbRobotPartner);
            gbMorse.Controls.Add(rtbMorse);
            gbMorse.Controls.Add(btnMorse);
            gbMorse.Enabled = false;
            gbMorse.Location = new Point(282, 16);
            gbMorse.Margin = new Padding(4, 3, 4, 3);
            gbMorse.Name = "gbMorse";
            gbMorse.Padding = new Padding(4, 3, 4, 3);
            gbMorse.Size = new Size(233, 128);
            gbMorse.TabIndex = 13;
            gbMorse.TabStop = false;
            gbMorse.Text = "Morse";
            // 
            // tbRobotPartner
            // 
            tbRobotPartner.Location = new Point(7, 98);
            tbRobotPartner.Margin = new Padding(4, 3, 4, 3);
            tbRobotPartner.Name = "tbRobotPartner";
            tbRobotPartner.Size = new Size(188, 23);
            tbRobotPartner.TabIndex = 13;
            // 
            // rtbMorse
            // 
            rtbMorse.Location = new Point(7, 22);
            rtbMorse.Margin = new Padding(4, 3, 4, 3);
            rtbMorse.Name = "rtbMorse";
            rtbMorse.Size = new Size(219, 72);
            rtbMorse.TabIndex = 12;
            rtbMorse.Text = "SOS";
            // 
            // btnMorse
            // 
            btnMorse.Image = Properties.Resources.send;
            btnMorse.Location = new Point(203, 98);
            btnMorse.Margin = new Padding(4, 3, 4, 3);
            btnMorse.Name = "btnMorse";
            btnMorse.Size = new Size(27, 27);
            btnMorse.TabIndex = 11;
            toolTip.SetToolTip(btnMorse, "Morse text");
            btnMorse.UseVisualStyleBackColor = true;
            btnMorse.Click += BtnMorse_Click;
            // 
            // gbJoystick
            // 
            gbJoystick.Controls.Add(tbMinimumDelta);
            gbJoystick.Controls.Add(tbDeltaModifier);
            gbJoystick.Enabled = false;
            gbJoystick.Location = new Point(175, 14);
            gbJoystick.Margin = new Padding(4, 3, 4, 3);
            gbJoystick.Name = "gbJoystick";
            gbJoystick.Padding = new Padding(4, 3, 4, 3);
            gbJoystick.Size = new Size(100, 130);
            gbJoystick.TabIndex = 9;
            gbJoystick.TabStop = false;
            gbJoystick.Text = "Joystick settings";
            // 
            // tbMinimumDelta
            // 
            tbMinimumDelta.LargeChange = 10;
            tbMinimumDelta.Location = new Point(7, 72);
            tbMinimumDelta.Margin = new Padding(4, 3, 4, 3);
            tbMinimumDelta.Maximum = 50;
            tbMinimumDelta.Minimum = 5;
            tbMinimumDelta.Name = "tbMinimumDelta";
            tbMinimumDelta.Size = new Size(88, 45);
            tbMinimumDelta.SmallChange = 5;
            tbMinimumDelta.TabIndex = 23;
            tbMinimumDelta.TickFrequency = 5;
            tbMinimumDelta.Value = 5;
            // 
            // tbDeltaModifier
            // 
            tbDeltaModifier.LargeChange = 50;
            tbDeltaModifier.Location = new Point(4, 39);
            tbDeltaModifier.Margin = new Padding(4, 3, 4, 3);
            tbDeltaModifier.Maximum = 400;
            tbDeltaModifier.Minimum = 300;
            tbDeltaModifier.Name = "tbDeltaModifier";
            tbDeltaModifier.Size = new Size(88, 45);
            tbDeltaModifier.SmallChange = 10;
            tbDeltaModifier.TabIndex = 22;
            tbDeltaModifier.TickFrequency = 10;
            tbDeltaModifier.Value = 380;
            // 
            // gbControl
            // 
            gbControl.Controls.Add(btnSouthEast);
            gbControl.Controls.Add(btnSouth);
            gbControl.Controls.Add(btnSouthWest);
            gbControl.Controls.Add(btnEast);
            gbControl.Controls.Add(btnWest);
            gbControl.Controls.Add(btnNorthEast);
            gbControl.Controls.Add(btnNorth);
            gbControl.Controls.Add(btnNorthWest);
            gbControl.Controls.Add(btnStop);
            gbControl.Enabled = false;
            gbControl.Location = new Point(4, 14);
            gbControl.Margin = new Padding(4, 3, 4, 3);
            gbControl.Name = "gbControl";
            gbControl.Padding = new Padding(4, 3, 4, 3);
            gbControl.Size = new Size(164, 130);
            gbControl.TabIndex = 8;
            gbControl.TabStop = false;
            gbControl.Text = "Control";
            // 
            // btnSouthEast
            // 
            btnSouthEast.Image = (Image)resources.GetObject("btnSouthEast.Image");
            btnSouthEast.Location = new Point(110, 92);
            btnSouthEast.Margin = new Padding(4, 3, 4, 3);
            btnSouthEast.Name = "btnSouthEast";
            btnSouthEast.Size = new Size(40, 27);
            btnSouthEast.TabIndex = 8;
            btnSouthEast.UseVisualStyleBackColor = true;
            btnSouthEast.MouseDown += BtnSouthEast_MouseDown;
            btnSouthEast.MouseUp += BtnMouseUp;
            // 
            // btnSouth
            // 
            btnSouth.Image = (Image)resources.GetObject("btnSouth.Image");
            btnSouth.Location = new Point(63, 92);
            btnSouth.Margin = new Padding(4, 3, 4, 3);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(40, 27);
            btnSouth.TabIndex = 7;
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.MouseDown += BtnSouth_MouseDown;
            btnSouth.MouseUp += BtnMouseUp;
            // 
            // btnSouthWest
            // 
            btnSouthWest.Image = (Image)resources.GetObject("btnSouthWest.Image");
            btnSouthWest.Location = new Point(16, 92);
            btnSouthWest.Margin = new Padding(4, 3, 4, 3);
            btnSouthWest.Name = "btnSouthWest";
            btnSouthWest.Size = new Size(40, 27);
            btnSouthWest.TabIndex = 6;
            btnSouthWest.UseVisualStyleBackColor = true;
            btnSouthWest.MouseDown += BtnSouthWest_MouseDown;
            btnSouthWest.MouseUp += BtnMouseUp;
            // 
            // btnEast
            // 
            btnEast.Image = (Image)resources.GetObject("btnEast.Image");
            btnEast.Location = new Point(110, 59);
            btnEast.Margin = new Padding(4, 3, 4, 3);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(40, 27);
            btnEast.TabIndex = 5;
            btnEast.UseVisualStyleBackColor = true;
            btnEast.MouseDown += BtnEast_MouseDown;
            btnEast.MouseUp += BtnMouseUp;
            // 
            // btnWest
            // 
            btnWest.Image = (Image)resources.GetObject("btnWest.Image");
            btnWest.Location = new Point(16, 59);
            btnWest.Margin = new Padding(4, 3, 4, 3);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(40, 27);
            btnWest.TabIndex = 3;
            btnWest.UseVisualStyleBackColor = true;
            btnWest.MouseDown += BtnWest_MouseDown;
            btnWest.MouseUp += BtnMouseUp;
            // 
            // btnNorthEast
            // 
            btnNorthEast.Image = (Image)resources.GetObject("btnNorthEast.Image");
            btnNorthEast.Location = new Point(110, 25);
            btnNorthEast.Margin = new Padding(4, 3, 4, 3);
            btnNorthEast.Name = "btnNorthEast";
            btnNorthEast.Size = new Size(40, 27);
            btnNorthEast.TabIndex = 2;
            btnNorthEast.UseVisualStyleBackColor = true;
            btnNorthEast.MouseDown += BtnNorthEast_MouseDown;
            btnNorthEast.MouseUp += BtnMouseUp;
            // 
            // btnNorth
            // 
            btnNorth.Image = (Image)resources.GetObject("btnNorth.Image");
            btnNorth.Location = new Point(63, 25);
            btnNorth.Margin = new Padding(4, 3, 4, 3);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(40, 27);
            btnNorth.TabIndex = 1;
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.MouseDown += BtnNorth_MouseDown;
            btnNorth.MouseUp += BtnMouseUp;
            // 
            // btnNorthWest
            // 
            btnNorthWest.Image = (Image)resources.GetObject("btnNorthWest.Image");
            btnNorthWest.Location = new Point(16, 25);
            btnNorthWest.Margin = new Padding(4, 3, 4, 3);
            btnNorthWest.Name = "btnNorthWest";
            btnNorthWest.Size = new Size(40, 27);
            btnNorthWest.TabIndex = 0;
            btnNorthWest.UseVisualStyleBackColor = true;
            btnNorthWest.MouseDown += BtnNorthWest_MouseDown;
            btnNorthWest.MouseUp += BtnMouseUp;
            // 
            // btnStop
            // 
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.Location = new Point(63, 59);
            btnStop.Margin = new Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(40, 27);
            btnStop.TabIndex = 10;
            toolTip.SetToolTip(btnStop, "Stop moving");
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 215);
            Controls.Add(pMain);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(738, 254);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lego Mindstorms EV3";
            FormClosing += MainForm_FormClosing;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pMain.ResumeLayout(false);
            pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTemperature).EndInit();
            gbMorse.ResumeLayout(false);
            gbMorse.PerformLayout();
            gbJoystick.ResumeLayout(false);
            gbJoystick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbMinimumDelta).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDeltaModifier).EndInit();
            gbControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiJoystick;
        private System.Windows.Forms.ToolStripMenuItem tsmiVoiceControl;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbJoystick;
        private System.Windows.Forms.TrackBar tbMinimumDelta;
        private System.Windows.Forms.TrackBar tbDeltaModifier;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnSouthEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnSouthWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorthEast;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnNorthWest;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripComboBox cbPort;
        private System.Windows.Forms.ToolStripButton btnConnectOrDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslLeftMotor;
        private System.Windows.Forms.ToolStripComboBox tscbLeftMotor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslRightMotor;
        private System.Windows.Forms.ToolStripComboBox tscbRightMotor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiMotors;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpeaker;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreen;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripMenuItem tsmiSensors;
        private System.Windows.Forms.ToolStripMenuItem tsmiLightSensor;
        private System.Windows.Forms.ToolStripMenuItem tsmiUltrasonicSensor;
        private System.Windows.Forms.ToolStripMenuItem tsmiTouchSensor;
        private System.Windows.Forms.ToolStripMenuItem tsmiGyroSensor;
        private System.Windows.Forms.Button btnMorse;
        private System.Windows.Forms.RichTextBox rtbMorse;
        private System.Windows.Forms.ToolStripLabel tslLeverMotor;
        private System.Windows.Forms.ToolStripComboBox tscbLeverMotor;
        private System.Windows.Forms.ToolStripMenuItem tsmiButtons;
        private System.Windows.Forms.GroupBox gbMorse;
        private System.Windows.Forms.ToolStripMenuItem tsmiGames;
        private System.Windows.Forms.ToolStripMenuItem tsmiSnake;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeviceInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCircles;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfraredSensor;
        private System.Windows.Forms.TextBox tbRobotPartner;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageConverter;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiBehaveLikeADog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSoundRecorder;
        private System.Windows.Forms.Label lblDaisyChainLayer;
        private System.Windows.Forms.ComboBox cbDaisyChainLayer;
        private Button btnAskChatGpt;
        private RichTextBox rtbChatGpt;
        private TrackBar tbTemperature;
    }
}

