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
            this.pMain = new System.Windows.Forms.Panel();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnRecordOrStop = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.pMain.Size = new System.Drawing.Size(264, 55);
            this.pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblInterval);
            this.gbMain.Controls.Add(this.btnRecordOrStop);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(264, 55);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // btnRecordOrStop
            // 
            this.btnRecordOrStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecordOrStop.Location = new System.Drawing.Point(177, 19);
            this.btnRecordOrStop.Name = "btnRecordOrStop";
            this.btnRecordOrStop.Size = new System.Drawing.Size(75, 23);
            this.btnRecordOrStop.TabIndex = 0;
            this.btnRecordOrStop.Text = "Record";
            this.btnRecordOrStop.UseVisualStyleBackColor = true;
            this.btnRecordOrStop.Click += new System.EventHandler(this.BtnRecordOrStop_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(12, 24);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(0, 13);
            this.lblInterval.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Recording.wav";
            this.saveFileDialog.Filter = "Wave files|*.wav";
            // 
            // SoundRecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 55);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SoundRecorderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound Recorder";
            this.pMain.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnRecordOrStop;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}