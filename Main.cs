using Agent_Program.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Agent_Program.LoginSignup;

namespace Agent_Program
{
    public partial class Main : Form
    {
        string currentPage = "takeOut";
        private static readonly HttpClient client = new HttpClient();
        public bool IsLogout { get; private set; } = false;

        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // 깜빡임 방지
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ifCurrentPage();

            Username.Text = UserSession.Username;

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

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(54, 54, 54); // 어두운 배경
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.Rows.Add("홍길동", 30, "서울");

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

        private void ifCurrentPage()
        {
            if (currentPage == "takeOut")
            {
                TakeoutPanel.BringToFront();
            }
            else if (currentPage == "takeCheck")
            {
                TakecheckPanel.BringToFront();
            }
            else
            {
                InforPanel.BringToFront();
            }
        }

        private void TakeoutBtn_Click(object sender, EventArgs e)
        {
            currentPage = "takeOut";
            ifCurrentPage();
        }

        private void TakecheckBtn_Click(object sender, EventArgs e)
        {
            currentPage = "takeCheck";
            ifCurrentPage();
        }

        private async void InforBtn_Click(object sender, EventArgs e)
        {
            string agentId = getAgentId();
            if (string.IsNullOrEmpty(agentId)) return;

            string url = $"http://192.168.0.82/Smsproject/Api/getconfig.html?val=" + agentId;

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result.StartsWith("OK"))
                    {
                        string[] parts = result.Split('|');
                        string decodedExtension = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parts[1]));
                        string decodedException = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parts[2]));

                        Extension.Text = decodedExtension;
                        Exception.Text = decodedException;

                        currentPage = "Infor";
                        ifCurrentPage();
                    }
                    else
                    {
                        MessageBox.Show($"서버 응답 오류: {result}");
                    }

                }
                else
                {
                    MessageBox.Show($"통신 실패: {(int)response.StatusCode} {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private string getAgentId()
        {
            string filePath = "D:\\박연희\\AgentProgram\\AgentID.id";


            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);  // 저장된 ID 전체를 읽음
            }
            else
            {
                MessageBox.Show("Agent ID 파일이 존재하지 않습니다.");
                return null;
            }
        }

        private async void LogoutBtn_Click(object sender, EventArgs e)
        {
            string agentId = getAgentId();
            if (string.IsNullOrEmpty(agentId)) return;

            string url = $"http://192.168.0.82/Smsproject/Api/logout.html?val=" + agentId;

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result == "OK")
                    {
                        IsLogout = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"서버 응답 오류: {result}");
                    }

                }
                else
                {
                    MessageBox.Show($"통신 실패: {(int)response.StatusCode} {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private async void CheckBtn_Click(object sender, EventArgs e)
        {
            string agentId = getAgentId();
            if (string.IsNullOrEmpty(agentId)) return;

            string url = $"http://192.168.0.82/Smsproject/Api/check.html?val=" + agentId;

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result.StartsWith("OK|"))
                    {
                        string[] parts = result.Split('|');
                        string interval = parts[1];
                        MessageBox.Show($"Agent 체크\n주기: {interval}", "Agnet 체크 요청");
                    }
                    else
                    {
                        MessageBox.Show($"서버 응답 오류: {result}");
                    }

                }
                else
                {
                    MessageBox.Show($"통신 실패: {(int)response.StatusCode} {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void Getpanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                GetTextBox.Text = files[0]; // 첫 번째 파일 경로를 텍스트박스에 출력
            }
        }

        private void Getpanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void GetBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "파일 선택";
                openFileDialog.Filter = "모든 파일 (*.*)|*.*"; // 필요시 확장자 제한 가능

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    GetTextBox.Text = selectedFilePath; // 파일 경로를 텍스트박스에 출력
                }
            }
        }

        private async void RequestBtn_Click(object sender, EventArgs e)
        {
            string agentId = getAgentId();
            string filePath = GetTextBox.Text.Trim();
            if (string.IsNullOrEmpty(agentId)) return;
            else if (string.IsNullOrEmpty(filePath) || filePath == "파일을 드래그하거나 가져와주세요")
            {
                MessageBox.Show("파일을 넣어주세요");
                return;
            }
            else if(ReasonText.Text == "사유")
            {
                MessageBox.Show("사유를 작성해주세요");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("파일이 존재하지 않습니다.");
                return;
            }

            string reasonText = ReasonText.Text;
            string val = $"{agentId}|{filePath}|{reasonText}";
            string url = $"http://192.168.0.82/Smsproject/Api/request.html?val="+Uri.EscapeDataString(val);
            Debug.WriteLine(url);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result.StartsWith("OK|"))
                    {
                        string[] parts = result.Split('|');
                        string requestID = parts[1];
                        MessageBox.Show($"Agent 요청\n요청ID: {requestID}");
                    }
                    else
                    {
                        MessageBox.Show($"서버 응답 오류: {result}\n{agentId}");
                    }

                }
                else
                {
                    MessageBox.Show($"통신 실패: {(int)response.StatusCode} {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
    }
}
