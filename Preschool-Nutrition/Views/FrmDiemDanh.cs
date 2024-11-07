using Preschool_Nutrition.Controllers;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Preschool_Nutrition.Views
{
    public partial class FrmDiemDanh : Form
    {
        private int maLopHoc;
        private DiemDanhController danhController;
        public FrmDiemDanh()
        {
            InitializeComponent();
            danhController = new DiemDanhController();
            CenterToScreen();
        }
        public FrmDiemDanh(int maLopHoc)
        {
            InitializeComponent();
            this.maLopHoc = maLopHoc;
        }

        private void FrmDiemDanh_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            try
            {
                var classes = danhController.LoadClasses();
                comboBoxClass.DataSource = classes;
                comboBoxClass.DisplayMember = "TenLopHoc";
                comboBoxClass.ValueMember = "MaLopHoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message);
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            if (comboBoxClass.SelectedValue != null && comboBoxClass.SelectedValue is int)
            {
                var selectedClassId = (int)comboBoxClass.SelectedValue;

                try
                {
                    var students = danhController.LoadStudents(selectedClassId);
                    dataGridViewStudents.DataSource = null;
                    dataGridViewStudents.DataSource = null;
                    dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewStudents.DataSource = students;
                    dataGridViewStudents.RowHeadersWidth = 30;
                    dataGridViewStudents.RowTemplate.Height = 150;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách học sinh: " + ex.Message);
                }
            }
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có giá trị nào được chọn trong comboBoxClass không
                if (comboBoxClass.SelectedValue == null || comboBoxClass.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Vui lòng chọn lớp học.");
                    return;
                }

                int maLopHoc = Convert.ToInt32(comboBoxClass.SelectedValue);

                // Kiểm tra DataTable có dữ liệu không
                if (dataGridViewStudents.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
                {
                    // Kiểm tra từng hàng trong DataTable để xử lý giá trị DBNull
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Kiểm tra giá trị trong DataRow
                        if (row["MaHocSinh"] == DBNull.Value)
                        {
                            MessageBox.Show("Có học sinh không hợp lệ. Vui lòng kiểm tra lại.");
                            return;
                        }
                    }

                    danhController.SaveAttendance(maLopHoc, dataTable);
                    MessageBox.Show("Điểm danh đã được lưu cho tất cả học sinh.");
                }
                else
                {
                    MessageBox.Show("Không có học sinh nào để lưu điểm danh.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu điểm danh: " + ex.Message);
            }
        }

        private void btn_lsdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLichSuDiemDanh frmLichSuDiemDanh = new FrmLichSuDiemDanh();
            frmLichSuDiemDanh.FormClosed += (s, args) => this.Show();
            frmLichSuDiemDanh.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.Token = string.Empty;
            Properties.Settings.Default.Save();
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.FormClosed += (s, args) =>
            {
                this.Close();
            };
            login.ShowDialog();
            return;
        }
    }
}
