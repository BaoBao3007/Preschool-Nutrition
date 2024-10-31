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
            dataGridViewMonAn.Location = new Point(8, 32);
            dataGridViewMonAn.Margin = new Padding(4, 4, 4, 4);
            dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewMonAn.RowHeadersWidth = 51;
            dataGridViewMonAn.Size = new Size(1045, 106);
            dataGridViewMonAn.TabIndex = 0;
            dataGridViewMonAn.MouseClick += dataGridViewMonAn_MouseClick;
            // 
            // dataGridViewNguyenLieuMonAn
            // 
            dataGridViewNguyenLieuMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNguyenLieuMonAn.Location = new Point(8, 32);
            dataGridViewNguyenLieuMonAn.Margin = new Padding(4, 4, 4, 4);
            dataGridViewNguyenLieuMonAn.Name = "dataGridViewNguyenLieuMonAn";
            dataGridViewNguyenLieuMonAn.RowHeadersWidth = 51;
            dataGridViewNguyenLieuMonAn.Size = new Size(1049, 219);
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
            groupBox1.Location = new Point(34, 36);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1061, 310);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin món ăn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(918, 228);
            btnXoaMon.Margin = new Padding(4, 4, 4, 4);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(135, 36);
            btnXoaMon.TabIndex = 33;
            btnXoaMon.Text = "Xóa món ăn";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnSuaMon
            // 
            btnSuaMon.Location = new Point(918, 162);
            btnSuaMon.Margin = new Padding(4, 4, 4, 4);
            btnSuaMon.Name = "btnSuaMon";
            btnSuaMon.Size = new Size(135, 36);
            btnSuaMon.TabIndex = 32;
            btnSuaMon.Text = "Sửa món ăn";
            btnSuaMon.UseVisualStyleBackColor = true;
            btnSuaMon.Click += btnSuaMon_Click;
            // 
            // txtGC
            // 
            txtGC.Location = new Point(412, 228);
            txtGC.Margin = new Padding(4, 4, 4, 4);
            txtGC.Name = "txtGC";
            txtGC.Size = new Size(488, 31);
            txtGC.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 228);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 30;
            label9.Text = "Ghi chú:";
            // 
            // cboBuoi
            // 
            cboBuoi.FormattingEnabled = true;
            cboBuoi.Location = new Point(100, 226);
            cboBuoi.Margin = new Padding(4, 4, 4, 4);
            cboBuoi.Name = "cboBuoi";
            cboBuoi.Size = new Size(169, 33);
            cboBuoi.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 226);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 25;
            label5.Text = "Buổi:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewNguyenLieuMonAn);
            groupBox2.Location = new Point(34, 354);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(1061, 259);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nguyên Liệu Món Ăn";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(856, 32);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(171, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(856, 76);
            btnSua.Margin = new Padding(4, 4, 4, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(171, 36);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(856, 120);
            btnXoa.Margin = new Padding(4, 4, 4, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(171, 36);
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
            groupBox3.Location = new Point(41, 620);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(1049, 268);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao Tác";
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(710, 42);
            txtDVT.Margin = new Padding(4, 4, 4, 4);
            txtDVT.Name = "txtDVT";
            txtDVT.ReadOnly = true;
            txtDVT.Size = new Size(98, 31);
            txtDVT.TabIndex = 15;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(162, 120);
            txtGhiChu.Margin = new Padding(4, 4, 4, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(423, 31);
            txtGhiChu.TabIndex = 14;
            // 
            // txtKhoiLuong
            // 
            txtKhoiLuong.Location = new Point(488, 48);
            txtKhoiLuong.Margin = new Padding(4, 4, 4, 4);
            txtKhoiLuong.Name = "txtKhoiLuong";
            txtKhoiLuong.Size = new Size(98, 31);
            txtKhoiLuong.TabIndex = 13;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(162, 44);
            cboNguyenLieu.Margin = new Padding(4, 4, 4, 4);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(188, 33);
            cboNguyenLieu.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 11;
            label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 10;
            label3.Text = "Khối lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 9;
            label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 8;
            label1.Text = "Tên Nguyên Liệu";
            // 
            // txtThemNL
            // 
            txtThemNL.Location = new Point(638, 118);
            txtThemNL.Margin = new Padding(4, 4, 4, 4);
            txtThemNL.Name = "txtThemNL";
            txtThemNL.Size = new Size(171, 36);
            txtThemNL.TabIndex = 7;
            txtThemNL.Text = "Thêm nguyên liệu";
            txtThemNL.UseVisualStyleBackColor = true;
            txtThemNL.Click += txtThemNL_Click;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Location = new Point(765, 199);
            cboLoaiMon.Margin = new Padding(4, 4, 4, 4);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(169, 33);
            cboLoaiMon.TabIndex = 28;
            // 
            // txtCalo
            // 
            txtCalo.Location = new Point(514, 200);
            txtCalo.Margin = new Padding(4, 4, 4, 4);
            txtCalo.Name = "txtCalo";
            txtCalo.Size = new Size(123, 31);
            txtCalo.TabIndex = 27;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(134, 200);
            txtTenMon.Margin = new Padding(4, 4, 4, 4);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(290, 31);
            txtTenMon.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 204);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 24;
            label6.Text = "Calo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(665, 204);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 23;
            label7.Text = "Loại Món:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 204);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 22;
            label8.Text = "Tên Món:";
            // 
            // FrmChiTietMonAn_NguyenLieuMonAn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 788);
            Controls.Add(cboLoaiMon);
            Controls.Add(txtCalo);
            Controls.Add(txtTenMon);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
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