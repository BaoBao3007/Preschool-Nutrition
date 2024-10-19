namespace Preschool_Nutrition.Views
{
    partial class FrmChangePass
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
            txt_username = new TextBox();
            txt_oldPassword = new TextBox();
            txt_newPassword = new TextBox();
            btn_changepass = new Button();
            label4 = new Label();
            txt_confirmPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 107);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 162);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 1;
            label2.Text = "Current password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 216);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 2;
            label3.Text = "New password:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(460, 104);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(262, 31);
            txt_username.TabIndex = 3;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.Location = new Point(460, 159);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.Size = new Size(262, 31);
            txt_oldPassword.TabIndex = 4;
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(460, 213);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(262, 31);
            txt_newPassword.TabIndex = 5;
            // 
            // btn_changepass
            // 
            btn_changepass.Location = new Point(400, 346);
            btn_changepass.Name = "btn_changepass";
            btn_changepass.Size = new Size(166, 34);
            btn_changepass.TabIndex = 6;
            btn_changepass.Text = "Change password";
            btn_changepass.UseVisualStyleBackColor = true;
            btn_changepass.Click += btn_changepass_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 269);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 7;
            label4.Text = "Re-enter new password:";
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(460, 263);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(262, 31);
            txt_confirmPassword.TabIndex = 8;
            // 
            // FrmChangePass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_confirmPassword);
            Controls.Add(label4);
            Controls.Add(btn_changepass);
            Controls.Add(txt_newPassword);
            Controls.Add(txt_oldPassword);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmChangePass";
            Text = "FrmChangePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_oldPassword;
        private TextBox txt_newPassword;
        private Button btn_changepass;
        private Label label4;
        private TextBox txt_confirmPassword;
    }
}