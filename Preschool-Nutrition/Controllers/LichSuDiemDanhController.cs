using MySql.Data.MySqlClient;
using Preschool_Nutrition.Repositories;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    internal class LichSuDiemDanhController
    {
        private LichSuDiemDanhRepository lichSuDiemDanhRepository;
        public LichSuDiemDanhController()
        {
            lichSuDiemDanhRepository = new LichSuDiemDanhRepository();
        }
        public void LoadClasses(ComboBox comboBoxClass)
        {
            var dataTable = lichSuDiemDanhRepository.LoadClasses();
            comboBoxClass.DataSource = dataTable;
            comboBoxClass.DisplayMember = "TenLopHoc";
            comboBoxClass.ValueMember = "MaLopHoc";
        }

        public void LoadAttendanceHistory(DataGridView dataGridViewHistory, DateTime selectedDate, int selectedClassId)
        {
            var dataTable = lichSuDiemDanhRepository.LoadAttendanceHistory(selectedDate.ToString("yyyy-MM-dd"), selectedClassId);
            dataGridViewHistory.DataSource = dataTable;
        }

        public void UpdateAttendance(DataGridView dataGridViewHistory)
        {
            foreach (DataGridViewRow row in dataGridViewHistory.Rows)
            {
                var attendanceId = Convert.ToInt32(row.Cells["MaDiemDanh"].Value);
                var isAbsent = Convert.ToBoolean(row.Cells["VangMat"].Value);
                lichSuDiemDanhRepository.UpdateAttendance(attendanceId, isAbsent);
            }
        }

        public void DeleteAttendance(int selectedClassId, DateTime selectedDate)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                //connection.Open();
                var query = "DELETE FROM DiemDanhBaoAn " +
                            "WHERE MaHocSinh IN (SELECT MaHocSinh FROM HocSinh WHERE MaLopHoc = @MaLopHoc) " +
                            "AND Ngay = @Ngay";

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaLopHoc", selectedClassId);
                command.Parameters.AddWithValue("@Ngay", selectedDate.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
            }
        }
    }
}
