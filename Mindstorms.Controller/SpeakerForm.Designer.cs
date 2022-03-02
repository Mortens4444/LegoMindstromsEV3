namespace Mindstorms.Controller
{
    partial class SpeakerForm
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
            this.gbBeep = new System.Windows.Forms.GroupBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbPlayMusic = new System.Windows.Forms.ToolStripButton();
            this.cbMelodies = new System.Windows.Forms.ToolStripComboBox();
            this.cbSounds = new System.Windows.Forms.ToolStripComboBox();
            this.tsbPlaySound = new System.Windows.Forms.ToolStripButton();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnSilence = new System.Windows.Forms.Button();
            this.lblFrequecncy = new System.Windows.Forms.Label();
            this.nudFrequecncy = new System.Windows.Forms.NumericUpDown();
            this.btnBeep = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.pMain.SuspendLayout();
            this.gbBeep.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequecncy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbBeep);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(359, 111);
            this.pMain.TabIndex = 0;
            // 
            // gbBeep
            // 
            this.gbBeep.Controls.Add(this.toolStrip);
            this.gbBeep.Controls.Add(this.tbVolume);
            this.gbBeep.Controls.Add(this.btnSilence);
            this.gbBeep.Controls.Add(this.lblFrequecncy);
            this.gbBeep.Controls.Add(this.nudFrequecncy);
            this.gbBeep.Controls.Add(this.btnBeep);
            this.gbBeep.Controls.Add(this.lblVolume);
            this.gbBeep.Controls.Add(this.lblDuration);
            this.gbBeep.Controls.Add(this.nudDuration);
            this.gbBeep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBeep.Location = new System.Drawing.Point(0, 0);
            this.gbBeep.Name = "gbBeep";
            this.gbBeep.Size = new System.Drawing.Size(359, 111);
            this.gbBeep.TabIndex = 5;
            this.gbBeep.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlayMusic,
            this.cbMelodies,
            this.cbSounds,
            this.tsbPlaySound});
            this.toolStrip.Location = new System.Drawing.Point(3, 83);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(353, 25);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbPlayMusic
            // 
            this.tsbPlayMusic.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbPlayMusic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlayMusic.Image = global::Mindstorms.Controller.Properties.Resources.notes;
            this.tsbPlayMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlayMusic.Name = "tsbPlayMusic";
            this.tsbPlayMusic.Size = new System.Drawing.Size(23, 22);
            this.tsbPlayMusic.Text = "Play melody";
            this.tsbPlayMusic.Click += new System.EventHandler(this.BtnPlayMusic_Click);
            // 
            // cbMelodies
            // 
            this.cbMelodies.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbMelodies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMelodies.Name = "cbMelodies";
            this.cbMelodies.Size = new System.Drawing.Size(121, 25);
            // 
            // cbSounds
            // 
            this.cbSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSounds.Name = "cbSounds";
            this.cbSounds.Size = new System.Drawing.Size(121, 25);
            // 
            // tsbPlaySound
            // 
            this.tsbPlaySound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlaySound.Image = global::Mindstorms.Controller.Properties.Resources.notes;
            this.tsbPlaySound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlaySound.Name = "tsbPlaySound";
            this.tsbPlaySound.Size = new System.Drawing.Size(23, 22);
            this.tsbPlaySound.Text = "Play sound";
            this.tsbPlaySound.Click += new System.EventHandler(this.BtnPlaySound_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(6, 29);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Minimum = 1;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 50);
            this.tbVolume.TabIndex = 7;
            this.tbVolume.Value = 10;
            // 
            // btnSilence
            // 
            this.btnSilence.Image = global::Mindstorms.Controller.Properties.Resources.mute;
            this.btnSilence.Location = new System.Drawing.Point(191, 39);
            this.btnSilence.Name = "btnSilence";
            this.btnSilence.Size = new System.Drawing.Size(23, 23);
            this.btnSilence.TabIndex = 12;
            this.btnSilence.UseVisualStyleBackColor = true;
            this.btnSilence.Click += new System.EventHandler(this.BtnSilence_Click);
            // 
            // lblFrequecncy
            // 
            this.lblFrequecncy.AutoSize = true;
            this.lblFrequecncy.Location = new System.Drawing.Point(61, 47);
            this.lblFrequecncy.Name = "lblFrequecncy";
            this.lblFrequecncy.Size = new System.Drawing.Size(63, 13);
            this.lblFrequecncy.TabIndex = 6;
            this.lblFrequecncy.Text = "Frequecncy";
            // 
            // nudFrequecncy
            // 
            this.nudFrequecncy.Location = new System.Drawing.Point(130, 42);
            this.nudFrequecncy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFrequecncy.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudFrequecncy.Name = "nudFrequecncy";
            this.nudFrequecncy.Size = new System.Drawing.Size(55, 20);
            this.nudFrequecncy.TabIndex = 5;
            this.nudFrequecncy.Value = new decimal(new int[] {
            440,
            0,
            0,
            0});
            // 
            // btnBeep
            // 
            this.btnBeep.Image = global::Mindstorms.Controller.Properties.Resources.volume;
            this.btnBeep.Location = new System.Drawing.Point(191, 14);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(23, 23);
            this.btnBeep.TabIndex = 4;
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.BtnBeep_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(6, 16);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "Volume";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(61, 16);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(69, 13);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration (ms)";
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(130, 14);
            this.nudDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(55, 20);
            this.nudDuration.TabIndex = 2;
            this.nudDuration.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // SpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 111);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpeakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speaker";
            this.pMain.ResumeLayout(false);
            this.gbBeep.ResumeLayout(false);
            this.gbBeep.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequecncy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbBeep;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnSilence;
        private System.Windows.Forms.Label lblFrequecncy;
        private System.Windows.Forms.NumericUpDown nudFrequecncy;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbPlayMusic;
        private System.Windows.Forms.ToolStripComboBox cbMelodies;
        private System.Windows.Forms.ToolStripComboBox cbSounds;
        private System.Windows.Forms.ToolStripButton tsbPlaySound;
    }
}