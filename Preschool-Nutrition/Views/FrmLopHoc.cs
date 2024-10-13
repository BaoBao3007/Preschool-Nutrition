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
using System.Collections.Generic; // Để sử dụng List<T>


namespace Preschool_Nutrition.Views
{
    public partial class FrmLopHoc : Form
    {
        private List<GiaoVien> dsGiaoVien;
        private List<LopHoc> dsLopHoc;
        private GiaoVienRepository giaoVienRepository;
        private lopHocRepository lopHocRepository;

        public FrmLopHoc()
        {
            InitializeComponent();
            giaoVienRepository = new GiaoVienRepository();
            lopHocRepository = new lopHocRepository();
            dsGiaoVien = new List<GiaoVien>();
            dsLopHoc = new List<LopHoc>();

            LoadGiaoVienData();
            LoadLopHocData();
            //InitializeComboBox();
        }

        private void InitializeComboBox()
        {
           
            List<string> dsChucVu = new List<string>
            {
                "Giáo viên chủ nhiệm",
                "Giáo viên bộ môn",
                "Tổ trưởng",
                "Hiệu trưởng",
                "Phó hiệu trưởng"
            };

            comboBoxGV.DataSource = dsChucVu;
            comboBoxGV.SelectedIndex = 0; 
        }

        private void LoadGiaoVienData()
        {
            try
            {
         
                dsGiaoVien = giaoVienRepository.GetAllGiaoVien();

                if (dsGiaoVien.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu giáo viên để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

           
                comboBoxGV.DataSource = dsGiaoVien;
                comboBoxGV.DisplayMember = "HoTen";
                comboBoxGV.ValueMember = "MaGiaoVien"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu giáo viên: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadLopHocData()
        {
            try
            {
                
                dsLopHoc = lopHocRepository.GetAllLopHoc();

                if (dsLopHoc.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu lớp học để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            
                var lopHocData = dsLopHoc.Select(lh => new
                {
                    TenLopHoc = lh.TenLopHoc,
                    NamHoc = lh.NamHoc,
                    MaGiaoVienChuNhiem = lh.MaGiaoVienChuNhiem,
                    GiaoVien = dsGiaoVien.FirstOrDefault(gv => gv.MaGiaoVien == lh.MaGiaoVienChuNhiem)?.HoTen 
                }).ToList();

          
                dataGridView1.DataSource = lopHocData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu lớp học: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxTenLopHoc.Text) ||
                    string.IsNullOrEmpty(textBoxNamHoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LopHoc newLop = new LopHoc
                {
                    TenLopHoc = textBoxTenLopHoc.Text,
                    NamHoc = textBoxNamHoc.Text,
                    MaGiaoVienChuNhiem = (int)comboBoxGV.SelectedValue 
                };

                lopHocRepository.AddLopHoc(newLop);
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLopHocData(); 
                ClearFormFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Xác nhận xóa lớp học
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                string tenLopHoc = textBoxTenLopHoc.Text;

                lopHocRepository.DeleteLopHocByTen(tenLopHoc);
                MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLopHocData(); // Tải lại dữ liệu sau khi xóa
                ClearFormFields(); // Xóa các trường nhập liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            textBoxTenLopHoc.Clear();
            textBoxNamHoc.Clear();
            comboBoxGV.SelectedIndex = 0; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                textBoxTenLopHoc.Text = selectedRow.Cells["TenLopHoc"].Value.ToString();
                textBoxNamHoc.Text = selectedRow.Cells["NamHoc"].Value.ToString();

                int maGiaoVien = Convert.ToInt32(selectedRow.Cells["MaGiaoVienChuNhiem"].Value);

                comboBoxGV.SelectedValue = maGiaoVien;
            }
            }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void comboBoxGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
