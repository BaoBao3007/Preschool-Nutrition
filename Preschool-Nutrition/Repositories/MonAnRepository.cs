using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
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
                string query = "SELECT * FROM MonAn";  // Đảm bảo rằng bảng MonAn có cột Buoi
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
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : reader.GetString("GhiChu"),
                                Buoi = reader.IsDBNull(reader.GetOrdinal("Buoi")) ? null : reader.GetString("Buoi")  // Lấy giá trị Buổi
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
        public List<NguyenLieuMonAn> GetNguyenLieuByMonAn(int maMonAn)
        {
            List<NguyenLieuMonAn> nguyenLieuList = new List<NguyenLieuMonAn>();

            string query = "SELECT n.MaMonAn, n.MaNguyenLieu, g.TenNguyenLieu, n.DVT, n.KhoiLuong, n.GhiChu " +
                           "FROM NguyenLieuMonAn n " +
                           "JOIN NguyenLieu g ON n.MaNguyenLieu = g.MaNguyenLieu " +
                           "WHERE n.MaMonAn = @MaMonAn";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); // Mở kết nối chỉ khi nó chưa mở
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                NguyenLieuMonAn nguyenLieu = new NguyenLieuMonAn
                                {
                                    MaMonAn = reader.GetInt32("MaMonAn"),
                                    MaNguyenLieu = reader.GetInt32("MaNguyenLieu"),
                                    TenNguyenLieu = reader.GetString("TenNGuyenLieu"),
                                    DVT = reader.GetString("DVT"),
                                    KhoiLuong = reader.GetFloat("KhoiLuong"),
                                    GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? string.Empty : reader.GetString("GhiChu")
                                };
                                nguyenLieuList.Add(nguyenLieu);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw; // Ném ngoại lệ để có thể xử lý ở nơi gọi
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close(); // Đóng kết nối nếu nó đang mở
                    }
                }
            }

            return nguyenLieuList;
        }
        public List<MonAn> SearchMonAn(string searchTerm)
        {
            List<MonAn> monAnList = new List<MonAn>();
            MySqlConnection conn = DatabaseHelper.GetConnection();  // Sử dụng DatabaseHelper

            try
            {
                // Tạo câu lệnh SQL với tham số động
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM MonAn WHERE 1=1");

                // Tìm kiếm theo tên món ăn, loại món ăn, ghi chú và buổi
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    queryBuilder.Append(" AND (TenMonAn LIKE @SearchTerm OR LoaiMonAn LIKE @SearchTerm OR GhiChu LIKE @SearchTerm OR Buoi LIKE @SearchTerm)");

                    // Kiểm tra nếu searchTerm có phải là một số (calo)
                    if (float.TryParse(searchTerm, out float calo))
                    {
                        queryBuilder.Append(" OR Calo = @Calo");
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand(queryBuilder.ToString(), conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    // Thêm tham số Calo nếu có
                    if (float.TryParse(searchTerm, out float calo))
                    {
                        cmd.Parameters.AddWithValue("@Calo", calo);
                    }

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
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? null : reader.GetString("GhiChu"),
                                Buoi = reader.IsDBNull(reader.GetOrdinal("Buoi")) ? null : reader.GetString("Buoi")
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
        //Ham Thêm Món Ăn
        public void ThemMonAn(MonAn monAn)
        {
            string query = "INSERT INTO MonAn (TenMonAn, LoaiMonAn, Calo, GhiChu, Buoi) VALUES (@TenMonAn, @LoaiMonAn, @Calo, @GhiChu, @Buoi)";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
                    cmd.Parameters.AddWithValue("@LoaiMonAn", monAn.LoaiMonAn);
                    cmd.Parameters.AddWithValue("@Calo", monAn.Calo);
                    cmd.Parameters.AddWithValue("@GhiChu", monAn.GhiChu);
                    cmd.Parameters.AddWithValue("@Buoi", monAn.Buoi);

                    // Thực thi câu lệnh
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // Đóng kết nối
                    DatabaseHelper.CloseConnection(connection);
                }
            }
        }

        public void AddNguyenLieuMonAn(NguyenLieuMonAn nguyenLieuMonAn)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO NguyenLieuMonAn (MaMonAn, MaNguyenLieu, DVT, KhoiLuong, GhiChu) VALUES (@MaMonAn, @MaNguyenLieu, @DVT, @KhoiLuong, @GhiChu)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaMonAn", nguyenLieuMonAn.MaMonAn);
                cmd.Parameters.AddWithValue("@MaNguyenLieu", nguyenLieuMonAn.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@DVT", nguyenLieuMonAn.DVT);
                cmd.Parameters.AddWithValue("@KhoiLuong", nguyenLieuMonAn.KhoiLuong);
                cmd.Parameters.AddWithValue("@GhiChu", nguyenLieuMonAn.GhiChu);
                cmd.ExecuteNonQuery();
            }
        }

        // Cập nhật nguyên liệu món ăn
        public void UpdateNguyenLieuMonAn(NguyenLieuMonAn nguyenLieuMonAn, string tenNguyenLieuCu)
        {
            string query = "UPDATE NguyenLieuMonAn SET MaNguyenLieu = @MaNguyenLieu, DVT = @DVT, KhoiLuong = @KhoiLuong, GhiChu = @GhiChu " +
                           "WHERE MaMonAn = @MaMonAn AND MaNguyenLieu = (SELECT MaNguyenLieu FROM NguyenLieu WHERE TenNGuyenLieu = @TenNguyenLieuCu)";

            using (var connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaMonAn", nguyenLieuMonAn.MaMonAn);
                cmd.Parameters.AddWithValue("@MaNguyenLieu", nguyenLieuMonAn.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@DVT", nguyenLieuMonAn.DVT);
                cmd.Parameters.AddWithValue("@KhoiLuong", nguyenLieuMonAn.KhoiLuong);
                cmd.Parameters.AddWithValue("@GhiChu", nguyenLieuMonAn.GhiChu);
                cmd.Parameters.AddWithValue("@TenNguyenLieuCu", tenNguyenLieuCu); // Thêm tên nguyên liệu cũ

                // Kiểm tra trạng thái kết nối trước khi mở
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); // Mở kết nối trước khi thực thi
                }

                cmd.ExecuteNonQuery();
            }
        }




        public void DeleteNguyenLieuMonAn(string tenNguyenLieu, int maMonAn)
        {
            // Truy vấn để lấy mã nguyên liệu dựa trên tên nguyên liệu
            string query = "DELETE FROM NguyenLieuMonAn WHERE MaNguyenLieu = (SELECT MaNguyenLieu FROM NguyenLieu WHERE TenNguyenLieu = @TenNguyenLieu) AND MaMonAn = @MaMonAn";

            using (var connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", tenNguyenLieu);
                cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

                // Kiểm tra trạng thái kết nối trước khi mở
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); // Mở kết nối chỉ khi nó chưa mở
                }

                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateMonAn(MonAn monAn)
        {
            string query = "UPDATE MonAn SET TenMonAn = @TenMonAn, LoaiMonAn = @LoaiMonAn, Calo = @Calo, GhiChu = @GhiChu, Buoi = @Buoi WHERE MaMonAn = @MaMonAn";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn);
                cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
                cmd.Parameters.AddWithValue("@LoaiMonAn", monAn.LoaiMonAn);
                cmd.Parameters.AddWithValue("@Calo", monAn.Calo);
                cmd.Parameters.AddWithValue("@GhiChu", monAn.GhiChu);
                cmd.Parameters.AddWithValue("@Buoi", monAn.Buoi);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); // Mở kết nối
                    }
                    int rowsAffected = cmd.ExecuteNonQuery(); // Thực hiện câu lệnh cập nhật

                    // Kiểm tra số dòng bị ảnh hưởng
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Cập nhật món ăn thành công.");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy món ăn để cập nhật.");
                    }
                }
                catch (MySqlException ex)
                {
                    // Thông báo lỗi chi tiết
                    Console.WriteLine("Error while connecting to database: " + ex.Message);
                    throw; // Ném lại lỗi để xử lý ngoài nếu cần
                }
            }
        }
        public void DeleteMonAn(int maMonAn)
        {
            // Đầu tiên, xóa tất cả các nguyên liệu của món ăn
            DeleteAllNguyenLieuMonAn(maMonAn);

            // Sau đó, xóa món ăn
            string query = "DELETE FROM MonAn WHERE MaMonAn = @MaMonAn";

            using (var connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); // Mở kết nối chỉ khi nó chưa mở
                    }

                    cmd.ExecuteNonQuery(); // Thực hiện câu lệnh xóa
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw; // Ném lại lỗi để xử lý ngoài nếu cần
                }
            }
        }

        private void DeleteAllNguyenLieuMonAn(int maMonAn)
        {
            string query = "DELETE FROM NguyenLieuMonAn WHERE MaMonAn = @MaMonAn";

            using (var connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open(); // Mở kết nối chỉ khi nó chưa mở
                    }

                    cmd.ExecuteNonQuery(); // Thực hiện câu lệnh xóa nguyên liệu
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw; // Ném lại lỗi để xử lý ngoài nếu cần
                }
            }
        }

    }
}
