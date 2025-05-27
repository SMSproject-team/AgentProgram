namespace Agent_Program
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Header = new Panel();
            LogoutBtn = new Button();
            Logo = new PictureBox();
            MenuPanel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ContentPanel = new Panel();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(54, 54, 54);
            Header.Controls.Add(LogoutBtn);
            Header.Controls.Add(Logo);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(805, 70);
            Header.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(713, 12);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 50);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "로그아웃";
            LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(148, 50);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.White;
            MenuPanel.Controls.Add(panel1);
            MenuPanel.Location = new Point(0, 76);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Padding = new Padding(50);
            MenuPanel.Size = new Size(175, 373);
            MenuPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(148, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Pretendard Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(54, 5);
            label1.Name = "label1";
            label1.Size = new Size(89, 50);
            label1.TabIndex = 1;
            label1.Text = "Check";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.White;
            ContentPanel.Location = new Point(180, 76);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(624, 373);
            ContentPanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Header);
            Controls.Add(ContentPanel);
            Controls.Add(MenuPanel);
            Name = "Main";
            Text = "Main";
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox Logo;
        private Button LogoutBtn;
        private Panel MenuPanel;
        private Panel ContentPanel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}