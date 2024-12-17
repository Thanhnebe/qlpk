using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DataAccess;  // Đảm bảo sử dụng đúng namespace từ DataAccess
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void RegisterUser(string username, string email, string password)
        {
            // Kiểm tra username và email
            if (_userRepository.IsUsernameExists(username))
                throw new System.Exception("Username already exists.");

            if (_userRepository.IsEmailExists(email))
                throw new System.Exception("Email already exists.");

            // Mã hóa mật khẩu
            string hashedPassword = HashPassword(password);

            // Tạo đối tượng User từ DataAccess
            User newUser = new User
            {
                Username = username,
                Email = email,
                PasswordHash = hashedPassword,
                CreatedAt = DateTime.Now
            };

            // Thêm vào database
            _userRepository.AddUser(newUser);
        }

        // Phương thức đăng nhập
        public bool AuthenticateUser(string username, string password)
        {
            // Tìm người dùng trong cơ sở dữ liệu dựa trên tên đăng nhập
            var user = _userRepository.GetUserByUsername(username);

            // Nếu không tìm thấy người dùng
            if (user == null)
                return false;

            // Mã hóa mật khẩu và kiểm tra với mật khẩu đã lưu trong cơ sở dữ liệu
            string hashedPassword = HashPassword(password);

            return user.PasswordHash == hashedPassword;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
