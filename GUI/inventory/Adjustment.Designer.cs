namespace GUI.inventory
{
    partial class Adjustment
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
            dtpCreateAdjustment = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtProductID = new TextBox();
            label7 = new Label();
            txtReason = new TextBox();
            label3 = new Label();
            txtAdjustmentID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            viewAdjustment = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
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
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 40);
            label1.TabIndex = 0;
            label1.Text = "Điều chỉnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(314, 85);
            label4.Name = "label4";
            label4.Size = new Size(192, 26);
            label4.TabIndex = 23;
            label4.Text = "Ngày điều chỉnh";
            // 
            // dtpCreateAdjustment
            // 
            dtpCreateAdjustment.CalendarFont = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpCreateAdjustment.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCreateAdjustment.Location = new Point(512, 85);
            dtpCreateAdjustment.Name = "dtpCreateAdjustment";
            dtpCreateAdjustment.Size = new Size(316, 30);
            dtpCreateAdjustment.TabIndex = 22;
            dtpCreateAdjustment.ValueChanged += dtpCreateAdjustment_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAdjustmentID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Location = new Point(84, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 208);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin điều chỉnh";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(172, 91);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(250, 30);
            txtProductID.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 91);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 32;
            label7.Text = "Mã sản phẩm";
            // 
            // txtReason
            // 
            txtReason.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReason.Location = new Point(582, 91);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(250, 30);
            txtReason.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(476, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 17;
            label3.Text = "Lý do";
            // 
            // txtAdjustmentID
            // 
            txtAdjustmentID.Enabled = false;
            txtAdjustmentID.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdjustmentID.Location = new Point(172, 37);
            txtAdjustmentID.Name = "txtAdjustmentID";
            txtAdjustmentID.Size = new Size(250, 30);
            txtAdjustmentID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 37);
            label6.Name = "label6";
            label6.Size = new Size(140, 22);
            label6.TabIndex = 15;
            label6.Text = "Mã điều chỉnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(476, 40);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 14;
            label5.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(584, 37);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 30);
            txtQuantity.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(991, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(991, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(991, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // viewAdjustment
            // 
            viewAdjustment.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            viewAdjustment.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewAdjustment.FullRowSelect = true;
            viewAdjustment.GridLines = true;
            viewAdjustment.Location = new Point(84, 385);
            viewAdjustment.Name = "viewAdjustment";
            viewAdjustment.Size = new Size(1001, 303);
            viewAdjustment.TabIndex = 35;
            viewAdjustment.UseCompatibleStateImageBehavior = false;
            viewAdjustment.View = View.Details;
            viewAdjustment.SelectedIndexChanged += viewAdjustment_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sản phẩm";
            columnHeader2.Width = 270;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Lý do";
            columnHeader4.Width = 260;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ngày điều chỉnh";
            columnHeader5.Width = 250;
            // 
            // Adjustment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 760);
            Controls.Add(viewAdjustment);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dtpCreateAdjustment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adjustment";
            Text = "Adjustment";
            Load += Adjustment_Load;
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
        private DateTimePicker dtpCreateAdjustment;
        private GroupBox groupBox1;
        private TextBox txtAdjustmentID;
        private Label label6;
        private Label label5;
        private TextBox txtQuantity;
        private Label label3;
        private TextBox txtReason;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtProductID;
        private Label label7;
        private ListView viewAdjustment;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}