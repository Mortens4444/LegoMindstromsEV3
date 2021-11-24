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
            this.pMain = new System.Windows.Forms.Panel();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbInverseRectangle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbPixel = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.pDisplay = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetLedsState = new System.Windows.Forms.ToolStripButton();
            this.cbLedPattern = new System.Windows.Forms.ToolStripComboBox();
            this.pMain.SuspendLayout();
            this.gbScreen.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbScreen);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(194, 226);
            this.pMain.TabIndex = 0;
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.toolStrip1);
            this.gbScreen.Controls.Add(this.chkFill);
            this.gbScreen.Controls.Add(this.tbText);
            this.gbScreen.Controls.Add(this.btnUpdate);
            this.gbScreen.Controls.Add(this.rbText);
            this.gbScreen.Controls.Add(this.rbLine);
            this.gbScreen.Controls.Add(this.rbInverseRectangle);
            this.gbScreen.Controls.Add(this.rbRectangle);
            this.gbScreen.Controls.Add(this.rbCircle);
            this.gbScreen.Controls.Add(this.rbPixel);
            this.gbScreen.Controls.Add(this.btnClear);
            this.gbScreen.Controls.Add(this.pDisplay);
            this.gbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbScreen.Location = new System.Drawing.Point(0, 0);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(194, 226);
            this.gbScreen.TabIndex = 0;
            this.gbScreen.TabStop = false;
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(8, 15);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(38, 17);
            this.chkFill.TabIndex = 32;
            this.chkFill.Text = "Fill";
            this.chkFill.UseVisualStyleBackColor = true;
            // 
            // tbText
            // 
            this.tbText.Enabled = false;
            this.tbText.Location = new System.Drawing.Point(108, 174);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(78, 20);
            this.tbText.TabIndex = 31;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // rbText
            // 
            this.rbText.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(78, 172);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(24, 23);
            this.rbText.TabIndex = 29;
            this.rbText.Text = "A";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.RbText_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLine.AutoSize = true;
            this.rbLine.Image = global::Mindstorms.Controller.Properties.Resources.line;
            this.rbLine.Location = new System.Drawing.Point(31, 172);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(22, 22);
            this.rbLine.TabIndex = 28;
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbInverseRectangle
            // 
            this.rbInverseRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInverseRectangle.AutoSize = true;
            this.rbInverseRectangle.Image = global::Mindstorms.Controller.Properties.Resources.inverse_rectangle;
            this.rbInverseRectangle.Location = new System.Drawing.Point(55, 172);
            this.rbInverseRectangle.Name = "rbInverseRectangle";
            this.rbInverseRectangle.Size = new System.Drawing.Size(22, 22);
            this.rbInverseRectangle.TabIndex = 27;
            this.rbInverseRectangle.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Image = global::Mindstorms.Controller.Properties.Resources.rectangle;
            this.rbRectangle.Location = new System.Drawing.Point(71, 11);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(22, 22);
            this.rbRectangle.TabIndex = 26;
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCircle.AutoSize = true;
            this.rbCircle.Image = global::Mindstorms.Controller.Properties.Resources.circle;
            this.rbCircle.Location = new System.Drawing.Point(48, 11);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(22, 22);
            this.rbCircle.TabIndex = 25;
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbPixel
            // 
            this.rbPixel.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPixel.AutoSize = true;
            this.rbPixel.Checked = true;
            this.rbPixel.Image = global::Mindstorms.Controller.Properties.Resources.pixel;
            this.rbPixel.Location = new System.Drawing.Point(8, 172);
            this.rbPixel.Name = "rbPixel";
            this.rbPixel.Size = new System.Drawing.Size(22, 22);
            this.rbPixel.TabIndex = 24;
            this.rbPixel.TabStop = true;
            this.rbPixel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Image = global::Mindstorms.Controller.Properties.Resources.eraser;
            this.btnClear.Location = new System.Drawing.Point(99, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // pDisplay
            // 
            this.pDisplay.BackColor = System.Drawing.Color.CadetBlue;
            this.pDisplay.Location = new System.Drawing.Point(8, 38);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(178, 128);
            this.pDisplay.TabIndex = 22;
            this.pDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            this.pDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Display_MouseDown);
            this.pDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Display_MouseMove);
            this.pDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Display_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetLedsState,
            this.cbLedPattern});
            this.toolStrip1.Location = new System.Drawing.Point(3, 198);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(188, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetLedsState
            // 
            this.btnSetLedsState.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSetLedsState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetLedsState.Image = global::Mindstorms.Controller.Properties.Resources.led;
            this.btnSetLedsState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetLedsState.Name = "btnSetLedsState";
            this.btnSetLedsState.Size = new System.Drawing.Size(23, 22);
            this.btnSetLedsState.Text = "toolStripButton1";
            this.btnSetLedsState.Click += new System.EventHandler(this.BtnSetLedsState_Click);
            // 
            // cbLedPattern
            // 
            this.cbLedPattern.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbLedPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLedPattern.Name = "cbLedPattern";
            this.cbLedPattern.Size = new System.Drawing.Size(121, 25);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 226);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen";
            this.pMain.ResumeLayout(false);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}