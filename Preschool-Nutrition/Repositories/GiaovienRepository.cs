using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;

namespace Preschool_Nutrition.Repositories
{
    public class GiaoVienRepository
    {
        public void AddGiaoVien(GiaoVien giaoVien)
        {

                        // Kiểm tra các trường thông tin cần thiết
                if (string.IsNullOrEmpty(giaoVien.HoTen) ||
                    giaoVien.NgaySinh == DateTime.MinValue ||
                    string.IsNullOrEmpty(giaoVien.GioiTinh) ||
                    string.IsNullOrEmpty(giaoVien.ChucVu) ||
                    string.IsNullOrEmpty(giaoVien.DiaChi) ||
                    string.IsNullOrEmpty(giaoVien.DienThoai))
                {
                    throw new ArgumentException("Thông tin giáo viên không hợp lệ.");
                }

                using (var connection = DatabaseHelper.GetConnection())
                {
                    try
                    {
                     
                        string query = "INSERT INTO GiaoVien (HoTen, NgaySinh, GioiTinh, ChucVu, DiaChi, DienThoai) " +
                                       "VALUES (@HoTen, @NgaySinh, @GioiTinh, @ChucVu, @DiaChi, @DienThoai)";

                        using (var command = new MySqlCommand(query, connection))
                        {
                          
                            command.Parameters.AddWithValue("@HoTen", giaoVien.HoTen);
                            command.Parameters.AddWithValue("@NgaySinh", giaoVien.NgaySinh);
                            command.Parameters.AddWithValue("@GioiTinh", giaoVien.GioiTinh);
                            command.Parameters.AddWithValue("@ChucVu", giaoVien.ChucVu);
                            command.Parameters.AddWithValue("@DiaChi", giaoVien.DiaChi);
                            command.Parameters.AddWithValue("@DienThoai", giaoVien.DienThoai);

                        command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi thêm giáo viên: {ex.Message}");
                    }
                }
            
        }
        public List<GiaoVien> GetAllMTGiaoVien()
        {
            List<GiaoVien> danhSachGiaoVien = new List<GiaoVien>();


            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaGiaoVien, HoTen FROM GiaoVien"; 
                

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GiaoVien giaoVien = new GiaoVien
                            {
                                MaGiaoVien = reader.GetInt32("MaGiaoVien"),
                                HoTen = reader["HoTen"].ToString()
                            };
                            danhSachGiaoVien.Add(giaoVien);
                        }
                    }
                }
            }

            return danhSachGiaoVien;
        }
        public List<GiaoVien> GetAllGiaoVien()
        {
            List<GiaoVien> dsGiaoVien = new List<GiaoVien>();

            using (var connection = DatabaseHelper.GetConnection())
            {
         
                string query = "SELECT HoTen, NgaySinh, GioiTinh, ChucVu, DiaChi, DienThoai FROM GiaoVien";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var giaoVien = new GiaoVien
                            {
                                HoTen = reader["HoTen"].ToString(),
                                NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                                GioiTinh = reader["GioiTinh"].ToString(),
                                ChucVu = reader["ChucVu"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                DienThoai = reader["DienThoai"].ToString(),
                            };
                            dsGiaoVien.Add(giaoVien);
                        }
                    }
                }
            }

            return dsGiaoVien;
        }
        public void UpdateGiaoVienByHoTen(GiaoVien updatedTeacher)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {


                var query = @"UPDATE GiaoVien 
                      SET 
                          NgaySinh = @NgaySinh, 
                          GioiTinh = @GioiTinh, 
                          ChucVu = @ChucVu, 
                          DiaChi = @DiaChi, 
                          DienThoai = @DienThoai 
                      WHERE HoTen = @HoTen";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HoTen", updatedTeacher.HoTen);
                    command.Parameters.AddWithValue("@NgaySinh", updatedTeacher.NgaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", updatedTeacher.GioiTinh);
                    command.Parameters.AddWithValue("@ChucVu", updatedTeacher.ChucVu);
                    command.Parameters.AddWithValue("@DiaChi", updatedTeacher.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", updatedTeacher.DienThoai);

                    command.ExecuteNonQuery();
                }
            }
        }
        public bool IsGiaoVienAssigned(string hoTen)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
         

                var query = @"SELECT COUNT(*) FROM PhanCong WHERE HoTenGiaoVien = @HoTen";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Trả về true nếu có phân công, ngược lại false
                }
            }
        }

        public void DeleteGiaoVienByHoTen(string hoTen)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                

                // Kiểm tra xem giáo viên có đang được phân công dạy hay không
                var checkQuery = @"SELECT COUNT(*) FROM PhanCong 
                           WHERE HoTenGiaoVien = @HoTen";

                using (var checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@HoTen", hoTen);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    // Nếu giáo viên đang được phân công dạy
                    if (count > 0)
                    {
                        throw new InvalidOperationException("Không thể xóa giáo viên vì vẫn còn đang được phân công dạy.");
                    }
                }

                // Nếu không có ràng buộc, tiến hành xóa
                var deleteQuery = @"DELETE FROM GiaoVien WHERE HoTen = @HoTen";

                using (var deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@HoTen", hoTen);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }


    }
}
