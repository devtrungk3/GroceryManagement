namespace GUI.admin
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
            dtpCreateAdjustment = new DateTimePicker();
            label4 = new Label();
            viewAdjustment = new DataGridView();
            label2 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAdjustment).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 233, 242);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 60);
            panel1.TabIndex = 3;
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
            // dtpCreateAdjustment
            // 
            dtpCreateAdjustment.CalendarFont = new Font("JetBrains Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpCreateAdjustment.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCreateAdjustment.Location = new Point(504, 91);
            dtpCreateAdjustment.Name = "dtpCreateAdjustment";
            dtpCreateAdjustment.Size = new Size(316, 30);
            dtpCreateAdjustment.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(306, 91);
            label4.Name = "label4";
            label4.Size = new Size(192, 26);
            label4.TabIndex = 14;
            label4.Text = "Ngày điều chỉnh";
            // 
            // viewAdjustment
            // 
            viewAdjustment.AllowUserToAddRows = false;
            viewAdjustment.AllowUserToDeleteRows = false;
            viewAdjustment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAdjustment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            viewAdjustment.Location = new Point(76, 234);
            viewAdjustment.Name = "viewAdjustment";
            viewAdjustment.ReadOnly = true;
            viewAdjustment.RowHeadersWidth = 51;
            viewAdjustment.Size = new Size(1001, 320);
            viewAdjustment.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(560, 577);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 21;
            label2.Text = "1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(440, 577);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 20;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(612, 577);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 19;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã điều chỉnh";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Lý do";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày điều chỉnh";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Adjustment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 713);
            Controls.Add(label2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(viewAdjustment);
            Controls.Add(label4);
            Controls.Add(dtpCreateAdjustment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adjustment";
            Text = "Adjustment";
            Load += Adjustment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewAdjustment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dtpCreateAdjustment;
        private Label label4;
        private DataGridView viewAdjustment;
        private Label label2;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}