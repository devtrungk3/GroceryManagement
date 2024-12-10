namespace GUI.admin
{
    partial class Unit
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
            btnUpdate = new Button();
            lbPageNumber = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            txtUnitID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtUnitName = new TextBox();
            btnDelete = new Button();
            viewUnit = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 0;
            label1.Text = "Đơn vị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 86);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 28;
            label4.Text = "Tìm kiếm";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbPageNumber
            // 
            lbPageNumber.AutoSize = true;
            lbPageNumber.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPageNumber.Location = new Point(576, 687);
            lbPageNumber.Name = "lbPageNumber";
            lbPageNumber.Size = new Size(27, 30);
            lbPageNumber.TabIndex = 26;
            lbPageNumber.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(456, 687);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 25;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(628, 687);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 24;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(416, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên đơn vị";
            txtSearch.Size = new Size(363, 34);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUnitID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUnitName);
            groupBox1.Location = new Point(87, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 138);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin danh mục";
            // 
            // txtUnitID
            // 
            txtUnitID.Enabled = false;
            txtUnitID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitID.Location = new Point(172, 37);
            txtUnitID.Name = "txtUnitID";
            txtUnitID.Size = new Size(250, 30);
            txtUnitID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã đơn vị";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 91);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 14;
            label5.Text = "Tên đơn vị";
            // 
            // txtUnitName
            // 
            txtUnitName.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitName.Location = new Point(172, 91);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(250, 30);
            txtUnitName.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // viewUnit
            // 
            viewUnit.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            viewUnit.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewUnit.FullRowSelect = true;
            viewUnit.GridLines = true;
            viewUnit.Location = new Point(87, 357);
            viewUnit.Name = "viewUnit";
            viewUnit.Size = new Size(1001, 303);
            viewUnit.TabIndex = 31;
            viewUnit.UseCompatibleStateImageBehavior = false;
            viewUnit.View = View.Details;
            viewUnit.SelectedIndexChanged += viewUnit_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã đơn vị";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên đơn vị";
            columnHeader2.Width = 800;
            // 
            // Unit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(viewUnit);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(lbPageNumber);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Unit";
            Text = "Unit";
            Load += Unit_Load;
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
        private Button btnUpdate;
        private Label lbPageNumber;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnAdd;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private TextBox txtUnitID;
        private Label label6;
        private Label label5;
        private TextBox txtUnitName;
        private Button btnDelete;
        private ListView viewUnit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}