namespace GUI.vendor
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
            label1 = new Label();
            label2 = new Label();
            dtpCreatedAt = new DateTimePicker();
            viewOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label3 = new Label();
            viewOrderDetail = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
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
            label1.TabIndex = 1;
            label1.Text = "Đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 123);
            label2.Name = "label2";
            label2.Size = new Size(170, 37);
            label2.TabIndex = 3;
            label2.Text = "Ngày xuất";
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.Cursor = Cursors.Hand;
            dtpCreatedAt.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpCreatedAt.Location = new Point(58, 163);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(395, 34);
            dtpCreatedAt.TabIndex = 4;
            dtpCreatedAt.ValueChanged += dtpCreatedAt_ValueChanged;
            // 
            // viewOrder
            // 
            viewOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            viewOrder.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            viewOrder.FullRowSelect = true;
            viewOrder.GridLines = true;
            viewOrder.Location = new Point(517, 163);
            viewOrder.Name = "viewOrder";
            viewOrder.Size = new Size(657, 273);
            viewOrder.TabIndex = 5;
            viewOrder.UseCompatibleStateImageBehavior = false;
            viewOrder.View = View.Details;
            viewOrder.SelectedIndexChanged += viewOrder_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã hóa đơn";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ngày xuất";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thành tiền";
            columnHeader3.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 123);
            label3.Name = "label3";
            label3.Size = new Size(306, 37);
            label3.TabIndex = 6;
            label3.Text = "Danh sách hóa đơn";
            // 
            // viewOrderDetail
            // 
            viewOrderDetail.Alignment = ListViewAlignment.Default;
            viewOrderDetail.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            viewOrderDetail.Font = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            viewOrderDetail.GridLines = true;
            viewOrderDetail.Location = new Point(58, 477);
            viewOrderDetail.Name = "viewOrderDetail";
            viewOrderDetail.Size = new Size(1118, 296);
            viewOrderDetail.TabIndex = 22;
            viewOrderDetail.UseCompatibleStateImageBehavior = false;
            viewOrderDetail.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên sản phẩm";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Đơn vị";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Đơn giá";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Số lượng";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tổng tiền";
            columnHeader8.Width = 260;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 785);
            Controls.Add(viewOrderDetail);
            Controls.Add(label3);
            Controls.Add(viewOrder);
            Controls.Add(dtpCreatedAt);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpCreatedAt;
        private ListView viewOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private ListView viewOrderDetail;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}