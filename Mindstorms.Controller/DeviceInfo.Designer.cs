namespace Mindstorms.Controller
{
    partial class DeviceInfo
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.rtbCommandResult = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblCommand = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnGetLastError = new System.Windows.Forms.Button();
            this.lblHardwareVersion = new System.Windows.Forms.Label();
            this.lblFirmwareBuild = new System.Windows.Forms.Label();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.lblOperatingSystemBuild = new System.Windows.Forms.Label();
            this.lblOperatingSystemVersion = new System.Windows.Forms.Label();
            this.lblBatteryTemperatureRise = new System.Windows.Forms.Label();
            this.lblBatteryVoltage = new System.Windows.Forms.Label();
            this.lblBatteryCurrent = new System.Windows.Forms.Label();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblCommunicationInterface = new System.Windows.Forms.Label();
            this.cbCommunicationInterface = new System.Windows.Forms.ComboBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(659, 297);
            this.pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.rtbCommandResult);
            this.gbMain.Controls.Add(this.btnExecute);
            this.gbMain.Controls.Add(this.lblCommand);
            this.gbMain.Controls.Add(this.tbCommand);
            this.gbMain.Controls.Add(this.btnGetLastError);
            this.gbMain.Controls.Add(this.lblHardwareVersion);
            this.gbMain.Controls.Add(this.lblFirmwareBuild);
            this.gbMain.Controls.Add(this.lblFirmwareVersion);
            this.gbMain.Controls.Add(this.lblOperatingSystemBuild);
            this.gbMain.Controls.Add(this.lblOperatingSystemVersion);
            this.gbMain.Controls.Add(this.lblBatteryTemperatureRise);
            this.gbMain.Controls.Add(this.lblBatteryVoltage);
            this.gbMain.Controls.Add(this.lblBatteryCurrent);
            this.gbMain.Controls.Add(this.lblBatteryLevel);
            this.gbMain.Controls.Add(this.btnChangePin);
            this.gbMain.Controls.Add(this.tbPin);
            this.gbMain.Controls.Add(this.lblPin);
            this.gbMain.Controls.Add(this.lblCommunicationInterface);
            this.gbMain.Controls.Add(this.cbCommunicationInterface);
            this.gbMain.Controls.Add(this.btnChangeName);
            this.gbMain.Controls.Add(this.tbName);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(659, 297);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // rtbCommandResult
            // 
            this.rtbCommandResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommandResult.Location = new System.Drawing.Point(9, 203);
            this.rtbCommandResult.Name = "rtbCommandResult";
            this.rtbCommandResult.Size = new System.Drawing.Size(638, 88);
            this.rtbCommandResult.TabIndex = 21;
            this.rtbCommandResult.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(572, 175);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 20;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(6, 161);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(54, 13);
            this.lblCommand.TabIndex = 19;
            this.lblCommand.Text = "Command";
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(9, 177);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(557, 20);
            this.tbCommand.TabIndex = 18;
            this.tbCommand.Text = "df -h";
            // 
            // btnGetLastError
            // 
            this.btnGetLastError.Location = new System.Drawing.Point(572, 145);
            this.btnGetLastError.Name = "btnGetLastError";
            this.btnGetLastError.Size = new System.Drawing.Size(75, 23);
            this.btnGetLastError.TabIndex = 17;
            this.btnGetLastError.Text = "Get last error";
            this.btnGetLastError.UseVisualStyleBackColor = true;
            this.btnGetLastError.Click += new System.EventHandler(this.BtnGetLastError_Click);
            // 
            // lblHardwareVersion
            // 
            this.lblHardwareVersion.AutoSize = true;
            this.lblHardwareVersion.Location = new System.Drawing.Point(437, 92);
            this.lblHardwareVersion.Name = "lblHardwareVersion";
            this.lblHardwareVersion.Size = new System.Drawing.Size(90, 13);
            this.lblHardwareVersion.TabIndex = 16;
            this.lblHardwareVersion.Text = "Hardware version";
            // 
            // lblFirmwareBuild
            // 
            this.lblFirmwareBuild.AutoSize = true;
            this.lblFirmwareBuild.Location = new System.Drawing.Point(437, 73);
            this.lblFirmwareBuild.Name = "lblFirmwareBuild";
            this.lblFirmwareBuild.Size = new System.Drawing.Size(74, 13);
            this.lblFirmwareBuild.TabIndex = 15;
            this.lblFirmwareBuild.Text = "Firmware build";
            // 
            // lblFirmwareVersion
            // 
            this.lblFirmwareVersion.AutoSize = true;
            this.lblFirmwareVersion.Location = new System.Drawing.Point(437, 54);
            this.lblFirmwareVersion.Name = "lblFirmwareVersion";
            this.lblFirmwareVersion.Size = new System.Drawing.Size(86, 13);
            this.lblFirmwareVersion.TabIndex = 14;
            this.lblFirmwareVersion.Text = "Firmware version";
            // 
            // lblOperatingSystemBuild
            // 
            this.lblOperatingSystemBuild.AutoSize = true;
            this.lblOperatingSystemBuild.Location = new System.Drawing.Point(437, 35);
            this.lblOperatingSystemBuild.Name = "lblOperatingSystemBuild";
            this.lblOperatingSystemBuild.Size = new System.Drawing.Size(113, 13);
            this.lblOperatingSystemBuild.TabIndex = 13;
            this.lblOperatingSystemBuild.Text = "Operating system build";
            // 
            // lblOperatingSystemVersion
            // 
            this.lblOperatingSystemVersion.AutoSize = true;
            this.lblOperatingSystemVersion.Location = new System.Drawing.Point(437, 16);
            this.lblOperatingSystemVersion.Name = "lblOperatingSystemVersion";
            this.lblOperatingSystemVersion.Size = new System.Drawing.Size(125, 13);
            this.lblOperatingSystemVersion.TabIndex = 12;
            this.lblOperatingSystemVersion.Text = "Operating system version";
            // 
            // lblBatteryTemperatureRise
            // 
            this.lblBatteryTemperatureRise.AutoSize = true;
            this.lblBatteryTemperatureRise.Location = new System.Drawing.Point(273, 73);
            this.lblBatteryTemperatureRise.Name = "lblBatteryTemperatureRise";
            this.lblBatteryTemperatureRise.Size = new System.Drawing.Size(118, 13);
            this.lblBatteryTemperatureRise.TabIndex = 11;
            this.lblBatteryTemperatureRise.Text = "Battery temperature rise";
            // 
            // lblBatteryVoltage
            // 
            this.lblBatteryVoltage.AutoSize = true;
            this.lblBatteryVoltage.Location = new System.Drawing.Point(273, 54);
            this.lblBatteryVoltage.Name = "lblBatteryVoltage";
            this.lblBatteryVoltage.Size = new System.Drawing.Size(78, 13);
            this.lblBatteryVoltage.TabIndex = 10;
            this.lblBatteryVoltage.Text = "Battery voltage";
            // 
            // lblBatteryCurrent
            // 
            this.lblBatteryCurrent.AutoSize = true;
            this.lblBatteryCurrent.Location = new System.Drawing.Point(273, 35);
            this.lblBatteryCurrent.Name = "lblBatteryCurrent";
            this.lblBatteryCurrent.Size = new System.Drawing.Size(76, 13);
            this.lblBatteryCurrent.TabIndex = 9;
            this.lblBatteryCurrent.Text = "Battery current";
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.Location = new System.Drawing.Point(273, 16);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(65, 13);
            this.lblBatteryLevel.TabIndex = 8;
            this.lblBatteryLevel.Text = "Battery level";
            // 
            // btnChangePin
            // 
            this.btnChangePin.Location = new System.Drawing.Point(163, 122);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(75, 23);
            this.btnChangePin.TabIndex = 7;
            this.btnChangePin.Text = "Change";
            this.btnChangePin.UseVisualStyleBackColor = true;
            this.btnChangePin.Click += new System.EventHandler(this.BtnChangePin_Click);
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(9, 124);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(148, 20);
            this.tbPin.TabIndex = 6;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(6, 108);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(22, 13);
            this.lblPin.TabIndex = 5;
            this.lblPin.Text = "Pin";
            // 
            // lblCommunicationInterface
            // 
            this.lblCommunicationInterface.AutoSize = true;
            this.lblCommunicationInterface.Location = new System.Drawing.Point(12, 66);
            this.lblCommunicationInterface.Name = "lblCommunicationInterface";
            this.lblCommunicationInterface.Size = new System.Drawing.Size(123, 13);
            this.lblCommunicationInterface.TabIndex = 4;
            this.lblCommunicationInterface.Text = "Communication interface";
            // 
            // cbCommunicationInterface
            // 
            this.cbCommunicationInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommunicationInterface.Enabled = false;
            this.cbCommunicationInterface.FormattingEnabled = true;
            this.cbCommunicationInterface.Location = new System.Drawing.Point(9, 82);
            this.cbCommunicationInterface.Name = "cbCommunicationInterface";
            this.cbCommunicationInterface.Size = new System.Drawing.Size(145, 21);
            this.cbCommunicationInterface.TabIndex = 3;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(163, 30);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(75, 23);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "Change";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.BtnChangeName_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(148, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // DeviceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 297);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DeviceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device info";
            this.Shown += new System.EventHandler(this.DeviceInfo_Shown);
            this.pMain.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbCommunicationInterface;
        private System.Windows.Forms.Label lblCommunicationInterface;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblBatteryTemperatureRise;
        private System.Windows.Forms.Label lblBatteryVoltage;
        private System.Windows.Forms.Label lblBatteryCurrent;
        private System.Windows.Forms.Label lblBatteryLevel;
        private System.Windows.Forms.Label lblFirmwareBuild;
        private System.Windows.Forms.Label lblFirmwareVersion;
        private System.Windows.Forms.Label lblOperatingSystemBuild;
        private System.Windows.Forms.Label lblOperatingSystemVersion;
        private System.Windows.Forms.Label lblHardwareVersion;
        private System.Windows.Forms.Button btnGetLastError;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.RichTextBox rtbCommandResult;
    }
}