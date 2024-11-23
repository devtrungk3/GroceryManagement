namespace GUI.admin
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
            panel1 = new Panel();
            label1 = new Label();
            viewAccount = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            viewRole = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            txtAccountRoleID = new TextBox();
            label10 = new Label();
            txtPhone = new TextBox();
            txtFullname = new TextBox();
            label3 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtPassword = new TextBox();
            btnAddAccount = new Button();
            btnUpdateAccount = new Button();
            btnDeleteAccount = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewRole).BeginInit();
            groupBox2.SuspendLayout();
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
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 40);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // viewAccount
            // 
            viewAccount.AllowUserToAddRows = false;
            viewAccount.AllowUserToDeleteRows = false;
            viewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAccount.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewAccount.Location = new Point(22, 437);
            viewAccount.Name = "viewAccount";
            viewAccount.ReadOnly = true;
            viewAccount.RowHeadersWidth = 51;
            viewAccount.Size = new Size(768, 270);
            viewAccount.TabIndex = 6;
            viewAccount.CellContentClick += viewAccount_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên tài khoản";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Vai trò";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // viewRole
            // 
            viewRole.AllowUserToAddRows = false;
            viewRole.AllowUserToDeleteRows = false;
            viewRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewRole.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6 });
            viewRole.Location = new Point(823, 437);
            viewRole.Name = "viewRole";
            viewRole.ReadOnly = true;
            viewRole.RowHeadersWidth = 51;
            viewRole.Size = new Size(321, 270);
            viewRole.TabIndex = 7;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã vai trò";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tên vai trò";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 86);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 14;
            label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(146, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên hoặc số điện thoại";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAccountRoleID);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtFullname);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Location = new Point(22, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(768, 179);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // txtAccountRoleID
            // 
            txtAccountRoleID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccountRoleID.Location = new Point(168, 133);
            txtAccountRoleID.Name = "txtAccountRoleID";
            txtAccountRoleID.Size = new Size(227, 30);
            txtAccountRoleID.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 136);
            label10.Name = "label10";
            label10.Size = new Size(110, 22);
            label10.TabIndex = 23;
            label10.Text = "Mã vai trò";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(500, 86);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 30);
            txtPhone.TabIndex = 22;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(500, 38);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(227, 30);
            txtFullname.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(424, 91);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 18;
            label3.Text = "Số ĐT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(424, 45);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 17;
            label7.Text = "Họ tên";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(168, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 30);
            txtUsername.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 45);
            label8.Name = "label8";
            label8.Size = new Size(140, 22);
            label8.TabIndex = 15;
            label8.Text = "Tên tài khoản";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 91);
            label9.Name = "label9";
            label9.Size = new Size(130, 22);
            label9.TabIndex = 14;
            label9.Text = "Mật khẩu mới";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(168, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(227, 30);
            txtPassword.TabIndex = 14;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(46, 391);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(108, 29);
            btnAddAccount.TabIndex = 23;
            btnAddAccount.Text = "Tạo tài khoản";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(174, 391);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(108, 29);
            btnUpdateAccount.TabIndex = 24;
            btnUpdateAccount.Text = "Sửa tài khoản";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(303, 391);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(112, 29);
            btnDeleteAccount.TabIndex = 25;
            btnDeleteAccount.Text = "Xóa tài khoản";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(viewRole);
            Controls.Add(viewAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewRole).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView viewAccount;
        private DataGridView viewRole;
        private Label label4;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Label label3;
        private Label label7;
        private TextBox txtUsername;
        private Label label8;
        private Label label9;
        private TextBox txtPassword;
        private TextBox txtFullname;
        private TextBox txtPhone;
        private Label label10;
        private TextBox txtAccountRoleID;
        private Button btnAddAccount;
        private Button btnUpdateAccount;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnDeleteAccount;
    }
}