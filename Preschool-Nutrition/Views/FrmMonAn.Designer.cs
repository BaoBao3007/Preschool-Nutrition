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
            groupBox1 = new GroupBox();
            btnTim = new Button();
            txtTim = new TextBox();
            groupBox3 = new GroupBox();
            btnThem = new Button();
            txtGhiChu = new TextBox();
            cboBuoi = new ComboBox();
            cboLoaiMon = new ComboBox();
            txtCalo = new TextBox();
            txtTenMon = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnReload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMonAn
            // 
            dataGridViewMonAn.AllowUserToDeleteRows = false;
            dataGridViewMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonAn.Location = new Point(16, 26);
            dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewMonAn.RowHeadersWidth = 51;
            dataGridViewMonAn.Size = new Size(861, 359);
            dataGridViewMonAn.TabIndex = 26;
            dataGridViewMonAn.MouseClick += dataGridViewMonAn_MouseClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMonAn);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Location = new Point(61, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 438);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Món Ăn";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(559, 404);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 24;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(669, 405);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(208, 27);
            txtTim.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnReload);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(cboBuoi);
            groupBox3.Controls.Add(cboLoaiMon);
            groupBox3.Controls.Add(txtCalo);
            groupBox3.Controls.Add(txtTenMon);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 496);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(991, 189);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm Món Ăn";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(477, 107);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(113, 107);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(341, 27);
            txtGhiChu.TabIndex = 22;
            // 
            // cboBuoi
            // 
            cboBuoi.FormattingEnabled = true;
            cboBuoi.Location = new Point(816, 54);
            cboBuoi.Name = "cboBuoi";
            cboBuoi.Size = new Size(136, 28);
            cboBuoi.TabIndex = 21;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Location = new Point(618, 54);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(136, 28);
            cboLoaiMon.TabIndex = 20;
            // 
            // txtCalo
            // 
            txtCalo.Location = new Point(417, 55);
            txtCalo.Name = "txtCalo";
            txtCalo.Size = new Size(99, 27);
            txtCalo.TabIndex = 19;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(113, 55);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(233, 27);
            txtTenMon.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 107);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 17;
            label5.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 58);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 16;
            label3.Text = "Buổi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 58);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 15;
            label4.Text = "Calo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 58);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 14;
            label2.Text = "Loại Món:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 58);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Tên Món:";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(687, 105);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(108, 31);
            btnReload.TabIndex = 26;
            btnReload.Text = "RL";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 768);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FrmMonAn";
            Text = "FrmMonAn";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewMonAn;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnThem;
        private Button btnTim;
        private TextBox txtTim;
        private TextBox txtGhiChu;
        private ComboBox cboBuoi;
        private ComboBox cboLoaiMon;
        private TextBox txtCalo;
        private TextBox txtTenMon;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnReload;
    }

}