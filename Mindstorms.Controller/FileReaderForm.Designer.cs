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
            pMain = new Panel();
            gbMain = new GroupBox();
            rtbFileContent = new RichTextBox();
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
            pMain.Size = new Size(933, 519);
            pMain.TabIndex = 0;
            // 
            // gbMain
            // 
            gbMain.Controls.Add(rtbFileContent);
            gbMain.Dock = DockStyle.Fill;
            gbMain.Location = new Point(0, 0);
            gbMain.Margin = new Padding(4, 3, 4, 3);
            gbMain.Name = "gbMain";
            gbMain.Padding = new Padding(4, 3, 4, 3);
            gbMain.Size = new Size(933, 519);
            gbMain.TabIndex = 0;
            gbMain.TabStop = false;
            // 
            // rtbFileContent
            // 
            rtbFileContent.Dock = DockStyle.Fill;
            rtbFileContent.Location = new Point(4, 19);
            rtbFileContent.Margin = new Padding(4, 3, 4, 3);
            rtbFileContent.Name = "rtbFileContent";
            rtbFileContent.ReadOnly = true;
            rtbFileContent.Size = new Size(925, 497);
            rtbFileContent.TabIndex = 0;
            rtbFileContent.Text = "";
            rtbFileContent.KeyDown += FileReaderForm_KeyDown;
            // 
            // FileReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FileReaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File viewer";
            KeyDown += FileReaderForm_KeyDown;
            pMain.ResumeLayout(false);
            gbMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.RichTextBox rtbFileContent;
    }
}