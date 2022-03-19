namespace Mindstorms.Controller
{
    partial class FileReaderForm
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
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
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
            this.pMain.Size = new System.Drawing.Size(800, 450);
            this.pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.rtbFileContent);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(800, 450);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFileContent.Location = new System.Drawing.Point(3, 16);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.ReadOnly = true;
            this.rtbFileContent.Size = new System.Drawing.Size(794, 431);
            this.rtbFileContent.TabIndex = 0;
            this.rtbFileContent.Text = "";
            this.rtbFileContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileReaderForm_KeyDown);
            // 
            // FileReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMain);
            this.Name = "FileReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View file content";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileReaderForm_KeyDown);
            this.pMain.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.RichTextBox rtbFileContent;
    }
}