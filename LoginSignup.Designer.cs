using Microsoft.VisualBasic.Logging;

namespace Agent_Program
{
    partial class LoginSignup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSignup));
            Leftpanel = new Panel();
            label1 = new Label();
            Logo = new PictureBox();
            Rightpanel = new Panel();
            SignupBtn = new Button();
            LoginSignupBtn = new Button();
            Textpanel3 = new Panel();
            Textbox3 = new TextBox();
            Textpanel2 = new Panel();
            Textbox2 = new TextBox();
            Textpanel1 = new Panel();
            Textbox1 = new TextBox();
            Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            Rightpanel.SuspendLayout();
            Textpanel3.SuspendLayout();
            Textpanel2.SuspendLayout();
            Textpanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Leftpanel
            // 
            Leftpanel.BackColor = Color.FromArgb(54, 54, 54);
            Leftpanel.Controls.Add(label1);
            Leftpanel.Controls.Add(Logo);
            Leftpanel.Location = new Point(0, 0);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Padding = new Padding(10, 160, 10, 150);
            Leftpanel.Size = new Size(330, 450);
            Leftpanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Pretendard SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 216);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(310, 57);
            label1.TabIndex = 3;
            label1.Text = "Hello, I’m imon!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(10, 160);
            Logo.Name = "Logo";
            Logo.Size = new Size(310, 56);
            Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // Rightpanel
            // 
            Rightpanel.BackColor = Color.White;
            Rightpanel.Controls.Add(SignupBtn);
            Rightpanel.Controls.Add(LoginSignupBtn);
            Rightpanel.Controls.Add(Textpanel3);
            Rightpanel.Controls.Add(Textpanel2);
            Rightpanel.Controls.Add(Textpanel1);
            Rightpanel.Location = new Point(330, 0);
            Rightpanel.Name = "Rightpanel";
            Rightpanel.Padding = new Padding(50);
            Rightpanel.Size = new Size(471, 450);
            Rightpanel.TabIndex = 2;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.Transparent;
            SignupBtn.FlatAppearance.BorderSize = 0;
            SignupBtn.FlatStyle = FlatStyle.Flat;
            SignupBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SignupBtn.ForeColor = Color.FromArgb(62, 55, 225);
            SignupBtn.Location = new Point(53, 365);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(75, 25);
            SignupBtn.TabIndex = 4;
            SignupBtn.Text = "회원가입";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // LoginSignupBtn
            // 
            LoginSignupBtn.BackColor = Color.FromArgb(62, 55, 255);
            LoginSignupBtn.FlatStyle = FlatStyle.Flat;
            LoginSignupBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LoginSignupBtn.ForeColor = Color.White;
            LoginSignupBtn.Location = new Point(53, 310);
            LoginSignupBtn.Name = "LoginSignupBtn";
            LoginSignupBtn.Padding = new Padding(5);
            LoginSignupBtn.Size = new Size(100, 40);
            LoginSignupBtn.TabIndex = 3;
            LoginSignupBtn.Text = "로그인";
            LoginSignupBtn.UseVisualStyleBackColor = false;
            LoginSignupBtn.Click += LoginSignupBtn_Click;
            // 
            // Textpanel3
            // 
            Textpanel3.BackColor = Color.FromArgb(223, 223, 223);
            Textpanel3.Controls.Add(Textbox3);
            Textpanel3.Location = new Point(53, 240);
            Textpanel3.Name = "Textpanel3";
            Textpanel3.Padding = new Padding(5, 8, 5, 5);
            Textpanel3.Size = new Size(365, 40);
            Textpanel3.TabIndex = 2;
            // 
            // Textbox3
            // 
            Textbox3.BackColor = Color.FromArgb(223, 223, 223);
            Textbox3.BorderStyle = BorderStyle.None;
            Textbox3.Dock = DockStyle.Fill;
            Textbox3.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Textbox3.Location = new Point(5, 8);
            Textbox3.Name = "Textbox3";
            Textbox3.Size = new Size(355, 23);
            Textbox3.TabIndex = 0;
            Textbox3.Text = "사용자명";
            // 
            // Textpanel2
            // 
            Textpanel2.BackColor = Color.FromArgb(223, 223, 223);
            Textpanel2.Controls.Add(Textbox2);
            Textpanel2.Location = new Point(53, 170);
            Textpanel2.Name = "Textpanel2";
            Textpanel2.Padding = new Padding(5, 8, 5, 5);
            Textpanel2.Size = new Size(365, 40);
            Textpanel2.TabIndex = 2;
            // 
            // Textbox2
            // 
            Textbox2.BackColor = Color.FromArgb(223, 223, 223);
            Textbox2.BorderStyle = BorderStyle.None;
            Textbox2.Dock = DockStyle.Fill;
            Textbox2.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Textbox2.Location = new Point(5, 8);
            Textbox2.Name = "Textbox2";
            Textbox2.Size = new Size(355, 23);
            Textbox2.TabIndex = 0;
            Textbox2.Text = "IP";
            // 
            // Textpanel1
            // 
            Textpanel1.BackColor = Color.FromArgb(223, 223, 223);
            Textpanel1.Controls.Add(Textbox1);
            Textpanel1.Location = new Point(53, 100);
            Textpanel1.Name = "Textpanel1";
            Textpanel1.Padding = new Padding(5, 8, 5, 5);
            Textpanel1.Size = new Size(365, 40);
            Textpanel1.TabIndex = 1;
            // 
            // Textbox1
            // 
            Textbox1.BackColor = Color.FromArgb(223, 223, 223);
            Textbox1.BorderStyle = BorderStyle.None;
            Textbox1.Dock = DockStyle.Fill;
            Textbox1.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Textbox1.Location = new Point(5, 8);
            Textbox1.Name = "Textbox1";
            Textbox1.Size = new Size(355, 23);
            Textbox1.TabIndex = 0;
            Textbox1.Text = "hostname";
            // 
            // LoginSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Rightpanel);
            Controls.Add(Leftpanel);
            Name = "LoginSignup";
            Text = "LoginSignup";
            Load += LoginSignup_Load;
            Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            Rightpanel.ResumeLayout(false);
            Textpanel3.ResumeLayout(false);
            Textpanel3.PerformLayout();
            Textpanel2.ResumeLayout(false);
            Textpanel2.PerformLayout();
            Textpanel1.ResumeLayout(false);
            Textpanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Leftpanel;
        private PictureBox Logo;
        private Label label1;
        private Panel Rightpanel;
        private Panel Textpanel1;
        private TextBox Textbox1;
        private Button LoginSignupBtn;
        private Panel Textpanel3;
        private TextBox Textbox3;
        private Panel Textpanel2;
        private TextBox Textbox2;
        private Button SignupBtn;
    }
}
