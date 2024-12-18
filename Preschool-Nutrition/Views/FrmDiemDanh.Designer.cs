﻿namespace Preschool_Nutrition.Views
{
    partial class FrmDiemDanh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxClass = new ComboBox();
            dataGridViewStudents = new DataGridView();
            btnSaveAttendance = new Button();
            lblClass = new Label();
            btn_lsdd = new Button();
            btn_logout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(100, 31);
            comboBoxClass.Margin = new Padding(4, 5, 4, 5);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(249, 33);
            comboBoxClass.TabIndex = 0;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(25, 94);
            dataGridViewStudents.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.RowTemplate.Height = 24;
            dataGridViewStudents.Size = new Size(625, 391);
            dataGridViewStudents.TabIndex = 1;
            // 
            // btnSaveAttendance
            // 
            btnSaveAttendance.Location = new Point(308, 500);
            btnSaveAttendance.Margin = new Padding(4, 5, 4, 5);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(150, 47);
            btnSaveAttendance.TabIndex = 2;
            btnSaveAttendance.Text = "Lưu điểm danh";
            btnSaveAttendance.UseVisualStyleBackColor = true;
            btnSaveAttendance.Click += btnSaveAttendance_Click;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(25, 36);
            lblClass.Margin = new Padding(4, 0, 4, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(80, 25);
            lblClass.TabIndex = 3;
            lblClass.Text = "Lớp học:";
            // 
            // btn_lsdd
            // 
            btn_lsdd.Location = new Point(25, 500);
            btn_lsdd.Margin = new Padding(4, 5, 4, 5);
            btn_lsdd.Name = "btn_lsdd";
            btn_lsdd.Size = new Size(255, 47);
            btn_lsdd.TabIndex = 4;
            btn_lsdd.Text = "Xem lịch sử điểm danh";
            btn_lsdd.UseVisualStyleBackColor = true;
            btn_lsdd.Click += btn_lsdd_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(490, 500);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(160, 47);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Đăng xuất";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // FrmDiemDanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 596);
            Controls.Add(btn_logout);
            Controls.Add(btn_lsdd);
            Controls.Add(lblClass);
            Controls.Add(btnSaveAttendance);
            Controls.Add(dataGridViewStudents);
            Controls.Add(comboBoxClass);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmDiemDanh";
            Text = "Điểm danh";
            Load += FrmDiemDanh_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Label lblClass;
        private Button btn_lsdd;
        private Button btn_logout;
    }
}