namespace GUI.admin
{
    partial class Order
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
            viewOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtpCreatedAt = new DateTimePicker();
            viewOrderDetail = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 407);
            label5.Name = "label5";
            label5.Size = new Size(216, 26);
            label5.TabIndex = 30;
            label5.Text = "Chi tiết đơn hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(337, 90);
            label3.Name = "label3";
            label3.Size = new Size(228, 26);
            label3.TabIndex = 29;
            label3.Text = "Danh sách đơn hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 90);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 23;
            label4.Text = "Ngày tạo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 233, 242);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 60);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Đơn hàng";
            // 
            // viewOrder
            // 
            viewOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            viewOrder.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewOrder.FullRowSelect = true;
            viewOrder.GridLines = true;
            viewOrder.Location = new Point(337, 127);
            viewOrder.Name = "viewOrder";
            viewOrder.Size = new Size(776, 262);
            viewOrder.TabIndex = 35;
            viewOrder.UseCompatibleStateImageBehavior = false;
            viewOrder.View = View.Details;
            viewOrder.SelectedIndexChanged += viewOrder_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã đơn hàng";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên TK nhân viên";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tổng tiền";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày tạo";
            columnHeader4.Width = 240;
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.CustomFormat = "dd/MM/yyyy";
            dtpCreatedAt.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCreatedAt.Format = DateTimePickerFormat.Custom;
            dtpCreatedAt.Location = new Point(49, 127);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(250, 30);
            dtpCreatedAt.TabIndex = 36;
            dtpCreatedAt.ValueChanged += dtpCreatedAt_ValueChanged;
            // 
            // viewOrderDetail
            // 
            viewOrderDetail.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            viewOrderDetail.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewOrderDetail.FullRowSelect = true;
            viewOrderDetail.GridLines = true;
            viewOrderDetail.Location = new Point(49, 436);
            viewOrderDetail.Name = "viewOrderDetail";
            viewOrderDetail.Size = new Size(1064, 283);
            viewOrderDetail.TabIndex = 37;
            viewOrderDetail.UseCompatibleStateImageBehavior = false;
            viewOrderDetail.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã đơn hàng";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tên sản phẩm";
            columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Đơn vị";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Đơn giá";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Số lượng";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Tổng tiền";
            columnHeader10.Width = 150;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(viewOrderDetail);
            Controls.Add(dtpCreatedAt);
            Controls.Add(viewOrder);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            Text = "Order";
            Load += Order_Load;
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
        private ListView viewOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DateTimePicker dtpCreatedAt;
        private ListView viewOrderDetail;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}