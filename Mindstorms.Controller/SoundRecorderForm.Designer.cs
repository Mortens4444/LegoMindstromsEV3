namespace Mindstorms.Controller
{
    partial class SoundRecorderForm
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
            lblInterval = new Label();
            btnRecordOrStop = new Button();
            saveFileDialog = new SaveFileDialog();
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
            pMain.Size = new Size(308, 63);
            pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            gbMain.Controls.Add(lblInterval);
            gbMain.Controls.Add(btnRecordOrStop);
            gbMain.Dock = DockStyle.Fill;
            gbMain.Location = new Point(0, 0);
            gbMain.Margin = new Padding(4, 3, 4, 3);
            gbMain.Name = "gbMain";
            gbMain.Padding = new Padding(4, 3, 4, 3);
            gbMain.Size = new Size(308, 63);
            gbMain.TabIndex = 0;
            gbMain.TabStop = false;
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new Point(14, 28);
            lblInterval.Margin = new Padding(4, 0, 4, 0);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(0, 15);
            lblInterval.TabIndex = 1;
            // 
            // btnRecordOrStop
            // 
            btnRecordOrStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecordOrStop.Location = new Point(206, 22);
            btnRecordOrStop.Margin = new Padding(4, 3, 4, 3);
            btnRecordOrStop.Name = "btnRecordOrStop";
            btnRecordOrStop.Size = new Size(88, 27);
            btnRecordOrStop.TabIndex = 0;
            btnRecordOrStop.Text = "Record";
            btnRecordOrStop.UseVisualStyleBackColor = true;
            btnRecordOrStop.Click += BtnRecordOrStop_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "Recording.wav";
            saveFileDialog.Filter = "Wave files|*.wav";
            // 
            // SoundRecorderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 63);
            Controls.Add(pMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SoundRecorderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sound Recorder";
            pMain.ResumeLayout(false);
            gbMain.ResumeLayout(false);
            gbMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnRecordOrStop;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}