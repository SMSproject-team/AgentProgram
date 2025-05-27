using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Agent_Program
{
    public partial class LoginSignup : Form
    {
        string hostName = System.Environment.MachineName;
        string ipAddress = Dns.GetHostAddresses(Dns.GetHostName())
    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?.ToString();
        bool isLogin = true;
        const int CheckPriod = 3600;

        public LoginSignup()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // 깜빡임 방지
        }

        private void LoginSignup_Load(object sender, EventArgs e)
        {
            isLoginTrue();
        }

        // 로그인(혹은 회원가입) 버튼 클릭
        private void LoginSignupBtn_Click(object sender, EventArgs e)
        {
            if(isLogin == true)
            {
                // 로그인 성공 시
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if(hostName == Textbox1.Text && ipAddress == Textbox2.Text)
                {
                    //agentid 받기 && 회원가입 성공
                    string agentId = GenerateAgentIdAlphaOnly(hostName);
                    Console.WriteLine(agentId);
                    MessageBox.Show("AgentID를 복사했습니다.", "회원가입 성공");
                    Clipboard.SetText(agentId);
                    isLogin = true;
                    isLoginTrue();
                }
                else
                {
                    MessageBox.Show("Hostname 혹은 IP가 잘못되었습니다.", "회원가입 실패");
                    Debug.WriteLine(hostName);
                    Debug.WriteLine(ipAddress);
                }
            }

            
        }

        // 현재창의 상태가 로그인 상태인지 아닌지 확인 후 변경
        private void isLoginTrue()
        {
            if (isLogin == true)
            {
                Textbox1.Text = "AgentID";
                SignupBtn.Text = "회원가입";
                LoginSignupBtn.Text = "로그인";
            }
            else
            {
                Textbox1.Text = "Hostname";
                SignupBtn.Text = "로그인";
                LoginSignupBtn.Text = "회원가입";
            }
        }

        // 버튼 아래의 회원가입, 로그인 상태 변경 버튼
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (isLogin == true)
            {
                isLogin = false;
            }
            else
            {
                isLogin = true;
            }
            isLoginTrue();
        }

        // AgendID 제작
        public static string GenerateAgentIdAlphaOnly(string hostname)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(hostname));
                const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                StringBuilder sb = new StringBuilder();

                // 해시 바이트를 0~25 사이 값으로 변환 후 알파벳 매핑
                for (int i = 0; sb.Length < 16 && i < hashBytes.Length; i++)
                {
                    int index = hashBytes[i] % letters.Length;  // 0~25
                    sb.Append(letters[index]);
                }

                // 만약 16자 미만이면 'A'로 채우기 (안정성 위해)
                while (sb.Length < 16)
                    sb.Append('A');

                return sb.ToString();
            }
        }
    }
}
