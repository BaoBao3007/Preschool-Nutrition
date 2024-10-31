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

    public partial class FrmMonAn : Form
    {
        private int maMonAn;
        public FrmMonAn()
        {
            InitializeComponent();
            monAnRepository = new MonAnRepository();
            LoadData(); 
            LoadLoaiMon();
            LoadBuoi();
        }
        private void LoadLoaiMon()
        {
            cboLoaiMon.Items.Add("Món Chính");
            cboLoaiMon.Items.Add("Món Canh");
            cboLoaiMon.Items.Add("Món Phụ");
            cboLoaiMon.Items.Add("Món Ăn Kèm");
            cboLoaiMon.Items.Add("Món Ăn Nhẹ");

            cboLoaiMon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLoaiMon.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadBuoi()
        {
            cboBuoi.Items.Add("Sáng");
            cboBuoi.Items.Add("Trưa");
            cboBuoi.Items.Add("Xế");

            cboBuoi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboBuoi.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadData()
        {
            try
            {
                // Gọi phương thức để lấy danh sách món ăn
                List<MonAn> monAnList = monAnRepository.GetAllMonAn();
                dataGridViewMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đặt AutoGenerateColumns thành false để kiểm soát các cột hiển thị
                dataGridViewMonAn.AutoGenerateColumns = false;

                // Xóa hết các cột cũ trước khi thêm mới (nếu cần)
                dataGridViewMonAn.Columns.Clear();

                // Thêm cột mã món ăn (cột ẩn)
                var maMonAnColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaMonAn",
                    HeaderText = "Mã Món Ăn",
                    Width = 50,
                    Visible = false  // Ẩn cột này
                };
                dataGridViewMonAn.Columns.Add(maMonAnColumn);

                // Thêm các cột thủ công cho các thuộc tính mà bạn muốn hiển thị
                dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenMonAn",
                    HeaderText = "Tên Món Ăn",
                    Width = 160
                });

                dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "LoaiMonAn",
                    HeaderText = "Loại Món Ăn",
                    Width = 125
                });

                dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Calo",
                    HeaderText = "Calo",
                    Width = 60
                });

                dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GhiChu",
                    HeaderText = "Ghi Chú",
                    Width = 380
                });

                // Thêm cột Buổi
                dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Buoi",
                    HeaderText = "Buổi",
                    Width = 60  // Điều chỉnh kích thước theo ý muốn
                });

                // Gán danh sách món ăn cho DataGridView

                dataGridViewMonAn.DataSource = monAnList;
                dataGridViewMonAn.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void dataGridViewMonAn_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                // Lấy thông tin về dòng được click trong DataGridView
                var hitTestInfo = dataGridViewMonAn.HitTest(e.X, e.Y);

                // Kiểm tra nếu dòng được chọn hợp lệ (không phải tiêu đề cột)
                if (hitTestInfo.RowIndex >= 0)
                {
                    // Lấy dữ liệu từ dòng được chọn
                    DataGridViewRow row = dataGridViewMonAn.Rows[hitTestInfo.RowIndex];

                    // Lấy giá trị của các cột mà bạn cần (kể cả cột ẩn)
                    int maMonAn = Convert.ToInt32(row.Cells[0].Value);
                    string tenMonAn = row.Cells[1].Value.ToString();
                    string loaiMonAn = row.Cells[2].Value.ToString();
                    float calo = Convert.ToSingle(row.Cells[3].Value);
                    string ghiChu = row.Cells[4].Value.ToString();
                    string buoi = row.Cells[5].Value.ToString();

                    ((MainForm)this.ParentForm).OpenChiTietMonAn(maMonAn, tenMonAn, loaiMonAn, calo, ghiChu, buoi);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox tìm kiếm
                string searchTerm = txtTim.Text.Trim();

                // Gọi phương thức tìm kiếm
                List<MonAn> result = monAnRepository.SearchMonAn(searchTerm);

                // Gán danh sách kết quả vào DataGridView
                dataGridViewMonAn.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm món ăn: " + ex.Message);
            }
        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                string tenMonAn = txtTenMon.Text.Trim();

                // Kiểm tra và lấy giá trị calo
                if (!float.TryParse(txtCalo.Text.Trim(), out float calo) || calo < 0)
                {
                    MessageBox.Show("Số calo không hợp lệ. Vui lòng nhập số lớn hơn hoặc bằng 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không thêm nếu số calo không hợp lệ
                }

                string loaiMonAn = cboLoaiMon.SelectedItem.ToString();
                string buoi = cboBuoi.SelectedItem.ToString();
                string ghiChu = txtGhiChu.Text.Trim();

                // Kiểm tra xem tên món ăn có bị trùng hay không
                var existingMonAnList = monAnRepository.GetAllMonAn(); // Lấy danh sách tất cả món ăn

                if (existingMonAnList.Any(m => m.TenMonAn.Equals(tenMonAn, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Tên món ăn đã tồn tại. Vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không thêm nếu trùng tên
                }

                // Tạo đối tượng món ăn mới
                MonAn newMonAn = new MonAn
                {
                    TenMonAn = tenMonAn,
                    Calo = calo,
                    LoaiMonAn = loaiMonAn,
                    Buoi = buoi,
                    GhiChu = ghiChu
                };

                // Thêm món ăn vào cơ sở dữ liệu
                monAnRepository.ThemMonAn(newMonAn);

                // Tải lại dữ liệu để hiển thị món ăn mới
                LoadData();

                // Thông báo thành công
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các trường nhập liệu sau khi thêm
                txtTenMon.Clear();
                txtCalo.Clear();
                cboLoaiMon.SelectedIndex = 0; // Đặt về giá trị mặc định
                cboBuoi.SelectedIndex = 0; // Đặt về giá trị mặc định
                txtGhiChu.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
