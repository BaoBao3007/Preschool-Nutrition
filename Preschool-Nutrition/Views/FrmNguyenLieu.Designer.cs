namespace Preschool_Nutrition.Views
{
    partial class FrmNguyenLieu
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_tenNL = new TextBox();
            cbo_loaiNL = new ComboBox();
            cbo_dvt = new ComboBox();
            txt_gia = new TextBox();
            groupBox1 = new GroupBox();
            txt_slt = new TextBox();
            label7 = new Label();
            btn_lammoi = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_them = new Button();
            txt_calo = new TextBox();
            groupBox2 = new GroupBox();
            txt_timkiem = new TextBox();
            btn_timkiem = new Button();
            dgv_nguyenlieu = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nguyenlieu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(223, 27);
            label1.Name = "label1";
            label1.Size = new Size(580, 56);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 148);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nguyên liệu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 195);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 195);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 3;
            label4.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 145);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 4;
            label5.Text = "Loại nguyên liệu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 171);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 5;
            label6.Text = "Calo:";
            // 
            // txt_tenNL
            // 
            txt_tenNL.Location = new Point(223, 142);
            txt_tenNL.Name = "txt_tenNL";
            txt_tenNL.Size = new Size(218, 31);
            txt_tenNL.TabIndex = 6;
            // 
            // cbo_loaiNL
            // 
            cbo_loaiNL.FormattingEnabled = true;
            cbo_loaiNL.Location = new Point(687, 142);
            cbo_loaiNL.Name = "cbo_loaiNL";
            cbo_loaiNL.Size = new Size(228, 33);
            cbo_loaiNL.TabIndex = 7;
            // 
            // cbo_dvt
            // 
            cbo_dvt.FormattingEnabled = true;
            cbo_dvt.Location = new Point(223, 192);
            cbo_dvt.Name = "cbo_dvt";
            cbo_dvt.Size = new Size(218, 33);
            cbo_dvt.TabIndex = 8;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(653, 106);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(228, 31);
            txt_gia.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_slt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_lammoi);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(txt_calo);
            groupBox1.Controls.Add(txt_gia);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(34, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(956, 308);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // txt_slt
            // 
            txt_slt.Enabled = false;
            txt_slt.Location = new Point(653, 168);
            txt_slt.Name = "txt_slt";
            txt_slt.Size = new Size(228, 31);
            txt_slt.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 171);
            label7.Name = "label7";
            label7.Size = new Size(156, 25);
            label7.TabIndex = 15;
            label7.Text = "Số lượng tồn kho:";
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(616, 249);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(112, 34);
            btn_lammoi.TabIndex = 14;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(489, 249);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(112, 34);
            btn_sua.TabIndex = 13;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(361, 249);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(112, 34);
            btn_xoa.TabIndex = 12;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(232, 249);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(112, 34);
            btn_them.TabIndex = 11;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // txt_calo
            // 
            txt_calo.Location = new Point(189, 168);
            txt_calo.Name = "txt_calo";
            txt_calo.Size = new Size(218, 31);
            txt_calo.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_timkiem);
            groupBox2.Controls.Add(btn_timkiem);
            groupBox2.Controls.Add(dgv_nguyenlieu);
            groupBox2.Location = new Point(34, 422);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(956, 367);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nguyên liệu";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(563, 47);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Nhập tên nguyên liệu cần tìm";
            txt_timkiem.Size = new Size(242, 31);
            txt_timkiem.TabIndex = 2;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(821, 44);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(112, 34);
            btn_timkiem.TabIndex = 1;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // dgv_nguyenlieu
            // 
            dgv_nguyenlieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nguyenlieu.Location = new Point(6, 98);
            dgv_nguyenlieu.Name = "dgv_nguyenlieu";
            dgv_nguyenlieu.RowHeadersWidth = 62;
            dgv_nguyenlieu.Size = new Size(944, 263);
            dgv_nguyenlieu.TabIndex = 0;
            dgv_nguyenlieu.CellClick += dgv_nguyenlieu_CellClick;
            // 
            // FrmNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 844);
            Controls.Add(groupBox2);
            Controls.Add(cbo_dvt);
            Controls.Add(cbo_loaiNL);
            Controls.Add(txt_tenNL);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmNguyenLieu";
            Text = "FrmNguyenLieu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nguyenlieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_tenNL;
        private ComboBox cbo_loaiNL;
        private ComboBox cbo_dvt;
        private TextBox txt_gia;
        private GroupBox groupBox1;
        private TextBox txt_calo;
        private Button btn_lammoi;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private GroupBox groupBox2;
        private DataGridView dgv_nguyenlieu;
        private Button btn_timkiem;
        private TextBox txt_timkiem;
        private Label label7;
        private TextBox txt_slt;
    }
}