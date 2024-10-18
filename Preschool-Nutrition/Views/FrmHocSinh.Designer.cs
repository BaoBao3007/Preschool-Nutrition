
namespace Preschool_Nutrition.Views
{
    partial class FrmHocSinh
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
            label1 = new Label();
            textBoxHoTen = new TextBox();
            comboBoxLopHoc = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxDiaChi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxDTPH = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            gb_gt = new GroupBox();
            rdbKhac = new RadioButton();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            buttonthem = new Button();
            btnXoa = new Button();
            buttonCapNhat = new Button();
            buttonThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gb_gt.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 85);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(247, 85);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(150, 31);
            textBoxHoTen.TabIndex = 1;
            textBoxHoTen.TextChanged += textBoxHoTen_TextChanged;
            // 
            // comboBoxLopHoc
            // 
            comboBoxLopHoc.FormattingEnabled = true;
            comboBoxLopHoc.Location = new Point(606, 88);
            comboBoxLopHoc.Name = "comboBoxLopHoc";
            comboBoxLopHoc.Size = new Size(182, 33);
            comboBoxLopHoc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 160);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 3;
            label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 230);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 5;
            label3.Text = "Giới Tính";
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(247, 295);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(150, 31);
            textBoxDiaChi.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 295);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 7;
            label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 91);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 9;
            label5.Text = "Mã Lớp";
            // 
            // textBoxDTPH
            // 
            textBoxDTPH.Location = new Point(702, 161);
            textBoxDTPH.Name = "textBoxDTPH";
            textBoxDTPH.Size = new Size(150, 31);
            textBoxDTPH.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(572, 164);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 11;
            label6.Text = "Điện Thoại PH";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(247, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(555, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(530, 246);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gb_gt
            // 
            gb_gt.Controls.Add(rdbKhac);
            gb_gt.Controls.Add(rdbNam);
            gb_gt.Controls.Add(rdbNu);
            gb_gt.Location = new Point(247, 206);
            gb_gt.Name = "gb_gt";
            gb_gt.Size = new Size(300, 72);
            gb_gt.TabIndex = 25;
            gb_gt.TabStop = false;
            gb_gt.Text = "Giới tính";
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
            rdbNam.CheckedChanged += rdbNam_CheckedChanged;
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
            rdbNu.CheckedChanged += rdbNu_CheckedChanged;
            // 
            // buttonthem
            // 
            buttonthem.Location = new Point(870, 82);
            buttonthem.Name = "buttonthem";
            buttonthem.Size = new Size(112, 34);
            buttonthem.TabIndex = 28;
            buttonthem.Text = "Thêm";
            buttonthem.UseVisualStyleBackColor = true;
            buttonthem.Click += buttonthem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(870, 131);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // buttonCapNhat
            // 
            buttonCapNhat.Location = new Point(870, 171);
            buttonCapNhat.Name = "buttonCapNhat";
            buttonCapNhat.Size = new Size(112, 34);
            buttonCapNhat.TabIndex = 30;
            buttonCapNhat.Text = "Cập Nhật";
            buttonCapNhat.UseVisualStyleBackColor = true;
            buttonCapNhat.Click += buttonCapNhat_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(870, 42);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(112, 34);
            buttonThoat.TabIndex = 31;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // FrmHocSinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 539);
            Controls.Add(buttonThoat);
            Controls.Add(buttonCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(buttonthem);
            Controls.Add(gb_gt);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxDTPH);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxDiaChi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxLopHoc);
            Controls.Add(textBoxHoTen);
            Controls.Add(label1);
            Name = "FrmHocSinh";
            Text = "FrmHocSinh";
            Load += FrmHocSinh_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gb_gt.ResumeLayout(false);
            gb_gt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox textBoxHoTen;
        private ComboBox comboBoxLopHoc;
        private Label label2;
        private Label label3;
        private TextBox textBoxDiaChi;
        private Label label4;
        private Label label5;
        private TextBox textBoxDTPH;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
     
        private GroupBox gb_gt;
        private RadioButton rdbKhac;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private Button buttonthem;
        private Button btnXoa;
        private Button buttonCapNhat;
        private Button buttonThoat;
    }
}