using MySql.Data.MySqlClient;
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

    public partial class FrmChiTietMonAn_NguyenLieuMonAn : Form
    {
        private MonAnRepository monAnRepository;

        private NguyenLieuRepository nguyenLieuRepository;
        public FrmChiTietMonAn_NguyenLieuMonAn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            monAnRepository = new MonAnRepository(); // Khởi tạo repository
            nguyenLieuRepository = new NguyenLieuRepository();
            InitializeDataGridView();
            InitializeNguyenLieuDataGridView();
            LoadNguyenLieu();
            cboNguyenLieu.SelectedIndexChanged += cboNguyenLieu_SelectedIndexChanged;
            LoadBuoi();
            LoadLoaiMon();
        }

        private void LoadLoaiMon()
        {
            // Thêm các giá trị cố định vào ComboBox
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
        private void LoadNguyenLieu()
        {
            try
            {
                // Lấy danh sách tên nguyên liệu từ repository
                List<string> tenNguyenLieuList = nguyenLieuRepository.GetAllTenNguyenLieu();

                // Xóa các mục cũ trong ComboBox
                cboNguyenLieu.Items.Clear();

                // Thêm các tên nguyên liệu vào ComboBox
                cboNguyenLieu.Items.AddRange(tenNguyenLieuList.ToArray());

                // Thiết lập chế độ tự động hoàn thành
                cboNguyenLieu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboNguyenLieu.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nguyên liệu: " + ex.Message);
            }
        }

        private void cboNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNguyenLieu.SelectedItem != null)
            {
                string tenNguyenLieu = cboNguyenLieu.SelectedItem.ToString();
                string dvt = nguyenLieuRepository.GetDonViTinhByName(tenNguyenLieu);

                // Giả sử bạn có một TextBox để hiển thị DVT
                txtDVT.Text = dvt; // Gán giá trị DVT vào TextBox
            }
        }

        private void InitializeDataGridView()
        {
            // Xóa tất cả các cột cũ trước khi thêm mới
            dataGridViewMonAn.Columns.Clear();
            dataGridViewMonAn.DataSource=null;
            dataGridViewMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Thêm cột mã món ăn (cột ẩn)
            var maMonAnColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaMonAn",
                HeaderText = "Mã Món Ăn",
                Width = 50,
                Visible = false // Ẩn cột này
            };
            dataGridViewMonAn.Columns.Add(maMonAnColumn);

            // Thêm các cột khác mà bạn muốn hiển thị
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
                Width = 370
            });

            // Thêm cột Buổi
            dataGridViewMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Buoi",
                HeaderText = "Buổi",
                Width = 60
            });
        }
        private void InitializeNguyenLieuDataGridView()
        {
            // Xóa tất cả các cột cũ trước khi thêm mới
            dataGridViewNguyenLieuMonAn.Columns.Clear();
            // dataGridViewNguyenLieuMonAn.AutoGenerateColumns = false;
            // Thêm cột mã món ăn (cột ẩn)
            dataGridViewNguyenLieuMonAn.DataSource = null;
            dataGridViewNguyenLieuMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var maMonAnColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaMonAn", // Chắc chắn rằng thuộc tính này có trong mô hình
                HeaderText = "Mã Món Ăn",
                Width = 50,
                Visible = false // Ẩn cột này
            };
            dataGridViewNguyenLieuMonAn.Columns.Add(maMonAnColumn);

            // Thêm cột mã nguyên liệu (cột ẩn)
            var maNguyenLieuColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaNguyenLieu",
                HeaderText = "Mã Nguyên Liệu",
                Width = 120
                //Visible = false // Ẩn cột này
            };
            dataGridViewNguyenLieuMonAn.Columns.Add(maNguyenLieuColumn);

            //Thêm các cột khác mà bạn muốn hiển thị
            dataGridViewNguyenLieuMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenNguyenLieu", // Chắc chắn rằng thuộc tính này có trong mô hình
                HeaderText = "Tên Nguyên Liệu",
                Width = 180
            });

            dataGridViewNguyenLieuMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DVT", // Đơn vị tính
                HeaderText = "Đơn Vị Tính",
                Width = 120
            });
            dataGridViewNguyenLieuMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GhiChu",
                HeaderText = "Ghi Chú",
                Width = 200
            });
            dataGridViewNguyenLieuMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "KhoiLuong",
                HeaderText = "Khối Lượng",
                Width = 120
            });


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void LoadNguyenLieuMonAn(int maMonAn)
        {
            try
            {
                // Gọi phương thức từ repository để lấy nguyên liệu
                List<NguyenLieuMonAn> nguyenLieuList = monAnRepository.GetNguyenLieuByMonAn(maMonAn);

                // Xóa các dòng cũ trước khi thêm mới
                dataGridViewNguyenLieuMonAn.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (var nguyenLieu in nguyenLieuList)
                {
                    dataGridViewNguyenLieuMonAn.Rows.Add(
                        nguyenLieu.MaMonAn,      // Mã Món Ăn
                        nguyenLieu.MaNguyenLieu, // Mã Nguyên Liệu
                        nguyenLieu.TenNguyenLieu, // Tên Nguyên Liệu
                        nguyenLieu.DVT,          // Đơn Vị Tính
                        nguyenLieu.GhiChu,       // Ghi Chú
                        nguyenLieu.KhoiLuong     // Khối Lượng
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nguyên liệu: " + ex.Message);
            }
        }


        // Cập nhật phương thức AddMonAn để gọi LoadNguyenLieuMonAn
        public void AddMonAn(int maMonAn, string tenMonAn, string loaiMonAn, float calo, string ghiChu, string buoi)
        {
            dataGridViewMonAn.Rows.Clear();
            //MessageBox.Show($"Mã món ăn: {maMonAn}");

            // Đảm bảo số cột trong DataGridView đã được thiết lập
            if (dataGridViewMonAn.Columns.Count == 0)
            {
                InitializeDataGridView();
            }

            // Thêm dòng mới
            dataGridViewMonAn.Rows.Add(maMonAn, tenMonAn, loaiMonAn, calo, ghiChu, buoi);
            LoadNguyenLieuMonAn(maMonAn);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy tên nguyên liệu từ ComboBox
            string tenNguyenLieu = cboNguyenLieu.SelectedItem?.ToString();



            // Lấy mã món ăn từ ô đầu tiên của dòng đầu tiên
            int maMonAn = Convert.ToInt32(dataGridViewNguyenLieuMonAn.Rows[0].Cells[0].Value);

            // Kiểm tra tên nguyên liệu có hợp lệ không
            if (string.IsNullOrEmpty(tenNguyenLieu))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo repository
            MonAnRepository repository = new MonAnRepository();

            try
            {
                // Gọi phương thức để xóa nguyên liệu món ăn
                repository.DeleteNguyenLieuMonAn(tenNguyenLieu, maMonAn);
                MessageBox.Show("Nguyên liệu đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách nguyên liệu nếu cần
                LoadNguyenLieuMonAn(maMonAn); // Gọi hàm để tải lại danh sách nguyên liệu nếu cần
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa nguyên liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.OpenChildForm(new FrmMonAn());
        }

        private void txtThemNL_Click(object sender, EventArgs e)
        {
            if (cboNguyenLieu.SelectedItem != null && float.TryParse(txtKhoiLuong.Text, out float khoiLuong))
            {
                string tenNguyenLieu = cboNguyenLieu.SelectedItem.ToString();

                // Kiểm tra xem có dòng nào đang được chọn trong DataGridView không
                if (dataGridViewMonAn.CurrentRow != null)
                {
                    // Lấy mã món ăn từ chỉ số cột 0
                    if (dataGridViewMonAn.CurrentRow.Cells[0].Value != null)
                    {
                        int maMonAn = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[0].Value);
                        int maNguyenLieu = nguyenLieuRepository.GetMaNguyenLieuByName(tenNguyenLieu);
                        string dvt = txtDVT.Text; // Đơn vị tính đã được lấy từ ComboBox
                        string ghiChu = txtGhiChu.Text; // Ghi chú từ TextBox

                        // Kiểm tra xem mã nguyên liệu có hợp lệ không
                        if (maNguyenLieu > 0)
                        {
                            // Tạo đối tượng nguyên liệu món ăn
                            NguyenLieuMonAn nguyenLieuMonAn = new NguyenLieuMonAn
                            {
                                MaMonAn = maMonAn,
                                MaNguyenLieu = maNguyenLieu,
                                DVT = dvt,
                                KhoiLuong = khoiLuong,
                                GhiChu = ghiChu
                            };

                            // Thêm nguyên liệu vào bảng NguyenLieuMonAn
                            monAnRepository.AddNguyenLieuMonAn(nguyenLieuMonAn);

                            // Cập nhật DataGridView để hiển thị nguyên liệu vừa thêm
                            LoadNguyenLieuMonAn(maMonAn);

                            // Thông báo thành công
                            MessageBox.Show("Nguyên liệu đã được thêm thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Nguyên liệu không hợp lệ. Vui lòng chọn một nguyên liệu đúng.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã món ăn không hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một món ăn để thêm nguyên liệu.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu và nhập khối lượng hợp lệ.");
            }
        }

        private void dataGridViewNguyenLieuMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn trong DataGridView không
            if (dataGridViewNguyenLieuMonAn.CurrentRow != null)
            {
                // Lấy thông tin từ dòng đang chọn
                int maMonAn = Convert.ToInt32(dataGridViewNguyenLieuMonAn.CurrentRow.Cells[0].Value);
                int maNguyenLieu = Convert.ToInt32(dataGridViewNguyenLieuMonAn.CurrentRow.Cells[1].Value);
                string tenNguyenLieu = dataGridViewNguyenLieuMonAn.CurrentRow.Cells[2].Value.ToString();
                string dvt = dataGridViewNguyenLieuMonAn.CurrentRow.Cells[3].Value.ToString();
                float khoiLuong = Convert.ToSingle(dataGridViewNguyenLieuMonAn.CurrentRow.Cells[5].Value);
                string ghiChu = dataGridViewNguyenLieuMonAn.CurrentRow.Cells[4].Value.ToString();

                // Điền thông tin vào các TextBox
                txtDVT.Text = dvt;
                txtKhoiLuong.Text = khoiLuong.ToString();
                txtGhiChu.Text = ghiChu;
                cboNguyenLieu.Text = tenNguyenLieu;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn trong DataGridView nguyên liệu không
            if (dataGridViewNguyenLieuMonAn.CurrentRow != null)
            {
                // Lấy thông tin từ dòng đang chọn
                int maMonAn = Convert.ToInt32(dataGridViewNguyenLieuMonAn.CurrentRow.Cells[0].Value);
                string tenNguyenLieuCu = dataGridViewNguyenLieuMonAn.CurrentRow.Cells[2].Value.ToString(); // Tên nguyên liệu cũ

                // Lấy mã nguyên liệu mới dựa vào tên nguyên liệu đã chỉnh sửa
                int maNguyenLieu = nguyenLieuRepository.GetMaNguyenLieuByName(cboNguyenLieu.SelectedItem.ToString());

                // Tạo đối tượng nguyên liệu món ăn mới với thông tin đã chỉnh sửa
                NguyenLieuMonAn nguyenLieuMonAn = new NguyenLieuMonAn
                {
                    MaMonAn = maMonAn,
                    MaNguyenLieu = maNguyenLieu,
                    DVT = txtDVT.Text,
                    KhoiLuong = float.Parse(txtKhoiLuong.Text),
                    GhiChu = txtGhiChu.Text
                };

                // Gọi phương thức sửa nguyên liệu trong repository
                monAnRepository.UpdateNguyenLieuMonAn(nguyenLieuMonAn, tenNguyenLieuCu);

                // Cập nhật lại DataGridView để hiển thị thông tin đã sửa
                LoadNguyenLieuMonAn(maMonAn);

                // Thông báo thành công
                MessageBox.Show("Nguyên liệu đã được cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu để sửa.");
            }
        }

        private void dataGridViewMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn trong DataGridView không
            if (dataGridViewMonAn.CurrentRow != null)
            {
                // Lấy thông tin từ dòng đang chọn
                int maMonAn = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[0].Value); // Mã món ăn
                string tenMonAn = dataGridViewMonAn.CurrentRow.Cells[1].Value.ToString(); // Tên món ăn
                string loaiMonAn = dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString(); // Loại món ăn
                float calo = Convert.ToSingle(dataGridViewMonAn.CurrentRow.Cells[3].Value); // Calo
                string ghiChu = dataGridViewMonAn.CurrentRow.Cells[4].Value.ToString(); // Ghi chú
                string buoi = dataGridViewMonAn.CurrentRow.Cells[5].Value.ToString(); // Buổi

                // Hiển thị thông tin vào các TextBox hoặc các điều khiển khác
                txtTenMon.Text = tenMonAn; // Giả sử bạn có một TextBox để hiển thị tên món ăn
                cboLoaiMon.Text = loaiMonAn; // TextBox cho loại món ăn
                txtCalo.Text = calo.ToString(); // TextBox cho calo
                txtGC.Text = ghiChu; // TextBox cho ghi chú
                cboBuoi.Text = buoi; // TextBox cho buổi
            }
        }
        private void LoadData()
        {
            // Lấy mã món ăn từ dòng đang chọn trong DataGridView món ăn
            if (dataGridViewMonAn.CurrentRow != null)
            {
                int maMonAn = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[0].Value);

                // Tải lại danh sách nguyên liệu cho món ăn đó
                LoadNguyenLieuMonAn(maMonAn);
            }
        }
        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (dataGridViewMonAn.CurrentRow != null)
            {
                int maMonAn = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[0].Value);

                MonAn monAn = new MonAn
                {
                    MaMonAn = maMonAn,
                    TenMonAn = txtTenMon.Text,
                    LoaiMonAn = cboLoaiMon.Text,
                    Calo = float.Parse(txtCalo.Text),
                    GhiChu = txtGC.Text,
                    Buoi = cboBuoi.Text
                };

                monAnRepository.UpdateMonAn(monAn); // Gọi phương thức cập nhật
                MessageBox.Show("Cập nhật món ăn thành công!");
                LoadData(); // Tải lại dữ liệu để cập nhật DataGridView
                this.Close();
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn trong DataGridView không
            if (dataGridViewMonAn.CurrentRow != null)
            {
                // Lấy mã món ăn từ ô đầu tiên của dòng đang chọn
                int maMonAn = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[0].Value);

                // Khởi tạo repository
                monAnRepository = new MonAnRepository();

                try
                {
                    // Gọi phương thức để xóa món ăn
                    monAnRepository.DeleteMonAn(maMonAn);
                    MessageBox.Show("Món ăn đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form sau khi xóa thành công
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa món ăn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
