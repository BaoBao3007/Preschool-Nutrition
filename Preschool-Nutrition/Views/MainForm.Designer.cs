using Preschool_Nutrition.Utilities;

namespace Preschool_Nutrition.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLeft = new Panel();
            groupBox1 = new GroupBox();
            //btn_gv = new Button();
            //btn_hs = new Button();
            //btn_monan = new Button();
            //btn_lophoc = new Button();
            //btn_nguyenlieu = new Button();
            btn_gv = new RoundedButton();
            btn_hs = new RoundedButton();
            btn_monan = new RoundedButton();
            btn_nguyenlieu = new RoundedButton();
            btn_lophoc = new RoundedButton();
            lbl_info = new Label();
            btn_logout = new Button();
            panelRight = new Panel();
            panelLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.PeachPuff;
            panelLeft.Controls.Add(groupBox1);
            panelLeft.Controls.Add(lbl_info);
            panelLeft.Controls.Add(btn_logout);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(349, 900);
            panelLeft.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_gv);
            groupBox1.Controls.Add(btn_hs);
            groupBox1.Controls.Add(btn_monan);
            groupBox1.Controls.Add(btn_lophoc);
            groupBox1.Controls.Add(btn_nguyenlieu);
            groupBox1.Location = new Point(3, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý";
            // 
            // btn_gv
            // 
            btn_gv.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_gv.Location = new Point(0, 45);
            btn_gv.Name = "btn_gv";
            btn_gv.Size = new Size(343, 43);
            btn_gv.TabIndex = 4;
            btn_gv.Text = "Giáo viên";
            btn_gv.UseVisualStyleBackColor = true;
            btn_gv.Click += btn_gv_Click;
            // 
            // btn_hs
            // 
            btn_hs.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hs.Location = new Point(0, 94);
            btn_hs.Name = "btn_hs";
            btn_hs.Size = new Size(343, 43);
            btn_hs.TabIndex = 1;
            btn_hs.Text = "Học sinh";
            btn_hs.UseVisualStyleBackColor = true;
            btn_hs.Click += btn_hs_Click;
            // 
            // btn_monan
            // 
            btn_monan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_monan.Location = new Point(0, 241);
            btn_monan.Name = "btn_monan";
            btn_monan.Size = new Size(343, 43);
            btn_monan.TabIndex = 3;
            btn_monan.Text = "Món ăn";
            btn_monan.UseVisualStyleBackColor = true;
            btn_monan.Click += btn_monan_Click;
            // 
            // btn_lophoc
            // 
            btn_lophoc.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lophoc.Location = new Point(0, 143);
            btn_lophoc.Name = "btn_lophoc";
            btn_lophoc.Size = new Size(343, 43);
            btn_lophoc.TabIndex = 2;
            btn_lophoc.Text = "Lớp học";
            btn_lophoc.UseVisualStyleBackColor = true;
            btn_lophoc.Click += btn_lophoc_Click;
            // 
            // btn_nguyenlieu
            // 
            btn_nguyenlieu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nguyenlieu.Location = new Point(0, 192);
            btn_nguyenlieu.Name = "btn_nguyenlieu";
            btn_nguyenlieu.Size = new Size(343, 43);
            btn_nguyenlieu.TabIndex = 0;
            btn_nguyenlieu.Text = "Nguyên liệu";
            btn_nguyenlieu.UseVisualStyleBackColor = true;
            btn_nguyenlieu.Click += btn_nguyenlieu_Click;
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Location = new Point(109, 142);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(137, 25);
            lbl_info.TabIndex = 0;
            lbl_info.Text = "Tên người dùng";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(88, 802);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(181, 43);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Đăng Xuất";
            btn_logout.TextAlign = ContentAlignment.MiddleRight;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.Control;
            panelRight.Location = new Point(349, 0);
            panelRight.Margin = new Padding(0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1229, 900);
            panelRight.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "MainForm";
            Text = "MainForm";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Button btn_lophoc;
        private Button btn_hs;
        private Button btn_nguyenlieu;
        private Button btn_monan;
        private Button btn_gv;
        private Button btn_logout;
        private Label lbl_info;
        private GroupBox groupBox1;
    }
}