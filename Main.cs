using Agent_Program.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_Program
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // 깜빡임 방지
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartPanel.Visible = true;
            //StartPanel.BringToFront();

            TakeoutBtn.Image = new Bitmap(Properties.Resources.takeoutIcon, 45, 45);
            TakecheckBtn.Image = new Bitmap(Properties.Resources.takeCheckIcon, 45, 45);
            InforBtn.Image = new Bitmap(Properties.Resources.inforIcon, 45, 45);

            CheckBtn.MouseEnter += Button_MouseEnter;
            LogoutBtn.MouseEnter += Button_MouseEnter;
            GetBtn.MouseEnter += Button2_MouseEnter;
            RequestBtn.MouseEnter += Button2_MouseEnter;

            CheckBtn.MouseLeave += Button_MouseLeave;
            LogoutBtn.MouseLeave += Button_MouseLeave;
            GetBtn.MouseLeave += Button2_MouseLeave;
            RequestBtn.MouseLeave += Button2_MouseLeave;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.ForeColor = Color.Black;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.ForeColor = Color.White;
        }
        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = ColorTranslator.FromHtml("#939393");
            }
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = ColorTranslator.FromHtml("#363636");
            }
        }
    }
}
