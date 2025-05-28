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
            CheckBtn = new Button();
            LogoutBtn = new Button();
            Logo = new PictureBox();
            MenuPanel = new Panel();
            InforBtn = new Button();
            TakecheckBtn = new Button();
            TakeoutBtn = new Button();
            Username = new Label();
            TakeoutPanel = new Panel();
            RequestBtn = new Button();
            ReasonText = new TextBox();
            GetBtn = new Button();
            Getpanel = new Panel();
            Gettextbox = new TextBox();
            InforPanel = new Panel();
            Exceptionfile = new Label();
            Secretfile = new Label();
            Exceptiontitle = new Label();
            Secrettitle = new Label();
            StartPanel = new Panel();
            StartTakecheck = new Button();
            StartInfor = new Button();
            StartTakeout = new Button();
            TakecheckPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuPanel.SuspendLayout();
            TakeoutPanel.SuspendLayout();
            Getpanel.SuspendLayout();
            InforPanel.SuspendLayout();
            StartPanel.SuspendLayout();
            TakecheckPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(54, 54, 54);
            Header.Controls.Add(CheckBtn);
            Header.Controls.Add(LogoutBtn);
            Header.Controls.Add(Logo);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(805, 70);
            Header.TabIndex = 0;
            // 
            // CheckBtn
            // 
            CheckBtn.BackColor = Color.Transparent;
            CheckBtn.FlatAppearance.BorderSize = 0;
            CheckBtn.FlatStyle = FlatStyle.Flat;
            CheckBtn.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CheckBtn.ForeColor = Color.White;
            CheckBtn.Location = new Point(632, 21);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new Size(75, 30);
            CheckBtn.TabIndex = 2;
            CheckBtn.Text = "체크 요청";
            CheckBtn.UseVisualStyleBackColor = false;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(713, 21);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 30);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "로그아웃";
            LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.logo;
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
            MenuPanel.Controls.Add(InforBtn);
            MenuPanel.Controls.Add(TakecheckBtn);
            MenuPanel.Controls.Add(TakeoutBtn);
            MenuPanel.Controls.Add(Username);
            MenuPanel.Location = new Point(0, 76);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Padding = new Padding(10);
            MenuPanel.Size = new Size(160, 373);
            MenuPanel.TabIndex = 1;
            // 
            // InforBtn
            // 
            InforBtn.FlatAppearance.BorderSize = 0;
            InforBtn.FlatStyle = FlatStyle.Flat;
            InforBtn.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            InforBtn.Image = Properties.Resources.inforIcon;
            InforBtn.ImageAlign = ContentAlignment.TopCenter;
            InforBtn.Location = new Point(32, 255);
            InforBtn.Name = "InforBtn";
            InforBtn.Padding = new Padding(7);
            InforBtn.Size = new Size(95, 95);
            InforBtn.TabIndex = 7;
            InforBtn.Text = "정보 요청";
            InforBtn.TextAlign = ContentAlignment.BottomCenter;
            InforBtn.UseVisualStyleBackColor = true;
            // 
            // TakecheckBtn
            // 
            TakecheckBtn.FlatAppearance.BorderSize = 0;
            TakecheckBtn.FlatStyle = FlatStyle.Flat;
            TakecheckBtn.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TakecheckBtn.Image = Properties.Resources.takeCheckIcon;
            TakecheckBtn.ImageAlign = ContentAlignment.TopCenter;
            TakecheckBtn.Location = new Point(32, 156);
            TakecheckBtn.Name = "TakecheckBtn";
            TakecheckBtn.Padding = new Padding(7);
            TakecheckBtn.Size = new Size(95, 95);
            TakecheckBtn.TabIndex = 6;
            TakecheckBtn.Text = "반출 확인";
            TakecheckBtn.TextAlign = ContentAlignment.BottomCenter;
            TakecheckBtn.UseVisualStyleBackColor = true;
            // 
            // TakeoutBtn
            // 
            TakeoutBtn.BackgroundImageLayout = ImageLayout.None;
            TakeoutBtn.FlatAppearance.BorderSize = 0;
            TakeoutBtn.FlatStyle = FlatStyle.Flat;
            TakeoutBtn.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TakeoutBtn.Image = Properties.Resources.takeoutIcon;
            TakeoutBtn.ImageAlign = ContentAlignment.TopCenter;
            TakeoutBtn.Location = new Point(32, 55);
            TakeoutBtn.Name = "TakeoutBtn";
            TakeoutBtn.Padding = new Padding(5);
            TakeoutBtn.Size = new Size(95, 95);
            TakeoutBtn.TabIndex = 5;
            TakeoutBtn.Text = "반출 요청";
            TakeoutBtn.TextAlign = ContentAlignment.BottomCenter;
            TakeoutBtn.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            Username.Font = new Font("Pretendard", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Username.Location = new Point(0, 10);
            Username.Name = "Username";
            Username.Size = new Size(160, 26);
            Username.TabIndex = 4;
            Username.Text = "userName";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TakeoutPanel
            // 
            TakeoutPanel.BackColor = Color.White;
            TakeoutPanel.Controls.Add(RequestBtn);
            TakeoutPanel.Controls.Add(ReasonText);
            TakeoutPanel.Controls.Add(GetBtn);
            TakeoutPanel.Controls.Add(Getpanel);
            TakeoutPanel.Location = new Point(166, 76);
            TakeoutPanel.Name = "TakeoutPanel";
            TakeoutPanel.Padding = new Padding(10);
            TakeoutPanel.Size = new Size(639, 373);
            TakeoutPanel.TabIndex = 2;
            // 
            // RequestBtn
            // 
            RequestBtn.BackColor = Color.FromArgb(54, 54, 54);
            RequestBtn.FlatAppearance.BorderSize = 0;
            RequestBtn.FlatStyle = FlatStyle.Flat;
            RequestBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RequestBtn.ForeColor = Color.White;
            RequestBtn.Location = new Point(36, 320);
            RequestBtn.Name = "RequestBtn";
            RequestBtn.Size = new Size(79, 30);
            RequestBtn.TabIndex = 6;
            RequestBtn.Text = "요청";
            RequestBtn.UseVisualStyleBackColor = false;
            // 
            // ReasonText
            // 
            ReasonText.BackColor = Color.White;
            ReasonText.Cursor = Cursors.IBeam;
            ReasonText.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ReasonText.Location = new Point(36, 126);
            ReasonText.Multiline = true;
            ReasonText.Name = "ReasonText";
            ReasonText.Size = new Size(428, 173);
            ReasonText.TabIndex = 5;
            ReasonText.Text = "사유";
            // 
            // GetBtn
            // 
            GetBtn.BackColor = Color.FromArgb(54, 54, 54);
            GetBtn.FlatAppearance.BorderSize = 0;
            GetBtn.FlatStyle = FlatStyle.Flat;
            GetBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            GetBtn.ForeColor = Color.White;
            GetBtn.Location = new Point(470, 59);
            GetBtn.Name = "GetBtn";
            GetBtn.Size = new Size(87, 32);
            GetBtn.TabIndex = 4;
            GetBtn.Text = "가져오기";
            GetBtn.UseVisualStyleBackColor = false;
            // 
            // Getpanel
            // 
            Getpanel.BackColor = Color.FromArgb(223, 223, 223);
            Getpanel.Controls.Add(Gettextbox);
            Getpanel.Location = new Point(36, 55);
            Getpanel.Name = "Getpanel";
            Getpanel.Padding = new Padding(5, 8, 5, 5);
            Getpanel.Size = new Size(428, 40);
            Getpanel.TabIndex = 3;
            // 
            // Gettextbox
            // 
            Gettextbox.BackColor = Color.FromArgb(223, 223, 223);
            Gettextbox.BorderStyle = BorderStyle.None;
            Gettextbox.Dock = DockStyle.Fill;
            Gettextbox.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Gettextbox.Location = new Point(5, 8);
            Gettextbox.Name = "Gettextbox";
            Gettextbox.Size = new Size(418, 23);
            Gettextbox.TabIndex = 0;
            // 
            // InforPanel
            // 
            InforPanel.BackColor = Color.White;
            InforPanel.Controls.Add(Exceptionfile);
            InforPanel.Controls.Add(Secretfile);
            InforPanel.Controls.Add(Exceptiontitle);
            InforPanel.Controls.Add(Secrettitle);
            InforPanel.Location = new Point(166, 76);
            InforPanel.Name = "InforPanel";
            InforPanel.Padding = new Padding(10);
            InforPanel.Size = new Size(639, 373);
            InforPanel.TabIndex = 3;
            // 
            // Exceptionfile
            // 
            Exceptionfile.AutoSize = true;
            Exceptionfile.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Exceptionfile.Location = new Point(58, 255);
            Exceptionfile.Name = "Exceptionfile";
            Exceptionfile.Size = new Size(65, 19);
            Exceptionfile.TabIndex = 3;
            Exceptionfile.Text = "파일나열";
            // 
            // Secretfile
            // 
            Secretfile.AutoSize = true;
            Secretfile.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Secretfile.Location = new Point(58, 115);
            Secretfile.Name = "Secretfile";
            Secretfile.Size = new Size(65, 19);
            Secretfile.TabIndex = 2;
            Secretfile.Text = "파일나열";
            // 
            // Exceptiontitle
            // 
            Exceptiontitle.AutoSize = true;
            Exceptiontitle.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Exceptiontitle.Location = new Point(36, 205);
            Exceptiontitle.Name = "Exceptiontitle";
            Exceptiontitle.Size = new Size(79, 23);
            Exceptiontitle.TabIndex = 1;
            Exceptiontitle.Text = "예외 폴더";
            // 
            // Secrettitle
            // 
            Secrettitle.AutoSize = true;
            Secrettitle.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Secrettitle.Location = new Point(36, 65);
            Secrettitle.Name = "Secrettitle";
            Secrettitle.Size = new Size(148, 23);
            Secrettitle.TabIndex = 0;
            Secrettitle.Text = "암호화 대상 확장자";
            // 
            // StartPanel
            // 
            StartPanel.Controls.Add(StartTakecheck);
            StartPanel.Controls.Add(StartInfor);
            StartPanel.Controls.Add(StartTakeout);
            StartPanel.Location = new Point(0, 76);
            StartPanel.Name = "StartPanel";
            StartPanel.Padding = new Padding(20);
            StartPanel.Size = new Size(802, 373);
            StartPanel.TabIndex = 4;
            // 
            // StartTakecheck
            // 
            StartTakecheck.BackColor = Color.White;
            StartTakecheck.Font = new Font("Pretendard", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            StartTakecheck.Image = (Image)resources.GetObject("StartTakecheck.Image");
            StartTakecheck.ImageAlign = ContentAlignment.TopCenter;
            StartTakecheck.Location = new Point(281, 84);
            StartTakecheck.Name = "StartTakecheck";
            StartTakecheck.Padding = new Padding(50);
            StartTakecheck.Size = new Size(240, 205);
            StartTakecheck.TabIndex = 2;
            StartTakecheck.Text = "반출 확인";
            StartTakecheck.TextAlign = ContentAlignment.BottomCenter;
            StartTakecheck.UseVisualStyleBackColor = false;
            // 
            // StartInfor
            // 
            StartInfor.BackColor = Color.White;
            StartInfor.Font = new Font("Pretendard", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            StartInfor.Image = (Image)resources.GetObject("StartInfor.Image");
            StartInfor.ImageAlign = ContentAlignment.TopCenter;
            StartInfor.Location = new Point(539, 84);
            StartInfor.Name = "StartInfor";
            StartInfor.Padding = new Padding(50);
            StartInfor.Size = new Size(240, 205);
            StartInfor.TabIndex = 1;
            StartInfor.Text = "정보 요청";
            StartInfor.TextAlign = ContentAlignment.BottomCenter;
            StartInfor.UseVisualStyleBackColor = false;
            // 
            // StartTakeout
            // 
            StartTakeout.BackColor = Color.White;
            StartTakeout.Font = new Font("Pretendard", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            StartTakeout.Image = (Image)resources.GetObject("StartTakeout.Image");
            StartTakeout.ImageAlign = ContentAlignment.TopCenter;
            StartTakeout.Location = new Point(23, 84);
            StartTakeout.Name = "StartTakeout";
            StartTakeout.Padding = new Padding(50);
            StartTakeout.Size = new Size(240, 205);
            StartTakeout.TabIndex = 0;
            StartTakeout.Text = "반출 요청";
            StartTakeout.TextAlign = ContentAlignment.BottomCenter;
            StartTakeout.UseVisualStyleBackColor = false;
            // 
            // TakecheckPanel
            // 
            TakecheckPanel.BackColor = Color.White;
            TakecheckPanel.Controls.Add(tableLayoutPanel1);
            TakecheckPanel.Location = new Point(166, 76);
            TakecheckPanel.Name = "TakecheckPanel";
            TakecheckPanel.Padding = new Padding(10);
            TakecheckPanel.Size = new Size(636, 373);
            TakecheckPanel.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.87611F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.1238937F));
            tableLayoutPanel1.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tableLayoutPanel1.Location = new Point(36, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.363636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.363636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.363636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.363636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.363636F));
            tableLayoutPanel1.Size = new Size(565, 306);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TakecheckPanel);
            Controls.Add(TakeoutPanel);
            Controls.Add(MenuPanel);
            Controls.Add(StartPanel);
            Controls.Add(InforPanel);
            Controls.Add(Header);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuPanel.ResumeLayout(false);
            TakeoutPanel.ResumeLayout(false);
            TakeoutPanel.PerformLayout();
            Getpanel.ResumeLayout(false);
            Getpanel.PerformLayout();
            InforPanel.ResumeLayout(false);
            InforPanel.PerformLayout();
            StartPanel.ResumeLayout(false);
            TakecheckPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox Logo;
        private Button LogoutBtn;
        private Panel MenuPanel;
        private Panel TakeoutPanel;
        private Panel InforPanel;
        private Button CheckBtn;
        private Label Username;
        private Label Exceptionfile;
        private Label Secretfile;
        private Label Exceptiontitle;
        private Label Secrettitle;
        private Panel StartPanel;
        private Button StartTakeout;
        private Button StartInfor;
        private Button StartTakecheck;
        private Button TakeoutBtn;
        private Button InforBtn;
        private Button TakecheckBtn;
        private Button GetBtn;
        private Panel Getpanel;
        private TextBox Gettextbox;
        private TextBox ReasonText;
        private Button RequestBtn;
        private Panel TakecheckPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}