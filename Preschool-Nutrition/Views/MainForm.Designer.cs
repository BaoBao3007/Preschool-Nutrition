namespace Preschool_Nutrition.Views
{
    partial class MainForm
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
            panelLeft = new Panel();
            btn_gv = new Button();
            btn_monan = new Button();
            btn_nguyenlieu = new Button();
            btn_lophoc = new Button();
            btn_hs = new Button();
            panelRight = new Panel();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.Highlight;
            panelLeft.Controls.Add(btn_gv);
            panelLeft.Controls.Add(btn_monan);
            panelLeft.Controls.Add(btn_nguyenlieu);
            panelLeft.Controls.Add(btn_lophoc);
            panelLeft.Controls.Add(btn_hs);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(349, 900);
            panelLeft.TabIndex = 0;
            // 
            // btn_gv
            // 
            btn_gv.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_gv.Location = new Point(0, 241);
            btn_gv.Name = "btn_gv";
            btn_gv.Size = new Size(349, 43);
            btn_gv.TabIndex = 4;
            btn_gv.Text = "Quản lý giáo viên";
            btn_gv.UseVisualStyleBackColor = true;
            btn_gv.Click += btn_gv_Click;
            // 
            // btn_monan
            // 
            btn_monan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_monan.Location = new Point(0, 480);
            btn_monan.Name = "btn_monan";
            btn_monan.Size = new Size(349, 43);
            btn_monan.TabIndex = 3;
            btn_monan.Text = "Quản lý món ăn";
            btn_monan.UseVisualStyleBackColor = true;
            btn_monan.Click += btn_monan_Click;
            // 
            // btn_nguyenlieu
            // 
            btn_nguyenlieu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nguyenlieu.Location = new Point(0, 420);
            btn_nguyenlieu.Name = "btn_nguyenlieu";
            btn_nguyenlieu.Size = new Size(349, 43);
            btn_nguyenlieu.TabIndex = 0;
            btn_nguyenlieu.Text = "Quản lý nguyên liệu";
            btn_nguyenlieu.UseVisualStyleBackColor = true;
            btn_nguyenlieu.Click += btn_nguyenlieu_Click;
            // 
            // btn_lophoc
            // 
            btn_lophoc.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lophoc.Location = new Point(0, 360);
            btn_lophoc.Name = "btn_lophoc";
            btn_lophoc.Size = new Size(349, 43);
            btn_lophoc.TabIndex = 2;
            btn_lophoc.Text = "Quản lý lớp học";
            btn_lophoc.UseVisualStyleBackColor = true;
            btn_lophoc.Click += btn_lophoc_Click;
            // 
            // btn_hs
            // 
            btn_hs.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hs.Location = new Point(0, 300);
            btn_hs.Name = "btn_hs";
            btn_hs.Size = new Size(349, 43);
            btn_hs.TabIndex = 1;
            btn_hs.Text = "Quản lý học sinh";
            btn_hs.UseVisualStyleBackColor = true;
            btn_hs.Click += btn_hs_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.Control;
            panelRight.Location = new Point(349, 0);
            panelRight.Margin = new Padding(0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1229, 900);
            panelRight.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "MainForm";
            Text = "MainForm";
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Button btn_lophoc;
        private Button btn_hs;
        private Button btn_nguyenlieu;
        private Button btn_monan;
        private Button btn_gv;
    }
}