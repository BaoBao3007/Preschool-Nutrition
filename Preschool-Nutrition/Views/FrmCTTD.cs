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
    public partial class FrmCTTD : Form
    {
        public FrmCTTD()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            // Load dữ liệu cho ComboBox Tuần (1 - 4)
        //    comboBoxTuan.Items.Clear(); // Xóa dữ liệu cũ nếu có
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        comboBoxTuan.Items.Add($"Tuần {i}");
        //    }
        //    comboBoxTuan.SelectedIndex = 0; // Chọn tuần đầu tiên mặc định

        //    // Load dữ liệu cho ComboBox Buổi (Sáng, Chiều, Xế)
        //    comboBoxNgay.Items.Clear(); // Xóa dữ liệu cũ nếu có
        //    comboBoxNgay.Items.Add("Sáng");
        //    comboBoxNgay.Items.Add("Chiều");
        //    comboBoxNgay.Items.Add("Xế");
        //    comboBoxNgay.SelectedIndex = 0; // Chọn buổi đầu tiên mặc định
        //}
        //private void LoadMonAnTheoBuoi(string buoi)
        //{
        //    MonAnService service = new MonAnService();
        //    List<string> dsMonAn = new List<string>();

        //    // Chọn loại món ăn tương ứng theo buổi
        //    switch (buoi)
        //    {
        //        case "Sáng":
        //            dsMonAn = service.GetRandomMonAn(buoi, "Món ăn nhẹ", 2);
        //            break;
        //        case "Chiều":
        //            dsMonAn = service.GetRandomMonAn(buoi, "Món uống", 2);
        //            break;
        //        case "Xế":
        //            dsMonAn = service.GetRandomMonAn(buoi, "Món uống", 2);
        //            break;
        //        case "Trưa":
        //            dsMonAn.AddRange(service.GetRandomMonAn(buoi, "Món chính", 1));
        //            dsMonAn.AddRange(service.GetRandomMonAn(buoi, "Món canh", 1));
        //            dsMonAn.AddRange(service.GetRandomMonAn(buoi, "Món tráng miệng", 1));
        //            break;
        //    }

        //    // Tạo bảng dữ liệu để đổ vào DataGridView
        //    DataTable table = new DataTable();
        //    table.Columns.Add("Tên Món Ăn");

        //    // Thêm dữ liệu vào bảng
        //    foreach (var mon in dsMonAn)
        //    {
        //        table.Rows.Add(mon);
        //    }

        //    // Hiển thị dữ liệu trong DataGridView
        //    dataGridViewMonAn.DataSource = table;
        }


        private void btnTTD_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateNgay.Value;
            DateTime ngayKetThuc = dateNgaykt.Value;
            int soLuongMonAn = int.Parse(textBoxSLMA.Text); // Số lượng món ăn nếu cần

            try
            {
                MonAnService monAnService = new MonAnService();
                monAnService.GenerateThucDon(ngayBatDau, ngayKetThuc);
                MessageBox.Show("Tạo thực đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

            //    try
            //    {
            //        // Lấy ngày bắt đầu và ngày kết thúc từ DateTimePicker
            //        DateTime ngayBatDau = dateNgay.Value;
            //        DateTime ngayKetThuc = dateNgaykt.Value;

            //        // Kiểm tra ngày bắt đầu phải trước ngày kết thúc
            //        if (ngayBatDau > ngayKetThuc)
            //        {
            //            MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // Lấy buổi từ ComboBox
            //        string buoi = comboBoxNgay.SelectedItem.ToString();

            //        // Lấy số lượng món ăn từ TextBox
            //        if (!int.TryParse(textBoxSLMA.Text, out int soLuongMonAn))
            //        {
            //            MessageBox.Show("Vui lòng nhập đúng số lượng món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // Tạo một danh sách giả định mã món ăn cho mỗi buổi
            //        // Ví dụ này chỉ là giả định, bạn sẽ cần sửa đổi để lấy mã món ăn thực tế từ cơ sở dữ liệu hoặc từ một phần khác của ứng dụng.
            //        Dictionary<string, List<int>> buoiMonAnDict = new Dictionary<string, List<int>>()
            //{
            //    { buoi, new List<int> { 1, 2 } }  // Thay đổi mã món ăn cho phù hợp
            //};

            //        // Gọi ThucDonService để lưu chi tiết thực đơn
            //        ThucDonService service = new ThucDonService();
            //        service.SaveThucDonChiTiet(ngayBatDau, ngayKetThuc, buoiMonAnDict);

            //        MessageBox.Show("Tạo thực đơn tuần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //try
            //{
            //    // Khởi tạo đối tượng ThucDonService để thao tác với CSDL
            //    ThucDonService service = new ThucDonService();

            //    // Lấy ngày bắt đầu và kết thúc từ DateTimePicker
            //    DateTime ngayBatDau = dateNgay.Value;
            //    DateTime ngayKetThuc = dateNgaykt.Value;

            //    // Kiểm tra ngày bắt đầu phải trước ngày kết thúc
            //    if (ngayBatDau > ngayKetThuc)
            //    {
            //        MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    // Tạo thực đơn tuần và lấy mã thực đơn tuần mới tạo
            //    int maThucDonTuan = service.CreateThucDonTuan(ngayBatDau, ngayKetThuc);

            //    // Duyệt qua từng ngày trong tuần (Từ ngày bắt đầu đến ngày kết thúc)
            //    for (DateTime date = ngayBatDau; date <= ngayKetThuc; date = date.AddDays(1))
            //    {
            //        // Duyệt qua các buổi trong ngày (Sáng, Chiều, Xế)
            //        foreach (string buoi in new[] { "Sáng", "Chiều", "Xế" })
            //        {
            //            // Lấy số lượng món ăn từ TextBox
            //            if (!int.TryParse(textBoxSLMA.Text, out int soLuongMonAn))
            //            {
            //                MessageBox.Show("Vui lòng nhập đúng số lượng món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }

            //            // Giả sử mã khẩu phần là 1 (Bạn có thể thay đổi theo nhu cầu)
            //            service.CreateThucDon(maThucDonTuan, date, buoi, 1, soLuongMonAn);
            //        }
            //    }

            //    MessageBox.Show("Tạo thực đơn tuần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        //private void SaveChiTietThucDon(MonAnService service, int maThucDon, int maMonAn, DateTime date, string buoi)
        //{
        //    string ghiChu = $"Thực đơn cho buổi {buoi} vào ngày {date.ToShortDateString()}";
        //    service.SaveChiTietThucDon(maThucDon, maMonAn, ghiChu);
        //}
        private void comboBoxNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string buoi = comboBoxNgay.SelectedItem.ToString();
            //LoadMonAnTheoBuoi(buoi);
        }

        private void dataGridViewMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
