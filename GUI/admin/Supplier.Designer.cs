namespace GUI.admin
{
    partial class Supplier
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
            label4 = new Label();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            label3 = new Label();
            lbPageNumber = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            viewSupplier = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            txtSupplierID = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtSupplierName = new TextBox();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewSupplier).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 0;
            label1.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 86);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 14;
            label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(416, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên hoặc số điện thoại";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1026, 228);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 370);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 20;
            // 
            // lbPageNumber
            // 
            lbPageNumber.AutoSize = true;
            lbPageNumber.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPageNumber.Location = new Point(576, 709);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(27, 30);
            lbPageNumber.TabIndex = 19;
            lbPageNumber.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(455, 709);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(628, 709);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 17;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // viewSupplier
            // 
            viewSupplier.AllowUserToAddRows = false;
            viewSupplier.AllowUserToDeleteRows = false;
            viewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewSupplier.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewSupplier.Location = new Point(90, 363);
            viewSupplier.Name = "viewSupplier";
            viewSupplier.ReadOnly = true;
            viewSupplier.RowHeadersWidth = 51;
            viewSupplier.Size = new Size(1001, 320);
            viewSupplier.TabIndex = 16;
            viewSupplier.CellContentClick += viewSupplier_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhà cung cấp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhà cung cấp";
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
            Column4.HeaderText = "Địa chỉ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1026, 178);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSupplierID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSupplierName);
            groupBox1.Location = new Point(87, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 138);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(631, 88);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 30);
            txtAddress.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(485, 91);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 19;
            label5.Text = "Địa chỉ";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(631, 42);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 30);
            txtPhone.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(485, 45);
            label7.Name = "label7";
            label7.Size = new Size(140, 22);
            label7.TabIndex = 17;
            label7.Text = "Số điện thoại";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Enabled = false;
            txtSupplierID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierID.Location = new Point(198, 42);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(250, 30);
            txtSupplierID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(160, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã nhà cung cấp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 91);
            label8.Name = "label8";
            label8.Size = new Size(170, 22);
            label8.TabIndex = 14;
            label8.Text = "Tên nhà cung cấp";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(198, 88);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(250, 30);
            txtSupplierName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1026, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(lbPageNumber);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewSupplier);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Supplier";
            Text = "Supplier";
            Load += Supplier_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewSupplier).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Label label3;
        private Label lbPageNumber;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridView viewSupplier;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtSupplierID;
        private Label label6;
        private Label label8;
        private TextBox txtSupplierName;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtAddress;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}