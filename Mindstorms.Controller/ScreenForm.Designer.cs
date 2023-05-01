namespace Mindstorms.Controller
{
    partial class ScreenForm
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
            gbScreen = new GroupBox();
            btnShow = new Button();
            cbEmbeddedImages = new ComboBox();
            toolStrip1 = new ToolStrip();
            btnSetLedsState = new ToolStripButton();
            cbLedPattern = new ToolStripComboBox();
            chkFill = new CheckBox();
            tbText = new TextBox();
            btnUpdate = new Button();
            rbText = new RadioButton();
            rbLine = new RadioButton();
            rbInverseRectangle = new RadioButton();
            rbRectangle = new RadioButton();
            rbCircle = new RadioButton();
            rbPixel = new RadioButton();
            btnClear = new Button();
            pDisplay = new Panel();
            pMain.SuspendLayout();
            gbScreen.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(gbScreen);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(226, 294);
            pMain.TabIndex = 0;
            // 
            // gbScreen
            // 
            gbScreen.Controls.Add(btnShow);
            gbScreen.Controls.Add(cbEmbeddedImages);
            gbScreen.Controls.Add(toolStrip1);
            gbScreen.Controls.Add(chkFill);
            gbScreen.Controls.Add(tbText);
            gbScreen.Controls.Add(btnUpdate);
            gbScreen.Controls.Add(rbText);
            gbScreen.Controls.Add(rbLine);
            gbScreen.Controls.Add(rbInverseRectangle);
            gbScreen.Controls.Add(rbRectangle);
            gbScreen.Controls.Add(rbCircle);
            gbScreen.Controls.Add(rbPixel);
            gbScreen.Controls.Add(btnClear);
            gbScreen.Controls.Add(pDisplay);
            gbScreen.Dock = DockStyle.Fill;
            gbScreen.Location = new Point(0, 0);
            gbScreen.Margin = new Padding(4, 3, 4, 3);
            gbScreen.Name = "gbScreen";
            gbScreen.Padding = new Padding(4, 3, 4, 3);
            gbScreen.Size = new Size(226, 294);
            gbScreen.TabIndex = 0;
            gbScreen.TabStop = false;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(155, 232);
            btnShow.Margin = new Padding(4, 3, 4, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(68, 27);
            btnShow.TabIndex = 35;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += BtnShow_Click;
            // 
            // cbEmbeddedImages
            // 
            cbEmbeddedImages.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmbeddedImages.FormattingEnabled = true;
            cbEmbeddedImages.Location = new Point(7, 234);
            cbEmbeddedImages.Margin = new Padding(4, 3, 4, 3);
            cbEmbeddedImages.Name = "cbEmbeddedImages";
            cbEmbeddedImages.Size = new Size(140, 23);
            cbEmbeddedImages.TabIndex = 34;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSetLedsState, cbLedPattern });
            toolStrip1.Location = new Point(4, 266);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(218, 25);
            toolStrip1.TabIndex = 33;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSetLedsState
            // 
            btnSetLedsState.Alignment = ToolStripItemAlignment.Right;
            btnSetLedsState.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSetLedsState.Image = Properties.Resources.led;
            btnSetLedsState.ImageTransparentColor = Color.Magenta;
            btnSetLedsState.Name = "btnSetLedsState";
            btnSetLedsState.Size = new Size(23, 22);
            btnSetLedsState.Text = "Change LEDs state";
            btnSetLedsState.Click += BtnSetLedsState_Click;
            // 
            // cbLedPattern
            // 
            cbLedPattern.Alignment = ToolStripItemAlignment.Right;
            cbLedPattern.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLedPattern.Name = "cbLedPattern";
            cbLedPattern.Size = new Size(140, 25);
            // 
            // chkFill
            // 
            chkFill.AutoSize = true;
            chkFill.Location = new Point(9, 17);
            chkFill.Margin = new Padding(4, 3, 4, 3);
            chkFill.Name = "chkFill";
            chkFill.Size = new Size(41, 19);
            chkFill.TabIndex = 32;
            chkFill.Text = "Fill";
            chkFill.UseVisualStyleBackColor = true;
            // 
            // tbText
            // 
            tbText.Enabled = false;
            tbText.Location = new Point(126, 201);
            tbText.Margin = new Padding(4, 3, 4, 3);
            tbText.Name = "tbText";
            tbText.Size = new Size(90, 23);
            tbText.TabIndex = 31;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(149, 13);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(68, 27);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // rbText
            // 
            rbText.Appearance = Appearance.Button;
            rbText.AutoSize = true;
            rbText.Location = new Point(91, 198);
            rbText.Margin = new Padding(4, 3, 4, 3);
            rbText.Name = "rbText";
            rbText.Size = new Size(25, 25);
            rbText.TabIndex = 29;
            rbText.Text = "A";
            rbText.UseVisualStyleBackColor = true;
            rbText.CheckedChanged += RbText_CheckedChanged;
            // 
            // rbLine
            // 
            rbLine.Appearance = Appearance.Button;
            rbLine.AutoSize = true;
            rbLine.Image = Properties.Resources.line;
            rbLine.Location = new Point(36, 198);
            rbLine.Margin = new Padding(4, 3, 4, 3);
            rbLine.Name = "rbLine";
            rbLine.Size = new Size(22, 22);
            rbLine.TabIndex = 28;
            rbLine.UseVisualStyleBackColor = true;
            // 
            // rbInverseRectangle
            // 
            rbInverseRectangle.Appearance = Appearance.Button;
            rbInverseRectangle.AutoSize = true;
            rbInverseRectangle.Image = Properties.Resources.inverse_rectangle;
            rbInverseRectangle.Location = new Point(64, 198);
            rbInverseRectangle.Margin = new Padding(4, 3, 4, 3);
            rbInverseRectangle.Name = "rbInverseRectangle";
            rbInverseRectangle.Size = new Size(22, 22);
            rbInverseRectangle.TabIndex = 27;
            rbInverseRectangle.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            rbRectangle.Appearance = Appearance.Button;
            rbRectangle.AutoSize = true;
            rbRectangle.Image = Properties.Resources.rectangle;
            rbRectangle.Location = new Point(83, 13);
            rbRectangle.Margin = new Padding(4, 3, 4, 3);
            rbRectangle.Name = "rbRectangle";
            rbRectangle.Size = new Size(22, 22);
            rbRectangle.TabIndex = 26;
            rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            rbCircle.Appearance = Appearance.Button;
            rbCircle.AutoSize = true;
            rbCircle.Image = Properties.Resources.circle;
            rbCircle.Location = new Point(56, 13);
            rbCircle.Margin = new Padding(4, 3, 4, 3);
            rbCircle.Name = "rbCircle";
            rbCircle.Size = new Size(22, 22);
            rbCircle.TabIndex = 25;
            rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbPixel
            // 
            rbPixel.Appearance = Appearance.Button;
            rbPixel.AutoSize = true;
            rbPixel.Checked = true;
            rbPixel.Image = Properties.Resources.pixel;
            rbPixel.Location = new Point(9, 198);
            rbPixel.Margin = new Padding(4, 3, 4, 3);
            rbPixel.Name = "rbPixel";
            rbPixel.Size = new Size(22, 22);
            rbPixel.TabIndex = 24;
            rbPixel.TabStop = true;
            rbPixel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Image = Properties.Resources.eraser;
            btnClear.Location = new Point(115, 13);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(27, 27);
            btnClear.TabIndex = 23;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // pDisplay
            // 
            pDisplay.BackColor = Color.CadetBlue;
            pDisplay.Location = new Point(9, 44);
            pDisplay.Margin = new Padding(4, 3, 4, 3);
            pDisplay.Name = "pDisplay";
            pDisplay.Size = new Size(208, 148);
            pDisplay.TabIndex = 22;
            pDisplay.Paint += Display_Paint;
            pDisplay.MouseDown += Display_MouseDown;
            pDisplay.MouseMove += Display_MouseMove;
            pDisplay.MouseUp += Display_MouseUp;
            // 
            // ScreenForm
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 294);
            Controls.Add(pMain);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen";
            pMain.ResumeLayout(false);
            gbScreen.ResumeLayout(false);
            gbScreen.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbInverseRectangle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbPixel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pDisplay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSetLedsState;
        private System.Windows.Forms.ToolStripComboBox cbLedPattern;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbEmbeddedImages;
    }
}