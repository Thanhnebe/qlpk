using System.Linq;

namespace DataAccess.Repository
{
    public class UserRepository
    {
        private readonly ClinicEntities _context;

        public UserRepository()
        {
            _context = new ClinicEntities();
        }

        public bool IsUsernameExists(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        public bool IsEmailExists(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        // Thêm người dùng mới vào cơ sở dữ liệu
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        // Lấy người dùng theo tên đăng nhập
        public User GetUserByUsername(string username)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username);
        }
    }
}
