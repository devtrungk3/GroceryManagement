namespace GUI.admin
{
    partial class Product
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
            btnUpdate = new Button();
            label2 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            viewProduct = new DataGridView();
            btnAdd = new Button();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            cbUnit = new ComboBox();
            cbCategory = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            txtCategoryID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCategoryName = new TextBox();
            btnDelete = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewProduct).BeginInit();
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
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 86);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(994, 226);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(575, 710);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 18;
            label2.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(455, 710);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 17;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(627, 710);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 16;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // viewProduct
            // 
            viewProduct.AllowUserToAddRows = false;
            viewProduct.AllowUserToDeleteRows = false;
            viewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewProduct.Location = new Point(87, 369);
            viewProduct.Name = "viewProduct";
            viewProduct.ReadOnly = true;
            viewProduct.RowHeadersWidth = 51;
            viewProduct.Size = new Size(1001, 320);
            viewProduct.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(994, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(416, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbUnit);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Location = new Point(87, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(880, 138);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(601, 88);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(250, 28);
            cbUnit.TabIndex = 20;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(601, 39);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 28);
            cbCategory.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 91);
            label3.Name = "label3";
            label3.Size = new Size(160, 22);
            label3.TabIndex = 18;
            label3.Text = "Đơn vị mặc định";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(485, 45);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 17;
            label7.Text = "Danh mục";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryID.Location = new Point(158, 37);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(250, 30);
            txtCategoryID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 91);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 14;
            label5.Text = "Tên sản phẩm";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(158, 86);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(250, 30);
            txtCategoryName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(994, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
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
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên danh mục";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn vị mặc định";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewProduct);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Button btnUpdate;
        private Label label2;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridView viewProduct;
        private Button btnAdd;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private TextBox txtCategoryID;
        private Label label6;
        private Label label5;
        private TextBox txtCategoryName;
        private ComboBox cbUnit;
        private ComboBox cbCategory;
        private Label label3;
        private Label label7;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}