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
            pMain = new Panel();
            gbBeep = new GroupBox();
            lblPlayType = new Label();
            cbPlayType = new ComboBox();
            toolStrip = new ToolStrip();
            tsbPlayMusic = new ToolStripButton();
            cbMelodies = new ToolStripComboBox();
            cbSounds = new ToolStripComboBox();
            tsbPlaySound = new ToolStripButton();
            tbVolume = new TrackBar();
            btnSilence = new Button();
            lblFrequecncy = new Label();
            nudFrequecncy = new NumericUpDown();
            btnBeep = new Button();
            lblVolume = new Label();
            lblDuration = new Label();
            nudDuration = new NumericUpDown();
            pMain.SuspendLayout();
            gbBeep.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFrequecncy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(gbBeep);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(434, 128);
            pMain.TabIndex = 0;
            // 
            // gbBeep
            // 
            gbBeep.Controls.Add(lblPlayType);
            gbBeep.Controls.Add(cbPlayType);
            gbBeep.Controls.Add(toolStrip);
            gbBeep.Controls.Add(tbVolume);
            gbBeep.Controls.Add(btnSilence);
            gbBeep.Controls.Add(lblFrequecncy);
            gbBeep.Controls.Add(nudFrequecncy);
            gbBeep.Controls.Add(btnBeep);
            gbBeep.Controls.Add(lblVolume);
            gbBeep.Controls.Add(lblDuration);
            gbBeep.Controls.Add(nudDuration);
            gbBeep.Dock = DockStyle.Fill;
            gbBeep.Location = new Point(0, 0);
            gbBeep.Margin = new Padding(4, 3, 4, 3);
            gbBeep.Name = "gbBeep";
            gbBeep.Padding = new Padding(4, 3, 4, 3);
            gbBeep.Size = new Size(434, 128);
            gbBeep.TabIndex = 5;
            gbBeep.TabStop = false;
            // 
            // lblPlayType
            // 
            lblPlayType.AutoSize = true;
            lblPlayType.Location = new Point(275, 22);
            lblPlayType.Margin = new Padding(4, 0, 4, 0);
            lblPlayType.Name = "lblPlayType";
            lblPlayType.Size = new Size(55, 15);
            lblPlayType.TabIndex = 15;
            lblPlayType.Text = "Play type";
            // 
            // cbPlayType
            // 
            cbPlayType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlayType.FormattingEnabled = true;
            cbPlayType.Location = new Point(275, 47);
            cbPlayType.Margin = new Padding(4, 3, 4, 3);
            cbPlayType.Name = "cbPlayType";
            cbPlayType.Size = new Size(148, 23);
            cbPlayType.TabIndex = 14;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbPlayMusic, cbMelodies, cbSounds, tsbPlaySound });
            toolStrip.Location = new Point(4, 100);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(426, 25);
            toolStrip.TabIndex = 13;
            toolStrip.Text = "toolStrip1";
            // 
            // tsbPlayMusic
            // 
            tsbPlayMusic.Alignment = ToolStripItemAlignment.Right;
            tsbPlayMusic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPlayMusic.Image = Properties.Resources.notes;
            tsbPlayMusic.ImageTransparentColor = Color.Magenta;
            tsbPlayMusic.Name = "tsbPlayMusic";
            tsbPlayMusic.Size = new Size(23, 22);
            tsbPlayMusic.Text = "Play melody";
            tsbPlayMusic.Click += BtnPlayMusic_Click;
            // 
            // cbMelodies
            // 
            cbMelodies.Alignment = ToolStripItemAlignment.Right;
            cbMelodies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMelodies.Name = "cbMelodies";
            cbMelodies.Size = new Size(140, 25);
            // 
            // cbSounds
            // 
            cbSounds.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSounds.Name = "cbSounds";
            cbSounds.Size = new Size(140, 25);
            // 
            // tsbPlaySound
            // 
            tsbPlaySound.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPlaySound.Image = Properties.Resources.notes;
            tsbPlaySound.ImageTransparentColor = Color.Magenta;
            tsbPlaySound.Name = "tsbPlaySound";
            tsbPlaySound.Size = new Size(23, 22);
            tsbPlaySound.Text = "Play sound";
            tsbPlaySound.Click += BtnPlaySound_Click;
            // 
            // tbVolume
            // 
            tbVolume.Location = new Point(7, 33);
            tbVolume.Margin = new Padding(4, 3, 4, 3);
            tbVolume.Maximum = 100;
            tbVolume.Minimum = 1;
            tbVolume.Name = "tbVolume";
            tbVolume.Orientation = Orientation.Vertical;
            tbVolume.Size = new Size(45, 58);
            tbVolume.TabIndex = 7;
            tbVolume.Value = 10;
            // 
            // btnSilence
            // 
            btnSilence.Image = Properties.Resources.mute;
            btnSilence.Location = new Point(241, 45);
            btnSilence.Margin = new Padding(4, 3, 4, 3);
            btnSilence.Name = "btnSilence";
            btnSilence.Size = new Size(27, 27);
            btnSilence.TabIndex = 12;
            btnSilence.UseVisualStyleBackColor = true;
            btnSilence.Click += BtnSilence_Click;
            // 
            // lblFrequecncy
            // 
            lblFrequecncy.AutoSize = true;
            lblFrequecncy.Location = new Point(90, 54);
            lblFrequecncy.Margin = new Padding(4, 0, 4, 0);
            lblFrequecncy.Name = "lblFrequecncy";
            lblFrequecncy.Size = new Size(68, 15);
            lblFrequecncy.TabIndex = 6;
            lblFrequecncy.Text = "Frequecncy";
            // 
            // nudFrequecncy
            // 
            nudFrequecncy.Location = new Point(170, 48);
            nudFrequecncy.Margin = new Padding(4, 3, 4, 3);
            nudFrequecncy.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudFrequecncy.Minimum = new decimal(new int[] { 250, 0, 0, 0 });
            nudFrequecncy.Name = "nudFrequecncy";
            nudFrequecncy.Size = new Size(64, 23);
            nudFrequecncy.TabIndex = 5;
            nudFrequecncy.Value = new decimal(new int[] { 440, 0, 0, 0 });
            // 
            // btnBeep
            // 
            btnBeep.Image = Properties.Resources.volume;
            btnBeep.Location = new Point(241, 16);
            btnBeep.Margin = new Padding(4, 3, 4, 3);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new Size(27, 27);
            btnBeep.TabIndex = 4;
            btnBeep.UseVisualStyleBackColor = true;
            btnBeep.Click += BtnBeep_Click;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(7, 18);
            lblVolume.Margin = new Padding(4, 0, 4, 0);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(47, 15);
            lblVolume.TabIndex = 1;
            lblVolume.Text = "Volume";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(90, 18);
            lblDuration.Margin = new Padding(4, 0, 4, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(80, 15);
            lblDuration.TabIndex = 3;
            lblDuration.Text = "Duration (ms)";
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(170, 16);
            nudDuration.Margin = new Padding(4, 3, 4, 3);
            nudDuration.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(64, 23);
            nudDuration.TabIndex = 2;
            nudDuration.Value = new decimal(new int[] { 400, 0, 0, 0 });
            // 
            // SpeakerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 128);
            Controls.Add(pMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SpeakerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Speaker";
            pMain.ResumeLayout(false);
            gbBeep.ResumeLayout(false);
            gbBeep.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFrequecncy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPlayType;
        private System.Windows.Forms.ComboBox cbPlayType;
    }
}