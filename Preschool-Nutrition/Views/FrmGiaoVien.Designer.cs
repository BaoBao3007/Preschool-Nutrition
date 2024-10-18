namespace Preschool_Nutrition.Views
{
    partial class FrmGiaoVien
    {
        private const int V = 15;

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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxHoTen = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxDiaChi = new TextBox();
            label8 = new Label();
            textBoxDienThoai = new TextBox();
            dgv_gv = new DataGridView();
            btn_xoa = new Button();
            btn_capnhat = new Button();
            btn_thoat = new Button();
            btn_them = new Button();
            dateTimePickerNgaySinh = new DateTimePicker();
            gb_gt = new GroupBox();
            rdbKhac = new RadioButton();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            comboBoxChucVu = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_gv).BeginInit();
            gb_gt.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 33);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 1;
            label1.Text = "Danh Sách Giáo Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 170);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 101);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 6;
            label4.Text = "Họ Tên GV";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(220, 101);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(208, 31);
            textBoxHoTen.TabIndex = 5;
            textBoxHoTen.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 242);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 8;
            label5.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 101);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 10;
            label6.Text = "Chức Vụ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(547, 173);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 12;
            label7.Text = "Địa Chỉ";
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(676, 170);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(190, 31);
            textBoxDiaChi.TabIndex = 11;
            textBoxDiaChi.TextChanged += textBoxDiaChi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(547, 242);
            label8.Name = "label8";
            label8.Size = new Size(122, 25);
            label8.TabIndex = 14;
            label8.Text = "Số Điện Thoại";
            // 
            // textBoxDienThoai
            // 
            textBoxDienThoai.Location = new Point(676, 239);
            textBoxDienThoai.Name = "textBoxDienThoai";
            textBoxDienThoai.Size = new Size(190, 31);
            textBoxDienThoai.TabIndex = 13;
            textBoxDienThoai.TextChanged += textBoxDienThoai_TextChanged;
            // 
            // dgv_gv
            // 
            dgv_gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_gv.Location = new Point(127, 351);
            dgv_gv.Name = "dgv_gv";
            dgv_gv.RowHeadersWidth = 62;
            dgv_gv.Size = new Size(818, 271);
            dgv_gv.TabIndex = 22;
            dgv_gv.CellClick += dgv_gv_CellClick;
            dgv_gv.CellContentClick += Dgv_gv_CellContentClick;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(491, 628);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(112, 34);
            btn_xoa.TabIndex = 16;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(646, 628);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(112, 34);
            btn_capnhat.TabIndex = 17;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(803, 628);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 34);
            btn_thoat.TabIndex = 18;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(346, 628);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(112, 34);
            btn_them.TabIndex = 19;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(220, 173);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(300, 31);
            dateTimePickerNgaySinh.TabIndex = 23;
            dateTimePickerNgaySinh.ValueChanged += dateTimePickerNgaySinh_ValueChanged;
            // 
            // gb_gt
            // 
            gb_gt.Controls.Add(rdbKhac);
            gb_gt.Controls.Add(rdbNam);
            gb_gt.Controls.Add(rdbNu);
            gb_gt.Location = new Point(220, 242);
            gb_gt.Name = "gb_gt";
            gb_gt.Size = new Size(300, 72);
            gb_gt.TabIndex = 24;
            gb_gt.TabStop = false;
            gb_gt.Text = "Giới tính";
            gb_gt.Enter += groupBox1_Enter;
            // 
            // rdbKhac
            // 
            rdbKhac.AutoSize = true;
            rdbKhac.Location = new Point(180, 30);
            rdbKhac.Name = "rdbKhac";
            rdbKhac.Size = new Size(74, 29);
            rdbKhac.TabIndex = 26;
            rdbKhac.TabStop = true;
            rdbKhac.Text = "Khác";
            rdbKhac.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(6, 30);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 29);
            rdbNam.TabIndex = 25;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(113, 30);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(61, 29);
            rdbNu.TabIndex = 25;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Location = new Point(676, 93);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(182, 33);
            comboBoxChucVu.TabIndex = 25;
            comboBoxChucVu.SelectedIndexChanged += comboBoxChucVu_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(220, 628);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 26;
            button1.Text = "Làm Mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmGiaoVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 674);
            Controls.Add(button1);
            Controls.Add(comboBoxChucVu);
            Controls.Add(gb_gt);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(btn_them);
            Controls.Add(dgv_gv);
            Controls.Add(btn_thoat);
            Controls.Add(btn_capnhat);
            Controls.Add(btn_xoa);
            Controls.Add(label8);
            Controls.Add(textBoxDienThoai);
            Controls.Add(label7);
            Controls.Add(textBoxDiaChi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxHoTen);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmGiaoVien";
            Text = "FrmGiaoVien";
            Load += FrmGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_gv).EndInit();
            gb_gt.ResumeLayout(false);
            gb_gt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBoxHoTen;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxDiaChi;
        private Label label8;
        private TextBox textBoxDienThoai;
        private DataGridView dgv_gv;
        private Button btn_xoa;
        private Button btn_capnhat;
        private Button btn_thoat;
        private Button btn_them;
        private DateTimePicker dateTimePickerNgaySinh;
        private GroupBox gb_gt;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private RadioButton rdbKhac;
        private ComboBox comboBoxChucVu;
        private Button button1;
    }
}