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

            txt_mgv.ReadOnly = true;
            LoadGiaoVienData();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            if (dgv_gv == null)
            {
                dgv_gv = new DataGridView();
                dgv_gv.Location = new Point(100, 400);
                dgv_gv.Size = new Size(800, 300);
                this.Controls.Add(dgv_gv);
            }


            //if (dgv_gv.Columns.Count == 0)
            //{
            //    dgv_gv.Columns.Add("MaGiaoVien", "Mã Giáo Viên");
            //    dgv_gv.Columns.Add("HoTen", "Họ Tên");
            //    dgv_gv.Columns.Add("NgaySinh", "Ngày Sinh");
            //    dgv_gv.Columns.Add("GioiTinh", "Giới Tính");
            //    dgv_gv.Columns.Add("ChucVu", "Chức Vụ");
            //    dgv_gv.Columns.Add("DiaChi", "Địa Chỉ");
            //    dgv_gv.Columns.Add("DienThoai", "Điện Thoại");
            //}


            dgv_gv.AllowUserToAddRows = false;
            dgv_gv.ReadOnly = true;
        }
        private void LoadGiaoVienData()
        {
            dsGiaoVien = giaoVienRepository.GetAllGiaoVien();
            RefreshDataGridView();
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

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien newTeacher = new GiaoVien
                {
                    MaGiaoVien = GenerateMaGiaoVien(),
                    HoTen = textBoxHoTen.Text,
                    NgaySinh = dateTimePickerNgaySinh.Value,
                    GioiTinh = GetSelectedGender(),
                    ChucVu = textBoxChucVu.Text,
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
        private string GenerateMaGiaoVien()
        {
            int soLuongGiaoVien = dsGiaoVien.Count;
            return $"GV{(soLuongGiaoVien + 1).ToString("0")}";
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
            textBoxChucVu.Clear();
            textBoxDiaChi.Clear();
            textBoxDienThoai.Clear();
        }

       
        private void RefreshDataGridView()
        {
            dgv_gv.DataSource = null;
            dgv_gv.DataSource = dsGiaoVien;
        }

        private void Dgv_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
