using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;

namespace Preschool_Nutrition.Repositories
{
    public class lopHocRepository
    {
       
        public void AddLopHoc(LopHoc lopHoc)
        {
           
            if (string.IsNullOrEmpty(lopHoc.TenLopHoc))
            {
                throw new ArgumentException("Tên lớp học không được để trống.");
            }

            if (string.IsNullOrEmpty(lopHoc.NamHoc))
            {
                throw new ArgumentException("Năm học không được để trống.");
            }

            if (lopHoc.MaGiaoVienChuNhiem <= 0)
            {
                throw new ArgumentException("Mã giáo viên chủ nhiệm không hợp lệ.");
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO LopHoc (TenLopHoc, NamHoc, MaGiaoVienChuNhiem) " +
                                   "VALUES (@TenLopHoc, @NamHoc, @MaGiaoVienChuNhiem)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenLopHoc", lopHoc.TenLopHoc);
                        command.Parameters.AddWithValue("@NamHoc", lopHoc.NamHoc);
                        command.Parameters.AddWithValue("@MaGiaoVienChuNhiem", lopHoc.MaGiaoVienChuNhiem);

                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                  
                    Console.WriteLine($"Lỗi khi thêm lớp học: {ex.Message}");
                    throw new Exception("Có lỗi xảy ra khi thêm lớp học. Vui lòng kiểm tra lại thông tin.");
                }
                catch (Exception ex)
                {
                  
                    Console.WriteLine($"Lỗi khi thêm lớp học: {ex.Message}");
                    throw;
                }
            }
        }


        // Lấy tất cả lớp học từ cơ sở dữ liệu
        public List<LopHoc> GetAllLopHoc()
        {
            List<LopHoc> dsLopHoc = new List<LopHoc>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                // Chỉ lấy những trường cần thiết (bỏ qua MaLopHoc)
                string query = "SELECT TenLopHoc, NamHoc, MaGiaoVienChuNhiem FROM LopHoc";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var lopHoc = new LopHoc
                            {
                                TenLopHoc = reader["TenLopHoc"].ToString(),
                                NamHoc = reader["NamHoc"].ToString(),
                                MaGiaoVienChuNhiem = reader.GetInt32("MaGiaoVienChuNhiem")
                            };
                            dsLopHoc.Add(lopHoc);
                        }
                    }
                }
            }

            return dsLopHoc;
        }


        // Cập nhật thông tin lớp học theo tên lớp học
        public void UpdateLopHocByTenLop(LopHoc updatedLop)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                var query = @"UPDATE LopHoc 
                              SET 
                                  NamHoc = @NamHoc, 
                                  MaGiaoVienChuNhiem = @MaGiaoVienChuNhiem 
                              WHERE TenLopHoc = @TenLopHoc";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenLopHoc", updatedLop.TenLopHoc);
                    command.Parameters.AddWithValue("@NamHoc", updatedLop.NamHoc);
                    command.Parameters.AddWithValue("@MaGiaoVienChuNhiem", updatedLop.MaGiaoVienChuNhiem);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Xóa lớp học theo tên lớp học
        public void DeleteLopHocByTen(string tenLopHoc)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                // Kiểm tra xem lớp học có đang được phân công hay không
                var checkQuery = @"SELECT COUNT(*) FROM PhanCong WHERE TenLopHoc = @TenLopHoc";

                using (var checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TenLopHoc", tenLopHoc);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new InvalidOperationException("Không thể xóa lớp học vì vẫn còn phân công giảng dạy.");
                    }
                }

                // Tiến hành xóa nếu không có ràng buộc
                var deleteQuery = @"DELETE FROM LopHoc WHERE TenLopHoc = @TenLopHoc";

                using (var deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@TenLopHoc", tenLopHoc);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }

        // Kiểm tra lớp học có đang được phân công giảng dạy hay không
        public bool IsLopHocAssigned(string tenLopHoc)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                var query = @"SELECT COUNT(*) FROM PhanCong WHERE TenLopHoc = @TenLopHoc";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenLopHoc", tenLopHoc);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
