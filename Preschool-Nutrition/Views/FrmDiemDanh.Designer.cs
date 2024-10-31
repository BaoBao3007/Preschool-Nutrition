namespace Preschool_Nutrition.Views
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
            btnSaveAttendance.Location = new Point(500, 500);
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
            // FrmDiemDanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 596);
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
    }
}