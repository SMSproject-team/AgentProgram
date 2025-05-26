using Microsoft.VisualBasic.Logging;
using System.Resources;

namespace Agent_Program
{
    partial class Main
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Header = new Panel();
            MainLogo = new PictureBox();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainLogo).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(54, 54, 54);
            Header.Controls.Add(MainLogo);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Padding = new Padding(0, 10, 10, 10);
            Header.Size = new Size(1000, 80);
            Header.TabIndex = 0;
            // 
            // MainLogo
            // 
            MainLogo.BackColor = Color.Transparent;
            MainLogo.Dock = DockStyle.Left;
            MainLogo.Image = (Image)resources.GetObject("MainLogo.Image");
            MainLogo.Location = new Point(0, 10);
            MainLogo.Name = "MainLogo";
            MainLogo.Size = new Size(200, 60);
            MainLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            MainLogo.TabIndex = 0;
            MainLogo.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            Controls.Add(Header);
            Name = "Main";
            Size = new Size(1000, 600);
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox MainLogo;
    }
}
