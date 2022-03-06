
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cbPort = new System.Windows.Forms.ToolStripComboBox();
            this.btnConnectOrDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLeftMotor = new System.Windows.Forms.ToolStripLabel();
            this.tscbLeftMotor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslRightMotor = new System.Windows.Forms.ToolStripLabel();
            this.tscbRightMotor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLeverMotor = new System.Windows.Forms.ToolStripLabel();
            this.tscbLeverMotor = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiControl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMotors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpeaker = new System.Windows.Forms.ToolStripMenuItem();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiJoystick = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVoiceControl = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeviceInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSensors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGyroSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLightSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTouchSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfraredSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUltrasonicSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSnake = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCircles = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.gbMorse = new System.Windows.Forms.GroupBox();
            this.tbRobotPartner = new System.Windows.Forms.TextBox();
            this.rtbMorse = new System.Windows.Forms.RichTextBox();
            this.btnMorse = new System.Windows.Forms.Button();
            this.gbJoystick = new System.Windows.Forms.GroupBox();
            this.tbMinimumDelta = new System.Windows.Forms.TrackBar();
            this.tbDeltaModifier = new System.Windows.Forms.TrackBar();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSouthEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnSouthWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorthEast = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnNorthWest = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pMain.SuspendLayout();
            this.gbMorse.SuspendLayout();
            this.gbJoystick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinimumDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeltaModifier)).BeginInit();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "cs";
            this.saveFileDialog.Filter = "C# files|*.cs";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "cs";
            this.openFileDialog.Filter = "C# files|*.cs";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbPort,
            this.btnConnectOrDisconnect,
            this.toolStripSeparator1,
            this.tslLeftMotor,
            this.tscbLeftMotor,
            this.toolStripSeparator2,
            this.tslRightMotor,
            this.tscbRightMotor,
            this.toolStripSeparator3,
            this.tslLeverMotor,
            this.tscbLeverMotor});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(619, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 25);
            // 
            // btnConnectOrDisconnect
            // 
            this.btnConnectOrDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnectOrDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnectOrDisconnect.Image")));
            this.btnConnectOrDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnectOrDisconnect.Name = "btnConnectOrDisconnect";
            this.btnConnectOrDisconnect.Size = new System.Drawing.Size(23, 22);
            this.btnConnectOrDisconnect.ToolTipText = "Connect/Disconnect";
            this.btnConnectOrDisconnect.Click += new System.EventHandler(this.BtnConnectOrDisconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslLeftMotor
            // 
            this.tslLeftMotor.Name = "tslLeftMotor";
            this.tslLeftMotor.Size = new System.Drawing.Size(63, 22);
            this.tslLeftMotor.Text = "Left motor";
            // 
            // tscbLeftMotor
            // 
            this.tscbLeftMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbLeftMotor.Name = "tscbLeftMotor";
            this.tscbLeftMotor.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslRightMotor
            // 
            this.tslRightMotor.Name = "tslRightMotor";
            this.tslRightMotor.Size = new System.Drawing.Size(71, 22);
            this.tslRightMotor.Text = "Right motor";
            // 
            // tscbRightMotor
            // 
            this.tscbRightMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbRightMotor.Name = "tscbRightMotor";
            this.tscbRightMotor.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslLeverMotor
            // 
            this.tslLeverMotor.Name = "tslLeverMotor";
            this.tslLeverMotor.Size = new System.Drawing.Size(71, 22);
            this.tslLeverMotor.Text = "Lever motor";
            // 
            // tscbLeverMotor
            // 
            this.tscbLeverMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbLeverMotor.Name = "tscbLeverMotor";
            this.tscbLeverMotor.Size = new System.Drawing.Size(75, 25);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiControl,
            this.tsmiSensors,
            this.tsmiGames,
            this.tsmiTools});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(619, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiControl
            // 
            this.tsmiControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiButtons,
            this.tsmiFileSystem,
            this.tsmiMotors,
            this.tsmiScreen,
            this.tsmiSpeaker,
            this.separator,
            this.tsmiJoystick,
            this.tsmiVoiceControl,
            this.separator2,
            this.tsmiDeviceInfo});
            this.tsmiControl.Name = "tsmiControl";
            this.tsmiControl.Size = new System.Drawing.Size(59, 20);
            this.tsmiControl.Text = "Control";
            // 
            // tsmiButtons
            // 
            this.tsmiButtons.Enabled = false;
            this.tsmiButtons.Image = global::Mindstorms.Controller.Properties.Resources.button;
            this.tsmiButtons.Name = "tsmiButtons";
            this.tsmiButtons.Size = new System.Drawing.Size(180, 22);
            this.tsmiButtons.Text = "Buttons";
            this.tsmiButtons.Click += new System.EventHandler(this.TsmiButtons_Click);
            // 
            // tsmiFileSystem
            // 
            this.tsmiFileSystem.Enabled = false;
            this.tsmiFileSystem.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFileSystem.Image")));
            this.tsmiFileSystem.Name = "tsmiFileSystem";
            this.tsmiFileSystem.Size = new System.Drawing.Size(180, 22);
            this.tsmiFileSystem.Text = "File system";
            this.tsmiFileSystem.Click += new System.EventHandler(this.TsmiFileSystem_Click);
            // 
            // tsmiMotors
            // 
            this.tsmiMotors.Enabled = false;
            this.tsmiMotors.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMotors.Image")));
            this.tsmiMotors.Name = "tsmiMotors";
            this.tsmiMotors.Size = new System.Drawing.Size(180, 22);
            this.tsmiMotors.Text = "Motors";
            this.tsmiMotors.Click += new System.EventHandler(this.TsmiMotors_Click);
            // 
            // tsmiScreen
            // 
            this.tsmiScreen.Enabled = false;
            this.tsmiScreen.Image = ((System.Drawing.Image)(resources.GetObject("tsmiScreen.Image")));
            this.tsmiScreen.Name = "tsmiScreen";
            this.tsmiScreen.Size = new System.Drawing.Size(180, 22);
            this.tsmiScreen.Text = "Screen";
            this.tsmiScreen.Click += new System.EventHandler(this.TsmiScreen_Click);
            // 
            // tsmiSpeaker
            // 
            this.tsmiSpeaker.Enabled = false;
            this.tsmiSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSpeaker.Image")));
            this.tsmiSpeaker.Name = "tsmiSpeaker";
            this.tsmiSpeaker.Size = new System.Drawing.Size(180, 22);
            this.tsmiSpeaker.Text = "Speaker";
            this.tsmiSpeaker.Click += new System.EventHandler(this.TsmiSpeaker_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiJoystick
            // 
            this.tsmiJoystick.CheckOnClick = true;
            this.tsmiJoystick.Enabled = false;
            this.tsmiJoystick.Image = ((System.Drawing.Image)(resources.GetObject("tsmiJoystick.Image")));
            this.tsmiJoystick.Name = "tsmiJoystick";
            this.tsmiJoystick.Size = new System.Drawing.Size(180, 22);
            this.tsmiJoystick.Text = "Joystick";
            this.tsmiJoystick.CheckedChanged += new System.EventHandler(this.ChkJoystick_CheckedChanged);
            // 
            // tsmiVoiceControl
            // 
            this.tsmiVoiceControl.CheckOnClick = true;
            this.tsmiVoiceControl.Enabled = false;
            this.tsmiVoiceControl.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVoiceControl.Image")));
            this.tsmiVoiceControl.Name = "tsmiVoiceControl";
            this.tsmiVoiceControl.Size = new System.Drawing.Size(180, 22);
            this.tsmiVoiceControl.Text = "Voice control";
            this.tsmiVoiceControl.CheckedChanged += new System.EventHandler(this.ChkVoiceControl_CheckedChanged);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiDeviceInfo
            // 
            this.tsmiDeviceInfo.Enabled = false;
            this.tsmiDeviceInfo.Name = "tsmiDeviceInfo";
            this.tsmiDeviceInfo.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeviceInfo.Text = "Device info";
            this.tsmiDeviceInfo.Click += new System.EventHandler(this.TsmiDeviceInfo_Click);
            // 
            // tsmiSensors
            // 
            this.tsmiSensors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGyroSensor,
            this.tsmiLightSensor,
            this.tsmiTouchSensor,
            this.tsmiInfraredSensor,
            this.tsmiUltrasonicSensor});
            this.tsmiSensors.Name = "tsmiSensors";
            this.tsmiSensors.Size = new System.Drawing.Size(59, 20);
            this.tsmiSensors.Text = "Sensors";
            // 
            // tsmiGyroSensor
            // 
            this.tsmiGyroSensor.Enabled = false;
            this.tsmiGyroSensor.Name = "tsmiGyroSensor";
            this.tsmiGyroSensor.Size = new System.Drawing.Size(180, 22);
            this.tsmiGyroSensor.Text = "Gyro sensor";
            this.tsmiGyroSensor.Click += new System.EventHandler(this.TsmiGyroSensor_Click);
            // 
            // tsmiLightSensor
            // 
            this.tsmiLightSensor.Enabled = false;
            this.tsmiLightSensor.Name = "tsmiLightSensor";
            this.tsmiLightSensor.Size = new System.Drawing.Size(180, 22);
            this.tsmiLightSensor.Text = "Light sensor";
            this.tsmiLightSensor.Click += new System.EventHandler(this.TsmiLightSensor_Click);
            // 
            // tsmiTouchSensor
            // 
            this.tsmiTouchSensor.Enabled = false;
            this.tsmiTouchSensor.Name = "tsmiTouchSensor";
            this.tsmiTouchSensor.Size = new System.Drawing.Size(180, 22);
            this.tsmiTouchSensor.Text = "Touch sensor";
            this.tsmiTouchSensor.Click += new System.EventHandler(this.TsmiTouchSensor_Click);
            // 
            // tsmiInfraredSensor
            // 
            this.tsmiInfraredSensor.Enabled = false;
            this.tsmiInfraredSensor.Name = "tsmiInfraredSensor";
            this.tsmiInfraredSensor.Size = new System.Drawing.Size(180, 22);
            this.tsmiInfraredSensor.Text = "Infrared sensor";
            this.tsmiInfraredSensor.Click += new System.EventHandler(this.TsmiInfraredSensor_Click);
            // 
            // tsmiUltrasonicSensor
            // 
            this.tsmiUltrasonicSensor.Enabled = false;
            this.tsmiUltrasonicSensor.Name = "tsmiUltrasonicSensor";
            this.tsmiUltrasonicSensor.Size = new System.Drawing.Size(180, 22);
            this.tsmiUltrasonicSensor.Text = "Ultrasonic sensor";
            this.tsmiUltrasonicSensor.Click += new System.EventHandler(this.TsmiUltrasonicSensor_Click);
            // 
            // tsmiGames
            // 
            this.tsmiGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSnake,
            this.tsmiCircles});
            this.tsmiGames.Name = "tsmiGames";
            this.tsmiGames.Size = new System.Drawing.Size(55, 20);
            this.tsmiGames.Text = "Games";
            // 
            // tsmiSnake
            // 
            this.tsmiSnake.Enabled = false;
            this.tsmiSnake.Name = "tsmiSnake";
            this.tsmiSnake.Size = new System.Drawing.Size(109, 22);
            this.tsmiSnake.Text = "Snake";
            this.tsmiSnake.Click += new System.EventHandler(this.TsmiSnake_Click);
            // 
            // tsmiCircles
            // 
            this.tsmiCircles.Enabled = false;
            this.tsmiCircles.Name = "tsmiCircles";
            this.tsmiCircles.Size = new System.Drawing.Size(109, 22);
            this.tsmiCircles.Text = "Circles";
            this.tsmiCircles.Click += new System.EventHandler(this.TsmiCircles_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbMorse);
            this.pMain.Controls.Add(this.gbJoystick);
            this.pMain.Controls.Add(this.gbControl);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 49);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(619, 137);
            this.pMain.TabIndex = 6;
            // 
            // gbMorse
            // 
            this.gbMorse.Controls.Add(this.tbRobotPartner);
            this.gbMorse.Controls.Add(this.rtbMorse);
            this.gbMorse.Controls.Add(this.btnMorse);
            this.gbMorse.Enabled = false;
            this.gbMorse.Location = new System.Drawing.Point(242, 14);
            this.gbMorse.Name = "gbMorse";
            this.gbMorse.Size = new System.Drawing.Size(200, 111);
            this.gbMorse.TabIndex = 13;
            this.gbMorse.TabStop = false;
            this.gbMorse.Text = "Morse";
            // 
            // tbRobotPartner
            // 
            this.tbRobotPartner.Location = new System.Drawing.Point(6, 85);
            this.tbRobotPartner.Name = "tbRobotPartner";
            this.tbRobotPartner.Size = new System.Drawing.Size(162, 20);
            this.tbRobotPartner.TabIndex = 13;
            // 
            // rtbMorse
            // 
            this.rtbMorse.Location = new System.Drawing.Point(6, 19);
            this.rtbMorse.Name = "rtbMorse";
            this.rtbMorse.Size = new System.Drawing.Size(188, 63);
            this.rtbMorse.TabIndex = 12;
            this.rtbMorse.Text = "SOS";
            // 
            // btnMorse
            // 
            this.btnMorse.Image = global::Mindstorms.Controller.Properties.Resources.send;
            this.btnMorse.Location = new System.Drawing.Point(174, 85);
            this.btnMorse.Name = "btnMorse";
            this.btnMorse.Size = new System.Drawing.Size(23, 23);
            this.btnMorse.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnMorse, "Morse text");
            this.btnMorse.UseVisualStyleBackColor = true;
            this.btnMorse.Click += new System.EventHandler(this.BtnMorse_Click);
            // 
            // gbJoystick
            // 
            this.gbJoystick.Controls.Add(this.tbMinimumDelta);
            this.gbJoystick.Controls.Add(this.tbDeltaModifier);
            this.gbJoystick.Enabled = false;
            this.gbJoystick.Location = new System.Drawing.Point(150, 12);
            this.gbJoystick.Name = "gbJoystick";
            this.gbJoystick.Size = new System.Drawing.Size(86, 113);
            this.gbJoystick.TabIndex = 9;
            this.gbJoystick.TabStop = false;
            this.gbJoystick.Text = "Joystick settings";
            // 
            // tbMinimumDelta
            // 
            this.tbMinimumDelta.LargeChange = 10;
            this.tbMinimumDelta.Location = new System.Drawing.Point(6, 62);
            this.tbMinimumDelta.Maximum = 50;
            this.tbMinimumDelta.Minimum = 5;
            this.tbMinimumDelta.Name = "tbMinimumDelta";
            this.tbMinimumDelta.Size = new System.Drawing.Size(75, 45);
            this.tbMinimumDelta.SmallChange = 5;
            this.tbMinimumDelta.TabIndex = 23;
            this.tbMinimumDelta.TickFrequency = 5;
            this.tbMinimumDelta.Value = 5;
            // 
            // tbDeltaModifier
            // 
            this.tbDeltaModifier.LargeChange = 50;
            this.tbDeltaModifier.Location = new System.Drawing.Point(3, 34);
            this.tbDeltaModifier.Maximum = 400;
            this.tbDeltaModifier.Minimum = 300;
            this.tbDeltaModifier.Name = "tbDeltaModifier";
            this.tbDeltaModifier.Size = new System.Drawing.Size(75, 45);
            this.tbDeltaModifier.SmallChange = 10;
            this.tbDeltaModifier.TabIndex = 22;
            this.tbDeltaModifier.TickFrequency = 10;
            this.tbDeltaModifier.Value = 380;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSouthEast);
            this.gbControl.Controls.Add(this.btnSouth);
            this.gbControl.Controls.Add(this.btnSouthWest);
            this.gbControl.Controls.Add(this.btnEast);
            this.gbControl.Controls.Add(this.btnWest);
            this.gbControl.Controls.Add(this.btnNorthEast);
            this.gbControl.Controls.Add(this.btnNorth);
            this.gbControl.Controls.Add(this.btnNorthWest);
            this.gbControl.Controls.Add(this.btnStop);
            this.gbControl.Enabled = false;
            this.gbControl.Location = new System.Drawing.Point(3, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(141, 113);
            this.gbControl.TabIndex = 8;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnSouthEast
            // 
            this.btnSouthEast.Image = ((System.Drawing.Image)(resources.GetObject("btnSouthEast.Image")));
            this.btnSouthEast.Location = new System.Drawing.Point(94, 80);
            this.btnSouthEast.Name = "btnSouthEast";
            this.btnSouthEast.Size = new System.Drawing.Size(34, 23);
            this.btnSouthEast.TabIndex = 8;
            this.btnSouthEast.UseVisualStyleBackColor = true;
            this.btnSouthEast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSouthEast_MouseDown);
            this.btnSouthEast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnSouth
            // 
            this.btnSouth.Image = ((System.Drawing.Image)(resources.GetObject("btnSouth.Image")));
            this.btnSouth.Location = new System.Drawing.Point(54, 80);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(34, 23);
            this.btnSouth.TabIndex = 7;
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSouth_MouseDown);
            this.btnSouth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnSouthWest
            // 
            this.btnSouthWest.Image = ((System.Drawing.Image)(resources.GetObject("btnSouthWest.Image")));
            this.btnSouthWest.Location = new System.Drawing.Point(14, 80);
            this.btnSouthWest.Name = "btnSouthWest";
            this.btnSouthWest.Size = new System.Drawing.Size(34, 23);
            this.btnSouthWest.TabIndex = 6;
            this.btnSouthWest.UseVisualStyleBackColor = true;
            this.btnSouthWest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSouthWest_MouseDown);
            this.btnSouthWest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnEast
            // 
            this.btnEast.Image = ((System.Drawing.Image)(resources.GetObject("btnEast.Image")));
            this.btnEast.Location = new System.Drawing.Point(94, 51);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(34, 23);
            this.btnEast.TabIndex = 5;
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnEast_MouseDown);
            this.btnEast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnWest
            // 
            this.btnWest.Image = ((System.Drawing.Image)(resources.GetObject("btnWest.Image")));
            this.btnWest.Location = new System.Drawing.Point(14, 51);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(34, 23);
            this.btnWest.TabIndex = 3;
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnWest_MouseDown);
            this.btnWest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnNorthEast
            // 
            this.btnNorthEast.Image = ((System.Drawing.Image)(resources.GetObject("btnNorthEast.Image")));
            this.btnNorthEast.Location = new System.Drawing.Point(94, 22);
            this.btnNorthEast.Name = "btnNorthEast";
            this.btnNorthEast.Size = new System.Drawing.Size(34, 23);
            this.btnNorthEast.TabIndex = 2;
            this.btnNorthEast.UseVisualStyleBackColor = true;
            this.btnNorthEast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNorthEast_MouseDown);
            this.btnNorthEast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnNorth
            // 
            this.btnNorth.Image = ((System.Drawing.Image)(resources.GetObject("btnNorth.Image")));
            this.btnNorth.Location = new System.Drawing.Point(54, 22);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(34, 23);
            this.btnNorth.TabIndex = 1;
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNorth_MouseDown);
            this.btnNorth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnNorthWest
            // 
            this.btnNorthWest.Image = ((System.Drawing.Image)(resources.GetObject("btnNorthWest.Image")));
            this.btnNorthWest.Location = new System.Drawing.Point(14, 22);
            this.btnNorthWest.Name = "btnNorthWest";
            this.btnNorthWest.Size = new System.Drawing.Size(34, 23);
            this.btnNorthWest.TabIndex = 0;
            this.btnNorthWest.UseVisualStyleBackColor = true;
            this.btnNorthWest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNorthWest_MouseDown);
            this.btnNorthWest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMouseUp);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(54, 51);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(34, 23);
            this.btnStop.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnStop, "Stop moving");
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImageConverter});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(46, 20);
            this.tsmiTools.Text = "Tools";
            // 
            // tsmiImageConverter
            // 
            this.tsmiImageConverter.Name = "tsmiImageConverter";
            this.tsmiImageConverter.Size = new System.Drawing.Size(180, 22);
            this.tsmiImageConverter.Text = "Image converter";
            this.tsmiImageConverter.Click += new System.EventHandler(this.TsmiImageConverter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 186);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(485, 225);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lego Mindstorms EV3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.gbMorse.ResumeLayout(false);
            this.gbMorse.PerformLayout();
            this.gbJoystick.ResumeLayout(false);
            this.gbJoystick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinimumDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeltaModifier)).EndInit();
            this.gbControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

