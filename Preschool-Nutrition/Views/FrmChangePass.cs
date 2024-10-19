using Preschool_Nutrition.Controllers;
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
    public partial class FrmChangePass : Form
    {
        private TaiKhoanController taiKhoanController;
        public FrmChangePass()
        {
            InitializeComponent();
            taiKhoanController = new TaiKhoanController();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string tenDangNhap = txt_username.Text.Trim(); // Tên đăng nhập
            string matKhauCu = txt_oldPassword.Text.Trim(); // Mật khẩu cũ
            string matKhauMoi = txt_newPassword.Text.Trim(); // Mật khẩu mới
            string xacNhanMatKhauMoi = txt_confirmPassword.Text.Trim(); // Xác nhận mật khẩu mới

            // Kiểm tra các trường không được để trống
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhauCu) ||
                string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhauMoi))
            {
                string message = string.IsNullOrEmpty(tenDangNhap) ? "Tên đăng nhập không được để trống!" :
                                 string.IsNullOrEmpty(matKhauCu) ? "Mật khẩu cũ không được để trống!" :
                                 string.IsNullOrEmpty(matKhauMoi) ? "Mật khẩu mới không được để trống!" :
                                 "Xác nhận mật khẩu mới không được để trống!";

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Đặt focus vào trường trống đầu tiên
                if (string.IsNullOrEmpty(tenDangNhap))
                    txt_username.Focus();
                else if (string.IsNullOrEmpty(matKhauCu))
                    txt_oldPassword.Focus();
                else if (string.IsNullOrEmpty(matKhauMoi))
                    txt_newPassword.Focus();
                else
                    txt_confirmPassword.Focus();

                return; // Dừng thực hiện nếu có trường bị trống
            }

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu mới có khớp nhau hay không
            if (matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_confirmPassword.Focus();
                return; // Dừng thực hiện nếu mật khẩu không khớp
            }

            // Gọi phương thức đổi mật khẩu nếu mọi thứ hợp lệ
            bool result = taiKhoanController.ChangePassword(tenDangNhap, matKhauCu, matKhauMoi);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
