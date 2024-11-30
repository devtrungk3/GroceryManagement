namespace GUI.vendor
{
    partial class Account
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
            txtAccountName = new TextBox();
            label4 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            btnUpdate = new Button();
            txtComfirmPass = new TextBox();
            label5 = new Label();
            txtNewPass = new TextBox();
            label6 = new Label();
            txtCurrentPass = new TextBox();
            label7 = new Label();
            btnChangePass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 19.7999973F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 118, 225);
            label1.Location = new Point(58, 52);
            label1.Name = "label1";
            label1.Size = new Size(199, 44);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // txtAccountName
            // 
            txtAccountName.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtAccountName.Location = new Point(135, 218);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(387, 38);
            txtAccountName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 178);
            label4.Name = "label4";
            label4.Size = new Size(238, 37);
            label4.TabIndex = 10;
            label4.Text = "Tên tài khoản";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(135, 335);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(387, 38);
            txtUserName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 295);
            label2.Name = "label2";
            label2.Size = new Size(255, 37);
            label2.TabIndex = 12;
            label2.Text = "Tên người dùng";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(135, 461);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(387, 38);
            txtPhone.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 421);
            label3.Name = "label3";
            label3.Size = new Size(238, 37);
            label3.TabIndex = 14;
            label3.Text = "Số điện thoại";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 118, 225);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(237, 531);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(169, 55);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtComfirmPass
            // 
            txtComfirmPass.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtComfirmPass.Location = new Point(660, 461);
            txtComfirmPass.Name = "txtComfirmPass";
            txtComfirmPass.PasswordChar = '*';
            txtComfirmPass.Size = new Size(434, 38);
            txtComfirmPass.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(660, 421);
            label5.Name = "label5";
            label5.Size = new Size(306, 37);
            label5.TabIndex = 21;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(660, 335);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(434, 38);
            txtNewPass.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(660, 295);
            label6.Name = "label6";
            label6.Size = new Size(221, 37);
            label6.TabIndex = 19;
            label6.Text = "Mật khẩu mới";
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCurrentPass.Location = new Point(660, 218);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.PasswordChar = '*';
            txtCurrentPass.Size = new Size(434, 38);
            txtCurrentPass.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(660, 178);
            label7.Name = "label7";
            label7.Size = new Size(306, 37);
            label7.TabIndex = 17;
            label7.Text = "Mật khẩu hiện tại";
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(0, 118, 225);
            btnChangePass.Cursor = Cursors.Hand;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(776, 531);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(199, 55);
            btnChangePass.TabIndex = 22;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = false;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 785);
            Controls.Add(btnChangePass);
            Controls.Add(txtComfirmPass);
            Controls.Add(label5);
            Controls.Add(txtNewPass);
            Controls.Add(label6);
            Controls.Add(txtCurrentPass);
            Controls.Add(label7);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtAccountName);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccountName;
        private Label label4;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private Button btnUpdate;
        private TextBox txtComfirmPass;
        private Label label5;
        private TextBox txtNewPass;
        private Label label6;
        private TextBox txtCurrentPass;
        private Label label7;
        private Button btnChangePass;
    }
}