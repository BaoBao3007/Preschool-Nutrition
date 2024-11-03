using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Repositories
{
    public class TaiKhoanRepository
    {
        private UserService userService = new UserService();
        public bool Login(string tenDangNhap, string matKhau)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MatKhau FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                try
                {
                    object result = cmd.ExecuteScalar(); // Lấy mật khẩu đã mã hóa từ cơ sở dữ liệu

                    if (result != null)
                    {
                        string hashedPassword = result.ToString();
                        UserService userService = new UserService(); // Tạo instance của UserService để xác thực mật khẩu
                        return userService.VerifyPassword(matKhau, hashedPassword); // Kiểm tra mật khẩu
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết (log hoặc ném ra ngoại lệ)
                    Console.WriteLine("Lỗi khi đăng nhập: " + ex.Message);
                }
            }

            return false; // Trả về false nếu tên đăng nhập không tồn tại hoặc mật khẩu không hợp lệ
        }
        public void AddTaiKhoanNhanVien(TaiKhoan taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.TenDangNhap) ||
                string.IsNullOrEmpty(taiKhoan.MatKhau) ||
                string.IsNullOrEmpty(taiKhoan.LoaiTaiKhoan) ||
                taiKhoan.MaNhanVien <= 0)
            {
                throw new ArgumentException("Thông tin tài khoản không hợp lệ.");
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string hashedPassword = userService.HashPassword(taiKhoan.MatKhau);

                string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, MaNhanVien) " +
                               "VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan, @MaNhanVien)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", hashedPassword);
                    command.Parameters.AddWithValue("@LoaiTaiKhoan", taiKhoan.LoaiTaiKhoan);
                    command.Parameters.AddWithValue("@MaNguoiDung", taiKhoan.MaNhanVien);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteTaiKhoan(string tenDangNhap)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                var query = @"DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateTaiKhoanNhanVien(TaiKhoan updatedTaiKhoan)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                var query = @"UPDATE TaiKhoan 
                              SET 
                                  MatKhau = @MatKhau, 
                                  LoaiTaiKhoan = @LoaiTaiKhoan, 
                                  MaNhanVien = @MaNhanVien 
                              WHERE TenDangNhap = @TenDangNhap";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", updatedTaiKhoan.TenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", userService.HashPassword(updatedTaiKhoan.MatKhau)); // Mã hóa mật khẩu mới
                    command.Parameters.AddWithValue("@LoaiTaiKhoan", updatedTaiKhoan.LoaiTaiKhoan);
                    command.Parameters.AddWithValue("@MaNhanVien", updatedTaiKhoan.MaNhanVien);
                    command.ExecuteNonQuery();
                }
            }
        }
        public string GetHashedPasswordFromDB(string tenDangNhap)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MatKhau FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                try
                {
                    object result = cmd.ExecuteScalar(); // Lấy kết quả từ câu truy vấn
                    if (result != null)
                    {
                        return result.ToString(); // Trả về mật khẩu đã băm
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết (log hoặc ném ra ngoại lệ)
                    Console.WriteLine("Lỗi khi lấy mật khẩu: " + ex.Message);
                }
            }

            return null; // Trả về null nếu không tìm thấy tên đăng nhập
        }
        public string GetUserInfo(string tenDangNhap)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT LoaiTaiKhoan, MaNhanVien, MaGiaoVien FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string loaiTaiKhoan = reader["LoaiTaiKhoan"].ToString();
                            int? maNhanVien = reader.IsDBNull(reader.GetOrdinal("MaNhanVien")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("MaNhanVien"));
                            int? maGiaoVien = reader.IsDBNull(reader.GetOrdinal("MaGiaoVien")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("MaGiaoVien"));

                            if (loaiTaiKhoan == "Admin")
                            {
                                return "Xin chào Admin";
                            }
                            else if (loaiTaiKhoan == "NhanVien" && maNhanVien.HasValue)
                            {
                                // Lấy tên nhân viên
                                return GetHoTenNhanVien(maNhanVien.Value);
                            }
                            else if (loaiTaiKhoan == "GiaoVien" && maGiaoVien.HasValue)
                            {
                                // Lấy tên giáo viên
                                return GetHoTenGiaoVien(maGiaoVien.Value);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy thông tin người dùng: " + ex.Message);
                }
            }

            return "Thông tin không hợp lệ";
        }

        private string GetHoTenNhanVien(int maNhanVien)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT HoTen FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                try
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return "Xin chào " + result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy tên nhân viên: " + ex.Message);
                }
            }
            return "Không tìm thấy thông tin nhân viên";
        }

        private string GetHoTenGiaoVien(int maGiaoVien)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT HoTen FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);

                try
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return "Xin chào " + result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy tên giáo viên: " + ex.Message);
                }
            }
            return "Không tìm thấy thông tin giáo viên";
        }
        public bool ChangePassword(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                // Lấy mật khẩu hiện tại
                string hashedCurrentPassword = GetHashedPasswordFromDB(tenDangNhap);

                // Xác thực mật khẩu cũ
                if (userService.VerifyPassword(matKhauCu, hashedCurrentPassword))
                {
                    string newHashedPassword = userService.HashPassword(matKhauMoi); // Mã hóa mật khẩu mới

                    string query = "UPDATE TaiKhoan SET MatKhau = @MatKhau WHERE TenDangNhap = @TenDangNhap";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", newHashedPassword);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string GetLoaiTaiKhoan(string tenDangNhap)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                try
                {
                    object result = cmd.ExecuteScalar(); 
                    if (result != null)
                    {
                        return result.ToString(); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy loại tài khoản: " + ex.Message);
                }
            }

            return null; 
        }
    }
}
