namespace GUI.inventory
{
    partial class Profile
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnChangePass = new Button();
            txtReNewPass = new TextBox();
            txtNewPassword = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            lbUsername = new Label();
            lbFullname = new Label();
            lbPhone = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 233, 242);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 60);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 40);
            label1.TabIndex = 0;
            label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 96);
            label2.Name = "label2";
            label2.Size = new Size(180, 26);
            label2.TabIndex = 8;
            label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(96, 26);
            label3.TabIndex = 9;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 245);
            label4.Name = "label4";
            label4.Size = new Size(180, 26);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChangePass);
            groupBox1.Controls.Add(txtReNewPass);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(620, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 277);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi mật khẩu";
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new Point(206, 230);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(126, 29);
            btnChangePass.TabIndex = 22;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtReNewPass
            // 
            txtReNewPass.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReNewPass.Location = new Point(250, 174);
            txtReNewPass.Name = "txtReNewPass";
            txtReNewPass.PasswordChar = '*';
            txtReNewPass.Size = new Size(250, 30);
            txtReNewPass.TabIndex = 21;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(250, 106);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(250, 30);
            txtNewPassword.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 182);
            label7.Name = "label7";
            label7.Size = new Size(220, 22);
            label7.TabIndex = 19;
            label7.Text = "Xác nhận mật khẩu mới";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 114);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 18;
            label6.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 45);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 12;
            label5.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(250, 37);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 30);
            txtPassword.TabIndex = 17;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(217, 96);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(180, 26);
            lbUsername.TabIndex = 12;
            lbUsername.Text = "Không xác định";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFullname.Location = new Point(217, 169);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(180, 26);
            lbFullname.TabIndex = 13;
            lbFullname.Text = "Không xác định";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(217, 245);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(180, 26);
            lbPhone.TabIndex = 14;
            lbPhone.Text = "Không xác định";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(lbPhone);
            Controls.Add(lbFullname);
            Controls.Add(lbUsername);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtReNewPass;
        private TextBox txtNewPassword;
        private Label label7;
        private Label label6;
        private TextBox txtPassword;
        private Button btnChangePass;
        private Label lbUsername;
        private Label lbFullname;
        private Label lbPhone;
    }
}