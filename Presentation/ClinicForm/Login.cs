using System;
using System.Windows.Forms;
using BusinessLogic.Service;

namespace ClinicManagement.ClinicForm
{
    public partial class Login : Form
    {
        private readonly UserService _userService;

        public Login()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        // Xử lý khi người dùng nhấn nút Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra đăng nhập
                bool isAuthenticated = _userService.AuthenticateUser(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Ẩn form đăng nhập
                    MainForm mainForm = new MainForm(); // Form chính sau khi login thành công
                    mainForm.Show(); // Mở form chính
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nhấn Enter trong TextBox
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Kiểm tra nếu người dùng nhấn Enter
            {
                btnLogin_Click(sender, e); // Gọi phương thức đăng nhập
            }
        }
        private void btnTodangky(object sender, EventArgs e)
        {
            // Create a new instance of the Register form and show it
            Register registerForm = new Register();
            registerForm.Show();  // This will open the Register form
            this.Hide();  // Optionally hide the Login form
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
