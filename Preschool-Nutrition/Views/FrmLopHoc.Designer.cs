namespace Preschool_Nutrition.Views
{
    partial class FrmLopHoc
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
            txt_tenlophoc = new TextBox();
            txt_namhoc = new TextBox();
            cbo_gv = new ComboBox();
            dgv_lophoc = new DataGridView();
            button1 = new Button();
            btn_them = new Button();
            btn_thoat = new Button();
            btn_capnhat = new Button();
            btn_xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_lophoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh sách lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 65);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Lớp Học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 143);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Năm Học:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 221);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 3;
            label4.Text = "Giáo Viên Chủ Nhiệm:";
            // 
            // txt_tenlophoc
            // 
            txt_tenlophoc.Location = new Point(262, 62);
            txt_tenlophoc.Name = "txt_tenlophoc";
            txt_tenlophoc.Size = new Size(229, 31);
            txt_tenlophoc.TabIndex = 4;
            // 
            // txt_namhoc
            // 
            txt_namhoc.Location = new Point(262, 143);
            txt_namhoc.Name = "txt_namhoc";
            txt_namhoc.Size = new Size(229, 31);
            txt_namhoc.TabIndex = 5;
            // 
            // cbo_gv
            // 
            cbo_gv.FormattingEnabled = true;
            cbo_gv.Location = new Point(262, 218);
            cbo_gv.Name = "cbo_gv";
            cbo_gv.Size = new Size(229, 33);
            cbo_gv.TabIndex = 6;
            // 
            // dgv_lophoc
            // 
            dgv_lophoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lophoc.Location = new Point(574, 68);
            dgv_lophoc.Name = "dgv_lophoc";
            dgv_lophoc.RowHeadersWidth = 62;
            dgv_lophoc.Size = new Size(606, 240);
            dgv_lophoc.TabIndex = 7;
            dgv_lophoc.CellClick += dgv_lophoc_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(521, 347);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 31;
            button1.Text = "Làm Mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(660, 347);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(112, 34);
            btn_them.TabIndex = 30;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(1097, 347);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 34);
            btn_thoat.TabIndex = 29;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(949, 347);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(112, 34);
            btn_capnhat.TabIndex = 28;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(799, 347);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(112, 34);
            btn_xoa.TabIndex = 27;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // FrmLopHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 589);
            Controls.Add(button1);
            Controls.Add(btn_them);
            Controls.Add(btn_thoat);
            Controls.Add(btn_capnhat);
            Controls.Add(btn_xoa);
            Controls.Add(dgv_lophoc);
            Controls.Add(cbo_gv);
            Controls.Add(txt_namhoc);
            Controls.Add(txt_tenlophoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLopHoc";
            Text = "FrmLopHoc";
            ((System.ComponentModel.ISupportInitialize)dgv_lophoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_tenlophoc;
        private TextBox txt_namhoc;
        private ComboBox cbo_gv;
        private DataGridView dgv_lophoc;
        private Button button1;
        private Button btn_them;
        private Button btn_thoat;
        private Button btn_capnhat;
        private Button btn_xoa;
    }
}