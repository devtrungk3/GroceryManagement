namespace GUI.admin
{
    partial class Conversion
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
            txtConversionID = new TextBox();
            label2 = new Label();
            txtFactor = new TextBox();
            cbFromUnit = new ComboBox();
            cbToUnit = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            txtProductID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            viewConversion = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lbPageNumber = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            columnHeader5 = new ColumnHeader();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 40);
            label1.TabIndex = 0;
            label1.Text = "Quy đổi đơn vị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(303, 84);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 22;
            label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(417, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConversionID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFactor);
            groupBox1.Controls.Add(cbFromUnit);
            groupBox1.Controls.Add(cbToUnit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(89, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 183);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin quy đổi";
            // 
            // txtConversionID
            // 
            txtConversionID.Enabled = false;
            txtConversionID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConversionID.Location = new Point(158, 33);
            txtConversionID.Name = "txtConversionID";
            txtConversionID.Size = new Size(250, 30);
            txtConversionID.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 36);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 23;
            label2.Text = "Mã quy đổi";
            // 
            // txtFactor
            // 
            txtFactor.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFactor.Location = new Point(559, 83);
            txtFactor.Name = "txtFactor";
            txtFactor.Size = new Size(250, 30);
            txtFactor.TabIndex = 22;
            // 
            // cbFromUnit
            // 
            cbFromUnit.FormattingEnabled = true;
            cbFromUnit.Location = new Point(158, 135);
            cbFromUnit.Name = "cbFromUnit";
            cbFromUnit.Size = new Size(250, 28);
            cbFromUnit.TabIndex = 21;
            // 
            // cbToUnit
            // 
            cbToUnit.FormattingEnabled = true;
            cbToUnit.Location = new Point(559, 135);
            cbToUnit.Name = "cbToUnit";
            cbToUnit.Size = new Size(250, 28);
            cbToUnit.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 137);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 18;
            label3.Text = "Sang đơn vị";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(493, 86);
            label7.Name = "label7";
            label7.Size = new Size(60, 22);
            label7.TabIndex = 17;
            label7.Text = "Hệ số";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(158, 83);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(250, 30);
            txtProductID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 86);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 137);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 14;
            label5.Text = "Từ đơn vị";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(954, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(954, 224);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(954, 174);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // viewConversion
            // 
            viewConversion.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            viewConversion.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewConversion.FullRowSelect = true;
            viewConversion.GridLines = true;
            viewConversion.Location = new Point(89, 365);
            viewConversion.Name = "viewConversion";
            viewConversion.Size = new Size(1001, 303);
            viewConversion.TabIndex = 27;
            viewConversion.UseCompatibleStateImageBehavior = false;
            viewConversion.View = View.Details;
            viewConversion.SelectedIndexChanged += viewConversion_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên sản phẩm";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Từ đơn vị";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sang đơn vị";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hệ số";
            columnHeader4.Width = 150;
            // 
            // lbPageNumber
            // 
            lbPageNumber.AutoSize = true;
            lbPageNumber.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPageNumber.Location = new Point(574, 694);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(27, 30);
            lbPageNumber.TabIndex = 30;
            lbPageNumber.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(454, 694);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 29;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(626, 694);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 28;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã quy đổi";
            columnHeader5.Width = 140;
            // 
            // Conversion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(lbPageNumber);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewConversion);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Conversion";
            Text = "Conversion";
            Load += Conversion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private ComboBox cbToUnit;
        private Label label3;
        private Label label7;
        private TextBox txtProductID;
        private Label label6;
        private Label label5;
        private ComboBox cbFromUnit;
        private TextBox txtFactor;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ListView viewConversion;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lbPageNumber;
        private Button btnPrevious;
        private Button btnNext;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label2;
        private TextBox txtConversionID;
        private ColumnHeader columnHeader5;
    }
}