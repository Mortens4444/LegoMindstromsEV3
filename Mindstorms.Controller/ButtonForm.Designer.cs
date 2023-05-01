namespace Mindstorms.Controller
{
    partial class ButtonForm
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
            gbButtonStates = new GroupBox();
            lblButtonStates = new Label();
            btnDown = new Button();
            btnRight = new Button();
            btnCenter = new Button();
            btnLeft = new Button();
            btnUp = new Button();
            btnBack = new Button();
            gbButtonStates.SuspendLayout();
            SuspendLayout();
            // 
            // gbButtonStates
            // 
            gbButtonStates.Controls.Add(lblButtonStates);
            gbButtonStates.Controls.Add(btnDown);
            gbButtonStates.Controls.Add(btnRight);
            gbButtonStates.Controls.Add(btnCenter);
            gbButtonStates.Controls.Add(btnLeft);
            gbButtonStates.Controls.Add(btnUp);
            gbButtonStates.Controls.Add(btnBack);
            gbButtonStates.Dock = DockStyle.Fill;
            gbButtonStates.Location = new Point(0, 0);
            gbButtonStates.Margin = new Padding(4, 3, 4, 3);
            gbButtonStates.Name = "gbButtonStates";
            gbButtonStates.Padding = new Padding(4, 3, 4, 3);
            gbButtonStates.Size = new Size(210, 168);
            gbButtonStates.TabIndex = 6;
            gbButtonStates.TabStop = false;
            // 
            // lblButtonStates
            // 
            lblButtonStates.AutoSize = true;
            lblButtonStates.Location = new Point(7, 143);
            lblButtonStates.Margin = new Padding(4, 0, 4, 0);
            lblButtonStates.Name = "lblButtonStates";
            lblButtonStates.Size = new Size(0, 15);
            lblButtonStates.TabIndex = 12;
            // 
            // btnDown
            // 
            btnDown.BackColor = Color.WhiteSmoke;
            btnDown.Location = new Point(89, 118);
            btnDown.Margin = new Padding(4, 3, 4, 3);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(27, 27);
            btnDown.TabIndex = 3;
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += Btn_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.WhiteSmoke;
            btnRight.Location = new Point(122, 84);
            btnRight.Margin = new Padding(4, 3, 4, 3);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(27, 27);
            btnRight.TabIndex = 4;
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += Btn_Click;
            // 
            // btnCenter
            // 
            btnCenter.BackColor = Color.WhiteSmoke;
            btnCenter.Location = new Point(89, 84);
            btnCenter.Margin = new Padding(4, 3, 4, 3);
            btnCenter.Name = "btnCenter";
            btnCenter.Size = new Size(27, 27);
            btnCenter.TabIndex = 2;
            btnCenter.UseVisualStyleBackColor = false;
            btnCenter.Click += Btn_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.WhiteSmoke;
            btnLeft.Location = new Point(55, 84);
            btnLeft.Margin = new Padding(4, 3, 4, 3);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(27, 27);
            btnLeft.TabIndex = 5;
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += Btn_Click;
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.WhiteSmoke;
            btnUp.Location = new Point(89, 51);
            btnUp.Margin = new Padding(4, 3, 4, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(27, 27);
            btnUp.TabIndex = 1;
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += Btn_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.Location = new Point(19, 18);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(27, 27);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += Btn_Click;
            btnBack.MouseDown += Btn_MouseDown;
            btnBack.MouseUp += Btn_MouseUp;
            // 
            // ButtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 168);
            Controls.Add(gbButtonStates);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ButtonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buttons";
            Shown += ButtonForm_Shown;
            gbButtonStates.ResumeLayout(false);
            gbButtonStates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbButtonStates;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblButtonStates;
    }
}