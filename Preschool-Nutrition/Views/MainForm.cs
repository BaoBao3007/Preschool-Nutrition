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

namespace Preschool_Nutrition.Views
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1600, 900);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(1600, 900);
            this.MaximumSize = new Size(1600, 900);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Width = 349;
            panelRight.Dock = DockStyle.Fill;
            AddSetUpButton();
        }
        public void OpenChildForm(Form childForm)
        {
            if (childForm is FrmMonAn)
            {
                if (panelRight.Controls.OfType<FrmMonAn>().Any())
                {
                    return;
                }
            }
            if (panelRight.Controls.Count > 0)
            {
                panelRight.Controls[0].Dispose();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelRight.Controls.Add(childForm);
            panelRight.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void OpenChiTietMonAn(int maMonAn, string tenMonAn, string loaiMonAn, float calo, string ghiChu, string buoi)
        {
            var detailForm = new FrmChiTietMonAn_NguyenLieuMonAn();
            detailForm.AddMonAn(maMonAn, tenMonAn, loaiMonAn, calo, ghiChu, buoi);
            OpenChildForm(detailForm);
        }

        private void SetupButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.Black;
            button.FlatAppearance.BorderSize = 0;
            //button.MouseEnter += (s, e) => button.BackColor = Color.DarkSlateBlue;
            //button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(50, 150, 250);
            button.MouseEnter += (s, e) => button.BackColor = Color.White;
            //button.MouseLeave += (s, e) =>
            //{
            //    button.BackColor = (button == currentButton) ? Color.DarkSlateBlue : panelLeft.BackColor;
            //    //button.BackColor = (button == currentButton) ? Color.DarkSlateBlue : Color.Orange;
            //};
            button.MouseLeave += (s, e) =>
            {
                // Nếu button không phải là button hiện tại, nó sẽ quay lại màu panelLeft
                if (button != currentButton)
                {
                    button.BackColor = panelLeft.BackColor;
                }
            };
            button.Click += (s, e) => HighlightButton(button);
        }

        private void HighlightButton(Button button)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = panelLeft.BackColor;
            }

            currentButton = button;
            /*button.BackColor = Color.DarkSlateBlue*/
            ;
            button.BackColor = Color.White;
        }
        private void AddSetUpButton()
        {
            SetupButton(btn_gv);
            SetupButton(btn_hs);
            SetupButton(btn_monan);
            SetupButton(btn_nguyenlieu);
            SetupButton(btn_lophoc);
            SetupButton(btn_lenthucdon);
            SetupButton(btn_xemthucdon);
        }
        private void btn_lophoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLopHoc());
            HighlightButton(btn_lophoc);
        }

        private void btn_gv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGiaoVien());
            HighlightButton(btn_gv);
        }

        private void btn_nguyenlieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNguyenLieu());
            HighlightButton(btn_nguyenlieu);
        }

        private void btn_monan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMonAn());
            HighlightButton(btn_monan);
        }

        private void btn_hs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHocSinh());
            HighlightButton(btn_hs);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.Token = string.Empty;
            Properties.Settings.Default.Save();
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.FormClosed += (s, args) =>
            {
                this.Close();
            };
            login.ShowDialog();
            return;
        }
        public void UpdateUserInfo(string userInfo)
        {
            lbl_info.Text = userInfo;
        }

        private void btn_lenthucdon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCTTD());
            HighlightButton(btn_lenthucdon);
        }

        private void btn_xemthucdon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThucDon());
            HighlightButton(btn_xemthucdon);
        }
    }
}
