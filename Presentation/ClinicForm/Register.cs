using System;
using System.Windows.Forms;
using BusinessLogic.Service;

namespace ClinicManagement.ClinicForm
{
    public partial class Register : Form
    {
        private readonly UserService _userService;

        public Register()
        {
            InitializeComponent();
            _userService = new UserService();
        }
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            // Create and show the Login form
            Login loginForm = new Login();
            loginForm.Show();  // Show the Login form
            this.Hide();  // Optionally hide the Register form
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi service để đăng ký
                _userService.RegisterUser(username, email, password);
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Ẩn form đăng nhập
                Login loginForm = new Login(); // Form chính sau khi login thành công
                loginForm.Show(); // Mở form chính
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create and show the Login form
            Login loginForm = new Login();
            loginForm.Show();  // Show the Login form
            this.Hide();  // Optionally hide the Register form
        }
    }
}
