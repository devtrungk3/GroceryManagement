namespace GUI.admin
{
    partial class Price
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
            groupBox1 = new GroupBox();
            cbUnit = new ComboBox();
            txtPrice = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtPriceID = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtProductID = new TextBox();
            viewPrice = new DataGridView();
            label2 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewPrice).BeginInit();
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
            label1.Size = new Size(143, 40);
            label1.TabIndex = 0;
            label1.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 87);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 16;
            label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(416, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm hoặc giá bán";
            txtSearch.Size = new Size(386, 34);
            txtSearch.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbUnit);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPriceID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Location = new Point(87, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 138);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin giá bán";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(600, 43);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(250, 28);
            cbUnit.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(600, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 30);
            txtPrice.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(507, 91);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 19;
            label5.Text = "Giá bán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(507, 45);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 17;
            label7.Text = "Đơn vị";
            // 
            // txtPriceID
            // 
            txtPriceID.Enabled = false;
            txtPriceID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriceID.Location = new Point(198, 42);
            txtPriceID.Name = "txtPriceID";
            txtPriceID.Size = new Size(250, 30);
            txtPriceID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(110, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã giá bán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 91);
            label8.Name = "label8";
            label8.Size = new Size(120, 22);
            label8.TabIndex = 14;
            label8.Text = "Mã sản phẩm";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(198, 88);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(250, 30);
            txtProductID.TabIndex = 14;
            // 
            // viewPrice
            // 
            viewPrice.AllowUserToAddRows = false;
            viewPrice.AllowUserToDeleteRows = false;
            viewPrice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewPrice.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewPrice.Location = new Point(87, 359);
            viewPrice.Name = "viewPrice";
            viewPrice.ReadOnly = true;
            viewPrice.RowHeadersWidth = 51;
            viewPrice.Size = new Size(1001, 320);
            viewPrice.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(568, 697);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 27;
            label2.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(448, 697);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 26;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(620, 697);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 25;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(994, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(994, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(994, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã giá bán";
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
            Column3.HeaderText = "Đơn vị";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Price
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewPrice);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Price";
            Text = "Price";
            Load += Price_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private TextBox txtPrice;
        private Label label5;
        private Label label7;
        private TextBox txtPriceID;
        private Label label6;
        private Label label8;
        private TextBox txtProductID;
        private DataGridView viewPrice;
        private Label label2;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbUnit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}