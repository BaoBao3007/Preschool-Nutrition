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

namespace Preschool_Nutrition.Views
{
    public partial class FrmNguyenLieu : Form
    {
        private NguyenLieuController controller;
        public FrmNguyenLieu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            controller = new NguyenLieuController();
            loadData();
            loadComboBox();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clearText();
            loadData();
        }
        private void loadData()
        {
            var nguyenLieus = controller.GetAllNguyenLieus();
            dgv_nguyenlieu.DataSource = nguyenLieus;
            if (dgv_nguyenlieu.Columns["MaNguyenLieu"] != null)
            {
                dgv_nguyenlieu.Columns["MaNguyenLieu"].Visible = false;
                dgv_nguyenlieu.Columns["NguyenLieuMonAns"].Visible = false;
                dgv_nguyenlieu.Columns["ChiTietPhieuKeChos"].Visible = false;
                dgv_nguyenlieu.Columns["ChiTietPhieuNhaps"].Visible = false;
                dgv_nguyenlieu.Columns["PhieuXuats"].Visible = false;
            }
            dgv_nguyenlieu.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            dgv_nguyenlieu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgv_nguyenlieu.Columns["Gia"].HeaderText = "Giá";
            dgv_nguyenlieu.Columns["LoaiNguyenLieu"].HeaderText = "Loại nguyên liệu";
            dgv_nguyenlieu.Columns["SoLuongTonKho"].HeaderText = "Số lương tồn kho";
            dgv_nguyenlieu.Columns["Calo"].HeaderText = "Calo";

        }
        private void loadComboBox()
        {
            cbo_dvt.Items.Add("Kilogram");
            cbo_dvt.Items.Add("Gram");
            cbo_dvt.Items.Add("Lít");
            cbo_dvt.Items.Add("Chén");
            cbo_dvt.Items.Add("Cái");

            cbo_loaiNL.Items.Add("Thực phẩm");
            cbo_loaiNL.Items.Add("Đồ uống");
            cbo_loaiNL.Items.Add("Gia vị");
            cbo_loaiNL.Items.Add("Thực phẩm chế biến sẵn");
            cbo_loaiNL.Items.Add("Nguyên liệu khác");
        }
        private void clearText()
        {
            txt_tenNL.Text = string.Empty;
            txt_gia.Text = string.Empty;
            txt_calo.Text = string.Empty;
            txt_slt.Text = string.Empty;
            cbo_dvt.Text = string.Empty;
            cbo_loaiNL.Text = string.Empty;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_tenNL.Text) || string.IsNullOrEmpty(cbo_dvt.Text) ||
                    string.IsNullOrEmpty(txt_gia.Text) || string.IsNullOrEmpty(cbo_loaiNL.Text) ||
                    string.IsNullOrEmpty(txt_calo.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NguyenLieu nguyenLieu = new NguyenLieu()
                {
                    TenNguyenLieu = txt_tenNL.Text,
                    DonViTinh = cbo_dvt.Text,
                    Gia = float.Parse(txt_gia.Text),
                    LoaiNguyenLieu = cbo_loaiNL.Text,
                    SoLuongTonKho = string.IsNullOrEmpty(txt_slt.Text) ? 0 : float.Parse(txt_slt.Text),
                    Calo = string.IsNullOrEmpty(txt_calo.Text) ? 0 : float.Parse(txt_calo.Text)
                };
                controller.AddNguyenLieu(nguyenLieu);
                loadData();

                MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_nguyenlieu.CurrentRow != null)
            {
                int maNguyenLieu = Convert.ToInt32(dgv_nguyenlieu.CurrentRow.Cells["MaNguyenLieu"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        controller.DeleteNguyenLieu(maNguyenLieu);
                        loadData();
                        MessageBox.Show("Xóa nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_nguyenlieu.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa thông tin nguyên liệu này không?",
                                                             "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        NguyenLieu nguyenLieu = new NguyenLieu()
                        {
                            MaNguyenLieu = Convert.ToInt32(dgv_nguyenlieu.SelectedRows[0].Cells["MaNguyenLieu"].Value),
                            TenNguyenLieu = txt_tenNL.Text,
                            DonViTinh = cbo_dvt.Text,
                            Gia = float.Parse(txt_gia.Text),
                            LoaiNguyenLieu = cbo_loaiNL.Text,
                            SoLuongTonKho = float.Parse(dgv_nguyenlieu.SelectedRows[0].Cells["SoLuongTonKho"].Value.ToString()),
                            Calo = float.Parse(txt_calo.Text)
                        };
                        controller.UpdateNguyenLieu(nguyenLieu);
                        loadData();

                        MessageBox.Show("Cập nhật thông tin nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgv_nguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nguyenlieu.Rows[e.RowIndex];
                txt_tenNL.Text = row.Cells["TenNguyenLieu"].Value?.ToString();
                cbo_dvt.Text = row.Cells["DonViTinh"].Value?.ToString();
                txt_gia.Text = row.Cells["Gia"].Value?.ToString();
                cbo_loaiNL.Text = row.Cells["LoaiNguyenLieu"].Value?.ToString();
                txt_slt.Text = row.Cells["SoLuongTonKho"].Value?.ToString();
                txt_calo.Text = row.Cells["Calo"].Value?.ToString();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenNguyenLieu = txt_timkiem.Text.Trim();
            var results = controller.TimKiemNguyenLieu(tenNguyenLieu);

            dgv_nguyenlieu.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nguyên liệu nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
