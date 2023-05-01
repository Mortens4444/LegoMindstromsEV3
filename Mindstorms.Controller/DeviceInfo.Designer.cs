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
            pMain = new Panel();
            gbMain = new GroupBox();
            cbCommand = new ComboBox();
            rtbCommandResult = new RichTextBox();
            btnExecute = new Button();
            lblCommand = new Label();
            btnGetLastError = new Button();
            lblHardwareVersion = new Label();
            lblFirmwareBuild = new Label();
            lblFirmwareVersion = new Label();
            lblOperatingSystemBuild = new Label();
            lblOperatingSystemVersion = new Label();
            lblBatteryTemperatureRise = new Label();
            lblBatteryVoltage = new Label();
            lblBatteryCurrent = new Label();
            lblBatteryLevel = new Label();
            btnChangePin = new Button();
            tbPin = new TextBox();
            lblPin = new Label();
            lblCommunicationInterface = new Label();
            cbCommunicationInterface = new ComboBox();
            btnChangeName = new Button();
            tbName = new TextBox();
            lblName = new Label();
            pMain.SuspendLayout();
            gbMain.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(gbMain);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(769, 343);
            pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            gbMain.Controls.Add(cbCommand);
            gbMain.Controls.Add(rtbCommandResult);
            gbMain.Controls.Add(btnExecute);
            gbMain.Controls.Add(lblCommand);
            gbMain.Controls.Add(btnGetLastError);
            gbMain.Controls.Add(lblHardwareVersion);
            gbMain.Controls.Add(lblFirmwareBuild);
            gbMain.Controls.Add(lblFirmwareVersion);
            gbMain.Controls.Add(lblOperatingSystemBuild);
            gbMain.Controls.Add(lblOperatingSystemVersion);
            gbMain.Controls.Add(lblBatteryTemperatureRise);
            gbMain.Controls.Add(lblBatteryVoltage);
            gbMain.Controls.Add(lblBatteryCurrent);
            gbMain.Controls.Add(lblBatteryLevel);
            gbMain.Controls.Add(btnChangePin);
            gbMain.Controls.Add(tbPin);
            gbMain.Controls.Add(lblPin);
            gbMain.Controls.Add(lblCommunicationInterface);
            gbMain.Controls.Add(cbCommunicationInterface);
            gbMain.Controls.Add(btnChangeName);
            gbMain.Controls.Add(tbName);
            gbMain.Controls.Add(lblName);
            gbMain.Dock = DockStyle.Fill;
            gbMain.Location = new Point(0, 0);
            gbMain.Margin = new Padding(4, 3, 4, 3);
            gbMain.Name = "gbMain";
            gbMain.Padding = new Padding(4, 3, 4, 3);
            gbMain.Size = new Size(769, 343);
            gbMain.TabIndex = 0;
            gbMain.TabStop = false;
            // 
            // cbCommand
            // 
            cbCommand.FormattingEnabled = true;
            cbCommand.Items.AddRange(new object[] { "dmesg", "mount", "ps", "pwd", "ls -la /", "df -h", "reboot", "find / -name output.rtf", "ifconfig -a", "uname -a", "lsusb -v", "lsmod", "modprobe -l" });
            cbCommand.Location = new Point(10, 204);
            cbCommand.Margin = new Padding(4, 3, 4, 3);
            cbCommand.Name = "cbCommand";
            cbCommand.Size = new Size(649, 23);
            cbCommand.TabIndex = 22;
            // 
            // rtbCommandResult
            // 
            rtbCommandResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbCommandResult.Location = new Point(10, 234);
            rtbCommandResult.Margin = new Padding(4, 3, 4, 3);
            rtbCommandResult.Name = "rtbCommandResult";
            rtbCommandResult.Size = new Size(744, 101);
            rtbCommandResult.TabIndex = 21;
            rtbCommandResult.Text = "";
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(667, 202);
            btnExecute.Margin = new Padding(4, 3, 4, 3);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(88, 27);
            btnExecute.TabIndex = 20;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += BtnExecute_Click;
            // 
            // lblCommand
            // 
            lblCommand.AutoSize = true;
            lblCommand.Location = new Point(7, 186);
            lblCommand.Margin = new Padding(4, 0, 4, 0);
            lblCommand.Name = "lblCommand";
            lblCommand.Size = new Size(64, 15);
            lblCommand.TabIndex = 19;
            lblCommand.Text = "Command";
            // 
            // btnGetLastError
            // 
            btnGetLastError.Location = new Point(667, 167);
            btnGetLastError.Margin = new Padding(4, 3, 4, 3);
            btnGetLastError.Name = "btnGetLastError";
            btnGetLastError.Size = new Size(88, 27);
            btnGetLastError.TabIndex = 17;
            btnGetLastError.Text = "Get last error";
            btnGetLastError.UseVisualStyleBackColor = true;
            btnGetLastError.Click += BtnGetLastError_Click;
            // 
            // lblHardwareVersion
            // 
            lblHardwareVersion.AutoSize = true;
            lblHardwareVersion.Location = new Point(510, 106);
            lblHardwareVersion.Margin = new Padding(4, 0, 4, 0);
            lblHardwareVersion.Name = "lblHardwareVersion";
            lblHardwareVersion.Size = new Size(99, 15);
            lblHardwareVersion.TabIndex = 16;
            lblHardwareVersion.Text = "Hardware version";
            // 
            // lblFirmwareBuild
            // 
            lblFirmwareBuild.AutoSize = true;
            lblFirmwareBuild.Location = new Point(510, 84);
            lblFirmwareBuild.Margin = new Padding(4, 0, 4, 0);
            lblFirmwareBuild.Name = "lblFirmwareBuild";
            lblFirmwareBuild.Size = new Size(86, 15);
            lblFirmwareBuild.TabIndex = 15;
            lblFirmwareBuild.Text = "Firmware build";
            // 
            // lblFirmwareVersion
            // 
            lblFirmwareVersion.AutoSize = true;
            lblFirmwareVersion.Location = new Point(510, 62);
            lblFirmwareVersion.Margin = new Padding(4, 0, 4, 0);
            lblFirmwareVersion.Name = "lblFirmwareVersion";
            lblFirmwareVersion.Size = new Size(97, 15);
            lblFirmwareVersion.TabIndex = 14;
            lblFirmwareVersion.Text = "Firmware version";
            // 
            // lblOperatingSystemBuild
            // 
            lblOperatingSystemBuild.AutoSize = true;
            lblOperatingSystemBuild.Location = new Point(510, 40);
            lblOperatingSystemBuild.Margin = new Padding(4, 0, 4, 0);
            lblOperatingSystemBuild.Name = "lblOperatingSystemBuild";
            lblOperatingSystemBuild.Size = new Size(130, 15);
            lblOperatingSystemBuild.TabIndex = 13;
            lblOperatingSystemBuild.Text = "Operating system build";
            // 
            // lblOperatingSystemVersion
            // 
            lblOperatingSystemVersion.AutoSize = true;
            lblOperatingSystemVersion.Location = new Point(510, 18);
            lblOperatingSystemVersion.Margin = new Padding(4, 0, 4, 0);
            lblOperatingSystemVersion.Name = "lblOperatingSystemVersion";
            lblOperatingSystemVersion.Size = new Size(141, 15);
            lblOperatingSystemVersion.TabIndex = 12;
            lblOperatingSystemVersion.Text = "Operating system version";
            // 
            // lblBatteryTemperatureRise
            // 
            lblBatteryTemperatureRise.AutoSize = true;
            lblBatteryTemperatureRise.Location = new Point(318, 84);
            lblBatteryTemperatureRise.Margin = new Padding(4, 0, 4, 0);
            lblBatteryTemperatureRise.Name = "lblBatteryTemperatureRise";
            lblBatteryTemperatureRise.Size = new Size(133, 15);
            lblBatteryTemperatureRise.TabIndex = 11;
            lblBatteryTemperatureRise.Text = "Battery temperature rise";
            // 
            // lblBatteryVoltage
            // 
            lblBatteryVoltage.AutoSize = true;
            lblBatteryVoltage.Location = new Point(318, 62);
            lblBatteryVoltage.Margin = new Padding(4, 0, 4, 0);
            lblBatteryVoltage.Name = "lblBatteryVoltage";
            lblBatteryVoltage.Size = new Size(86, 15);
            lblBatteryVoltage.TabIndex = 10;
            lblBatteryVoltage.Text = "Battery voltage";
            // 
            // lblBatteryCurrent
            // 
            lblBatteryCurrent.AutoSize = true;
            lblBatteryCurrent.Location = new Point(318, 40);
            lblBatteryCurrent.Margin = new Padding(4, 0, 4, 0);
            lblBatteryCurrent.Name = "lblBatteryCurrent";
            lblBatteryCurrent.Size = new Size(85, 15);
            lblBatteryCurrent.TabIndex = 9;
            lblBatteryCurrent.Text = "Battery current";
            // 
            // lblBatteryLevel
            // 
            lblBatteryLevel.AutoSize = true;
            lblBatteryLevel.Location = new Point(318, 18);
            lblBatteryLevel.Margin = new Padding(4, 0, 4, 0);
            lblBatteryLevel.Name = "lblBatteryLevel";
            lblBatteryLevel.Size = new Size(71, 15);
            lblBatteryLevel.TabIndex = 8;
            lblBatteryLevel.Text = "Battery level";
            // 
            // btnChangePin
            // 
            btnChangePin.Location = new Point(190, 141);
            btnChangePin.Margin = new Padding(4, 3, 4, 3);
            btnChangePin.Name = "btnChangePin";
            btnChangePin.Size = new Size(88, 27);
            btnChangePin.TabIndex = 7;
            btnChangePin.Text = "Change";
            btnChangePin.UseVisualStyleBackColor = true;
            btnChangePin.Click += BtnChangePin_Click;
            // 
            // tbPin
            // 
            tbPin.Location = new Point(10, 143);
            tbPin.Margin = new Padding(4, 3, 4, 3);
            tbPin.Name = "tbPin";
            tbPin.Size = new Size(172, 23);
            tbPin.TabIndex = 6;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(7, 125);
            lblPin.Margin = new Padding(4, 0, 4, 0);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(24, 15);
            lblPin.TabIndex = 5;
            lblPin.Text = "Pin";
            // 
            // lblCommunicationInterface
            // 
            lblCommunicationInterface.AutoSize = true;
            lblCommunicationInterface.Location = new Point(14, 76);
            lblCommunicationInterface.Margin = new Padding(4, 0, 4, 0);
            lblCommunicationInterface.Name = "lblCommunicationInterface";
            lblCommunicationInterface.Size = new Size(143, 15);
            lblCommunicationInterface.TabIndex = 4;
            lblCommunicationInterface.Text = "Communication interface";
            // 
            // cbCommunicationInterface
            // 
            cbCommunicationInterface.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCommunicationInterface.Enabled = false;
            cbCommunicationInterface.FormattingEnabled = true;
            cbCommunicationInterface.Location = new Point(10, 95);
            cbCommunicationInterface.Margin = new Padding(4, 3, 4, 3);
            cbCommunicationInterface.Name = "cbCommunicationInterface";
            cbCommunicationInterface.Size = new Size(168, 23);
            cbCommunicationInterface.TabIndex = 3;
            // 
            // btnChangeName
            // 
            btnChangeName.Location = new Point(190, 35);
            btnChangeName.Margin = new Padding(4, 3, 4, 3);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(88, 27);
            btnChangeName.TabIndex = 2;
            btnChangeName.Text = "Change";
            btnChangeName.UseVisualStyleBackColor = true;
            btnChangeName.Click += BtnChangeName_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(10, 37);
            tbName.Margin = new Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(172, 23);
            tbName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(7, 18);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // DeviceInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 343);
            Controls.Add(pMain);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeviceInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Device info";
            Shown += DeviceInfo_Shown;
            pMain.ResumeLayout(false);
            gbMain.ResumeLayout(false);
            gbMain.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox rtbCommandResult;
        private System.Windows.Forms.ComboBox cbCommand;
    }
}