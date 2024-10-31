using MySql.Data.MySqlClient;
using Preschool_Nutrition.Controllers;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Preschool_Nutrition.Views
{
    public partial class FrmThucDon : Form
    {
        private DateTime? selectedNgay = null;
        private string selectedBuoi = null;
        private ThucDonController controller;
        public FrmThucDon()
        {
            InitializeComponent();
            controller = new ThucDonController();
            LoadThucDon();
            LoadComboBoxData();
            cbo_buoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ngay.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadThucDon()
        {
            List<ThucDon> thucdons;
            if (selectedNgay == null && string.IsNullOrEmpty(selectedBuoi))
            {
                thucdons = controller.GetAllThucDon();
            }
            else
            {
                thucdons = controller.GetThucDonByFilter(selectedNgay, selectedBuoi);
            }
            dgv_thucdon.DataSource = null;
            dgv_thucdon.DataSource = thucdons;
            dgv_thucdon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_thucdon.Columns["ChiTietThucDons"].Visible = false;
            dgv_thucdon.Columns["ThucDonTuan"].Visible = false;
            dgv_thucdon.Columns["MaThucDonTuan"].Visible = false;
            dgv_thucdon.Columns["MaThucDon"].HeaderText = "Mã thực đơn";
            dgv_thucdon.Columns["SoLuongMonAn"].HeaderText = "Số lượng món ăn";
            dgv_thucdon.Columns["Ngay"].HeaderText = "Ngày";
            dgv_thucdon.Columns["Buoi"].HeaderText = "Buổi";
            dgv_thucdon.Columns["MaThucDon"].ReadOnly = true;
            dgv_thucdon.Columns["SoLuongMonAn"].ReadOnly = false;
            dgv_thucdon.Columns["Ngay"].ReadOnly = false;
            dgv_thucdon.Columns["Buoi"].ReadOnly = false;
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            if (dgv_thucdon.CurrentRow != null)
            {
                int maThucDon = Convert.ToInt32(dgv_thucdon.CurrentRow.Cells["MaThucDon"].Value);
                var chiTietThucDon = controller.GetChiTietThucDonByMaThucDon(maThucDon);

                dgv_ctthucdon.DataSource = null;
                dgv_ctthucdon.DataSource = chiTietThucDon;
                dgv_ctthucdon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_ctthucdon.Columns["MaThucDon"].HeaderText = "Mã thực đơn";
                dgv_ctthucdon.Columns["MaMonAn"].HeaderText = "Mã món ăn";
                dgv_ctthucdon.Columns["TenMonAn"].HeaderText = "Tên món ăn";
                dgv_ctthucdon.Columns["GhiChu"].HeaderText = "Ghi chú";
                dgv_ctthucdon.Columns["GhiChu"].Visible = false;
                dgv_ctthucdon.Columns["ThucDons"].Visible = false;
                dgv_ctthucdon.Columns["MonAns"].Visible = false;
            }
        }

        private void cbo_ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ngay.SelectedItem is DataRowView rowView && DateTime.TryParse(rowView["Value"].ToString(), out DateTime selectedDate))
            {
                selectedNgay = selectedDate;
            }
            else
            {
                selectedNgay = null;
            }
            LoadThucDon();
        }

        private void cbo_buoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buoi.SelectedItem is DataRowView rowView)
            {
                selectedBuoi = rowView["Value"].ToString();
            }
            else
            {
                selectedBuoi = null;
            }
            LoadThucDon();
        }
        private void LoadComboBoxData()
        {
            var ngayTable = new DataTable();
            ngayTable.Columns.Add("Display", typeof(string));
            ngayTable.Columns.Add("Value", typeof(DateTime));
            var rowFilterByDate = ngayTable.NewRow();
            rowFilterByDate["Display"] = "Lọc theo ngày";
            rowFilterByDate["Value"] = DBNull.Value;
            ngayTable.Rows.Add(rowFilterByDate);
            var ngayList = controller.GetDistinctNgay();
            foreach (var ngay in ngayList)
            {
                ngayTable.Rows.Add(ngay.ToString("dd/MM/yyyy"), ngay);
            }
            var buoiTable = new DataTable();
            buoiTable.Columns.Add("Display", typeof(string));
            buoiTable.Columns.Add("Value", typeof(string));
            var rowFilterByMealTime = buoiTable.NewRow();
            rowFilterByMealTime["Display"] = "Lọc theo buổi";
            rowFilterByMealTime["Value"] = string.Empty;
            buoiTable.Rows.Add(rowFilterByMealTime);
            var buoiList = controller.GetDistinctBuoi();
            foreach (var buoi in buoiList)
            {
                buoiTable.Rows.Add(buoi, buoi);
            }
            cbo_ngay.DataSource = ngayTable;
            cbo_ngay.DisplayMember = "Display";
            cbo_ngay.ValueMember = "Value";
            cbo_ngay.SelectedIndex = 0;

            cbo_buoi.DataSource = buoiTable;
            cbo_buoi.DisplayMember = "Display";
            cbo_buoi.ValueMember = "Value";
            cbo_buoi.SelectedIndex = 0;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn lưu không?", "Xác nhận lưu",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<ThucDon> updatedThucDons = new List<ThucDon>();

                foreach (DataGridViewRow row in dgv_thucdon.Rows)
                {
                    if (row.IsNewRow) continue;

                    var thucDon = new ThucDon
                    {
                        MaThucDon = Convert.ToInt32(row.Cells["MaThucDon"].Value),
                        SoLuongMonAn = Convert.ToInt32(row.Cells["SoLuongMonAn"].Value),
                        Ngay = Convert.ToDateTime(row.Cells["Ngay"].Value),
                        Buoi = row.Cells["Buoi"].Value.ToString()
                    };
                    updatedThucDons.Add(thucDon);
                }
                controller.UpdateThucDons(updatedThucDons);
                MessageBox.Show("Cập nhật thành công!");
                LoadThucDon();
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác lưu.");
            }
        }
        public void DeleteThucDon(int maThucDon)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM ThucDon WHERE MaThucDon = @MaThucDon";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_thucdon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một thực đơn để xóa.");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa thực đơn đã chọn không?", "Xác nhận xóa",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv_thucdon.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        int maThucDon = Convert.ToInt32(row.Cells["MaThucDon"].Value);
                        controller.DeleteThucDon(maThucDon);
                    }
                }
                MessageBox.Show("Xóa thành công!");
                LoadThucDon(); 
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác xóa.");
            }
        }
    }
}
