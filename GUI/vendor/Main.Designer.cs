namespace GUI.vendor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            openAccountBtn = new Button();
            openOrderBtn = new Button();
            label1 = new Label();
            openSellerBtn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(openAccountBtn);
            panel1.Controls.Add(openOrderBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(openSellerBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 796);
            panel1.TabIndex = 0;
            // 
            // openAccountBtn
            // 
            openAccountBtn.BackColor = Color.FromArgb(0, 118, 225);
            openAccountBtn.Cursor = Cursors.Hand;
            openAccountBtn.FlatAppearance.BorderSize = 0;
            openAccountBtn.FlatStyle = FlatStyle.Flat;
            openAccountBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            openAccountBtn.ForeColor = Color.White;
            openAccountBtn.Location = new Point(11, 277);
            openAccountBtn.Name = "openAccountBtn";
            openAccountBtn.Size = new Size(281, 61);
            openAccountBtn.TabIndex = 4;
            openAccountBtn.Text = "Tài khoản";
            openAccountBtn.UseVisualStyleBackColor = false;
            openAccountBtn.Click += openAccountBtn_Click;
            // 
            // openOrderBtn
            // 
            openOrderBtn.BackColor = Color.FromArgb(0, 118, 225);
            openOrderBtn.Cursor = Cursors.Hand;
            openOrderBtn.FlatAppearance.BorderSize = 0;
            openOrderBtn.FlatStyle = FlatStyle.Flat;
            openOrderBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            openOrderBtn.ForeColor = Color.White;
            openOrderBtn.Location = new Point(12, 202);
            openOrderBtn.Name = "openOrderBtn";
            openOrderBtn.Size = new Size(280, 61);
            openOrderBtn.TabIndex = 3;
            openOrderBtn.Text = "Đơn hàng";
            openOrderBtn.UseVisualStyleBackColor = false;
            openOrderBtn.Click += openOrderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 2;
            label1.Text = "Thu ngân";
            // 
            // openSellerBtn
            // 
            openSellerBtn.BackColor = Color.FromArgb(0, 118, 225);
            openSellerBtn.Cursor = Cursors.Hand;
            openSellerBtn.FlatAppearance.BorderSize = 0;
            openSellerBtn.FlatStyle = FlatStyle.Flat;
            openSellerBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            openSellerBtn.ForeColor = Color.White;
            openSellerBtn.Location = new Point(12, 127);
            openSellerBtn.Name = "openSellerBtn";
            openSellerBtn.Size = new Size(280, 61);
            openSellerBtn.TabIndex = 1;
            openSellerBtn.Text = "Đặt hàng";
            openSellerBtn.UseVisualStyleBackColor = false;
            openSellerBtn.Click += openSellerBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 674);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 796);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button openSellerBtn;
        private Label label1;
        private Button openOrderBtn;
        private Button openAccountBtn;
    }
}