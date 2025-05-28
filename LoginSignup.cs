using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Agent_Program
{
    public partial class LoginSignup : Form
    {
        string hostName = System.Environment.MachineName;
        string ipAddress = Dns.GetHostAddresses(Dns.GetHostName())
    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?.ToString();
        bool isLogin = true; // 현재가 로그인창인지 구별 [로그인 : true , 회원가입 : false]

        private static readonly HttpClient client = new HttpClient();

        public LoginSignup()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // 깜빡임 방지
            this.AcceptButton = LoginSignupBtn; // Enter키
        }

        private void LoginSignup_Load(object sender, EventArgs e)
        {
            isLoginTrue();
        }

        // 로그인(혹은 회원가입) 버튼 클릭
        private void LoginSignupBtn_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                LoginApi();
            }
            else
            {
                RegisterApi();
            }            
        }

        // 회원가입 버튼 눌렀을 시
        private async void RegisterApi()
        {
            string userName = Textbox2.Text;
            string departName = Textbox1.Text;
            string val = $"{hostName}|{ipAddress}|{userName}|{departName}";
            string url = $"http://192.168.0.82/Smsproject/Api/register.html?val="+Uri.EscapeDataString(val);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    if (result.StartsWith("OK|"))
                    {
                        string[] parts = result.Split('|');
                        string agentId = parts[1];
                        string interval = parts[2];
                        MessageBox.Show($"Agent 등록 성공\nID: {agentId}\n주기: {interval}");

                        string filePath = "D:\\박연희\\AgentProgram\\AgentID.id";

                        File.WriteAllText(filePath, agentId);

                        LoginApi();
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

        // 로그인버튼 눌렀을시
        private async void LoginApi()
        {
            string filePath = "D:\\박연희\\AgentProgram\\AgentID.id";
            string agentId = "";

            if (File.Exists(filePath))
            {
                agentId = File.ReadAllText(filePath);  // 저장된 ID 전체를 읽음
            }
            else
            {
                MessageBox.Show("Agent ID 파일이 존재하지 않습니다.");
                return;
            }

            string userName = Textbox2.Text;
            string val = $"{agentId}|{ipAddress}|{userName}";
            string url = $"http://192.168.0.82/Smsproject/Api/login.html?val=" + Uri.EscapeDataString(val);

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
                        MessageBox.Show($"Agent 로그인 성공\n주기: {interval}");
                        this.DialogResult = DialogResult.OK;
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

        // 현재창의 상태가 로그인 상태인지 아닌지 확인 후 변경
        private void isLoginTrue()
        {
            if (isLogin)
            {
                Textpanel1.Visible = false;
                SignupBtn.Text = "회원가입";
                LoginSignupBtn.Text = "로그인";
            }
            else
            {
                Textpanel1.Visible = true;
                Textbox1.Text = "부서명";
                SignupBtn.Text = "로그인";
                LoginSignupBtn.Text = "회원가입";
            }
        }

        // 버튼 아래의 회원가입, 로그인 상태 변경 버튼
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                isLogin = false;
            }
            else
            {
                isLogin = true;
            }
            isLoginTrue();
        }     
    }
}
