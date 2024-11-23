namespace GUI.admin
{
    partial class Unit
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
            txtUnitID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtUnitName = new TextBox();
            btnDelete = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 0;
            label1.Text = "Đơn vị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 86);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 28;
            label4.Text = "Tìm kiếm";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(576, 701);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 26;
            label2.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(456, 701);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 25;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(628, 701);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 24;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // viewProduct
            // 
            viewProduct.AllowUserToAddRows = false;
            viewProduct.AllowUserToDeleteRows = false;
            viewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            viewProduct.Location = new Point(87, 357);
            viewProduct.Name = "viewProduct";
            viewProduct.ReadOnly = true;
            viewProduct.RowHeadersWidth = 51;
            viewProduct.Size = new Size(1001, 320);
            viewProduct.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(416, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên đơn vị";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUnitID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUnitName);
            groupBox1.Location = new Point(87, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 138);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin danh mục";
            // 
            // txtUnitID
            // 
            txtUnitID.Enabled = false;
            txtUnitID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitID.Location = new Point(172, 37);
            txtUnitID.Name = "txtUnitID";
            txtUnitID.Size = new Size(250, 30);
            txtUnitID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã đơn vị";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 91);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 14;
            label5.Text = "Tên đơn vị";
            // 
            // txtUnitName
            // 
            txtUnitName.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitName.Location = new Point(172, 91);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(250, 30);
            txtUnitName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn vị";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên đơn vị";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Unit
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
            Name = "Unit";
            Text = "Unit";
            Load += Unit_Load;
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
        private TextBox txtUnitID;
        private Label label6;
        private Label label5;
        private TextBox txtUnitName;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}