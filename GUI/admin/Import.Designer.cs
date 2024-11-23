namespace GUI.admin
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
            viewPurchase = new DataGridView();
            label2 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            viewPurchaseDetail = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewPurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewPurchaseDetail).BeginInit();
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
            panel1.TabIndex = 2;
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
            // viewPurchase
            // 
            viewPurchase.AllowUserToAddRows = false;
            viewPurchase.AllowUserToDeleteRows = false;
            viewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewPurchase.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            viewPurchase.Location = new Point(475, 124);
            viewPurchase.Name = "viewPurchase";
            viewPurchase.ReadOnly = true;
            viewPurchase.RowHeadersWidth = 51;
            viewPurchase.Size = new Size(646, 224);
            viewPurchase.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(790, 367);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 17;
            label2.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(670, 367);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 16;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(842, 367);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 15;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // viewPurchaseDetail
            // 
            viewPurchaseDetail.AllowUserToAddRows = false;
            viewPurchaseDetail.AllowUserToDeleteRows = false;
            viewPurchaseDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewPurchaseDetail.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9, Column10 });
            viewPurchaseDetail.Location = new Point(40, 460);
            viewPurchaseDetail.Name = "viewPurchaseDetail";
            viewPurchaseDetail.ReadOnly = true;
            viewPurchaseDetail.RowHeadersWidth = 51;
            viewPurchaseDetail.Size = new Size(1081, 256);
            viewPurchaseDetail.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(475, 95);
            label3.Name = "label3";
            label3.Size = new Size(324, 26);
            label3.TabIndex = 19;
            label3.Text = "Danh sách hóa đơn nhập kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 431);
            label5.Name = "label5";
            label5.Size = new Size(312, 26);
            label5.TabIndex = 20;
            label5.Text = "Chi tiết hóa đơn nhập kho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 87);
            label4.Name = "label4";
            label4.Size = new Size(168, 26);
            label4.TabIndex = 13;
            label4.Text = "Ngày nhập kho";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(40, 124);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 21;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhà cung cấp";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tổng tiền";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày nhập kho";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã chi tiết hóa đơn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã hóa đơn";
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
            Column8.HeaderText = "Số lượng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Đơn vị";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Đơn giá";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Import
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(monthCalendar1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(viewPurchaseDetail);
            Controls.Add(label2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewPurchase);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Import";
            Text = "Import";
            Load += Import_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewPurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewPurchaseDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView viewPurchase;
        private Label label2;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridView viewPurchaseDetail;
        private Label label3;
        private Label label5;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}