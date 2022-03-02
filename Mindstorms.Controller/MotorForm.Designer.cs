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
            this.pMain.Size = new System.Drawing.Size(361, 149);
            this.pMain.TabIndex = 0;
            // 
            // gbMotor
            // 
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
            this.gbMotor.Size = new System.Drawing.Size(361, 149);
            this.gbMotor.TabIndex = 7;
            this.gbMotor.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(361, 149);
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
    }
}