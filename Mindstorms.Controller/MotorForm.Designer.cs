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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotorForm));
            pMain = new Panel();
            gbMotor = new GroupBox();
            btnWaitForFinish = new Button();
            btnReset = new Button();
            btnIsBusy = new Button();
            lblMotor = new Label();
            lblPolarity = new Label();
            cbMotor = new ComboBox();
            btnGetTacho = new Button();
            btnClrTacho = new Button();
            btnSet = new Button();
            cbPolarity = new ComboBox();
            lblDaisyChainLayer = new Label();
            cbDaisyChainLayer = new ComboBox();
            btnRefreshPositions = new Button();
            lblLeverMotorPosition = new Label();
            lblRightMotorPosition = new Label();
            lblLeftMotorPosition = new Label();
            btnSetLeverMotorSpeed = new Button();
            tbLeverSpeed = new TrackBar();
            tbAccelerate = new TrackBar();
            chkAccelerate = new CheckBox();
            btnSetLeftMotorSpeed = new Button();
            btnSetRightMotorSpeed = new Button();
            btnSetBothMotorSpeed = new Button();
            tbRightSpeed = new TrackBar();
            tbLeftSpeed = new TrackBar();
            chkTimeout = new CheckBox();
            nudTimeout = new NumericUpDown();
            toolTip = new ToolTip(components);
            pMain.SuspendLayout();
            gbMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbLeverSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAccelerate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRightSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeout).BeginInit();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(gbMotor);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(926, 186);
            pMain.TabIndex = 0;
            // 
            // gbMotor
            // 
            gbMotor.Controls.Add(btnWaitForFinish);
            gbMotor.Controls.Add(btnReset);
            gbMotor.Controls.Add(btnIsBusy);
            gbMotor.Controls.Add(lblMotor);
            gbMotor.Controls.Add(lblPolarity);
            gbMotor.Controls.Add(cbMotor);
            gbMotor.Controls.Add(btnGetTacho);
            gbMotor.Controls.Add(btnClrTacho);
            gbMotor.Controls.Add(btnSet);
            gbMotor.Controls.Add(cbPolarity);
            gbMotor.Controls.Add(lblDaisyChainLayer);
            gbMotor.Controls.Add(cbDaisyChainLayer);
            gbMotor.Controls.Add(btnRefreshPositions);
            gbMotor.Controls.Add(lblLeverMotorPosition);
            gbMotor.Controls.Add(lblRightMotorPosition);
            gbMotor.Controls.Add(lblLeftMotorPosition);
            gbMotor.Controls.Add(btnSetLeverMotorSpeed);
            gbMotor.Controls.Add(tbLeverSpeed);
            gbMotor.Controls.Add(tbAccelerate);
            gbMotor.Controls.Add(chkAccelerate);
            gbMotor.Controls.Add(btnSetLeftMotorSpeed);
            gbMotor.Controls.Add(btnSetRightMotorSpeed);
            gbMotor.Controls.Add(btnSetBothMotorSpeed);
            gbMotor.Controls.Add(tbRightSpeed);
            gbMotor.Controls.Add(tbLeftSpeed);
            gbMotor.Controls.Add(chkTimeout);
            gbMotor.Controls.Add(nudTimeout);
            gbMotor.Dock = DockStyle.Fill;
            gbMotor.Location = new Point(0, 0);
            gbMotor.Margin = new Padding(4, 3, 4, 3);
            gbMotor.Name = "gbMotor";
            gbMotor.Padding = new Padding(4, 3, 4, 3);
            gbMotor.Size = new Size(926, 186);
            gbMotor.TabIndex = 7;
            gbMotor.TabStop = false;
            // 
            // btnWaitForFinish
            // 
            btnWaitForFinish.Location = new Point(748, 73);
            btnWaitForFinish.Margin = new Padding(4, 3, 4, 3);
            btnWaitForFinish.Name = "btnWaitForFinish";
            btnWaitForFinish.Size = new Size(88, 27);
            btnWaitForFinish.TabIndex = 43;
            btnWaitForFinish.Text = "Wait";
            btnWaitForFinish.UseVisualStyleBackColor = true;
            btnWaitForFinish.Click += BtnWaitForFinish_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(839, 39);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 27);
            btnReset.TabIndex = 42;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnIsBusy
            // 
            btnIsBusy.Location = new Point(748, 39);
            btnIsBusy.Margin = new Padding(4, 3, 4, 3);
            btnIsBusy.Name = "btnIsBusy";
            btnIsBusy.Size = new Size(88, 27);
            btnIsBusy.TabIndex = 41;
            btnIsBusy.Text = "Is busy";
            btnIsBusy.UseVisualStyleBackColor = true;
            btnIsBusy.Click += BtnCheckBusyness_Click;
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Location = new Point(596, 18);
            lblMotor.Margin = new Padding(4, 0, 4, 0);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(43, 15);
            lblMotor.TabIndex = 40;
            lblMotor.Text = "Is busy";
            // 
            // lblPolarity
            // 
            lblPolarity.AutoSize = true;
            lblPolarity.Location = new Point(363, 21);
            lblPolarity.Margin = new Padding(4, 0, 4, 0);
            lblPolarity.Name = "lblPolarity";
            lblPolarity.Size = new Size(47, 15);
            lblPolarity.TabIndex = 39;
            lblPolarity.Text = "Polarity";
            // 
            // cbMotor
            // 
            cbMotor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMotor.FormattingEnabled = true;
            cbMotor.Location = new Point(600, 39);
            cbMotor.Margin = new Padding(4, 3, 4, 3);
            cbMotor.Name = "cbMotor";
            cbMotor.Size = new Size(140, 23);
            cbMotor.TabIndex = 38;
            // 
            // btnGetTacho
            // 
            btnGetTacho.Location = new Point(461, 73);
            btnGetTacho.Margin = new Padding(4, 3, 4, 3);
            btnGetTacho.Name = "btnGetTacho";
            btnGetTacho.Size = new Size(88, 27);
            btnGetTacho.TabIndex = 37;
            btnGetTacho.Text = "Get Tacho";
            btnGetTacho.UseVisualStyleBackColor = true;
            btnGetTacho.Click += BtnGetTacho_Click;
            // 
            // btnClrTacho
            // 
            btnClrTacho.Location = new Point(366, 73);
            btnClrTacho.Margin = new Padding(4, 3, 4, 3);
            btnClrTacho.Name = "btnClrTacho";
            btnClrTacho.Size = new Size(88, 27);
            btnClrTacho.TabIndex = 36;
            btnClrTacho.Text = "Clr Tacho";
            btnClrTacho.UseVisualStyleBackColor = true;
            btnClrTacho.Click += BtnClrTacho_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(514, 37);
            btnSet.Margin = new Padding(4, 3, 4, 3);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(43, 27);
            btnSet.TabIndex = 35;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += BtnSet_Click;
            // 
            // cbPolarity
            // 
            cbPolarity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPolarity.FormattingEnabled = true;
            cbPolarity.Location = new Point(366, 39);
            cbPolarity.Margin = new Padding(4, 3, 4, 3);
            cbPolarity.Name = "cbPolarity";
            cbPolarity.Size = new Size(140, 23);
            cbPolarity.TabIndex = 34;
            // 
            // lblDaisyChainLayer
            // 
            lblDaisyChainLayer.AutoSize = true;
            lblDaisyChainLayer.Location = new Point(373, 120);
            lblDaisyChainLayer.Margin = new Padding(4, 0, 4, 0);
            lblDaisyChainLayer.Name = "lblDaisyChainLayer";
            lblDaisyChainLayer.Size = new Size(95, 15);
            lblDaisyChainLayer.TabIndex = 33;
            lblDaisyChainLayer.Text = "Daisy chain layer";
            // 
            // cbDaisyChainLayer
            // 
            cbDaisyChainLayer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDaisyChainLayer.FormattingEnabled = true;
            cbDaisyChainLayer.Location = new Point(373, 138);
            cbDaisyChainLayer.Margin = new Padding(4, 3, 4, 3);
            cbDaisyChainLayer.Name = "cbDaisyChainLayer";
            cbDaisyChainLayer.Size = new Size(185, 23);
            cbDaisyChainLayer.TabIndex = 32;
            // 
            // btnRefreshPositions
            // 
            btnRefreshPositions.Location = new Point(244, 136);
            btnRefreshPositions.Margin = new Padding(4, 3, 4, 3);
            btnRefreshPositions.Name = "btnRefreshPositions";
            btnRefreshPositions.Size = new Size(122, 27);
            btnRefreshPositions.TabIndex = 31;
            btnRefreshPositions.Text = "Refresh positions";
            btnRefreshPositions.UseVisualStyleBackColor = true;
            btnRefreshPositions.Click += BtnRefreshPositions_Click;
            // 
            // lblLeverMotorPosition
            // 
            lblLeverMotorPosition.AutoSize = true;
            lblLeverMotorPosition.Location = new Point(240, 18);
            lblLeverMotorPosition.Margin = new Padding(4, 0, 4, 0);
            lblLeverMotorPosition.Name = "lblLeverMotorPosition";
            lblLeverMotorPosition.Size = new Size(0, 15);
            lblLeverMotorPosition.TabIndex = 30;
            // 
            // lblRightMotorPosition
            // 
            lblRightMotorPosition.AutoSize = true;
            lblRightMotorPosition.Location = new Point(120, 18);
            lblRightMotorPosition.Margin = new Padding(4, 0, 4, 0);
            lblRightMotorPosition.Name = "lblRightMotorPosition";
            lblRightMotorPosition.Size = new Size(0, 15);
            lblRightMotorPosition.TabIndex = 29;
            // 
            // lblLeftMotorPosition
            // 
            lblLeftMotorPosition.AutoSize = true;
            lblLeftMotorPosition.Location = new Point(13, 18);
            lblLeftMotorPosition.Margin = new Padding(4, 0, 4, 0);
            lblLeftMotorPosition.Name = "lblLeftMotorPosition";
            lblLeftMotorPosition.Size = new Size(0, 15);
            lblLeftMotorPosition.TabIndex = 28;
            // 
            // btnSetLeverMotorSpeed
            // 
            btnSetLeverMotorSpeed.Image = Properties.Resources.lever;
            btnSetLeverMotorSpeed.Location = new Point(265, 73);
            btnSetLeverMotorSpeed.Margin = new Padding(4, 3, 4, 3);
            btnSetLeverMotorSpeed.Name = "btnSetLeverMotorSpeed";
            btnSetLeverMotorSpeed.Size = new Size(27, 27);
            btnSetLeverMotorSpeed.TabIndex = 27;
            toolTip.SetToolTip(btnSetLeverMotorSpeed, "Lever motor");
            btnSetLeverMotorSpeed.UseVisualStyleBackColor = true;
            btnSetLeverMotorSpeed.Click += BtnSetLeverMotorSpeed_Click;
            // 
            // tbLeverSpeed
            // 
            tbLeverSpeed.Location = new Point(233, 39);
            tbLeverSpeed.Margin = new Padding(4, 3, 4, 3);
            tbLeverSpeed.Maximum = 100;
            tbLeverSpeed.Minimum = -100;
            tbLeverSpeed.Name = "tbLeverSpeed";
            tbLeverSpeed.Size = new Size(86, 45);
            tbLeverSpeed.TabIndex = 26;
            tbLeverSpeed.Value = 100;
            tbLeverSpeed.ValueChanged += TbSpeed_ValueChanged;
            // 
            // tbAccelerate
            // 
            tbAccelerate.Location = new Point(117, 130);
            tbAccelerate.Margin = new Padding(4, 3, 4, 3);
            tbAccelerate.Maximum = 50;
            tbAccelerate.Minimum = 1;
            tbAccelerate.Name = "tbAccelerate";
            tbAccelerate.Size = new Size(86, 45);
            tbAccelerate.TabIndex = 24;
            tbAccelerate.Value = 1;
            tbAccelerate.Scroll += TbSpeed_ValueChanged;
            // 
            // chkAccelerate
            // 
            chkAccelerate.AutoSize = true;
            chkAccelerate.Location = new Point(124, 106);
            chkAccelerate.Margin = new Padding(4, 3, 4, 3);
            chkAccelerate.Name = "chkAccelerate";
            chkAccelerate.Size = new Size(81, 19);
            chkAccelerate.TabIndex = 23;
            chkAccelerate.Text = "Accelerate";
            chkAccelerate.UseVisualStyleBackColor = true;
            // 
            // btnSetLeftMotorSpeed
            // 
            btnSetLeftMotorSpeed.Image = (Image)resources.GetObject("btnSetLeftMotorSpeed.Image");
            btnSetLeftMotorSpeed.Location = new Point(16, 73);
            btnSetLeftMotorSpeed.Margin = new Padding(4, 3, 4, 3);
            btnSetLeftMotorSpeed.Name = "btnSetLeftMotorSpeed";
            btnSetLeftMotorSpeed.Size = new Size(27, 27);
            btnSetLeftMotorSpeed.TabIndex = 0;
            toolTip.SetToolTip(btnSetLeftMotorSpeed, "Left motor");
            btnSetLeftMotorSpeed.UseVisualStyleBackColor = true;
            btnSetLeftMotorSpeed.Click += BtnSetLeftMotorSpeed_Click;
            // 
            // btnSetRightMotorSpeed
            // 
            btnSetRightMotorSpeed.Image = (Image)resources.GetObject("btnSetRightMotorSpeed.Image");
            btnSetRightMotorSpeed.Location = new Point(163, 73);
            btnSetRightMotorSpeed.Margin = new Padding(4, 3, 4, 3);
            btnSetRightMotorSpeed.Name = "btnSetRightMotorSpeed";
            btnSetRightMotorSpeed.Size = new Size(27, 27);
            btnSetRightMotorSpeed.TabIndex = 22;
            toolTip.SetToolTip(btnSetRightMotorSpeed, "Right motor");
            btnSetRightMotorSpeed.UseVisualStyleBackColor = true;
            btnSetRightMotorSpeed.Click += BtnSetRightMotorSpeed_Click;
            // 
            // btnSetBothMotorSpeed
            // 
            btnSetBothMotorSpeed.Image = Properties.Resources.pair_of_gears;
            btnSetBothMotorSpeed.Location = new Point(89, 73);
            btnSetBothMotorSpeed.Margin = new Padding(4, 3, 4, 3);
            btnSetBothMotorSpeed.Name = "btnSetBothMotorSpeed";
            btnSetBothMotorSpeed.Size = new Size(27, 27);
            btnSetBothMotorSpeed.TabIndex = 5;
            toolTip.SetToolTip(btnSetBothMotorSpeed, "Both motors");
            btnSetBothMotorSpeed.UseVisualStyleBackColor = true;
            btnSetBothMotorSpeed.Click += BtnSetBothMotorSpeed_Click;
            // 
            // tbRightSpeed
            // 
            tbRightSpeed.Location = new Point(114, 38);
            tbRightSpeed.Margin = new Padding(4, 3, 4, 3);
            tbRightSpeed.Maximum = 100;
            tbRightSpeed.Minimum = -100;
            tbRightSpeed.Name = "tbRightSpeed";
            tbRightSpeed.Size = new Size(86, 45);
            tbRightSpeed.TabIndex = 21;
            tbRightSpeed.Value = 100;
            tbRightSpeed.ValueChanged += TbSpeed_ValueChanged;
            // 
            // tbLeftSpeed
            // 
            tbLeftSpeed.Location = new Point(4, 38);
            tbLeftSpeed.Margin = new Padding(4, 3, 4, 3);
            tbLeftSpeed.Maximum = 100;
            tbLeftSpeed.Minimum = -100;
            tbLeftSpeed.Name = "tbLeftSpeed";
            tbLeftSpeed.Size = new Size(86, 45);
            tbLeftSpeed.TabIndex = 20;
            tbLeftSpeed.Value = 100;
            tbLeftSpeed.ValueChanged += TbSpeed_ValueChanged;
            // 
            // chkTimeout
            // 
            chkTimeout.AutoSize = true;
            chkTimeout.Checked = true;
            chkTimeout.CheckState = CheckState.Checked;
            chkTimeout.Location = new Point(4, 106);
            chkTimeout.Margin = new Padding(4, 3, 4, 3);
            chkTimeout.Name = "chkTimeout";
            chkTimeout.Size = new Size(97, 19);
            chkTimeout.TabIndex = 13;
            chkTimeout.Text = "Timeout (ms)";
            chkTimeout.UseVisualStyleBackColor = true;
            // 
            // nudTimeout
            // 
            nudTimeout.Location = new Point(4, 136);
            nudTimeout.Margin = new Padding(4, 3, 4, 3);
            nudTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudTimeout.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudTimeout.Name = "nudTimeout";
            nudTimeout.Size = new Size(83, 23);
            nudTimeout.TabIndex = 12;
            nudTimeout.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // MotorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 186);
            Controls.Add(pMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MotorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Motor";
            pMain.ResumeLayout(false);
            gbMotor.ResumeLayout(false);
            gbMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbLeverSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAccelerate).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRightSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLeftSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeout).EndInit();
            ResumeLayout(false);
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