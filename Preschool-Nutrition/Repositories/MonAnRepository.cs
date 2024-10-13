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
    public class MonAnRepository
    {
        // Hiển thị tất cả món ăn
        public List<MonAn> GetAllMonAn()
        {
            List<MonAn> monAnList = new List<MonAn>();
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                string query = "SELECT * FROM MonAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MonAn monAn = new MonAn
                            {
                                MaMonAn = reader.GetInt32("MaMonAn"),
                                TenMonAn = reader.GetString("TenMonAn"),
                                LoaiMonAn = reader.GetString("LoaiMonAn"),
                                Calo = reader.GetFloat("Calo"),
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : reader.GetString("GhiChu")
                            };
                            monAnList.Add(monAn);
                        }
                    }
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }

            return monAnList;
        }

        // Thêm món ăn
        public void AddMonAn(MonAn monAn)
        {
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                string query = "INSERT INTO MonAn (TenMonAn, LoaiMonAn, Calo, GhiChu) VALUES (@TenMonAn, @LoaiMonAn, @Calo, @GhiChu)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
                    cmd.Parameters.AddWithValue("@LoaiMonAn", monAn.LoaiMonAn);
                    cmd.Parameters.AddWithValue("@Calo", monAn.Calo);
                    cmd.Parameters.AddWithValue("@GhiChu", monAn.GhiChu);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }
        }

        // Xóa món ăn
        public void DeleteMonAn(int maMonAn, string tenMonAn)
        {
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                // Sử dụng câu lệnh SQL để xóa theo mã món ăn hoặc tên món ăn
                string query = "DELETE FROM MonAn WHERE MaMonAn = @MaMonAn OR TenMonAn = @TenMonAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                    cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }
        }
        public void DeleteMonAnByName(string tenMonAn)
        {
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                // Sử dụng câu lệnh SQL để xóa theo tên món ăn
                string query = "DELETE FROM MonAn WHERE TenMonAn = @TenMonAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }
        }


        // Sửa món ăn

        // Sửa món ăn
        public void UpdateMonAn(MonAn monAn)
        {
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                string query = "UPDATE MonAn SET TenMonAn = @TenMonAn, LoaiMonAn = @LoaiMonAn, Calo = @Calo, GhiChu = @GhiChu WHERE MaMonAn = @MaMonAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
                    cmd.Parameters.AddWithValue("@LoaiMonAn", monAn.LoaiMonAn);
                    cmd.Parameters.AddWithValue("@Calo", monAn.Calo);
                    cmd.Parameters.AddWithValue("@GhiChu", monAn.GhiChu);
                    cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn); // Cần có MaMonAn để xác định món ăn cần sửa

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }
        }
        // Tìm món ăn theo tên, loại và calo
        public List<MonAn> SearchMonAn(string searchTerm)
        {
            List<MonAn> monAnList = new List<MonAn>();
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                // Nếu chuỗi tìm kiếm là null hoặc rỗng, trả về danh sách rỗng
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    return monAnList;
                }

                // Chuyển đổi chuỗi tìm kiếm thành chữ thường
                string lowerSearchTerm = searchTerm.ToLower();

                // Câu lệnh SQL tìm kiếm với LOWER để so sánh không phân biệt chữ hoa thường
                string query = @"
            SELECT * FROM MonAn 
            WHERE LOWER(TenMonAn) LIKE @SearchTerm 
               OR LOWER(LoaiMonAn) LIKE @SearchTerm 
               OR Calo LIKE @SearchTerm";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + lowerSearchTerm + "%"); // Thêm dấu % để tìm kiếm tương đối

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MonAn monAn = new MonAn
                            {
                                MaMonAn = reader.GetInt32("MaMonAn"),
                                TenMonAn = reader.GetString("TenMonAn"),
                                LoaiMonAn = reader.GetString("LoaiMonAn"),
                                Calo = reader.GetFloat("Calo"),
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : reader.GetString("GhiChu")
                            };
                            monAnList.Add(monAn);
                        }
                    }
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }

            return monAnList;
        }



        // Tìm món ăn theo ID
        public MonAn GetMonAnById(int maMonAn)
        {
            MonAn monAn = null;
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                string query = "SELECT * FROM MonAn WHERE MaMonAn = @MaMonAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            monAn = new MonAn
                            {
                                MaMonAn = reader.GetInt32("MaMonAn"),
                                TenMonAn = reader.GetString("TenMonAn"),
                                LoaiMonAn = reader.GetString("LoaiMonAn"),
                                Calo = reader.GetFloat("Calo"),
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : reader.GetString("GhiChu")
                            };
                        }
                    }
                }
            }
            finally
            {
                DatabaseHelper.CloseConnection(conn);  // Đóng kết nối sau khi sử dụng
            }

            return monAn;
        }
    }
}
