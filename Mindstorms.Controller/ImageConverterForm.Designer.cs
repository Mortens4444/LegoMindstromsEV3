namespace Mindstorms.Controller
{
    partial class ImageConverterForm
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
            btnSaveRgf = new Button();
            tbContrast = new TrackBar();
            lblContrast = new Label();
            pbImage = new PictureBox();
            lblHint = new Label();
            btnBrowse = new Button();
            lblFilePathToConvert = new Label();
            tbFilePathToConvert = new TextBox();
            openFileDialog = new OpenFileDialog();
            pMain.SuspendLayout();
            gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.Controls.Add(gbMain);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(0, 0);
            pMain.Margin = new Padding(4, 3, 4, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(622, 208);
            pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            gbMain.Controls.Add(btnSaveRgf);
            gbMain.Controls.Add(tbContrast);
            gbMain.Controls.Add(lblContrast);
            gbMain.Controls.Add(pbImage);
            gbMain.Controls.Add(lblHint);
            gbMain.Controls.Add(btnBrowse);
            gbMain.Controls.Add(lblFilePathToConvert);
            gbMain.Controls.Add(tbFilePathToConvert);
            gbMain.Dock = DockStyle.Fill;
            gbMain.Location = new Point(0, 0);
            gbMain.Margin = new Padding(4, 3, 4, 3);
            gbMain.MinimumSize = new Size(626, 208);
            gbMain.Name = "gbMain";
            gbMain.Padding = new Padding(4, 3, 4, 3);
            gbMain.Size = new Size(626, 208);
            gbMain.TabIndex = 0;
            gbMain.TabStop = false;
            // 
            // btnSaveRgf
            // 
            btnSaveRgf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveRgf.Enabled = false;
            btnSaveRgf.Location = new Point(531, 72);
            btnSaveRgf.Margin = new Padding(4, 3, 4, 3);
            btnSaveRgf.Name = "btnSaveRgf";
            btnSaveRgf.Size = new Size(88, 27);
            btnSaveRgf.TabIndex = 8;
            btnSaveRgf.Text = "Save RGF";
            btnSaveRgf.UseVisualStyleBackColor = true;
            btnSaveRgf.Click += BtnSaveRgf_Click;
            // 
            // tbContrast
            // 
            tbContrast.Location = new Point(18, 89);
            tbContrast.Margin = new Padding(4, 3, 4, 3);
            tbContrast.Maximum = 255;
            tbContrast.Minimum = 1;
            tbContrast.Name = "tbContrast";
            tbContrast.Size = new Size(121, 45);
            tbContrast.TabIndex = 7;
            tbContrast.Value = 128;
            tbContrast.ValueChanged += TbContrast_ValueChanged;
            // 
            // lblContrast
            // 
            lblContrast.AutoSize = true;
            lblContrast.Location = new Point(14, 70);
            lblContrast.Margin = new Padding(4, 0, 4, 0);
            lblContrast.Name = "lblContrast";
            lblContrast.Size = new Size(52, 15);
            lblContrast.TabIndex = 6;
            lblContrast.Text = "Contrast";
            // 
            // pbImage
            // 
            pbImage.Anchor = AnchorStyles.Top;
            pbImage.BackColor = Color.CadetBlue;
            pbImage.Location = new Point(189, 70);
            pbImage.Margin = new Padding(4, 3, 4, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(208, 128);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 5;
            pbImage.TabStop = false;
            // 
            // lblHint
            // 
            lblHint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHint.AutoSize = true;
            lblHint.Location = new Point(229, 22);
            lblHint.Margin = new Padding(4, 0, 4, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(279, 15);
            lblHint.TabIndex = 4;
            lblHint.Text = "Hint: It is best if you use images with 178x128 pixels.";
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(531, 38);
            btnBrowse.Margin = new Padding(4, 3, 4, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(88, 27);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // lblFilePathToConvert
            // 
            lblFilePathToConvert.AutoSize = true;
            lblFilePathToConvert.Location = new Point(7, 22);
            lblFilePathToConvert.Margin = new Padding(4, 0, 4, 0);
            lblFilePathToConvert.Name = "lblFilePathToConvert";
            lblFilePathToConvert.Size = new Size(109, 15);
            lblFilePathToConvert.TabIndex = 1;
            lblFilePathToConvert.Text = "File path to convert";
            // 
            // tbFilePathToConvert
            // 
            tbFilePathToConvert.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilePathToConvert.Location = new Point(10, 40);
            tbFilePathToConvert.Margin = new Padding(4, 3, 4, 3);
            tbFilePathToConvert.Name = "tbFilePathToConvert";
            tbFilePathToConvert.Size = new Size(513, 23);
            tbFilePathToConvert.TabIndex = 0;
            // 
            // ImageConverterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 208);
            Controls.Add(pMain);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ImageConverterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image converter";
            pMain.ResumeLayout(false);
            gbMain.ResumeLayout(false);
            gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbContrast).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFilePathToConvert;
        private System.Windows.Forms.TextBox tbFilePathToConvert;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Button btnSaveRgf;
    }
}