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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            GetTextBox = new TextBox();
            InforPanel = new Panel();
            Exception = new Label();
            Extension = new Label();
            Exceptiontitle = new Label();
            Secrettitle = new Label();
            TakecheckPanel = new Panel();
            panel1 = new Panel();
            SearchTextBox = new TextBox();
            SearchBtn = new Button();
            dataGridView1 = new DataGridView();
            one = new DataGridViewTextBoxColumn();
            two = new DataGridViewTextBoxColumn();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuPanel.SuspendLayout();
            TakeoutPanel.SuspendLayout();
            Getpanel.SuspendLayout();
            InforPanel.SuspendLayout();
            TakecheckPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(54, 54, 54);
            Header.Controls.Add(CheckBtn);
            Header.Controls.Add(LogoutBtn);
            Header.Controls.Add(Logo);
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(3, 2, 3, 2);
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
            CheckBtn.Margin = new Padding(3, 2, 3, 2);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new Size(75, 30);
            CheckBtn.TabIndex = 2;
            CheckBtn.Text = "체크 요청";
            CheckBtn.UseVisualStyleBackColor = false;
            CheckBtn.Click += CheckBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(713, 21);
            LogoutBtn.Margin = new Padding(3, 2, 3, 2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 30);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "로그아웃";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(44, 0);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(70, 70);
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
            MenuPanel.Margin = new Padding(3, 2, 3, 2);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Padding = new Padding(10);
            MenuPanel.Size = new Size(160, 372);
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
            InforBtn.Margin = new Padding(3, 2, 3, 2);
            InforBtn.Name = "InforBtn";
            InforBtn.Padding = new Padding(7, 8, 7, 8);
            InforBtn.Size = new Size(95, 95);
            InforBtn.TabIndex = 7;
            InforBtn.Text = "정보 요청";
            InforBtn.TextAlign = ContentAlignment.BottomCenter;
            InforBtn.UseVisualStyleBackColor = true;
            InforBtn.Click += InforBtn_Click;
            // 
            // TakecheckBtn
            // 
            TakecheckBtn.FlatAppearance.BorderSize = 0;
            TakecheckBtn.FlatStyle = FlatStyle.Flat;
            TakecheckBtn.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TakecheckBtn.Image = Properties.Resources.takeCheckIcon;
            TakecheckBtn.ImageAlign = ContentAlignment.TopCenter;
            TakecheckBtn.Location = new Point(32, 156);
            TakecheckBtn.Margin = new Padding(3, 2, 3, 2);
            TakecheckBtn.Name = "TakecheckBtn";
            TakecheckBtn.Padding = new Padding(7, 8, 7, 8);
            TakecheckBtn.Size = new Size(95, 95);
            TakecheckBtn.TabIndex = 6;
            TakecheckBtn.Text = "반출 확인";
            TakecheckBtn.TextAlign = ContentAlignment.BottomCenter;
            TakecheckBtn.UseVisualStyleBackColor = true;
            TakecheckBtn.Click += TakecheckBtn_Click;
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
            TakeoutBtn.Margin = new Padding(3, 2, 3, 2);
            TakeoutBtn.Name = "TakeoutBtn";
            TakeoutBtn.Padding = new Padding(5);
            TakeoutBtn.Size = new Size(95, 95);
            TakeoutBtn.TabIndex = 5;
            TakeoutBtn.Text = "반출 요청";
            TakeoutBtn.TextAlign = ContentAlignment.BottomCenter;
            TakeoutBtn.UseVisualStyleBackColor = true;
            TakeoutBtn.Click += TakeoutBtn_Click;
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
            TakeoutPanel.Margin = new Padding(3, 2, 3, 2);
            TakeoutPanel.Name = "TakeoutPanel";
            TakeoutPanel.Padding = new Padding(10);
            TakeoutPanel.Size = new Size(639, 372);
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
            RequestBtn.Margin = new Padding(3, 2, 3, 2);
            RequestBtn.Name = "RequestBtn";
            RequestBtn.Size = new Size(79, 30);
            RequestBtn.TabIndex = 6;
            RequestBtn.Text = "요청";
            RequestBtn.UseVisualStyleBackColor = false;
            RequestBtn.Click += RequestBtn_Click;
            // 
            // ReasonText
            // 
            ReasonText.BackColor = Color.White;
            ReasonText.Cursor = Cursors.IBeam;
            ReasonText.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ReasonText.Location = new Point(36, 126);
            ReasonText.Margin = new Padding(3, 2, 3, 2);
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
            GetBtn.Margin = new Padding(3, 2, 3, 2);
            GetBtn.Name = "GetBtn";
            GetBtn.Size = new Size(87, 32);
            GetBtn.TabIndex = 4;
            GetBtn.Text = "가져오기";
            GetBtn.UseVisualStyleBackColor = false;
            GetBtn.Click += GetBtn_Click;
            // 
            // Getpanel
            // 
            Getpanel.AllowDrop = true;
            Getpanel.BackColor = Color.FromArgb(223, 223, 223);
            Getpanel.Controls.Add(GetTextBox);
            Getpanel.Location = new Point(36, 55);
            Getpanel.Margin = new Padding(3, 2, 3, 2);
            Getpanel.Name = "Getpanel";
            Getpanel.Padding = new Padding(5, 8, 5, 5);
            Getpanel.Size = new Size(428, 40);
            Getpanel.TabIndex = 3;
            Getpanel.DragDrop += Getpanel_DragDrop;
            Getpanel.DragEnter += Getpanel_DragEnter;
            // 
            // GetTextBox
            // 
            GetTextBox.BackColor = Color.FromArgb(223, 223, 223);
            GetTextBox.BorderStyle = BorderStyle.None;
            GetTextBox.Dock = DockStyle.Fill;
            GetTextBox.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            GetTextBox.ForeColor = Color.DimGray;
            GetTextBox.Location = new Point(5, 8);
            GetTextBox.Margin = new Padding(3, 2, 3, 2);
            GetTextBox.Name = "GetTextBox";
            GetTextBox.Size = new Size(418, 23);
            GetTextBox.TabIndex = 0;
            GetTextBox.Text = "파일을 드래그하거나 가져와주세요";
            // 
            // InforPanel
            // 
            InforPanel.BackColor = Color.White;
            InforPanel.Controls.Add(Exception);
            InforPanel.Controls.Add(Extension);
            InforPanel.Controls.Add(Exceptiontitle);
            InforPanel.Controls.Add(Secrettitle);
            InforPanel.Location = new Point(166, 76);
            InforPanel.Margin = new Padding(3, 2, 3, 2);
            InforPanel.Name = "InforPanel";
            InforPanel.Padding = new Padding(10);
            InforPanel.Size = new Size(639, 372);
            InforPanel.TabIndex = 3;
            // 
            // Exception
            // 
            Exception.AutoSize = true;
            Exception.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Exception.Location = new Point(58, 255);
            Exception.Name = "Exception";
            Exception.Size = new Size(65, 19);
            Exception.TabIndex = 3;
            Exception.Text = "파일나열";
            // 
            // Extension
            // 
            Extension.AutoSize = true;
            Extension.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Extension.Location = new Point(58, 115);
            Extension.Name = "Extension";
            Extension.Size = new Size(65, 19);
            Extension.TabIndex = 2;
            Extension.Text = "파일나열";
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
            // TakecheckPanel
            // 
            TakecheckPanel.BackColor = Color.White;
            TakecheckPanel.Controls.Add(panel1);
            TakecheckPanel.Controls.Add(SearchBtn);
            TakecheckPanel.Controls.Add(dataGridView1);
            TakecheckPanel.Location = new Point(166, 76);
            TakecheckPanel.Margin = new Padding(3, 2, 3, 2);
            TakecheckPanel.Name = "TakecheckPanel";
            TakecheckPanel.Padding = new Padding(10);
            TakecheckPanel.Size = new Size(636, 372);
            TakecheckPanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.FromArgb(223, 223, 223);
            panel1.Controls.Add(SearchTextBox);
            panel1.Font = new Font("Pretendard", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            panel1.Location = new Point(122, 34);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 8, 5, 5);
            panel1.Size = new Size(322, 40);
            panel1.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(223, 223, 223);
            SearchTextBox.BorderStyle = BorderStyle.None;
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Font = new Font("Pretendard", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SearchTextBox.ForeColor = Color.DimGray;
            SearchTextBox.Location = new Point(5, 8);
            SearchTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(312, 23);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.Text = "요청 ID";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(54, 54, 54);
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(450, 39);
            SearchBtn.Margin = new Padding(3, 2, 3, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(49, 32);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "검색";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Pretendard Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 54, 54);
            dataGridViewCellStyle2.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(54, 54, 54);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { one, two });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(0, 101);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 40;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(636, 171);
            dataGridView1.TabIndex = 0;
            // 
            // one
            // 
            one.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            one.FillWeight = 400F;
            one.HeaderText = "외부 반출 대상";
            one.Name = "one";
            one.ReadOnly = true;
            // 
            // two
            // 
            two.FillWeight = 200F;
            two.HeaderText = "처리";
            two.Name = "two";
            two.ReadOnly = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TakecheckPanel);
            Controls.Add(TakeoutPanel);
            Controls.Add(InforPanel);
            Controls.Add(MenuPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Main";
            FormClosing += Main_FormClosing;
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
            TakecheckPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label Exception;
        private Label Extension;
        private Label Exceptiontitle;
        private Label Secrettitle;
        private Button TakeoutBtn;
        private Button InforBtn;
        private Button TakecheckBtn;
        private Button GetBtn;
        private Panel Getpanel;
        private TextBox GetTextBox;
        private TextBox ReasonText;
        private Button RequestBtn;
        private Panel TakecheckPanel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn one;
        private DataGridViewTextBoxColumn two;
        private Button SearchBtn;
        private Panel panel1;
        private TextBox SearchTextBox;
    }
}