namespace GUI.inventory
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
            openPurchaseBtn = new Button();
            openProfileBtn = new Button();
            openAdjustmentBtn = new Button();
            openImportBtn = new Button();
            label1 = new Label();
            openDashboardBtn = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 197, 237);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(openPurchaseBtn);
            panel1.Controls.Add(openProfileBtn);
            panel1.Controls.Add(openAdjustmentBtn);
            panel1.Controls.Add(openImportBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(openDashboardBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 760);
            panel1.TabIndex = 0;
            // 
            // openPurchaseBtn
            // 
            openPurchaseBtn.BackColor = Color.FromArgb(180, 197, 237);
            openPurchaseBtn.FlatAppearance.BorderSize = 0;
            openPurchaseBtn.FlatStyle = FlatStyle.Flat;
            openPurchaseBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openPurchaseBtn.Image = (Image)resources.GetObject("openPurchaseBtn.Image");
            openPurchaseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openPurchaseBtn.Location = new Point(3, 191);
            openPurchaseBtn.Name = "openPurchaseBtn";
            openPurchaseBtn.Padding = new Padding(20, 0, 0, 0);
            openPurchaseBtn.Size = new Size(254, 42);
            openPurchaseBtn.TabIndex = 10;
            openPurchaseBtn.Text = "Hóa đơn";
            openPurchaseBtn.UseVisualStyleBackColor = false;
            openPurchaseBtn.Click += openPurchaseBtn_Click;
            // 
            // openProfileBtn
            // 
            openProfileBtn.BackColor = Color.FromArgb(180, 197, 237);
            openProfileBtn.FlatAppearance.BorderSize = 0;
            openProfileBtn.FlatStyle = FlatStyle.Flat;
            openProfileBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openProfileBtn.Image = (Image)resources.GetObject("openProfileBtn.Image");
            openProfileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openProfileBtn.Location = new Point(3, 287);
            openProfileBtn.Name = "openProfileBtn";
            openProfileBtn.Padding = new Padding(20, 0, 0, 0);
            openProfileBtn.Size = new Size(254, 42);
            openProfileBtn.TabIndex = 9;
            openProfileBtn.Text = "Thông tin";
            openProfileBtn.UseVisualStyleBackColor = false;
            openProfileBtn.Click += openProfileBtn_Click;
            // 
            // openAdjustmentBtn
            // 
            openAdjustmentBtn.BackColor = Color.FromArgb(180, 197, 237);
            openAdjustmentBtn.FlatAppearance.BorderSize = 0;
            openAdjustmentBtn.FlatStyle = FlatStyle.Flat;
            openAdjustmentBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openAdjustmentBtn.Image = (Image)resources.GetObject("openAdjustmentBtn.Image");
            openAdjustmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openAdjustmentBtn.Location = new Point(3, 239);
            openAdjustmentBtn.Name = "openAdjustmentBtn";
            openAdjustmentBtn.Padding = new Padding(20, 0, 0, 0);
            openAdjustmentBtn.Size = new Size(254, 42);
            openAdjustmentBtn.TabIndex = 8;
            openAdjustmentBtn.Text = "Điều chỉnh";
            openAdjustmentBtn.UseVisualStyleBackColor = false;
            openAdjustmentBtn.Click += openAdjustmentBtn_Click;
            // 
            // openImportBtn
            // 
            openImportBtn.BackColor = Color.FromArgb(180, 197, 237);
            openImportBtn.FlatAppearance.BorderSize = 0;
            openImportBtn.FlatStyle = FlatStyle.Flat;
            openImportBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openImportBtn.Image = (Image)resources.GetObject("openImportBtn.Image");
            openImportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openImportBtn.Location = new Point(3, 143);
            openImportBtn.Name = "openImportBtn";
            openImportBtn.Padding = new Padding(20, 0, 0, 0);
            openImportBtn.Size = new Size(254, 42);
            openImportBtn.TabIndex = 5;
            openImportBtn.Text = "Nhập kho";
            openImportBtn.UseVisualStyleBackColor = false;
            openImportBtn.Click += openImportBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ KHO";
            // 
            // openDashboardBtn
            // 
            openDashboardBtn.BackColor = Color.FromArgb(180, 197, 237);
            openDashboardBtn.FlatAppearance.BorderSize = 0;
            openDashboardBtn.FlatStyle = FlatStyle.Flat;
            openDashboardBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openDashboardBtn.Image = (Image)resources.GetObject("openDashboardBtn.Image");
            openDashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openDashboardBtn.Location = new Point(3, 95);
            openDashboardBtn.Name = "openDashboardBtn";
            openDashboardBtn.Padding = new Padding(20, 0, 0, 0);
            openDashboardBtn.Size = new Size(254, 42);
            openDashboardBtn.TabIndex = 1;
            openDashboardBtn.Text = "Tổng quan kho";
            openDashboardBtn.UseVisualStyleBackColor = false;
            openDashboardBtn.Click += openDashboardBtn_Click;
            // 
            // btnLogout
            // 
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(12, 705);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(36, 43);
            btnLogout.TabIndex = 14;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 760);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Main";
            Text = "Quản lý kho";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button openDashboardBtn;
        private Label label1;
        private Button openImportBtn;
        private Button openAdjustmentBtn;
        private Button openProfileBtn;
        private Button openPurchaseBtn;
        private Button btnLogout;
    }
}