namespace Mindstorms.Controller.SensorRead
{
    partial class UltrasonicSensorForm
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
            this.lblDaisyChainLayer = new System.Windows.Forms.Label();
            this.cbDaisyChainLayer = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStartStopRead = new System.Windows.Forms.Button();
            this.lblSensorMode = new System.Windows.Forms.Label();
            this.cbSensorMode = new System.Windows.Forms.ComboBox();
            this.lblSensorPort = new System.Windows.Forms.Label();
            this.cbSensorPort = new System.Windows.Forms.ComboBox();
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
            this.pMain.Size = new System.Drawing.Size(334, 111);
            this.pMain.TabIndex = 0;
            // 
            // gbLightSensor
            // 
            this.gbLightSensor.Controls.Add(this.lblDaisyChainLayer);
            this.gbLightSensor.Controls.Add(this.cbDaisyChainLayer);
            this.gbLightSensor.Controls.Add(this.lblResult);
            this.gbLightSensor.Controls.Add(this.btnStartStopRead);
            this.gbLightSensor.Controls.Add(this.lblSensorMode);
            this.gbLightSensor.Controls.Add(this.cbSensorMode);
            this.gbLightSensor.Controls.Add(this.lblSensorPort);
            this.gbLightSensor.Controls.Add(this.cbSensorPort);
            this.gbLightSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLightSensor.Location = new System.Drawing.Point(0, 0);
            this.gbLightSensor.Name = "gbLightSensor";
            this.gbLightSensor.Size = new System.Drawing.Size(334, 111);
            this.gbLightSensor.TabIndex = 0;
            this.gbLightSensor.TabStop = false;
            // 
            // lblDaisyChainLayer
            // 
            this.lblDaisyChainLayer.AutoSize = true;
            this.lblDaisyChainLayer.Location = new System.Drawing.Point(12, 89);
            this.lblDaisyChainLayer.Name = "lblDaisyChainLayer";
            this.lblDaisyChainLayer.Size = new System.Drawing.Size(87, 13);
            this.lblDaisyChainLayer.TabIndex = 17;
            this.lblDaisyChainLayer.Text = "Daisy chain layer";
            // 
            // cbDaisyChainLayer
            // 
            this.cbDaisyChainLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaisyChainLayer.FormattingEnabled = true;
            this.cbDaisyChainLayer.Location = new System.Drawing.Point(105, 84);
            this.cbDaisyChainLayer.Name = "cbDaisyChainLayer";
            this.cbDaisyChainLayer.Size = new System.Drawing.Size(159, 21);
            this.cbDaisyChainLayer.TabIndex = 16;
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
            // UltrasonicSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(350, 150);
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "UltrasonicSensorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultrasonic sensor";
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
        private System.Windows.Forms.Label lblDaisyChainLayer;
        private System.Windows.Forms.ComboBox cbDaisyChainLayer;
    }
}