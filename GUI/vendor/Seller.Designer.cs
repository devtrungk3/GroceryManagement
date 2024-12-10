namespace GUI.vendor
{
    partial class Seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller));
            label1 = new Label();
            label2 = new Label();
            txtProductID = new TextBox();
            btnCheckProduct = new PictureBox();
            groupBox1 = new GroupBox();
            btnAddOrder = new Button();
            txtTotalAmount = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtTotalPrice = new TextBox();
            label7 = new Label();
            cbUnit = new ComboBox();
            txtQuantity = new NumericUpDown();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            label8 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            viewOrderDetail = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)btnCheckProduct).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 19.7999973F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 118, 225);
            label1.Location = new Point(58, 52);
            label1.Name = "label1";
            label1.Size = new Size(179, 44);
            label1.TabIndex = 0;
            label1.Text = "Đặt hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(58, 132);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(58, 172);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(290, 38);
            txtProductID.TabIndex = 2;
            // 
            // btnCheckProduct
            // 
            btnCheckProduct.Cursor = Cursors.Hand;
            btnCheckProduct.Image = (Image)resources.GetObject("btnCheckProduct.Image");
            btnCheckProduct.Location = new Point(368, 172);
            btnCheckProduct.Name = "btnCheckProduct";
            btnCheckProduct.Size = new Size(38, 38);
            btnCheckProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCheckProduct.TabIndex = 3;
            btnCheckProduct.TabStop = false;
            btnCheckProduct.Click += btnCheckProduct_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddOrder);
            groupBox1.Controls.Add(txtTotalAmount);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(58, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 244);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(0, 118, 225);
            btnAddOrder.Cursor = Cursors.Hand;
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(137, 163);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(111, 55);
            btnAddOrder.TabIndex = 7;
            btnAddOrder.Text = "Xuất";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(32, 99);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(325, 38);
            txtTotalAmount.TabIndex = 6;
            txtTotalAmount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(32, 56);
            label3.Name = "label3";
            label3.Size = new Size(221, 37);
            label3.TabIndex = 5;
            label3.Text = "Tổng hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalPrice);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbUnit);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(btnDeleteProduct);
            groupBox2.Controls.Add(btnAddProduct);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(486, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(690, 357);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(49, 294);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(266, 38);
            txtTotalPrice.TabIndex = 20;
            txtTotalPrice.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(49, 254);
            label7.Name = "label7";
            label7.Size = new Size(187, 37);
            label7.TabIndex = 21;
            label7.Text = "Thành tiền";
            // 
            // cbUnit
            // 
            cbUnit.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbUnit.FormattingEnabled = true;
            cbUnit.Items.AddRange(new object[] { "Lít", "Cái", "Kg" });
            cbUnit.Location = new Point(418, 200);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(227, 38);
            cbUnit.TabIndex = 19;
            cbUnit.SelectedIndexChanged += cbUnit_SelectedIndexChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(49, 200);
            txtQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(325, 38);
            txtQuantity.TabIndex = 18;
            txtQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(0, 118, 225);
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(534, 276);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(111, 55);
            btnDeleteProduct.TabIndex = 17;
            btnDeleteProduct.Text = "Xóa";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(0, 118, 225);
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(397, 276);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(111, 55);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(418, 160);
            label8.Name = "label8";
            label8.Size = new Size(119, 37);
            label8.TabIndex = 16;
            label8.Text = "Đơn vị";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(49, 160);
            label6.Name = "label6";
            label6.Size = new Size(153, 37);
            label6.TabIndex = 12;
            label6.Text = "Số lượng";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(418, 104);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(227, 38);
            txtPrice.TabIndex = 9;
            txtPrice.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(418, 64);
            label5.Name = "label5";
            label5.Size = new Size(136, 37);
            label5.TabIndex = 10;
            label5.Text = "Đơn giá";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(49, 104);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(325, 38);
            txtProductName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(49, 64);
            label4.Name = "label4";
            label4.Size = new Size(221, 37);
            label4.TabIndex = 8;
            label4.Text = "Tên sản phẩm";
            // 
            // viewOrderDetail
            // 
            viewOrderDetail.Alignment = ListViewAlignment.Default;
            viewOrderDetail.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader2, columnHeader1, columnHeader4, columnHeader5 });
            viewOrderDetail.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            viewOrderDetail.FullRowSelect = true;
            viewOrderDetail.GridLines = true;
            viewOrderDetail.Location = new Point(58, 511);
            viewOrderDetail.Name = "viewOrderDetail";
            viewOrderDetail.Size = new Size(1118, 262);
            viewOrderDetail.TabIndex = 6;
            viewOrderDetail.UseCompatibleStateImageBehavior = false;
            viewOrderDetail.View = View.Details;
            viewOrderDetail.SelectedIndexChanged += viewOrderDetail_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên sản phẩm";
            columnHeader3.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Đơn vị";
            columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Đơn giá";
            columnHeader1.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tổng tiền";
            columnHeader5.Width = 260;
            // 
            // Seller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 785);
            Controls.Add(viewOrderDetail);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCheckProduct);
            Controls.Add(txtProductID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Seller";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)btnCheckProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProductID;
        private PictureBox btnCheckProduct;
        private GroupBox groupBox1;
        private Button btnAddOrder;
        private TextBox txtTotalAmount;
        private Label label3;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtProductName;
        private Label label4;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private Label label8;
        private ComboBox cbUnit;
        private NumericUpDown txtQuantity;
        private ListView viewOrderDetail;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox txtTotalPrice;
        private Label label7;
    }
}