using System;
using System.Security.Cryptography;
using System.Text;

namespace Preschool_Nutrition.Utilities
{
    public class HashService
    {
        // Phương thức băm chuỗi bằng SHA-256
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển đổi chuỗi thành mảng byte
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Chuyển đổi thành chuỗi hex
                }

                return builder.ToString(); // Trả về chuỗi băm
            }
        }

        // Phương thức so sánh chuỗi mật khẩu với giá trị băm
        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Băm mật khẩu được nhập vào
            string hashedInput = HashPassword(password);

            // So sánh giá trị băm đã băm và giá trị băm lưu trữ
            return hashedInput.Equals(hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
