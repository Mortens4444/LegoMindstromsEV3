namespace Mindstorms.Controller.SensorRead
{
    partial class InfraredSensorForm
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
            this.pMain = new System.Windows.Forms.Panel();
            this.gbLightSensor = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStartStopRead = new System.Windows.Forms.Button();
            this.lblSensorMode = new System.Windows.Forms.Label();
            this.cbSensorMode = new System.Windows.Forms.ComboBox();
            this.lblSensorPort = new System.Windows.Forms.Label();
            this.cbSensorPort = new System.Windows.Forms.ComboBox();
            this.btnRedUpper = new System.Windows.Forms.Button();
            this.btnRedLower = new System.Windows.Forms.Button();
            this.btnBlueUpper = new System.Windows.Forms.Button();
            this.btnBlueLower = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.pMain.SuspendLayout();
            this.gbLightSensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbLightSensor);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(334, 205);
            this.pMain.TabIndex = 0;
            // 
            // gbLightSensor
            // 
            this.gbLightSensor.Controls.Add(this.btnLong);
            this.gbLightSensor.Controls.Add(this.btnBlueLower);
            this.gbLightSensor.Controls.Add(this.btnBlueUpper);
            this.gbLightSensor.Controls.Add(this.btnRedLower);
            this.gbLightSensor.Controls.Add(this.btnRedUpper);
            this.gbLightSensor.Controls.Add(this.lblResult);
            this.gbLightSensor.Controls.Add(this.btnStartStopRead);
            this.gbLightSensor.Controls.Add(this.lblSensorMode);
            this.gbLightSensor.Controls.Add(this.cbSensorMode);
            this.gbLightSensor.Controls.Add(this.lblSensorPort);
            this.gbLightSensor.Controls.Add(this.cbSensorPort);
            this.gbLightSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLightSensor.Location = new System.Drawing.Point(0, 0);
            this.gbLightSensor.Name = "gbLightSensor";
            this.gbLightSensor.Size = new System.Drawing.Size(334, 205);
            this.gbLightSensor.TabIndex = 0;
            this.gbLightSensor.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(96, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 11;
            // 
            // btnStartStopRead
            // 
            this.btnStartStopRead.Location = new System.Drawing.Point(14, 55);
            this.btnStartStopRead.Name = "btnStartStopRead";
            this.btnStartStopRead.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopRead.TabIndex = 10;
            this.btnStartStopRead.Text = "Start";
            this.btnStartStopRead.UseVisualStyleBackColor = true;
            this.btnStartStopRead.Click += new System.EventHandler(this.BtnStartStopRead_Click);
            // 
            // lblSensorMode
            // 
            this.lblSensorMode.AutoSize = true;
            this.lblSensorMode.Location = new System.Drawing.Point(96, 12);
            this.lblSensorMode.Name = "lblSensorMode";
            this.lblSensorMode.Size = new System.Drawing.Size(34, 13);
            this.lblSensorMode.TabIndex = 9;
            this.lblSensorMode.Text = "Mode";
            // 
            // cbSensorMode
            // 
            this.cbSensorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensorMode.FormattingEnabled = true;
            this.cbSensorMode.Location = new System.Drawing.Point(99, 28);
            this.cbSensorMode.Name = "cbSensorMode";
            this.cbSensorMode.Size = new System.Drawing.Size(223, 21);
            this.cbSensorMode.TabIndex = 8;
            // 
            // lblSensorPort
            // 
            this.lblSensorPort.AutoSize = true;
            this.lblSensorPort.Location = new System.Drawing.Point(11, 12);
            this.lblSensorPort.Name = "lblSensorPort";
            this.lblSensorPort.Size = new System.Drawing.Size(26, 13);
            this.lblSensorPort.TabIndex = 7;
            this.lblSensorPort.Text = "Port";
            // 
            // cbSensorPort
            // 
            this.cbSensorPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSensorPort.FormattingEnabled = true;
            this.cbSensorPort.Location = new System.Drawing.Point(14, 28);
            this.cbSensorPort.Name = "cbSensorPort";
            this.cbSensorPort.Size = new System.Drawing.Size(75, 21);
            this.cbSensorPort.TabIndex = 6;
            // 
            // btnRedUpper
            // 
            this.btnRedUpper.Location = new System.Drawing.Point(208, 129);
            this.btnRedUpper.Name = "btnRedUpper";
            this.btnRedUpper.Size = new System.Drawing.Size(23, 23);
            this.btnRedUpper.TabIndex = 12;
            this.btnRedUpper.UseVisualStyleBackColor = true;
            // 
            // btnRedLower
            // 
            this.btnRedLower.Location = new System.Drawing.Point(208, 158);
            this.btnRedLower.Name = "btnRedLower";
            this.btnRedLower.Size = new System.Drawing.Size(23, 23);
            this.btnRedLower.TabIndex = 13;
            this.btnRedLower.UseVisualStyleBackColor = true;
            // 
            // btnBlueUpper
            // 
            this.btnBlueUpper.Location = new System.Drawing.Point(237, 129);
            this.btnBlueUpper.Name = "btnBlueUpper";
            this.btnBlueUpper.Size = new System.Drawing.Size(23, 23);
            this.btnBlueUpper.TabIndex = 14;
            this.btnBlueUpper.UseVisualStyleBackColor = true;
            // 
            // btnBlueLower
            // 
            this.btnBlueLower.Location = new System.Drawing.Point(237, 158);
            this.btnBlueLower.Name = "btnBlueLower";
            this.btnBlueLower.Size = new System.Drawing.Size(23, 23);
            this.btnBlueLower.TabIndex = 15;
            this.btnBlueLower.UseVisualStyleBackColor = true;
            // 
            // btnLong
            // 
            this.btnLong.Location = new System.Drawing.Point(208, 100);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(52, 23);
            this.btnLong.TabIndex = 16;
            this.btnLong.UseVisualStyleBackColor = true;
            // InfraredSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 205);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfraredSensorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infrared sensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UltrasonicSensorForm_FormClosing);
            this.pMain.ResumeLayout(false);
            this.gbLightSensor.ResumeLayout(false);
            this.gbLightSensor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbLightSensor;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStartStopRead;
        private System.Windows.Forms.Label lblSensorMode;
        private System.Windows.Forms.ComboBox cbSensorMode;
        private System.Windows.Forms.Label lblSensorPort;
        private System.Windows.Forms.ComboBox cbSensorPort;
        private System.Windows.Forms.Button btnBlueLower;
        private System.Windows.Forms.Button btnBlueUpper;
        private System.Windows.Forms.Button btnRedLower;
        private System.Windows.Forms.Button btnRedUpper;
        private System.Windows.Forms.Button btnLong;
    }
}