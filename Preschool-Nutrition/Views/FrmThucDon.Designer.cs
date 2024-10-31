namespace Preschool_Nutrition.Views
{
    partial class FrmThucDon
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
            groupBox1 = new GroupBox();
            btn_xoa = new Button();
            btn_luu = new Button();
            cbo_buoi = new ComboBox();
            cbo_ngay = new ComboBox();
            btn_xemchitiet = new Button();
            dgv_thucdon = new DataGridView();
            groupBox2 = new GroupBox();
            dgv_ctthucdon = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thucdon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ctthucdon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_luu);
            groupBox1.Controls.Add(cbo_buoi);
            groupBox1.Controls.Add(cbo_ngay);
            groupBox1.Controls.Add(btn_xemchitiet);
            groupBox1.Controls.Add(dgv_thucdon);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 473);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thực đơn";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(266, 410);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(159, 51);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(86, 410);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(159, 51);
            btn_luu.TabIndex = 4;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // cbo_buoi
            // 
            cbo_buoi.FormattingEnabled = true;
            cbo_buoi.Location = new Point(356, 348);
            cbo_buoi.Name = "cbo_buoi";
            cbo_buoi.Size = new Size(246, 33);
            cbo_buoi.TabIndex = 3;
            cbo_buoi.SelectedIndexChanged += cbo_buoi_SelectedIndexChanged;
            // 
            // cbo_ngay
            // 
            cbo_ngay.FormattingEnabled = true;
            cbo_ngay.Location = new Point(86, 348);
            cbo_ngay.Name = "cbo_ngay";
            cbo_ngay.Size = new Size(246, 33);
            cbo_ngay.TabIndex = 2;
            cbo_ngay.SelectedIndexChanged += cbo_ngay_SelectedIndexChanged;
            // 
            // btn_xemchitiet
            // 
            btn_xemchitiet.Location = new Point(444, 410);
            btn_xemchitiet.Name = "btn_xemchitiet";
            btn_xemchitiet.Size = new Size(159, 51);
            btn_xemchitiet.TabIndex = 1;
            btn_xemchitiet.Text = "Xem chi tiết";
            btn_xemchitiet.UseVisualStyleBackColor = true;
            btn_xemchitiet.Click += btn_xemchitiet_Click;
            // 
            // dgv_thucdon
            // 
            dgv_thucdon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thucdon.Location = new Point(6, 30);
            dgv_thucdon.Name = "dgv_thucdon";
            dgv_thucdon.RowHeadersWidth = 62;
            dgv_thucdon.Size = new Size(679, 298);
            dgv_thucdon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_ctthucdon);
            groupBox2.Location = new Point(709, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 339);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết thực đơn";
            // 
            // dgv_ctthucdon
            // 
            dgv_ctthucdon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ctthucdon.Location = new Point(6, 30);
            dgv_ctthucdon.Name = "dgv_ctthucdon";
            dgv_ctthucdon.RowHeadersWidth = 62;
            dgv_ctthucdon.Size = new Size(506, 298);
            dgv_ctthucdon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(398, 22);
            label1.Name = "label1";
            label1.Size = new Size(438, 59);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // FrmThucDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 712);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmThucDon";
            Text = "FrmThucDon";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_thucdon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ctthucdon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_xemchitiet;
        private DataGridView dgv_thucdon;
        private DataGridView dgv_ctthucdon;
        private ComboBox cbo_ngay;
        private ComboBox cbo_buoi;
        private Button btn_xoa;
        private Button btn_luu;
        private Label label1;
    }
}