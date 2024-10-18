using System;
using BCrypt.Net;

namespace Preschool_Nutrition.Utilities
{
    public class UserService
    {
        public string HashPassword(string password)
        {
            // Mã hóa mật khẩu
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Xác thực mật khẩu
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
