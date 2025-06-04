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
            SearchBtn.MouseEnter += Button2_MouseEnter;

            CheckBtn.MouseLeave += Button_MouseLeave;
            LogoutBtn.MouseLeave += Button_MouseLeave;
            GetBtn.MouseLeave += Button2_MouseLeave;
            RequestBtn.MouseLeave += Button2_MouseLeave;
            SearchBtn.MouseLeave += Button2_MouseLeave;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(54, 54, 54); // 어두운 배경
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor;

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        // 버튼 hover 효과
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

        // 현재 페이지 확인 및 text 되돌리기
        private void ifCurrentPage()
        {
            if (currentPage == "takeOut")
            {
                TakeoutPanel.BringToFront();
                SearchTextBox.Text = "요청ID";
                TakeoutBtn.BackColor = ColorTranslator.FromHtml("#EDEDED");
                TakecheckBtn.BackColor = Color.White;
                InforBtn.BackColor = Color.White;
            }
            else if (currentPage == "takeCheck")
            {
                TakecheckPanel.BringToFront();
                GetTextBox.Text = "파일을 드래그하거나 가져와주세요";
                ReasonText.Text = "사유";
                TakeoutBtn.BackColor = Color.White;
                TakecheckBtn.BackColor = ColorTranslator.FromHtml("#EDEDED");
                InforBtn.BackColor = Color.White;
            }
            else if (currentPage == "infor")
            {
                InforPanel.BringToFront();
                SearchTextBox.Text = "요청ID";
                GetTextBox.Text = "파일을 드래그하거나 가져와주세요";
                ReasonText.Text = "사유";
                TakeoutBtn.BackColor = Color.White;
                TakecheckBtn.BackColor = Color.White;
                InforBtn.BackColor = ColorTranslator.FromHtml("#EDEDED");
            }
        }

        // 옆 메뉴 눌렀을 때 - 요청
        private void TakeoutBtn_Click(object sender, EventArgs e)
        {
            currentPage = "takeOut";
            ifCurrentPage();
        }

        // 옆 메뉴 눌렀을 때 - 확인
        private void TakecheckBtn_Click(object sender, EventArgs e)
        {
            currentPage = "takeCheck";
            ifCurrentPage();
        }

        // agentID 불러오기
        private string getAgentId()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AgentID.id");


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

        // 옆 메뉴 눌렀을 때 - 정보
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

                        currentPage = "infor";
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

        // 로그아웃
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

        // 체크확인
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

        // 요청 - 파일 dragdrop 효과
        private void Getpanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                GetTextBox.Text = files[0]; // 첫 번째 파일 경로를 텍스트박스에 출력
            }
        }

        // 요청 - 파일 파일 넣을 수 있는지 효과
        private void Getpanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // 요청 - 가져오기 버튼
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

        // 요청 - 요청 버튼 클릭
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
            else if (ReasonText.Text == "사유")
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
            string url = $"http://192.168.0.82/Smsproject/Api/request.html?val=" + Uri.EscapeDataString(val);
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
                        MessageBox.Show($"Agent 요청\n요청ID: {requestID}\n*반출 요청 확인을 위해서는 요청ID가 필요합니다.*\n*요청ID는 자동으로 복사됩니다.*");
                        Clipboard.SetText(requestID);
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

        // 확인 - 검색 버튼
        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string agentId = getAgentId();
            string requestID = SearchTextBox.Text.Trim();

            string val = $"{agentId}|{requestID}";
            string url = $"http://192.168.0.82/Smsproject/Api/requestcheck.html?val=" + Uri.EscapeDataString(val);
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
                        string filePath = parts[1];
                        string requestResult = parts[2].ToLower();

                        switch (requestResult)
                        {
                            case "p":
                                requestResult = "대기중";
                                break;
                            case "a":
                                requestResult = "허용";
                                break;
                            case "d":
                                requestResult = "반려";
                                break;
                            default:
                                MessageBox.Show($"처리오류: {result}\n{requestID}");
                                break;
                        }

                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(filePath, requestResult);
                        dataGridView1.AllowUserToAddRows = false;
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
