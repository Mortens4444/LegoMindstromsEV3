namespace Mindstorms.Controller
{
    partial class ImageConverter
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
            this.btnSaveRgf = new System.Windows.Forms.Button();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.lblContrast = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFilePathToConvert = new System.Windows.Forms.Label();
            this.tbFilePathToConvert = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pMain.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.gbMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(533, 180);
            this.pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnSaveRgf);
            this.gbMain.Controls.Add(this.tbContrast);
            this.gbMain.Controls.Add(this.lblContrast);
            this.gbMain.Controls.Add(this.pbImage);
            this.gbMain.Controls.Add(this.lblHint);
            this.gbMain.Controls.Add(this.btnBrowse);
            this.gbMain.Controls.Add(this.lblFilePathToConvert);
            this.gbMain.Controls.Add(this.tbFilePathToConvert);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.MinimumSize = new System.Drawing.Size(537, 180);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(537, 180);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // btnSaveRgf
            // 
            this.btnSaveRgf.Enabled = false;
            this.btnSaveRgf.Location = new System.Drawing.Point(455, 62);
            this.btnSaveRgf.Name = "btnSaveRgf";
            this.btnSaveRgf.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRgf.TabIndex = 8;
            this.btnSaveRgf.Text = "Save RGF";
            this.btnSaveRgf.UseVisualStyleBackColor = true;
            this.btnSaveRgf.Click += new System.EventHandler(this.BtnSaveRgf_Click);
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(15, 77);
            this.tbContrast.Maximum = 255;
            this.tbContrast.Minimum = 1;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(104, 45);
            this.tbContrast.TabIndex = 7;
            this.tbContrast.Value = 128;
            this.tbContrast.ValueChanged += new System.EventHandler(this.TbContrast_ValueChanged);
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Location = new System.Drawing.Point(12, 61);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(46, 13);
            this.lblContrast.TabIndex = 6;
            this.lblContrast.Text = "Contrast";
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImage.BackColor = System.Drawing.Color.CadetBlue;
            this.pbImage.Location = new System.Drawing.Point(162, 61);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(178, 111);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(196, 19);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(253, 13);
            this.lblHint.TabIndex = 4;
            this.lblHint.Text = "Hint: It is best if you use images with 178x128 pixels.";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(455, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblFilePathToConvert
            // 
            this.lblFilePathToConvert.AutoSize = true;
            this.lblFilePathToConvert.Location = new System.Drawing.Point(6, 19);
            this.lblFilePathToConvert.Name = "lblFilePathToConvert";
            this.lblFilePathToConvert.Size = new System.Drawing.Size(98, 13);
            this.lblFilePathToConvert.TabIndex = 1;
            this.lblFilePathToConvert.Text = "File path to convert";
            // 
            // tbFilePathToConvert
            // 
            this.tbFilePathToConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePathToConvert.Location = new System.Drawing.Point(9, 35);
            this.tbFilePathToConvert.Name = "tbFilePathToConvert";
            this.tbFilePathToConvert.Size = new System.Drawing.Size(440, 20);
            this.tbFilePathToConvert.TabIndex = 0;
            // 
            // ImageConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 180);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImageConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image converter";
            this.pMain.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

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