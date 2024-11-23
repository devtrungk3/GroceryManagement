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
            viewPurchaseDetail = new DataGridView();
            label2 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            viewPurchase = new DataGridView();
            label4 = new Label();
            dtpCreatePurchase = new DateTimePicker();
            panel1 = new Panel();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)viewPurchaseDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewPurchase).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 453);
            label5.Name = "label5";
            label5.Size = new Size(216, 26);
            label5.TabIndex = 30;
            label5.Text = "Chi tiết đơn hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(475, 117);
            label3.Name = "label3";
            label3.Size = new Size(228, 26);
            label3.TabIndex = 29;
            label3.Text = "Danh sách đơn hàng";
            // 
            // viewPurchaseDetail
            // 
            viewPurchaseDetail.AllowUserToAddRows = false;
            viewPurchaseDetail.AllowUserToDeleteRows = false;
            viewPurchaseDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewPurchaseDetail.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            viewPurchaseDetail.Location = new Point(40, 482);
            viewPurchaseDetail.Name = "viewPurchaseDetail";
            viewPurchaseDetail.ReadOnly = true;
            viewPurchaseDetail.RowHeadersWidth = 51;
            viewPurchaseDetail.Size = new Size(1081, 256);
            viewPurchaseDetail.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(790, 389);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 27;
            label2.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(670, 389);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 26;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(842, 389);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 25;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // viewPurchase
            // 
            viewPurchase.AllowUserToAddRows = false;
            viewPurchase.AllowUserToDeleteRows = false;
            viewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewPurchase.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewPurchase.Location = new Point(475, 146);
            viewPurchase.Name = "viewPurchase";
            viewPurchase.ReadOnly = true;
            viewPurchase.RowHeadersWidth = 51;
            viewPurchase.Size = new Size(646, 224);
            viewPurchase.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 109);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 23;
            label4.Text = "Ngày tạo";
            // 
            // dtpCreatePurchase
            // 
            dtpCreatePurchase.CalendarFont = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpCreatePurchase.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCreatePurchase.Location = new Point(40, 138);
            dtpCreatePurchase.Name = "dtpCreatePurchase";
            dtpCreatePurchase.Size = new Size(316, 30);
            dtpCreatePurchase.TabIndex = 22;
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
            // Column1
            // 
            Column1.HeaderText = "Mã đơn hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày tạo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên tài khoản nhân viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã chi tiết đơn hàng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã đơn hàng";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tên sản phẩm";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Đơn giá";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Số lượng";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(viewPurchaseDetail);
            Controls.Add(label2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewPurchase);
            Controls.Add(label4);
            Controls.Add(dtpCreatePurchase);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)viewPurchaseDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewPurchase).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private DataGridView viewPurchaseDetail;
        private Label label2;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridView viewPurchase;
        private Label label4;
        private DateTimePicker dtpCreatePurchase;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}