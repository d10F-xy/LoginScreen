using System.Runtime.InteropServices;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        public Form1()
        {
            InitializeComponent();

            SetPlaceholder(loginIdBox, "아이디");
            SetPlaceholder(loginPwBox, "비밀번호");
        }

        public void SetPlaceholder(TextBox textBox, string promptText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, promptText);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // 1. 공백 검사 (Trim()은 앞뒤 공백 제거)
            if (string.IsNullOrWhiteSpace(loginIdBox.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                loginIdBox.Focus(); // 해당 칸으로 커서 이동
                return; // 함수 종료
            }

            if (string.IsNullOrWhiteSpace(loginPwBox.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                loginPwBox.Focus();
                return;
            }

            // 2. 실제 아이디/비밀번호 매칭 검사 (예시)
            string correctId = "admin";
            string correctPw = "1234";

            if (loginIdBox.Text == correctId && loginPwBox.Text == correctPw)
            {
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.");
            }
        }
    }
}
