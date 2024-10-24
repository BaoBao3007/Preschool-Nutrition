using MySql.Data.MySqlClient;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Repositories
{
    internal class LichSuDiemDanhRepository
    {
        public DataTable LoadClasses()
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();
                var command = new MySqlCommand("SELECT MaLopHoc, TenLopHoc FROM LopHoc", connection);
                var reader = command.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
        }

        public DataTable LoadAttendanceHistory(string selectedDate, int selectedClassId)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();
                var query = $"SELECT DiemDanhBaoAn.MaDiemDanh, HocSinh.HoTen, DiemDanhBaoAn.VangMat " +
                            $"FROM DiemDanhBaoAn " +
                            $"JOIN HocSinh ON DiemDanhBaoAn.MaHocSinh = HocSinh.MaHocSinh " +
                            $"WHERE DiemDanhBaoAn.Ngay = @SelectedDate " +
                            $"AND HocSinh.MaLopHoc = @SelectedClassId";

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                command.Parameters.AddWithValue("@SelectedClassId", selectedClassId);
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void UpdateAttendance(int attendanceId, bool isAbsent)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();
                var query = "UPDATE DiemDanhBaoAn SET VangMat = @VangMat WHERE MaDiemDanh = @MaDiemDanh";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@VangMat", isAbsent ? 1 : 0);
                command.Parameters.AddWithValue("@MaDiemDanh", attendanceId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAttendance(int attendanceId)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               // connection.Open();
                var query = "DELETE FROM DiemDanhBaoAn WHERE MaDiemDanh = @MaDiemDanh";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDiemDanh", attendanceId);
                command.ExecuteNonQuery();
            }
        }
    }
}
