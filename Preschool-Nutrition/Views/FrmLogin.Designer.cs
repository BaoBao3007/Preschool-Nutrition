namespace Preschool_Nutrition.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            chk_remember = new CheckBox();
            chk_showpass = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_login = new Button();
            btn_changepass = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(665, 216);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(669, 292);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(634, 130);
            label3.Name = "label3";
            label3.Size = new Size(504, 44);
            label3.TabIndex = 2;
            label3.Text = "PRESCHOOL NUTRITION SYSTEM";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(766, 213);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(372, 31);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(766, 292);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(372, 31);
            txt_password.TabIndex = 4;
            // 
            // chk_remember
            // 
            chk_remember.AutoSize = true;
            chk_remember.Location = new Point(766, 356);
            chk_remember.Name = "chk_remember";
            chk_remember.Size = new Size(169, 29);
            chk_remember.TabIndex = 5;
            chk_remember.Text = "Remember login";
            chk_remember.UseVisualStyleBackColor = true;
            // 
            // chk_showpass
            // 
            chk_showpass.AutoSize = true;
            chk_showpass.Location = new Point(974, 356);
            chk_showpass.Name = "chk_showpass";
            chk_showpass.Size = new Size(164, 29);
            chk_showpass.TabIndex = 6;
            chk_showpass.Text = "Show password";
            chk_showpass.UseVisualStyleBackColor = true;
            chk_showpass.CheckedChanged += chk_showpass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(617, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(617, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-3, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(585, 598);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(766, 447);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 10;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_changepass
            // 
            btn_changepass.Location = new Point(944, 447);
            btn_changepass.Name = "btn_changepass";
            btn_changepass.Size = new Size(166, 34);
            btn_changepass.TabIndex = 11;
            btn_changepass.Text = "Change password";
            btn_changepass.UseVisualStyleBackColor = true;
            btn_changepass.Click += btn_changepass_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 593);
            Controls.Add(btn_changepass);
            Controls.Add(btn_login);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(chk_showpass);
            Controls.Add(chk_remember);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private CheckBox chk_remember;
        private CheckBox chk_showpass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_login;
        private Button btn_changepass;
    }
}