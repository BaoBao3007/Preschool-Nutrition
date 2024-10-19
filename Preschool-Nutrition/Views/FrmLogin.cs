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
    public partial class FrmLogin : Form
    {
        private TaiKhoanController taiKhoanController;
        public FrmLogin()
        {
            InitializeComponent();
            taiKhoanController = new TaiKhoanController();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadUserCredentials();
        }
        private void LoadUserCredentials()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txt_username.Text = Properties.Settings.Default.Username;
                //txt_password.Text=Properties.Settings.Default.Password;
                //chk_remember.Checked = true;
                string token = Properties.Settings.Default.Token;
                if (IsValidToken(token))
                {

                    OpenMainForm();
                }
            }
        }
        private bool IsValidToken(string token)
        {
            return !string.IsNullOrEmpty(token);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_username.Text.Trim();
            string matKhau = txt_password.Text.Trim();
            bool dangnhap = taiKhoanController.Login(tenDangNhap, matKhau);
            if (dangnhap)
            {

                if (chk_remember.Checked)
                {
                    Properties.Settings.Default.Username = tenDangNhap;
                    //Properties.Settings.Default.Password = matKhau;
                    Properties.Settings.Default.Token = Guid.NewGuid().ToString();
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    Properties.Settings.Default.Username = string.Empty;
                    //Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.RememberMe = false;
                }

                Properties.Settings.Default.Save();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenMainForm();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showpass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }
        private void OpenMainForm()
        {
            string tenDangNhap = txt_username.Text.Trim();
            string userInfo = taiKhoanController.GetUserInfo(tenDangNhap);
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.UpdateUserInfo(userInfo);
            mainForm.FormClosed += (s, args) =>
            {
                this.Dispose();
            };
            mainForm.UpdateUserInfo(userInfo);
            mainForm.ShowDialog();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChangePass changePass = new FrmChangePass();
            changePass.FormClosed += (s, args) => this.Show();
            changePass.Show();
        }
    }
}
