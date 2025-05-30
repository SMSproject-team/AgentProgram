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
            comboBox1 = new ComboBox();
            SignupBtn = new Button();
            LoginSignupBtn = new Button();
            Textpanel2 = new Panel();
            Textbox2 = new TextBox();
            Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            Rightpanel.SuspendLayout();
            Textpanel2.SuspendLayout();
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
            Rightpanel.Controls.Add(comboBox1);
            Rightpanel.Controls.Add(SignupBtn);
            Rightpanel.Controls.Add(LoginSignupBtn);
            Rightpanel.Controls.Add(Textpanel2);
            Rightpanel.Location = new Point(330, 0);
            Rightpanel.Name = "Rightpanel";
            Rightpanel.Padding = new Padding(50);
            Rightpanel.Size = new Size(471, 450);
            Rightpanel.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(223, 223, 223);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 31);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "부서명";
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.Transparent;
            SignupBtn.FlatAppearance.BorderSize = 0;
            SignupBtn.FlatStyle = FlatStyle.Flat;
            SignupBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SignupBtn.ForeColor = Color.FromArgb(103, 173, 178);
            SignupBtn.Location = new Point(53, 321);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(75, 25);
            SignupBtn.TabIndex = 4;
            SignupBtn.Text = "등록";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // LoginSignupBtn
            // 
            LoginSignupBtn.BackColor = Color.FromArgb(137, 220, 226);
            LoginSignupBtn.FlatAppearance.BorderSize = 0;
            LoginSignupBtn.FlatStyle = FlatStyle.Flat;
            LoginSignupBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LoginSignupBtn.ForeColor = Color.Black;
            LoginSignupBtn.Location = new Point(53, 271);
            LoginSignupBtn.Name = "LoginSignupBtn";
            LoginSignupBtn.Padding = new Padding(5);
            LoginSignupBtn.Size = new Size(100, 35);
            LoginSignupBtn.TabIndex = 3;
            LoginSignupBtn.Text = "로그인";
            LoginSignupBtn.UseVisualStyleBackColor = false;
            LoginSignupBtn.Click += LoginSignupBtn_Click;
            // 
            // Textpanel2
            // 
            Textpanel2.BackColor = Color.FromArgb(223, 223, 223);
            Textpanel2.Controls.Add(Textbox2);
            Textpanel2.Location = new Point(53, 200);
            Textpanel2.Name = "Textpanel2";
            Textpanel2.Size = new Size(365, 31);
            Textpanel2.TabIndex = 2;
            // 
            // Textbox2
            // 
            Textbox2.BackColor = Color.FromArgb(223, 223, 223);
            Textbox2.BorderStyle = BorderStyle.None;
            Textbox2.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Textbox2.Location = new Point(3, 3);
            Textbox2.Name = "Textbox2";
            Textbox2.Size = new Size(357, 23);
            Textbox2.TabIndex = 0;
            Textbox2.Text = "사용자명";
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
            Textpanel2.ResumeLayout(false);
            Textpanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Leftpanel;
        private PictureBox Logo;
        private Label label1;
        private Panel Rightpanel;
        private Button LoginSignupBtn;
        private Panel Textpanel2;
        private TextBox Textbox2;
        private Button SignupBtn;
        private ComboBox comboBox1;
    }
}
