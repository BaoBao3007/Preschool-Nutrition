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
            LoadData();  // Gọi hàm tải dữ liệu khi khởi tạo form
        }
        private void LoadData()
        {
            try
            {
                // Gọi phương thức để lấy danh sách món ăn
                List<MonAn> monAnList = monAnRepository.GetAllMonAn();

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
                    Width = 50
                });

                dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GhiChu",
                    HeaderText = "Ghi Chú",
                    Width = 380
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

        private void dataGridViewMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridViewMonAn.CurrentRow != null && dataGridViewMonAn.CurrentRow.Index != -1)
            {
                //// Kiểm tra chỉ số cột thay vì tên cột để tránh lỗi nếu tên cột không khớp
                //txtTenMon.Text = dataGridViewMonAn.CurrentRow.Cells[0].Value.ToString();  // Cột 0: Tên Món Ăn
                //txtLoaiMon.Text = dataGridViewMonAn.CurrentRow.Cells[1].Value.ToString(); // Cột 1: Loại Món Ăn
                //txtCalo.Text = dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString();    // Cột 2: Calo
                //txtGhiChu.Text = dataGridViewMonAn.CurrentRow.Cells[3].Value.ToString();  // Cột 3: Ghi Chú
                // Kiểm tra xem có hàng nào được chọn không
                if (dataGridViewMonAn.CurrentRow != null && dataGridViewMonAn.CurrentRow.Index != -1)
                {
                    // Lấy mã món ăn từ cột ẩn
                    maMonAn = int.Parse(dataGridViewMonAn.CurrentRow.Cells[0].Value.ToString()); // Cột 0: Mã Món Ăn (cột ẩn)

                    txtTenMon.Text = dataGridViewMonAn.CurrentRow.Cells[1].Value.ToString();  // Cột 1: Tên Món Ăn
                    txtLoaiMon.Text = dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString(); // Cột 2: Loại Món Ăn
                    txtCalo.Text = dataGridViewMonAn.CurrentRow.Cells[3].Value.ToString();    // Cột 3: Calo
                    txtGhiChu.Text = dataGridViewMonAn.CurrentRow.Cells[4].Value.ToString();  // Cột 4: Ghi Chú
                }

            }
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Tạo đối tượng món ăn mới
                MonAn newMonAn = new MonAn
                {
                    TenMonAn = txtTenMon.Text,
                    LoaiMonAn = txtLoaiMon.Text,
                    Calo = float.Parse(txtCalo.Text),  // Chuyển đổi từ string sang float
                    GhiChu = txtGhiChu.Text
                };

                // Gọi phương thức thêm món ăn
                monAnRepository.AddMonAn(newMonAn);

                // Tải lại dữ liệu để cập nhật DataGridView
                LoadData();

                // Thông báo thành công
                MessageBox.Show("Thêm món ăn thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Calo phải là một số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message);
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Lấy tên món ăn từ txtTenMon
                string tenMonAn = txtTenMon.Text.Trim();

                // Kiểm tra tên món ăn có rỗng không
                if (string.IsNullOrWhiteSpace(tenMonAn))
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn để xóa.");
                    return;
                }

                // Xác nhận trước khi xóa
                var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa món ăn '{tenMonAn}'?",
                                                     "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Gọi phương thức xóa món ăn theo tên
                    monAnRepository.DeleteMonAnByName(tenMonAn);

                    // Tải lại dữ liệu để cập nhật DataGridView
                    LoadData();

                    // Thông báo thành công
                    MessageBox.Show("Xóa món ăn thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa món ăn: " + ex.Message);
            }
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Tạo đối tượng món ăn mới
                MonAn updatedMonAn = new MonAn
                {
                    MaMonAn = maMonAn,  // Sử dụng mã món ăn đã lưu
                    TenMonAn = txtTenMon.Text,
                    LoaiMonAn = txtLoaiMon.Text,
                    Calo = float.Parse(txtCalo.Text),  // Chuyển đổi từ string sang float
                    GhiChu = txtGhiChu.Text
                };

                // Gọi phương thức sửa món ăn
                monAnRepository.UpdateMonAn(updatedMonAn);

                // Tải lại dữ liệu để cập nhật DataGridView
                LoadData();

                // Thông báo thành công
                MessageBox.Show("Sửa món ăn thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Calo phải là một số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa món ăn: " + ex.Message);
            }
        }

        private void btnTim_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Lấy giá trị tìm kiếm từ txtTim
                string searchTerm = txtTim.Text.Trim();

                // Kiểm tra xem giá trị tìm kiếm có rỗng không
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi phương thức tìm kiếm từ MonAnRepository
                List<MonAn> searchResults = monAnRepository.SearchMonAn(searchTerm);

                // Kiểm tra kết quả tìm kiếm
                if (searchResults.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy món ăn nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Cập nhật DataGridView với danh sách kết quả tìm kiếm
                    dataGridViewMonAn.DataSource = searchResults;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
