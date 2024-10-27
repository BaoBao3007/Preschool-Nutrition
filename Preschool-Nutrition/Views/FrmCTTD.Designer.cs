namespace Preschool_Nutrition.Views
{
    partial class FrmCTTD
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
            comboBoxTuan = new ComboBox();
            label1 = new Label();
            Buổi = new Label();
            comboBoxNgay = new ComboBox();
            dateNgay = new DateTimePicker();
            label3 = new Label();
            textBoxSLMA = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxGC = new TextBox();
            dataGridViewMonAn = new DataGridView();
            btnTTD = new Button();
            label2 = new Label();
            label6 = new Label();
            dateNgaykt = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTuan
            // 
            comboBoxTuan.FormattingEnabled = true;
            comboBoxTuan.Location = new Point(28, 138);
            comboBoxTuan.Name = "comboBoxTuan";
            comboBoxTuan.Size = new Size(182, 33);
            comboBoxTuan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 78);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "Tuần";
            // 
            // Buổi
            // 
            Buổi.AutoSize = true;
            Buổi.Location = new Point(983, 78);
            Buổi.Name = "Buổi";
            Buổi.Size = new Size(52, 25);
            Buổi.TabIndex = 3;
            Buổi.Text = "Buổi ";
            // 
            // comboBoxNgay
            // 
            comboBoxNgay.FormattingEnabled = true;
            comboBoxNgay.Location = new Point(983, 128);
            comboBoxNgay.Name = "comboBoxNgay";
            comboBoxNgay.Size = new Size(182, 33);
            comboBoxNgay.TabIndex = 2;
            comboBoxNgay.SelectedIndexChanged += comboBoxNgay_SelectedIndexChanged;
            // 
            // dateNgay
            // 
            dateNgay.Location = new Point(318, 140);
            dateNgay.Name = "dateNgay";
            dateNgay.Size = new Size(300, 31);
            dateNgay.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 78);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 5;
            label3.Text = "Ngày Bắt Đầu";
            // 
            // textBoxSLMA
            // 
            textBoxSLMA.Location = new Point(280, 212);
            textBoxSLMA.Name = "textBoxSLMA";
            textBoxSLMA.Size = new Size(155, 31);
            textBoxSLMA.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 215);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 7;
            label4.Text = "Nhập số lượng món ăn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 218);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 9;
            label5.Text = "Ghi Chú";
            // 
            // textBoxGC
            // 
            textBoxGC.Location = new Point(669, 212);
            textBoxGC.Name = "textBoxGC";
            textBoxGC.Size = new Size(155, 31);
            textBoxGC.TabIndex = 8;
            // 
            // dataGridViewMonAn
            // 
            dataGridViewMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonAn.Location = new Point(262, 282);
            dataGridViewMonAn.Name = "dataGridViewMonAn";
            dataGridViewMonAn.RowHeadersWidth = 62;
            dataGridViewMonAn.Size = new Size(933, 338);
            dataGridViewMonAn.TabIndex = 10;
            dataGridViewMonAn.CellContentClick += dataGridViewMonAn_CellContentClick;
            // 
            // btnTTD
            // 
            btnTTD.Location = new Point(1034, 218);
            btnTTD.Name = "btnTTD";
            btnTTD.Size = new Size(137, 34);
            btnTTD.TabIndex = 11;
            btnTTD.Text = "Tạo Thực Đơn";
            btnTTD.UseVisualStyleBackColor = true;
            btnTTD.Click += btnTTD_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 406);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 12;
            label2.Text = "Món Ăn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(654, 78);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 14;
            label6.Text = "Ngày Kết Thúc";
            // 
            // dateNgaykt
            // 
            dateNgaykt.Location = new Point(654, 140);
            dateNgaykt.Name = "dateNgaykt";
            dateNgaykt.Size = new Size(300, 31);
            dateNgaykt.TabIndex = 13;
            // 
            // FrmCTTD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 660);
            Controls.Add(label6);
            Controls.Add(dateNgaykt);
            Controls.Add(label2);
            Controls.Add(btnTTD);
            Controls.Add(dataGridViewMonAn);
            Controls.Add(label5);
            Controls.Add(textBoxGC);
            Controls.Add(label4);
            Controls.Add(textBoxSLMA);
            Controls.Add(label3);
            Controls.Add(dateNgay);
            Controls.Add(Buổi);
            Controls.Add(comboBoxNgay);
            Controls.Add(label1);
            Controls.Add(comboBoxTuan);
            Name = "FrmCTTD";
            Text = "FrmCTTD";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTuan;
        private Label label1;
        private Label Buổi;
        private ComboBox comboBoxNgay;
        private DateTimePicker dateNgay;
        private Label label3;
        private TextBox textBoxSLMA;
        private Label label4;
        private Label label5;
        private TextBox textBoxGC;
        private DataGridView dataGridViewMonAn;
        private Button btnTTD;
        private Label label2;
        private Label label6;
        private DateTimePicker dateNgaykt;
    }
}