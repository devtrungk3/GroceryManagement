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
            txtUnitPrice = new TextBox();
            label3 = new Label();
            label7 = new Label();
            txtProductID = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label2 = new Label();
            btnComplete = new Button();
            viewImport = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            lbTotalAmount = new Label();
            btnUpdate = new Button();
            panel1.SuspendLayout();
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
            groupBox2.Controls.Add(txtUnitPrice);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtProductID);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Location = new Point(75, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 143);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(540, 40);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(227, 28);
            cbUnit.TabIndex = 24;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(540, 86);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(227, 30);
            txtUnitPrice.TabIndex = 22;
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
            // txtQuantity
            // 
            txtQuantity.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(168, 86);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(227, 30);
            txtQuantity.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(906, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(906, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 677);
            label2.Name = "label2";
            label2.Size = new Size(120, 26);
            label2.TabIndex = 27;
            label2.Text = "Tổng tiền";
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComplete.Location = new Point(938, 668);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(138, 39);
            btnComplete.TabIndex = 28;
            btnComplete.Text = "Xác nhận";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // viewImport
            // 
            viewImport.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            viewImport.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewImport.FullRowSelect = true;
            viewImport.GridLines = true;
            viewImport.Location = new Point(75, 314);
            viewImport.Name = "viewImport";
            viewImport.Size = new Size(1001, 322);
            viewImport.TabIndex = 37;
            viewImport.UseCompatibleStateImageBehavior = false;
            viewImport.View = View.Details;
            viewImport.SelectedIndexChanged += viewImport_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tên sản phẩm";
            columnHeader6.Width = 440;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Số lượng";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Đơn vị";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Đơn giá";
            columnHeader9.Width = 250;
            // 
            // lbTotalAmount
            // 
            lbTotalAmount.AutoSize = true;
            lbTotalAmount.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalAmount.Location = new Point(216, 670);
            lbTotalAmount.Name = "lbTotalAmount";
            lbTotalAmount.Size = new Size(34, 37);
            lbTotalAmount.TabIndex = 38;
            lbTotalAmount.Text = "0";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(906, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Import
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnUpdate);
            Controls.Add(lbTotalAmount);
            Controls.Add(viewImport);
            Controls.Add(btnComplete);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private ComboBox cbSuppiler;
        private GroupBox groupBox2;
        private TextBox txtUnitPrice;
        private Label label3;
        private Label label7;
        private TextBox txtProductID;
        private Label label8;
        private Label label9;
        private TextBox txtQuantity;
        private ComboBox cbUnit;
        private Button btnAdd;
        private Button btnDelete;
        private Label label2;
        private Button btnComplete;
        private ListView viewImport;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label lbTotalAmount;
        private Button btnUpdate;
    }
}