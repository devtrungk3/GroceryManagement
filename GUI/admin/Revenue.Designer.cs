namespace GUI.admin
{
    partial class Revenue
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
            label2 = new Label();
            label3 = new Label();
            viewRevenue = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtTotalAmount = new TextBox();
            txtTotalOrder = new TextBox();
            datePicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnCalculateTotal = new Button();
            panel1.SuspendLayout();
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
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 40);
            label1.TabIndex = 0;
            label1.Text = "Doanh thu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 26);
            label2.Name = "label2";
            label2.Size = new Size(153, 30);
            label2.TabIndex = 5;
            label2.Text = "Doanh thu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 13.7999992F);
            label3.Location = new Point(18, 77);
            label3.Name = "label3";
            label3.Size = new Size(195, 30);
            label3.TabIndex = 6;
            label3.Text = "Số đơn hàng: ";
            // 
            // viewRevenue
            // 
            viewRevenue.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            viewRevenue.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewRevenue.FullRowSelect = true;
            viewRevenue.GridLines = true;
            viewRevenue.Location = new Point(84, 294);
            viewRevenue.Name = "viewRevenue";
            viewRevenue.Size = new Size(1001, 303);
            viewRevenue.TabIndex = 33;
            viewRevenue.UseCompatibleStateImageBehavior = false;
            viewRevenue.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên tài khoản";
            columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Doanh thu";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số đơn hàng";
            columnHeader3.Width = 300;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(218, 26);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(302, 34);
            txtTotalAmount.TabIndex = 34;
            txtTotalAmount.Text = "0";
            // 
            // txtTotalOrder
            // 
            txtTotalOrder.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalOrder.Location = new Point(219, 77);
            txtTotalOrder.Name = "txtTotalOrder";
            txtTotalOrder.ReadOnly = true;
            txtTotalOrder.Size = new Size(302, 34);
            txtTotalOrder.TabIndex = 35;
            txtTotalOrder.Text = "0";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "MM/yyyy";
            datePicker.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(835, 243);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(250, 30);
            datePicker.TabIndex = 36;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotalAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTotalOrder);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(33, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 125);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tổng";
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Location = new Point(88, 243);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(137, 29);
            btnCalculateTotal.TabIndex = 39;
            btnCalculateTotal.Text = "Từ trước đến nay";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // Revenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(btnCalculateTotal);
            Controls.Add(groupBox1);
            Controls.Add(datePicker);
            Controls.Add(viewRevenue);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Revenue";
            Text = "Revenue";
            Load += Revenue_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView viewRevenue;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtTotalAmount;
        private TextBox txtTotalOrder;
        private DateTimePicker datePicker;
        private GroupBox groupBox1;
        private Button btnCalculateTotal;
    }
}