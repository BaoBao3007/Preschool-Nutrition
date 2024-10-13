using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;

namespace Preschool_Nutrition.Views
{

    partial class FrmMonAn
    {
        private MonAnRepository monAnRepository;
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtTenMon = new TextBox();
            txtCalo = new TextBox();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTim = new Button();
            txtLoaiMon = new TextBox();
            txtTim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMonAn
            // 
            dataGridViewMonAn.AllowUserToDeleteRows = false;
            dataGridViewMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonAn.Location = new Point(108, 61);
            dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewMonAn.RowHeadersWidth = 51;
            dataGridViewMonAn.Size = new Size(787, 291);
            dataGridViewMonAn.TabIndex = 0;
            dataGridViewMonAn.MouseClick += dataGridViewMonAn_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 23);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Món Ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 389);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Món";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 393);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Loại Món";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 473);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 470);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 6;
            label4.Text = "Calo";
            label4.Click += label4_Click;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(180, 386);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(197, 27);
            txtTenMon.TabIndex = 8;
            // 
            // txtCalo
            // 
            txtCalo.Location = new Point(178, 470);
            txtCalo.Name = "txtCalo";
            txtCalo.Size = new Size(141, 27);
            txtCalo.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(484, 473);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(385, 27);
            txtGhiChu.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(193, 598);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.MouseClick += btnThem_MouseClick;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(350, 598);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.MouseClick += btnXoa_MouseClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(494, 598);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.MouseClick += btnSua_MouseClick;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(628, 598);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 14;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            btnTim.MouseClick += btnTim_MouseClick;
            // 
            // txtLoaiMon
            // 
            txtLoaiMon.Location = new Point(561, 389);
            txtLoaiMon.Name = "txtLoaiMon";
            txtLoaiMon.Size = new Size(141, 27);
            txtLoaiMon.TabIndex = 15;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(743, 600);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(171, 27);
            txtTim.TabIndex = 16;
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(txtTim);
            Controls.Add(txtLoaiMon);
            Controls.Add(btnTim);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtGhiChu);
            Controls.Add(txtCalo);
            Controls.Add(txtTenMon);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewMonAn);
            Name = "FrmMonAn";
            Text = "FrmMonAn";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMonAn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtTenMon;
        private TextBox txtCalo;
        private TextBox txtGhiChu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTim;
        private TextBox txtLoaiMon;
        private TextBox txtTim;
    }

}