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
            if (string.IsNullOrEmpty(giaoVien.MaGiaoVien) ||
     string.IsNullOrEmpty(giaoVien.HoTen) ||
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
                    string query = "INSERT INTO GiaoVien (MaGiaoVien, HoTen, NgaySinh, GioiTinh, ChucVu, DiaChi, DienThoai) " +
                                   "VALUES (@MaGiaoVien, @HoTen, @NgaySinh, @GioiTinh, @ChucVu, @DiaChi, @DienThoai)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaGiaoVien", giaoVien.MaGiaoVien);
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
        public List<GiaoVien> GetAllGiaoVien()
        {
            List<GiaoVien> dsGiaoVien = new List<GiaoVien>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM GiaoVien";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var giaoVien = new GiaoVien
                            {
                                MaGiaoVien = reader["MaGiaoVien"].ToString(),
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

    }
}
