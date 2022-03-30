namespace Mindstorms.Controller
{
    partial class MotorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotorForm));
            this.pMain = new System.Windows.Forms.Panel();
            this.gbMotor = new System.Windows.Forms.GroupBox();
            this.btnWaitForFinish = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnIsBusy = new System.Windows.Forms.Button();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblPolarity = new System.Windows.Forms.Label();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.btnGetTacho = new System.Windows.Forms.Button();
            this.btnClrTacho = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.cbPolarity = new System.Windows.Forms.ComboBox();
            this.lblDaisyChainLayer = new System.Windows.Forms.Label();
            this.cbDaisyChainLayer = new System.Windows.Forms.ComboBox();
            this.btnRefreshPositions = new System.Windows.Forms.Button();
            this.lblLeverMotorPosition = new System.Windows.Forms.Label();
            this.lblRightMotorPosition = new System.Windows.Forms.Label();
            this.lblLeftMotorPosition = new System.Windows.Forms.Label();
            this.btnSetLeverMotorSpeed = new System.Windows.Forms.Button();
            this.tbLeverSpeed = new System.Windows.Forms.TrackBar();
            this.tbAccelerate = new System.Windows.Forms.TrackBar();
            this.chkAccelerate = new System.Windows.Forms.CheckBox();
            this.btnSetLeftMotorSpeed = new System.Windows.Forms.Button();
            this.btnSetRightMotorSpeed = new System.Windows.Forms.Button();
            this.btnSetBothMotorSpeed = new System.Windows.Forms.Button();
            this.tbRightSpeed = new System.Windows.Forms.TrackBar();
            this.tbLeftSpeed = new System.Windows.Forms.TrackBar();
            this.chkTimeout = new System.Windows.Forms.CheckBox();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pMain.SuspendLayout();
            this.gbMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeverSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccelerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbMotor);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(794, 161);
            this.pMain.TabIndex = 0;
            // 
            // gbMotor
            // 
            this.gbMotor.Controls.Add(this.btnWaitForFinish);
            this.gbMotor.Controls.Add(this.btnReset);
            this.gbMotor.Controls.Add(this.btnIsBusy);
            this.gbMotor.Controls.Add(this.lblMotor);
            this.gbMotor.Controls.Add(this.lblPolarity);
            this.gbMotor.Controls.Add(this.cbMotor);
            this.gbMotor.Controls.Add(this.btnGetTacho);
            this.gbMotor.Controls.Add(this.btnClrTacho);
            this.gbMotor.Controls.Add(this.btnSet);
            this.gbMotor.Controls.Add(this.cbPolarity);
            this.gbMotor.Controls.Add(this.lblDaisyChainLayer);
            this.gbMotor.Controls.Add(this.cbDaisyChainLayer);
            this.gbMotor.Controls.Add(this.btnRefreshPositions);
            this.gbMotor.Controls.Add(this.lblLeverMotorPosition);
            this.gbMotor.Controls.Add(this.lblRightMotorPosition);
            this.gbMotor.Controls.Add(this.lblLeftMotorPosition);
            this.gbMotor.Controls.Add(this.btnSetLeverMotorSpeed);
            this.gbMotor.Controls.Add(this.tbLeverSpeed);
            this.gbMotor.Controls.Add(this.tbAccelerate);
            this.gbMotor.Controls.Add(this.chkAccelerate);
            this.gbMotor.Controls.Add(this.btnSetLeftMotorSpeed);
            this.gbMotor.Controls.Add(this.btnSetRightMotorSpeed);
            this.gbMotor.Controls.Add(this.btnSetBothMotorSpeed);
            this.gbMotor.Controls.Add(this.tbRightSpeed);
            this.gbMotor.Controls.Add(this.tbLeftSpeed);
            this.gbMotor.Controls.Add(this.chkTimeout);
            this.gbMotor.Controls.Add(this.nudTimeout);
            this.gbMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMotor.Location = new System.Drawing.Point(0, 0);
            this.gbMotor.Name = "gbMotor";
            this.gbMotor.Size = new System.Drawing.Size(794, 161);
            this.gbMotor.TabIndex = 7;
            this.gbMotor.TabStop = false;
            // 
            // btnWaitForFinish
            // 
            this.btnWaitForFinish.Location = new System.Drawing.Point(641, 63);
            this.btnWaitForFinish.Name = "btnWaitForFinish";
            this.btnWaitForFinish.Size = new System.Drawing.Size(75, 23);
            this.btnWaitForFinish.TabIndex = 43;
            this.btnWaitForFinish.Text = "Wait";
            this.btnWaitForFinish.UseVisualStyleBackColor = true;
            this.btnWaitForFinish.Click += new System.EventHandler(this.BtnWaitForFinish_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(719, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnIsBusy
            // 
            this.btnIsBusy.Location = new System.Drawing.Point(641, 34);
            this.btnIsBusy.Name = "btnIsBusy";
            this.btnIsBusy.Size = new System.Drawing.Size(75, 23);
            this.btnIsBusy.TabIndex = 41;
            this.btnIsBusy.Text = "Is busy";
            this.btnIsBusy.UseVisualStyleBackColor = true;
            this.btnIsBusy.Click += new System.EventHandler(this.BtnCheckBusyness_Click);
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(511, 16);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(40, 13);
            this.lblMotor.TabIndex = 40;
            this.lblMotor.Text = "Is busy";
            // 
            // lblPolarity
            // 
            this.lblPolarity.AutoSize = true;
            this.lblPolarity.Location = new System.Drawing.Point(311, 18);
            this.lblPolarity.Name = "lblPolarity";
            this.lblPolarity.Size = new System.Drawing.Size(41, 13);
            this.lblPolarity.TabIndex = 39;
            this.lblPolarity.Text = "Polarity";
            // 
            // cbMotor
            // 
            this.cbMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Location = new System.Drawing.Point(514, 34);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(121, 21);
            this.cbMotor.TabIndex = 38;
            // 
            // btnGetTacho
            // 
            this.btnGetTacho.Location = new System.Drawing.Point(395, 63);
            this.btnGetTacho.Name = "btnGetTacho";
            this.btnGetTacho.Size = new System.Drawing.Size(75, 23);
            this.btnGetTacho.TabIndex = 37;
            this.btnGetTacho.Text = "Get Tacho";
            this.btnGetTacho.UseVisualStyleBackColor = true;
            this.btnGetTacho.Click += new System.EventHandler(this.BtnGetTacho_Click);
            // 
            // btnClrTacho
            // 
            this.btnClrTacho.Location = new System.Drawing.Point(314, 63);
            this.btnClrTacho.Name = "btnClrTacho";
            this.btnClrTacho.Size = new System.Drawing.Size(75, 23);
            this.btnClrTacho.TabIndex = 36;
            this.btnClrTacho.Text = "Clr Tacho";
            this.btnClrTacho.UseVisualStyleBackColor = true;
            this.btnClrTacho.Click += new System.EventHandler(this.BtnClrTacho_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(441, 32);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(37, 23);
            this.btnSet.TabIndex = 35;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // cbPolarity
            // 
            this.cbPolarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPolarity.FormattingEnabled = true;
            this.cbPolarity.Location = new System.Drawing.Point(314, 34);
            this.cbPolarity.Name = "cbPolarity";
            this.cbPolarity.Size = new System.Drawing.Size(121, 21);
            this.cbPolarity.TabIndex = 34;
            // 
            // lblDaisyChainLayer
            // 
            this.lblDaisyChainLayer.AutoSize = true;
            this.lblDaisyChainLayer.Location = new System.Drawing.Point(320, 104);
            this.lblDaisyChainLayer.Name = "lblDaisyChainLayer";
            this.lblDaisyChainLayer.Size = new System.Drawing.Size(87, 13);
            this.lblDaisyChainLayer.TabIndex = 33;
            this.lblDaisyChainLayer.Text = "Daisy chain layer";
            // 
            // cbDaisyChainLayer
            // 
            this.cbDaisyChainLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaisyChainLayer.FormattingEnabled = true;
            this.cbDaisyChainLayer.Location = new System.Drawing.Point(320, 120);
            this.cbDaisyChainLayer.Name = "cbDaisyChainLayer";
            this.cbDaisyChainLayer.Size = new System.Drawing.Size(159, 21);
            this.cbDaisyChainLayer.TabIndex = 32;
            // 
            // btnRefreshPositions
            // 
            this.btnRefreshPositions.Location = new System.Drawing.Point(209, 118);
            this.btnRefreshPositions.Name = "btnRefreshPositions";
            this.btnRefreshPositions.Size = new System.Drawing.Size(105, 23);
            this.btnRefreshPositions.TabIndex = 31;
            this.btnRefreshPositions.Text = "Refresh positions";
            this.btnRefreshPositions.UseVisualStyleBackColor = true;
            this.btnRefreshPositions.Click += new System.EventHandler(this.BtnRefreshPositions_Click);
            // 
            // lblLeverMotorPosition
            // 
            this.lblLeverMotorPosition.AutoSize = true;
            this.lblLeverMotorPosition.Location = new System.Drawing.Point(206, 16);
            this.lblLeverMotorPosition.Name = "lblLeverMotorPosition";
            this.lblLeverMotorPosition.Size = new System.Drawing.Size(0, 13);
            this.lblLeverMotorPosition.TabIndex = 30;
            // 
            // lblRightMotorPosition
            // 
            this.lblRightMotorPosition.AutoSize = true;
            this.lblRightMotorPosition.Location = new System.Drawing.Point(103, 16);
            this.lblRightMotorPosition.Name = "lblRightMotorPosition";
            this.lblRightMotorPosition.Size = new System.Drawing.Size(0, 13);
            this.lblRightMotorPosition.TabIndex = 29;
            // 
            // lblLeftMotorPosition
            // 
            this.lblLeftMotorPosition.AutoSize = true;
            this.lblLeftMotorPosition.Location = new System.Drawing.Point(11, 16);
            this.lblLeftMotorPosition.Name = "lblLeftMotorPosition";
            this.lblLeftMotorPosition.Size = new System.Drawing.Size(0, 13);
            this.lblLeftMotorPosition.TabIndex = 28;
            // 
            // btnSetLeverMotorSpeed
            // 
            this.btnSetLeverMotorSpeed.Image = global::Mindstorms.Controller.Properties.Resources.lever;
            this.btnSetLeverMotorSpeed.Location = new System.Drawing.Point(227, 63);
            this.btnSetLeverMotorSpeed.Name = "btnSetLeverMotorSpeed";
            this.btnSetLeverMotorSpeed.Size = new System.Drawing.Size(23, 23);
            this.btnSetLeverMotorSpeed.TabIndex = 27;
            this.toolTip.SetToolTip(this.btnSetLeverMotorSpeed, "Lever motor");
            this.btnSetLeverMotorSpeed.UseVisualStyleBackColor = true;
            this.btnSetLeverMotorSpeed.Click += new System.EventHandler(this.BtnSetLeverMotorSpeed_Click);
            // 
            // tbLeverSpeed
            // 
            this.tbLeverSpeed.Location = new System.Drawing.Point(200, 34);
            this.tbLeverSpeed.Maximum = 100;
            this.tbLeverSpeed.Minimum = -100;
            this.tbLeverSpeed.Name = "tbLeverSpeed";
            this.tbLeverSpeed.Size = new System.Drawing.Size(74, 45);
            this.tbLeverSpeed.TabIndex = 26;
            this.tbLeverSpeed.Value = 100;
            this.tbLeverSpeed.ValueChanged += new System.EventHandler(this.TbSpeed_ValueChanged);
            // 
            // tbAccelerate
            // 
            this.tbAccelerate.Location = new System.Drawing.Point(100, 113);
            this.tbAccelerate.Maximum = 50;
            this.tbAccelerate.Minimum = 1;
            this.tbAccelerate.Name = "tbAccelerate";
            this.tbAccelerate.Size = new System.Drawing.Size(74, 45);
            this.tbAccelerate.TabIndex = 24;
            this.tbAccelerate.Value = 1;
            this.tbAccelerate.Scroll += new System.EventHandler(this.TbSpeed_ValueChanged);
            // 
            // chkAccelerate
            // 
            this.chkAccelerate.AutoSize = true;
            this.chkAccelerate.Location = new System.Drawing.Point(106, 92);
            this.chkAccelerate.Name = "chkAccelerate";
            this.chkAccelerate.Size = new System.Drawing.Size(77, 17);
            this.chkAccelerate.TabIndex = 23;
            this.chkAccelerate.Text = "Accelerate";
            this.chkAccelerate.UseVisualStyleBackColor = true;
            // 
            // btnSetLeftMotorSpeed
            // 
            this.btnSetLeftMotorSpeed.Image = ((System.Drawing.Image)(resources.GetObject("btnSetLeftMotorSpeed.Image")));
            this.btnSetLeftMotorSpeed.Location = new System.Drawing.Point(14, 63);
            this.btnSetLeftMotorSpeed.Name = "btnSetLeftMotorSpeed";
            this.btnSetLeftMotorSpeed.Size = new System.Drawing.Size(23, 23);
            this.btnSetLeftMotorSpeed.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnSetLeftMotorSpeed, "Left motor");
            this.btnSetLeftMotorSpeed.UseVisualStyleBackColor = true;
            this.btnSetLeftMotorSpeed.Click += new System.EventHandler(this.BtnSetLeftMotorSpeed_Click);
            // 
            // btnSetRightMotorSpeed
            // 
            this.btnSetRightMotorSpeed.Image = ((System.Drawing.Image)(resources.GetObject("btnSetRightMotorSpeed.Image")));
            this.btnSetRightMotorSpeed.Location = new System.Drawing.Point(140, 63);
            this.btnSetRightMotorSpeed.Name = "btnSetRightMotorSpeed";
            this.btnSetRightMotorSpeed.Size = new System.Drawing.Size(23, 23);
            this.btnSetRightMotorSpeed.TabIndex = 22;
            this.toolTip.SetToolTip(this.btnSetRightMotorSpeed, "Right motor");
            this.btnSetRightMotorSpeed.UseVisualStyleBackColor = true;
            this.btnSetRightMotorSpeed.Click += new System.EventHandler(this.BtnSetRightMotorSpeed_Click);
            // 
            // btnSetBothMotorSpeed
            // 
            this.btnSetBothMotorSpeed.Image = global::Mindstorms.Controller.Properties.Resources.pair_of_gears;
            this.btnSetBothMotorSpeed.Location = new System.Drawing.Point(76, 63);
            this.btnSetBothMotorSpeed.Name = "btnSetBothMotorSpeed";
            this.btnSetBothMotorSpeed.Size = new System.Drawing.Size(23, 23);
            this.btnSetBothMotorSpeed.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnSetBothMotorSpeed, "Both motors");
            this.btnSetBothMotorSpeed.UseVisualStyleBackColor = true;
            this.btnSetBothMotorSpeed.Click += new System.EventHandler(this.BtnSetBothMotorSpeed_Click);
            // 
            // tbRightSpeed
            // 
            this.tbRightSpeed.Location = new System.Drawing.Point(98, 33);
            this.tbRightSpeed.Maximum = 100;
            this.tbRightSpeed.Minimum = -100;
            this.tbRightSpeed.Name = "tbRightSpeed";
            this.tbRightSpeed.Size = new System.Drawing.Size(74, 45);
            this.tbRightSpeed.TabIndex = 21;
            this.tbRightSpeed.Value = 100;
            this.tbRightSpeed.ValueChanged += new System.EventHandler(this.TbSpeed_ValueChanged);
            // 
            // tbLeftSpeed
            // 
            this.tbLeftSpeed.Location = new System.Drawing.Point(3, 33);
            this.tbLeftSpeed.Maximum = 100;
            this.tbLeftSpeed.Minimum = -100;
            this.tbLeftSpeed.Name = "tbLeftSpeed";
            this.tbLeftSpeed.Size = new System.Drawing.Size(74, 45);
            this.tbLeftSpeed.TabIndex = 20;
            this.tbLeftSpeed.Value = 100;
            this.tbLeftSpeed.ValueChanged += new System.EventHandler(this.TbSpeed_ValueChanged);
            // 
            // chkTimeout
            // 
            this.chkTimeout.AutoSize = true;
            this.chkTimeout.Checked = true;
            this.chkTimeout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimeout.Location = new System.Drawing.Point(3, 92);
            this.chkTimeout.Name = "chkTimeout";
            this.chkTimeout.Size = new System.Drawing.Size(86, 17);
            this.chkTimeout.TabIndex = 13;
            this.chkTimeout.Text = "Timeout (ms)";
            this.chkTimeout.UseVisualStyleBackColor = true;
            // 
            // nudTimeout
            // 
            this.nudTimeout.Location = new System.Drawing.Point(3, 118);
            this.nudTimeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(71, 20);
            this.nudTimeout.TabIndex = 12;
            this.nudTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 161);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MotorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motor";
            this.pMain.ResumeLayout(false);
            this.gbMotor.ResumeLayout(false);
            this.gbMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeverSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccelerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMotor;
        private System.Windows.Forms.TrackBar tbAccelerate;
        private System.Windows.Forms.CheckBox chkAccelerate;
        private System.Windows.Forms.Button btnSetLeftMotorSpeed;
        private System.Windows.Forms.Button btnSetRightMotorSpeed;
        private System.Windows.Forms.Button btnSetBothMotorSpeed;
        private System.Windows.Forms.TrackBar tbRightSpeed;
        private System.Windows.Forms.TrackBar tbLeftSpeed;
        private System.Windows.Forms.CheckBox chkTimeout;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.Button btnSetLeverMotorSpeed;
        private System.Windows.Forms.TrackBar tbLeverSpeed;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblLeverMotorPosition;
        private System.Windows.Forms.Label lblRightMotorPosition;
        private System.Windows.Forms.Label lblLeftMotorPosition;
        private System.Windows.Forms.Button btnRefreshPositions;
        private System.Windows.Forms.Label lblDaisyChainLayer;
        private System.Windows.Forms.ComboBox cbDaisyChainLayer;
        private System.Windows.Forms.ComboBox cbPolarity;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnClrTacho;
        private System.Windows.Forms.Button btnGetTacho;
        private System.Windows.Forms.Button btnIsBusy;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblPolarity;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWaitForFinish;
    }
}