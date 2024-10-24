namespace Preschool_Nutrition.Views
{
    partial class FrmChiTietMonAn_NguyenLieuMonAn
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
            dataGridViewMonAn = new DataGridView();
            dataGridViewNguyenLieuMonAn = new DataGridView();
            groupBox1 = new GroupBox();
            btnXoaMon = new Button();
            btnSuaMon = new Button();
            txtGC = new TextBox();
            label9 = new Label();
            cboBuoi = new ComboBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            txtDVT = new TextBox();
            txtGhiChu = new TextBox();
            txtKhoiLuong = new TextBox();
            cboNguyenLieu = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtThemNL = new Button();
            cboLoaiMon = new ComboBox();
            txtCalo = new TextBox();
            txtTenMon = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNguyenLieuMonAn).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMonAn
            // 
            dataGridViewMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonAn.Location = new Point(6, 26);
            dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewMonAn.RowHeadersWidth = 51;
            dataGridViewMonAn.Size = new Size(836, 85);
            dataGridViewMonAn.TabIndex = 0;
            dataGridViewMonAn.MouseClick += dataGridViewMonAn_MouseClick;
            // 
            // dataGridViewNguyenLieuMonAn
            // 
            dataGridViewNguyenLieuMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNguyenLieuMonAn.Location = new Point(6, 26);
            dataGridViewNguyenLieuMonAn.Name = "dataGridViewNguyenLieuMonAn";
            dataGridViewNguyenLieuMonAn.RowHeadersWidth = 51;
            dataGridViewNguyenLieuMonAn.Size = new Size(839, 175);
            dataGridViewNguyenLieuMonAn.TabIndex = 1;
            dataGridViewNguyenLieuMonAn.MouseClick += dataGridViewNguyenLieuMonAn_MouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaMon);
            groupBox1.Controls.Add(btnSuaMon);
            groupBox1.Controls.Add(txtGC);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboBuoi);
            groupBox1.Controls.Add(dataGridViewMonAn);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(27, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(849, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin món ăn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(734, 182);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(108, 29);
            btnXoaMon.TabIndex = 33;
            btnXoaMon.Text = "Xóa món ăn";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnSuaMon
            // 
            btnSuaMon.Location = new Point(734, 130);
            btnSuaMon.Name = "btnSuaMon";
            btnSuaMon.Size = new Size(108, 29);
            btnSuaMon.TabIndex = 32;
            btnSuaMon.Text = "Sửa món ăn";
            btnSuaMon.UseVisualStyleBackColor = true;
            btnSuaMon.Click += btnSuaMon_Click;
            // 
            // txtGC
            // 
            txtGC.Location = new Point(330, 182);
            txtGC.Name = "txtGC";
            txtGC.Size = new Size(391, 27);
            txtGC.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 182);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 30;
            label9.Text = "Ghi chú:";
            // 
            // cboBuoi
            // 
            cboBuoi.FormattingEnabled = true;
            cboBuoi.Location = new Point(80, 181);
            cboBuoi.Name = "cboBuoi";
            cboBuoi.Size = new Size(136, 28);
            cboBuoi.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 181);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 25;
            label5.Text = "Buổi:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewNguyenLieuMonAn);
            groupBox2.Location = new Point(27, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(849, 207);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nguyên Liệu Món Ăn";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(685, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(685, 61);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(685, 96);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDVT);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(txtKhoiLuong);
            groupBox3.Controls.Add(cboNguyenLieu);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtThemNL);
            groupBox3.Controls.Add(btnBack);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Location = new Point(33, 496);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(839, 214);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao Tác";
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(568, 34);
            txtDVT.Name = "txtDVT";
            txtDVT.ReadOnly = true;
            txtDVT.Size = new Size(79, 27);
            txtDVT.TabIndex = 15;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(130, 96);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(339, 27);
            txtGhiChu.TabIndex = 14;
            // 
            // txtKhoiLuong
            // 
            txtKhoiLuong.Location = new Point(390, 38);
            txtKhoiLuong.Name = "txtKhoiLuong";
            txtKhoiLuong.Size = new Size(79, 27);
            txtKhoiLuong.TabIndex = 13;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(130, 35);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(151, 28);
            cboNguyenLieu.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 96);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 11;
            label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 38);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 10;
            label3.Text = "Khối lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 9;
            label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên Nguyên Liệu";
            // 
            // txtThemNL
            // 
            txtThemNL.Location = new Point(510, 94);
            txtThemNL.Name = "txtThemNL";
            txtThemNL.Size = new Size(137, 29);
            txtThemNL.TabIndex = 7;
            txtThemNL.Text = "Thêm nguyên liệu";
            txtThemNL.UseVisualStyleBackColor = true;
            txtThemNL.Click += txtThemNL_Click;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Location = new Point(612, 159);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(136, 28);
            cboLoaiMon.TabIndex = 28;
            // 
            // txtCalo
            // 
            txtCalo.Location = new Point(411, 160);
            txtCalo.Name = "txtCalo";
            txtCalo.Size = new Size(99, 27);
            txtCalo.TabIndex = 27;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(107, 160);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(233, 27);
            txtTenMon.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 163);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 24;
            label6.Text = "Calo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 163);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 23;
            label7.Text = "Loại Món:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 163);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 22;
            label8.Text = "Tên Món:";
            // 
            // FrmChiTietMonAn_NguyenLieuMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 599);
            Controls.Add(cboLoaiMon);
            Controls.Add(txtCalo);
            Controls.Add(txtTenMon);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmChiTietMonAn_NguyenLieuMonAn";
            Text = "FrmChiTietMonAn_NguyenLieuMonAn";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNguyenLieuMonAn).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMonAn;
        private DataGridView dataGridViewNguyenLieuMonAn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnBack;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox3;
        private Button txtThemNL;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox cboNguyenLieu;
        private Label label4;
        private TextBox txtDVT;
        private TextBox txtGhiChu;
        private TextBox txtKhoiLuong;
        private ComboBox cboBuoi;
        private Label label5;
        private ComboBox cboLoaiMon;
        private TextBox txtCalo;
        private TextBox txtTenMon;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtGC;
        private Label label9;
        private Button btnXoaMon;
        private Button btnSuaMon;
    }
}