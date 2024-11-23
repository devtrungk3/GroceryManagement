namespace GUI.admin
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
            openPriceBtn = new Button();
            openInventoryBtn = new Button();
            openUnitBtn = new Button();
            openAccountBtn = new Button();
            openImportBtn = new Button();
            openAdjustmentBtn = new Button();
            openOrderBtn = new Button();
            openRevenueBtn = new Button();
            openSupplierBtn = new Button();
            openProductBtn = new Button();
            openCategoryBtn = new Button();
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
            panel1.Controls.Add(openPriceBtn);
            panel1.Controls.Add(openInventoryBtn);
            panel1.Controls.Add(openUnitBtn);
            panel1.Controls.Add(openAccountBtn);
            panel1.Controls.Add(openImportBtn);
            panel1.Controls.Add(openAdjustmentBtn);
            panel1.Controls.Add(openOrderBtn);
            panel1.Controls.Add(openRevenueBtn);
            panel1.Controls.Add(openSupplierBtn);
            panel1.Controls.Add(openProductBtn);
            panel1.Controls.Add(openCategoryBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(openDashboardBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 760);
            panel1.TabIndex = 1;
            // 
            // openPriceBtn
            // 
            openPriceBtn.BackColor = Color.FromArgb(180, 197, 237);
            openPriceBtn.FlatAppearance.BorderSize = 0;
            openPriceBtn.FlatStyle = FlatStyle.Flat;
            openPriceBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openPriceBtn.Image = (Image)resources.GetObject("openPriceBtn.Image");
            openPriceBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openPriceBtn.Location = new Point(3, 308);
            openPriceBtn.Name = "openPriceBtn";
            openPriceBtn.Padding = new Padding(20, 0, 0, 0);
            openPriceBtn.Size = new Size(254, 42);
            openPriceBtn.TabIndex = 12;
            openPriceBtn.Text = "Giá bán";
            openPriceBtn.UseVisualStyleBackColor = false;
            openPriceBtn.Click += openPriceBtn_Click;
            // 
            // openInventoryBtn
            // 
            openInventoryBtn.BackColor = Color.FromArgb(180, 197, 237);
            openInventoryBtn.FlatAppearance.BorderSize = 0;
            openInventoryBtn.FlatStyle = FlatStyle.Flat;
            openInventoryBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openInventoryBtn.Image = (Image)resources.GetObject("openInventoryBtn.Image");
            openInventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openInventoryBtn.Location = new Point(3, 356);
            openInventoryBtn.Name = "openInventoryBtn";
            openInventoryBtn.Padding = new Padding(20, 0, 0, 0);
            openInventoryBtn.Size = new Size(254, 42);
            openInventoryBtn.TabIndex = 11;
            openInventoryBtn.Text = "Kho";
            openInventoryBtn.UseVisualStyleBackColor = false;
            openInventoryBtn.Click += openInventoryBtn_Click;
            // 
            // openUnitBtn
            // 
            openUnitBtn.BackColor = Color.FromArgb(180, 197, 237);
            openUnitBtn.FlatAppearance.BorderSize = 0;
            openUnitBtn.FlatStyle = FlatStyle.Flat;
            openUnitBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openUnitBtn.Image = (Image)resources.GetObject("openUnitBtn.Image");
            openUnitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openUnitBtn.Location = new Point(3, 260);
            openUnitBtn.Name = "openUnitBtn";
            openUnitBtn.Padding = new Padding(20, 0, 0, 0);
            openUnitBtn.Size = new Size(254, 42);
            openUnitBtn.TabIndex = 10;
            openUnitBtn.Text = "Đơn vị";
            openUnitBtn.UseVisualStyleBackColor = false;
            openUnitBtn.Click += openUnitBtn_Click;
            // 
            // openAccountBtn
            // 
            openAccountBtn.BackColor = Color.FromArgb(180, 197, 237);
            openAccountBtn.FlatAppearance.BorderSize = 0;
            openAccountBtn.FlatStyle = FlatStyle.Flat;
            openAccountBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openAccountBtn.Image = (Image)resources.GetObject("openAccountBtn.Image");
            openAccountBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openAccountBtn.Location = new Point(3, 596);
            openAccountBtn.Name = "openAccountBtn";
            openAccountBtn.Padding = new Padding(20, 0, 0, 0);
            openAccountBtn.Size = new Size(254, 42);
            openAccountBtn.TabIndex = 9;
            openAccountBtn.Text = "Tài khoản";
            openAccountBtn.UseVisualStyleBackColor = false;
            openAccountBtn.Click += openAccountBtn_Click;
            // 
            // openImportBtn
            // 
            openImportBtn.BackColor = Color.FromArgb(180, 197, 237);
            openImportBtn.FlatAppearance.BorderSize = 0;
            openImportBtn.FlatStyle = FlatStyle.Flat;
            openImportBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openImportBtn.Image = (Image)resources.GetObject("openImportBtn.Image");
            openImportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openImportBtn.Location = new Point(3, 452);
            openImportBtn.Name = "openImportBtn";
            openImportBtn.Padding = new Padding(20, 0, 0, 0);
            openImportBtn.Size = new Size(254, 42);
            openImportBtn.TabIndex = 6;
            openImportBtn.Text = "Nhập kho";
            openImportBtn.UseVisualStyleBackColor = false;
            openImportBtn.Click += openImportBtn_Click;
            // 
            // openAdjustmentBtn
            // 
            openAdjustmentBtn.BackColor = Color.FromArgb(180, 197, 237);
            openAdjustmentBtn.FlatAppearance.BorderSize = 0;
            openAdjustmentBtn.FlatStyle = FlatStyle.Flat;
            openAdjustmentBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openAdjustmentBtn.Image = (Image)resources.GetObject("openAdjustmentBtn.Image");
            openAdjustmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openAdjustmentBtn.Location = new Point(3, 548);
            openAdjustmentBtn.Name = "openAdjustmentBtn";
            openAdjustmentBtn.Padding = new Padding(20, 0, 0, 0);
            openAdjustmentBtn.Size = new Size(254, 42);
            openAdjustmentBtn.TabIndex = 8;
            openAdjustmentBtn.Text = "Điều chỉnh";
            openAdjustmentBtn.UseVisualStyleBackColor = false;
            openAdjustmentBtn.Click += openAdjustmentBtn_Click;
            // 
            // openOrderBtn
            // 
            openOrderBtn.BackColor = Color.FromArgb(180, 197, 237);
            openOrderBtn.FlatAppearance.BorderSize = 0;
            openOrderBtn.FlatStyle = FlatStyle.Flat;
            openOrderBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openOrderBtn.Image = (Image)resources.GetObject("openOrderBtn.Image");
            openOrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openOrderBtn.Location = new Point(3, 500);
            openOrderBtn.Name = "openOrderBtn";
            openOrderBtn.Padding = new Padding(20, 0, 0, 0);
            openOrderBtn.Size = new Size(254, 42);
            openOrderBtn.TabIndex = 7;
            openOrderBtn.Text = "Đơn hàng";
            openOrderBtn.UseVisualStyleBackColor = false;
            openOrderBtn.Click += openOrderBtn_Click;
            // 
            // openRevenueBtn
            // 
            openRevenueBtn.BackColor = Color.FromArgb(180, 197, 237);
            openRevenueBtn.FlatAppearance.BorderSize = 0;
            openRevenueBtn.FlatStyle = FlatStyle.Flat;
            openRevenueBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openRevenueBtn.Image = (Image)resources.GetObject("openRevenueBtn.Image");
            openRevenueBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openRevenueBtn.Location = new Point(3, 116);
            openRevenueBtn.Name = "openRevenueBtn";
            openRevenueBtn.Padding = new Padding(20, 0, 0, 0);
            openRevenueBtn.Size = new Size(254, 42);
            openRevenueBtn.TabIndex = 6;
            openRevenueBtn.Text = "Doanh thu";
            openRevenueBtn.UseVisualStyleBackColor = false;
            openRevenueBtn.Click += openRevenueBtn_Click;
            // 
            // openSupplierBtn
            // 
            openSupplierBtn.BackColor = Color.FromArgb(180, 197, 237);
            openSupplierBtn.FlatAppearance.BorderSize = 0;
            openSupplierBtn.FlatStyle = FlatStyle.Flat;
            openSupplierBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openSupplierBtn.Image = (Image)resources.GetObject("openSupplierBtn.Image");
            openSupplierBtn.ImageAlign = ContentAlignment.TopLeft;
            openSupplierBtn.Location = new Point(3, 404);
            openSupplierBtn.Name = "openSupplierBtn";
            openSupplierBtn.Padding = new Padding(20, 0, 0, 0);
            openSupplierBtn.Size = new Size(254, 42);
            openSupplierBtn.TabIndex = 4;
            openSupplierBtn.Text = "Nhà cung cấp";
            openSupplierBtn.UseVisualStyleBackColor = false;
            openSupplierBtn.Click += openSupplierBtn_Click;
            // 
            // openProductBtn
            // 
            openProductBtn.BackColor = Color.FromArgb(180, 197, 237);
            openProductBtn.FlatAppearance.BorderSize = 0;
            openProductBtn.FlatStyle = FlatStyle.Flat;
            openProductBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openProductBtn.Image = (Image)resources.GetObject("openProductBtn.Image");
            openProductBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openProductBtn.Location = new Point(3, 212);
            openProductBtn.Name = "openProductBtn";
            openProductBtn.Padding = new Padding(20, 0, 0, 0);
            openProductBtn.Size = new Size(254, 42);
            openProductBtn.TabIndex = 3;
            openProductBtn.Text = "Sản phẩm";
            openProductBtn.UseVisualStyleBackColor = false;
            openProductBtn.Click += openProductBtn_Click;
            // 
            // openCategoryBtn
            // 
            openCategoryBtn.BackColor = Color.FromArgb(180, 197, 237);
            openCategoryBtn.FlatAppearance.BorderSize = 0;
            openCategoryBtn.FlatStyle = FlatStyle.Flat;
            openCategoryBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openCategoryBtn.Image = (Image)resources.GetObject("openCategoryBtn.Image");
            openCategoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openCategoryBtn.Location = new Point(3, 164);
            openCategoryBtn.Name = "openCategoryBtn";
            openCategoryBtn.Padding = new Padding(20, 0, 0, 0);
            openCategoryBtn.Size = new Size(254, 42);
            openCategoryBtn.TabIndex = 2;
            openCategoryBtn.Text = "Danh mục";
            openCategoryBtn.UseVisualStyleBackColor = false;
            openCategoryBtn.Click += openCategoryBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ";
            // 
            // openDashboardBtn
            // 
            openDashboardBtn.BackColor = Color.FromArgb(180, 197, 237);
            openDashboardBtn.FlatAppearance.BorderSize = 0;
            openDashboardBtn.FlatStyle = FlatStyle.Flat;
            openDashboardBtn.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openDashboardBtn.Image = (Image)resources.GetObject("openDashboardBtn.Image");
            openDashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            openDashboardBtn.Location = new Point(3, 68);
            openDashboardBtn.Name = "openDashboardBtn";
            openDashboardBtn.Padding = new Padding(20, 0, 0, 0);
            openDashboardBtn.Size = new Size(254, 42);
            openDashboardBtn.TabIndex = 1;
            openDashboardBtn.Text = "Tổng quan";
            openDashboardBtn.UseVisualStyleBackColor = false;
            openDashboardBtn.Click += openDashboardBtn_Click;
            // 
            // btnLogout
            // 
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(12, 705);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(36, 43);
            btnLogout.TabIndex = 13;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button openOrderBtn;
        private Button openRevenueBtn;
        private Button openSupplierBtn;
        private Button openProductBtn;
        private Button openCategoryBtn;
        private Label label1;
        private Button openDashboardBtn;
        private Button openAdjustmentBtn;
        private Button openImportBtn;
        private Button openAccountBtn;
        private Button openUnitBtn;
        private Button openInventoryBtn;
        private Button openPriceBtn;
        private Button btnLogout;
    }
}