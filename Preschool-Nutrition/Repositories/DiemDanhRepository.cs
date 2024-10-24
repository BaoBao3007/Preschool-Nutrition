using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Data;

namespace Preschool_Nutrition.Repositories
{
    public class DiemDanhRepository
    {
        
        public void AddDiemDanh(DiemDanhBaoAn diemDanh)
        {
            string query = "INSERT INTO DiemDanhBaoAn (Ngay, MaHocSinh, MaGiaoViens) VALUES (@Ngay, @MaHocSinh, @MaGiaoViens)";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ngay", diemDanh.Ngay);
                command.Parameters.AddWithValue("@MaHocSinh", diemDanh.MaHocSinh);
                command.Parameters.AddWithValue("@MaGiaoViens", diemDanh.MaGiaoViens);

                connection.Open(); // Đừng quên mở kết nối
                command.ExecuteNonQuery();
            }
        }
        public DataTable GetClasses()
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
             //   connection.Open();
                var command = new MySqlCommand("SELECT MaLopHoc, TenLopHoc FROM LopHoc", connection);
                var reader = command.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
        }

        public DataTable GetStudents(int classId)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();
                var query = $"SELECT MaHocSinh, HoTen FROM HocSinh WHERE MaLopHoc = {classId}";
                var adapter = new MySqlDataAdapter(query, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataTable.Columns.Add("VangMat", typeof(bool)); // Thêm cột checkbox
                return dataTable;
            }
        }

        public void SaveAttendance(int maGiaoVien, DataTable dataTable)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["MaHocSinh"] == DBNull.Value)
                    {
                        continue; // Bỏ qua hàng nếu không có mã học sinh
                    }

                    var maHocSinh = Convert.ToInt32(row["MaHocSinh"]);
                    var vangMat = row["VangMat"] != DBNull.Value ? Convert.ToBoolean(row["VangMat"]) : false; // Giả sử vắng mặt là false nếu là DBNull

                    // Thực hiện cập nhật hoặc thêm điểm danh
                    var query = "INSERT INTO DiemDanhBaoAn (Ngay, MaHocSinh, MaGiaoVien, VangMat) VALUES (@Ngay, @MaHocSinh, @MaGiaoVien, @VangMat)";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ngay", DateTime.Now); // Hoặc bạn có thể thay đổi theo ngày bạn muốn
                    command.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                    command.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                    command.Parameters.AddWithValue("@VangMat", vangMat);

                    command.ExecuteNonQuery();
                }
            }
        }


        public int GetMaGiaoVienChuNhiem(int maLopHoc)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();
                var command = new MySqlCommand("SELECT MaGiaoVienChuNhiem FROM LopHoc WHERE MaLopHoc = @MaLopHoc", connection);
                command.Parameters.AddWithValue("@MaLopHoc", maLopHoc);
                object result = command.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }

    }
}
