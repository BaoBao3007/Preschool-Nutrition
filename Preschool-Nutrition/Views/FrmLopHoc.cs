using Preschool_Nutrition.Controllers;
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
using System.Collections.Generic;


namespace Preschool_Nutrition.Views
{
    public partial class FrmLopHoc : Form
    {
        private LopHocController lopHocController;
        private GiaoVienController giaoVienController;
        public FrmLopHoc()
        {
            InitializeComponent();
            lopHocController = new LopHocController();
            giaoVienController = new GiaoVienController();
            LoadCboGiaoVien();
            LoadData();
        }
        private void LoadCboGiaoVien()
        {
            var danhSachGiaoVien = giaoVienController.GetAllHoTenGiaoVien();
            cbo_gv.DataSource = danhSachGiaoVien;
            cbo_gv.DisplayMember = "HoTen";
            cbo_gv.ValueMember = "MaGiaoVien";
            cbo_gv.SelectedIndex = -1;
        }
        private void LoadData()
        {
            var lopHocs = lopHocController.GetAllLopHoc();
            dgv_lophoc.DataSource = null;
            dgv_lophoc.DataSource = lopHocs;
            dgv_lophoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lophoc.Columns["MaGiaoVienChuNhiem"].Visible = false;
            dgv_lophoc.Columns["MaLopHoc"].Visible = false;
            dgv_lophoc.Columns["GiaoVienChuNhiems"].Visible = false;
            dgv_lophoc.Columns["HocSinhs"].Visible = false;
            dgv_lophoc.Columns["TenLopHoc"].HeaderText = "Tên lớp học";
            dgv_lophoc.Columns["NamHoc"].HeaderText = "Năm học";
            dgv_lophoc.Columns["HoTenGiaoVienChuNhiem"].HeaderText = "Giáo viên chủ nhiệm";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tenlophoc.Text) || string.IsNullOrWhiteSpace(txt_namhoc.Text) || cbo_gv.SelectedValue == null)
            {
                string errorMessage =
                    string.IsNullOrWhiteSpace(txt_tenlophoc.Text) ? "Tên lớp học không được để trống!" :
                    string.IsNullOrWhiteSpace(txt_namhoc.Text) ? "Năm học không được để trống!" :
                    "Vui lòng chọn giáo viên chủ nhiệm!";

                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lopHoc = new LopHoc
            {
                TenLopHoc = txt_tenlophoc.Text,
                NamHoc = txt_namhoc.Text,
                MaGiaoVienChuNhiem = (int)cbo_gv.SelectedValue
            };
            lopHocController.AddLopHoc(lopHoc);
            MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void dgv_lophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgv_lophoc.Rows[e.RowIndex];
                txt_tenlophoc.Text = selectedRow.Cells["TenLopHoc"].Value.ToString();
                txt_namhoc.Text = selectedRow.Cells["NamHoc"].Value.ToString();
                cbo_gv.SelectedValue = selectedRow.Cells["MaGiaoVienChuNhiem"].Value;
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (dgv_lophoc.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa lớp học này?",
                                                     "Xác nhận sửa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int maLopHoc = (int)dgv_lophoc.SelectedRows[0].Cells["MaLopHoc"].Value;
                    string tenLopHoc = txt_tenlophoc.Text;
                    string namHoc = txt_namhoc.Text;
                    int maGiaoVienChuNhiem = (int)((GiaoVien)cbo_gv.SelectedItem).MaGiaoVien;
                    var lopHoc = new LopHoc
                    {
                        MaLopHoc = maLopHoc,
                        TenLopHoc = tenLopHoc,
                        NamHoc = namHoc,
                        MaGiaoVienChuNhiem = maGiaoVienChuNhiem
                    };

                    lopHocController.UpdateLopHoc(lopHoc);
                    LoadData();
                    MessageBox.Show("Sửa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_lophoc.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int maLopHoc = (int)dgv_lophoc.SelectedRows[0].Cells["MaLopHoc"].Value;
                    lopHocController.DeleteLopHoc(maLopHoc);
                    LoadData();
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                                 "Xác nhận thoát",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
