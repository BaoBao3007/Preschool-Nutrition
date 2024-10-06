using Preschool_Nutrition.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Preschool_Nutrition.Repositories;
namespace Preschool_Nutrition.Views
{
    public partial class FrmGiaoVien : Form

    {
        private List<GiaoVien> dsGiaoVien;
        private GiaoVienRepository giaoVienRepository;

        public FrmGiaoVien()
        {
            InitializeComponent();
            this.Size = new Size(1024, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            dsGiaoVien = new List<GiaoVien>();
            giaoVienRepository = new GiaoVienRepository();


            LoadGiaoVienData();
            InitializeDataGridView();
            InitializeComboBox();

        }


        private void InitializeDataGridView()
        {
          
        }
        private void InitializeComboBox()
        {
           
            List<string> dsChucVu = new List<string>()
            {
                "Giáo viên chủ nhiệm",
                "Giáo viên bộ môn",
                "Tổ trưởng",
                "Hiệu trưởng",
                "Phó hiệu trưởng"
            };

         
            comboBoxChucVu.DataSource = dsChucVu;

            
            comboBoxChucVu.SelectedIndex = 0;
        }

        private void LoadGiaoVienData()
        {
            try
            {
                dsGiaoVien = giaoVienRepository.GetAllGiaoVien();
                if (dsGiaoVien.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu giáo viên để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu giáo viên: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(textBoxHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên giáo viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                GiaoVien updatedTeacher = new GiaoVien
                {
                    HoTen = textBoxHoTen.Text,
                    NgaySinh = dateTimePickerNgaySinh.Value,
                    GioiTinh = GetSelectedGender(),
                    ChucVu = comboBoxChucVu.SelectedItem.ToString(),
                    DiaChi = textBoxDiaChi.Text,
                    DienThoai = textBoxDienThoai.Text,
                };

               
                giaoVienRepository.UpdateGiaoVienByHoTen(updatedTeacher);

                MessageBox.Show("Cập nhật giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGiaoVienData(); 
                ClearFormFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(textBoxHoTen.Text))
                {
                    MessageBox.Show("Vui lòng chọn một giáo viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                string hoTen = textBoxHoTen.Text;

              
                bool isAssigned = giaoVienRepository.IsGiaoVienAssigned(hoTen);

                if (isAssigned)
                {
                    MessageBox.Show(".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                giaoVienRepository.DeleteGiaoVienByHoTen(hoTen);

                MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGiaoVienData();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xóa giáo viên vì vẫn còn đang được phân công dạy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien newTeacher = new GiaoVien
                {
                    HoTen = textBoxHoTen.Text,
                    NgaySinh = dateTimePickerNgaySinh.Value,
                    GioiTinh = GetSelectedGender(),
                    ChucVu = comboBoxChucVu.SelectedItem.ToString(),
                    DiaChi = textBoxDiaChi.Text,
                    DienThoai = textBoxDienThoai.Text,
                };

                giaoVienRepository.AddGiaoVien(newTeacher);

                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGiaoVienData();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string GetSelectedGender()
        {
            if (rdbNam.Checked)
                return "Nam";
            else if (rdbNu.Checked)
                return "Nữ";
            else
                return "Khác";
        }

        private void ClearFormFields()
        {
            textBoxHoTen.Clear();
            dateTimePickerNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbKhac.Checked = false;
            textBoxDiaChi.Clear();
            textBoxDienThoai.Clear();
            comboBoxChucVu.SelectedIndex = 0; 
        }


        private void RefreshDataGridView()
        {
            dgv_gv.DataSource = null;
            dgv_gv.DataSource = dsGiaoVien.Select(gv => new
            {
                HoTen = gv.HoTen,
                NgaySinh = gv.NgaySinh,
                GioiTinh = gv.GioiTinh,
                ChucVu = gv.ChucVu,
                DiaChi = gv.DiaChi,
                DienThoai = gv.DienThoai
            }).ToList(); 

           
            if (dgv_gv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trong DataGridView.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Dgv_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadGiaoVienData();
        }

        private void dgv_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                var selectedRow = dgv_gv.Rows[e.RowIndex];

                
                var hoTen = selectedRow.Cells["HoTen"].Value.ToString();

               
                textBoxHoTen.Text = hoTen;
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);

                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    rdbNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    rdbNu.Checked = true;
                else
                    rdbKhac.Checked = true;

                comboBoxChucVu.SelectedItem = selectedRow.Cells["ChucVu"].Value.ToString();
                textBoxDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                textBoxDienThoai.Text = selectedRow.Cells["DienThoai"].Value.ToString();

            }
        }

        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFormFields(); 
            LoadGiaoVienData();
        }
    }
}
