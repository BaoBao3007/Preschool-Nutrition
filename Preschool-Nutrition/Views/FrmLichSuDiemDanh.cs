using Preschool_Nutrition.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preschool_Nutrition.Views
{
    public partial class FrmLichSuDiemDanh : Form
    {
        private LichSuDiemDanhController historyController;
        public FrmLichSuDiemDanh()
        {
            InitializeComponent();
            historyController = new LichSuDiemDanhController();
            CenterToScreen();
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            historyController.LoadClasses(comboBoxClass);
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadAttendanceHistory();
        }

        private void LoadAttendanceHistory()
        {
            if (comboBoxClass.SelectedItem != null) // Kiểm tra nếu có lớp được chọn
            {
                var selectedClass = (DataRowView)comboBoxClass.SelectedItem; // Chuyển đổi sang DataRowView
                var selectedClassId = Convert.ToInt32(selectedClass["MaLopHoc"]); // Lấy giá trị MaLopHoc từ DataRowView
                historyController.LoadAttendanceHistory(dataGridViewHistory, dateTimePicker.Value, selectedClassId);
            }
        }


        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceHistory();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceHistory();
        }

        private void btnUpdateAttendance_Click(object sender, EventArgs e)
        {
            historyController.UpdateAttendance(dataGridViewHistory);
            MessageBox.Show("Cập nhật điểm danh thành công!");
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedItem != null) // Kiểm tra nếu có lớp được chọn
            {
                var selectedClass = (DataRowView)comboBoxClass.SelectedItem; // Chuyển đổi sang DataRowView
                var selectedClassId = Convert.ToInt32(selectedClass["MaLopHoc"]); // Lấy giá trị MaLopHoc từ DataRowView
                var selectedDate = dateTimePicker.Value; // Lấy ngày được chọn

                historyController.DeleteAttendance(selectedClassId, selectedDate); // Gọi phương thức xóa bản ghi
                MessageBox.Show("Xóa tất cả bản ghi điểm danh cho lớp trong ngày đã chọn thành công!");
                LoadAttendanceHistory(); // Tải lại dữ liệu sau khi xóa
            }
        }
    }
}
