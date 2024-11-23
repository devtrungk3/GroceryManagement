namespace GUI.inventory
{
    partial class Import
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
            cbSuppiler = new ComboBox();
            groupBox2 = new GroupBox();
            cbUnit = new ComboBox();
            txtPhone = new TextBox();
            label3 = new Label();
            label7 = new Label();
            txtProductID = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtQuatity = new TextBox();
            viewProduct = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtTotalAmount = new TextBox();
            btnComplete = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewProduct).BeginInit();
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
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Nhập kho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 77);
            label4.Name = "label4";
            label4.Size = new Size(204, 26);
            label4.TabIndex = 14;
            label4.Text = "Tên nhà cung cấp";
            // 
            // cbSuppiler
            // 
            cbSuppiler.FormattingEnabled = true;
            cbSuppiler.Location = new Point(285, 78);
            cbSuppiler.Name = "cbSuppiler";
            cbSuppiler.Size = new Size(250, 28);
            cbSuppiler.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbUnit);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtProductID);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtQuatity);
            groupBox2.Location = new Point(75, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 143);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(540, 40);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(227, 28);
            cbUnit.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(540, 86);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 30);
            txtPhone.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(424, 91);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 18;
            label3.Text = "Đơn giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(424, 45);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 17;
            label7.Text = "Đơn vị";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(168, 38);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(227, 30);
            txtProductID.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 45);
            label8.Name = "label8";
            label8.Size = new Size(120, 22);
            label8.TabIndex = 15;
            label8.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 91);
            label9.Name = "label9";
            label9.Size = new Size(90, 22);
            label9.TabIndex = 14;
            label9.Text = "Số lượng";
            // 
            // txtQuatity
            // 
            txtQuatity.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuatity.Location = new Point(168, 86);
            txtQuatity.Name = "txtQuatity";
            txtQuatity.Size = new Size(227, 30);
            txtQuatity.TabIndex = 14;
            // 
            // viewProduct
            // 
            viewProduct.AllowUserToAddRows = false;
            viewProduct.AllowUserToDeleteRows = false;
            viewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewProduct.Location = new Point(75, 322);
            viewProduct.Name = "viewProduct";
            viewProduct.ReadOnly = true;
            viewProduct.RowHeadersWidth = 51;
            viewProduct.Size = new Size(1001, 245);
            viewProduct.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(906, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(906, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 597);
            label2.Name = "label2";
            label2.Size = new Size(120, 26);
            label2.TabIndex = 27;
            label2.Text = "Tổng tiền";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(201, 590);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(227, 38);
            txtTotalAmount.TabIndex = 25;
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComplete.Location = new Point(938, 584);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(138, 39);
            btnComplete.TabIndex = 28;
            btnComplete.Text = "Xác nhận";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn vị";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Import
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnComplete);
            Controls.Add(txtTotalAmount);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(viewProduct);
            Controls.Add(groupBox2);
            Controls.Add(cbSuppiler);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Import";
            Text = "Import";
            Load += Import_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private ComboBox cbSuppiler;
        private GroupBox groupBox2;
        private TextBox txtPhone;
        private Label label3;
        private Label label7;
        private TextBox txtProductID;
        private Label label8;
        private Label label9;
        private TextBox txtQuatity;
        private ComboBox cbUnit;
        private DataGridView viewProduct;
        private Button btnAdd;
        private Button btnDelete;
        private Label label2;
        private TextBox txtTotalAmount;
        private Button btnComplete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}