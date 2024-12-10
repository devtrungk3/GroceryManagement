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
            viewAdjustment = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1.SuspendLayout();
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
            dtpCreateAdjustment.ValueChanged += dtpCreateAdjustment_ValueChanged;
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
            viewAdjustment.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            viewAdjustment.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewAdjustment.FullRowSelect = true;
            viewAdjustment.GridLines = true;
            viewAdjustment.Location = new Point(79, 182);
            viewAdjustment.Name = "viewAdjustment";
            viewAdjustment.Size = new Size(1001, 303);
            viewAdjustment.TabIndex = 34;
            viewAdjustment.UseCompatibleStateImageBehavior = false;
            viewAdjustment.View = View.Details;
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
            ClientSize = new Size(1152, 713);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dtpCreateAdjustment;
        private Label label4;
        private ListView viewAdjustment;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}