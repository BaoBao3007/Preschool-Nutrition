using Preschool_Nutrition.Models;
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

namespace Preschool_Nutrition.Views
{
    public partial class FrmHocSinh : Form
    {
        private List<LopHoc> dsLopHoc;
        private HocsinhRepository hocsinhRepository;

        public FrmHocSinh()
        {
            InitializeComponent();
            hocsinhRepository = new HocsinhRepository();
            dsLopHoc = new List<LopHoc>();

            LoadLopHocData();
        }
        private void LoadLopHocData()
        {
            try
            {

                dsLopHoc = hocsinhRepository.GetAllLopHoc();

                if (dsLopHoc == null || dsLopHoc.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu lớp học để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxLopHoc.DataSource = dsLopHoc;
                comboBoxLopHoc.DisplayMember = "TenLopHoc";
                comboBoxLopHoc.ValueMember = "MaLopHoc";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu lớp học: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadHocSinhData()
        {
            try
            {
                var dsHocSinh = hocsinhRepository.GetAllHocSinh();

                if (dsHocSinh.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu học sinh để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.DataSource = dsHocSinh.Select(hs => new
                {
                    hs.MaHocSinh,
                    hs.HoTen,
                    hs.NgaySinh,
                    hs.GioiTinh,
                    hs.DiaChi,
                    hs.DienThoaiPhuHuynh,
                    MaLopHoc = hs.MaLopHoc
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu học sinh: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            textBoxHoTen.Clear();
            textBoxDiaChi.Clear();
            textBoxDTPH.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            comboBoxLopHoc.SelectedIndex = 0;
        }
        private string GetGioiTinh()
        {
            if (rdbNam.Checked)
            {
                return "Nam";
            }
            else if (rdbNu.Checked)
            {
                return "Nữ";
            }
            return string.Empty;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxHoTen_TextChanged(object sender, EventArgs e)
        {

        }


        private void FrmHocSinh_Load(object sender, EventArgs e)
        {
            LoadHocSinhData();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonthem_Click_1(object sender, EventArgs e)
        {
            HocSinh newHocSinh = new HocSinh
            {
                HoTen = textBoxHoTen.Text,
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = GetGioiTinh(),
                MaLopHoc = Convert.ToInt32(comboBoxLopHoc.SelectedValue)
            };


            try
            {
                hocsinhRepository.AddHocSinh(newHocSinh);
                MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHocSinhData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm học sinh: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedHocSinh == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa học sinh {selectedHocSinh.HoTen}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    hocsinhRepository.DeleteHocSinh(selectedHocSinh.MaHocSinh);
                    MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHocSinhData();
                    ClearForm();
                    selectedHocSinh = null;  // Xóa thông tin đã chọn
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa học sinh: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (selectedHocSinh == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedHocSinh.HoTen = textBoxHoTen.Text;
            selectedHocSinh.NgaySinh = dateTimePicker1.Value;
            selectedHocSinh.GioiTinh = GetGioiTinh();
            selectedHocSinh.DiaChi = textBoxDiaChi.Text;
            selectedHocSinh.DienThoaiPhuHuynh = textBoxDTPH.Text;
            selectedHocSinh.MaLopHoc = Convert.ToInt32(comboBoxLopHoc.SelectedValue);

            try
            {
                hocsinhRepository.UpdateHocSinh(selectedHocSinh);
                MessageBox.Show("Cập nhật học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHocSinhData();
                ClearForm();
                selectedHocSinh = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật học sinh: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private HocSinh selectedHocSinh = null;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedHocSinh = new HocSinh
                {
                    MaHocSinh = Convert.ToInt32(row.Cells["MaHocSinh"].Value),
                    HoTen = row.Cells["HoTen"].Value.ToString(),
                    NgaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value),
                    GioiTinh = row.Cells["GioiTinh"].Value.ToString(),
                    DiaChi = row.Cells["DiaChi"].Value.ToString(),
                    DienThoaiPhuHuynh = row.Cells["DienThoaiPhuHuynh"].Value.ToString(),
                    MaLopHoc = Convert.ToInt32(row.Cells["MaLopHoc"].Value)
                };

                textBoxHoTen.Text = selectedHocSinh.HoTen;
                dateTimePicker1.Value = selectedHocSinh.NgaySinh;
                rdbNam.Checked = selectedHocSinh.GioiTinh == "Nam";
                rdbNu.Checked = selectedHocSinh.GioiTinh == "Nữ";
                textBoxDiaChi.Text = selectedHocSinh.DiaChi;
                textBoxDTPH.Text = selectedHocSinh.DienThoaiPhuHuynh;
                comboBoxLopHoc.SelectedValue = selectedHocSinh.MaLopHoc;
            }
        }

    }
}
