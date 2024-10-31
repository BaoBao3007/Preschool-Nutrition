namespace Preschool_Nutrition.Views
{
    partial class FrmLichSuDiemDanh
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
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.btnUpdateAttendance = new System.Windows.Forms.Button();
            this.btnDeleteAttendance = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox(); // Thêm ComboBox
            this.lblClass = new System.Windows.Forms.Label(); // Thêm Label cho ComboBox
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(20, 100); // Thay đổi vị trí
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(550, 250);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // btnUpdateAttendance
            // 
            this.btnUpdateAttendance.Location = new System.Drawing.Point(380, 370); // Cập nhật vị trí
            this.btnUpdateAttendance.Name = "btnUpdateAttendance";
            this.btnUpdateAttendance.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateAttendance.TabIndex = 1;
            this.btnUpdateAttendance.Text = "Cập nhật";
            this.btnUpdateAttendance.UseVisualStyleBackColor = true;
            this.btnUpdateAttendance.Click += new System.EventHandler(this.btnUpdateAttendance_Click);
            // 
            // btnDeleteAttendance
            // 
            this.btnDeleteAttendance.Location = new System.Drawing.Point(480, 370); // Cập nhật vị trí
            this.btnDeleteAttendance.Name = "btnDeleteAttendance";
            this.btnDeleteAttendance.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteAttendance.TabIndex = 2;
            this.btnDeleteAttendance.Text = "Xóa";
            this.btnDeleteAttendance.UseVisualStyleBackColor = true;
            this.btnDeleteAttendance.Click += new System.EventHandler(this.btnDeleteAttendance_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(120, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Chọn ngày:";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Chỉ cho phép chọn
            this.comboBoxClass.Location = new System.Drawing.Point(120, 60); // Đặt vị trí
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(200, 24);
            this.comboBoxClass.TabIndex = 5; // Chỉ định tab index
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged); // Thêm sự kiện
                                                                                                                         // 
                                                                                                                         // lblClass
                                                                                                                         // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(20, 65); // Đặt vị trí
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(82, 17);
            this.lblClass.TabIndex = 6; // Chỉ định tab index
            this.lblClass.Text = "Chọn lớp:";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420); // Cập nhật kích thước
            this.Controls.Add(this.lblClass); // Thêm label cho lớp học
            this.Controls.Add(this.comboBoxClass); // Thêm ComboBox
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnDeleteAttendance);
            this.Controls.Add(this.btnUpdateAttendance);
            this.Controls.Add(this.dataGridViewHistory);
            this.Name = "HistoryForm";
            this.Text = "Lịch sử điểm danh";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Button btnUpdateAttendance;
        private System.Windows.Forms.Button btnDeleteAttendance;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox comboBoxClass; // Thêm biến cho ComboBox
        private System.Windows.Forms.Label lblClass; // Thêm biến cho Label lớp học
    }
}