namespace GUI.inventory
{
    partial class Purchase
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
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            viewPurchase = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtpPurchaseDate = new DateTimePicker();
            viewPurchaseDetail = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 391);
            label5.Name = "label5";
            label5.Size = new Size(312, 26);
            label5.TabIndex = 30;
            label5.Text = "Chi tiết hóa đơn nhập kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 88);
            label3.Name = "label3";
            label3.Size = new Size(324, 26);
            label3.TabIndex = 29;
            label3.Text = "Danh sách hóa đơn nhập kho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 88);
            label4.Name = "label4";
            label4.Size = new Size(168, 26);
            label4.TabIndex = 23;
            label4.Text = "Ngày nhập kho";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 233, 242);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 60);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 40);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn nhập kho";
            // 
            // viewPurchase
            // 
            viewPurchase.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            viewPurchase.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewPurchase.FullRowSelect = true;
            viewPurchase.GridLines = true;
            viewPurchase.Location = new Point(316, 123);
            viewPurchase.Name = "viewPurchase";
            viewPurchase.Size = new Size(805, 224);
            viewPurchase.TabIndex = 35;
            viewPurchase.UseCompatibleStateImageBehavior = false;
            viewPurchase.View = View.Details;
            viewPurchase.SelectedIndexChanged += viewPurchase_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên nhà cung cấp";
            columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tổng tiền";
            columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày nhập kho";
            columnHeader4.Width = 250;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.CustomFormat = "MM/yyyy";
            dtpPurchaseDate.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPurchaseDate.Format = DateTimePickerFormat.Custom;
            dtpPurchaseDate.Location = new Point(40, 125);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(250, 30);
            dtpPurchaseDate.TabIndex = 36;
            dtpPurchaseDate.ValueChanged += dtpPurchaseDate_ValueChanged;
            // 
            // viewPurchaseDetail
            // 
            viewPurchaseDetail.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            viewPurchaseDetail.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewPurchaseDetail.FullRowSelect = true;
            viewPurchaseDetail.GridLines = true;
            viewPurchaseDetail.Location = new Point(40, 420);
            viewPurchaseDetail.Name = "viewPurchaseDetail";
            viewPurchaseDetail.Size = new Size(1081, 305);
            viewPurchaseDetail.TabIndex = 37;
            viewPurchaseDetail.UseCompatibleStateImageBehavior = false;
            viewPurchaseDetail.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã hóa đơn";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tên sản phẩm";
            columnHeader6.Width = 350;
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
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(viewPurchaseDetail);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(viewPurchase);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Purchase";
            Text = "Purchase";
            Load += Purchase_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private ListView viewPurchase;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DateTimePicker dtpPurchaseDate;
        private ListView viewPurchaseDetail;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}