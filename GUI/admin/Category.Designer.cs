namespace GUI.admin
{
    partial class Category
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
            panel1 = new Panel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            lbPageNumber = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtCategoryID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCategoryName = new TextBox();
            btnDelete = new Button();
            viewCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Danh mục";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 233, 242);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 60);
            panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(416, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên danh mục";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(626, 660);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 6;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(454, 660);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbPageNumber
            // 
            lbPageNumber.AutoSize = true;
            lbPageNumber.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPageNumber.Location = new Point(574, 660);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(27, 30);
            lbPageNumber.TabIndex = 8;
            lbPageNumber.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 299);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 226);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 86);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 12;
            label4.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Location = new Point(87, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 138);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin danh mục";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Enabled = false;
            txtCategoryID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryID.Location = new Point(172, 37);
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
            label6.Text = "Mã danh mục";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 91);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 14;
            label5.Text = "Tên danh mục";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(172, 91);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(250, 30);
            txtCategoryName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // viewCategory
            // 
            viewCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            viewCategory.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewCategory.FullRowSelect = true;
            viewCategory.GridLines = true;
            viewCategory.Location = new Point(87, 336);
            viewCategory.Name = "viewCategory";
            viewCategory.Size = new Size(1001, 303);
            viewCategory.TabIndex = 15;
            viewCategory.UseCompatibleStateImageBehavior = false;
            viewCategory.View = View.Details;
            viewCategory.SelectedIndexChanged += viewCategory_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã danh mục";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên danh mục";
            columnHeader2.Width = 800;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(viewCategory);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(lbPageNumber);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Category";
            Text = "Category";
            Load += Category_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnNext;
        private Button btnPrevious;
        private Label lbPageNumber;
        private Label label3;
        private Button btnUpdate;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtCategoryName;
        private Label label5;
        private Label label6;
        private TextBox txtCategoryID;
        private Button btnDelete;
        private ListView viewCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}