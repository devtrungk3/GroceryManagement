using BUS;
using DTO;
using GUI.admin;
using GUI.inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.vendor
{
    public partial class Seller : Form
    {
        private ProductBUS productBUS = new ProductBUS();
        private List<OrderDetailDTO> orderDetails = new List<OrderDetailDTO>();
        private OrderBUS orderBUS = new OrderBUS();
        private OrderDetailBUS odBUS = new OrderDetailBUS();
        private List<UnitDTO> units = new List<UnitDTO>();
        private UnitBUS unitBUS = new UnitBUS();
        private PriceBUS priceBUS = new PriceBUS();
        private OrderDetailDTO? orderDetail;
        private int index = -1;
        private AccountDTO account;
        public Seller(AccountDTO account)
        {
            InitializeComponent();
            this.account = account;
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadUnitComboBox();
        }
        private void LoadUnitComboBox()
        {
            units = unitBUS.GetUnits();
            cbUnit.DataSource = units;
            cbUnit.DisplayMember = "UnitName";
            cbUnit.ValueMember = "UnitID";

            cbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void btnCheckProduct_Click(object sender, EventArgs e)
        {
            ProductDTO? product = productBUS.GetProductByProductID(txtProductID.Text);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                return;
            }
            txtProductName.Text = product.ProductName;
            cbUnit.SelectedValue = product.UnitDTO.UnitID;
            txtQuantity.Value = 1;
            int price = priceBUS.GetPriceByProductIDAndUnitID(product.ProductID, product.UnitDTO.UnitID.ToString());
            txtPrice.Text = price.ToString();
            txtTotalPrice.Text = txtPrice.Text;
            orderDetail = new OrderDetailDTO(0, null, product, product.UnitDTO, price, Convert.ToInt32(txtQuantity.Value));
            txtProductID.Text = "";
        }

        private void LoadOrderDetailTable()
        {
            viewOrderDetail.Items.Clear();
            int amount = 0;
            if (orderDetails.Count > 0)
            {
                ListViewItem item;
                foreach (OrderDetailDTO o in orderDetails)
                {
                    item = item = new ListViewItem(o.ProductDTO.ProductName);
                    item.SubItems.Add(o.UnitDTO.UnitName);
                    item.SubItems.Add(o.UnitPrice.ToString());
                    item.SubItems.Add(o.Quantity.ToString());
                    item.SubItems.Add((o.Quantity * o.UnitPrice).ToString());
                    viewOrderDetail.Items.Add(item);
                    amount += o.Quantity * o.UnitPrice;
                }
            }
            txtTotalAmount.Text = amount.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (orderDetail == null) return;
            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetail.ProductDTO.ProductID == orderDetails[i].ProductDTO.ProductID && orderDetail.UnitDTO.UnitID == orderDetails[i].UnitDTO.UnitID)
                {
                    orderDetails[i] = orderDetail;
                    orderDetail = null;
                    LoadOrderDetailTable();
                    ClearTextBox();
                    return;
                }
            }
            orderDetails.Add(orderDetail);
            orderDetail = null;
            LoadOrderDetailTable();
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtProductName.Text = "";
            txtPrice.Text = "0";
            txtQuantity.Value = 1;
            cbUnit.SelectedIndex = 0;
            txtTotalPrice.Text = "0";
            index = -1;
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (orderDetail == null) return;
            orderDetail.Quantity = Convert.ToInt32(txtQuantity.Value);
            txtTotalPrice.Text = (orderDetail.UnitPrice * orderDetail.Quantity).ToString();
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderDetail == null || cbUnit.SelectedValue == null) return;
            orderDetail.UnitDTO = (UnitDTO)cbUnit.SelectedItem;
            orderDetail.UnitPrice = priceBUS.GetPriceByProductIDAndUnitID(orderDetail.ProductDTO.ProductID, orderDetail.UnitDTO.UnitID.ToString());
            txtPrice.Text = orderDetail.UnitPrice.ToString();
            txtTotalPrice.Text = (orderDetail.UnitPrice * orderDetail.Quantity).ToString();
        }

        private void viewOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewOrderDetail.SelectedItems.Count > 0 && orderDetails.Count > 0)
            {
                ListViewItem selectedItem = viewOrderDetail.SelectedItems[0];
                index = selectedItem.Index;
                txtProductName.Text = orderDetails[index].ProductDTO.ProductName;
                txtPrice.Text = orderDetails[index].UnitPrice.ToString();
                txtQuantity.Value = orderDetails[index].Quantity;
                cbUnit.SelectedValue = orderDetails[index].UnitDTO.UnitID;
                txtTotalPrice.Text = (orderDetails[index].Quantity * orderDetails[index].UnitPrice).ToString();
                orderDetail = new OrderDetailDTO(orderDetails[index]);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (viewOrderDetail.Items.Count == 0) return;
            if (viewOrderDetail.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa");
                return;
            }
            orderDetails.RemoveAt(viewOrderDetail.SelectedItems[0].Index);
            LoadOrderDetailTable();
            ClearTextBox();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (orderDetails.Count == 0)
            {
                MessageBox.Show("Xuất hóa đơn thất bại");
                return;
            }
            // show confirmation message before completed
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn hoàn tất đơn hàng không?", "Xác nhận hoàn tất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes) return;
            OrderDTO order = new OrderDTO(0, DateTime.Now, account, int.Parse(txtTotalAmount.Text));
            string message = orderBUS.InsertOrder(order);
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            int orderID = orderBUS.GetLastOrderID();
            if (orderID < 0) return;
            message = odBUS.InsertOrderDetail(orderID, orderDetails);
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            // show confirmation message before print
            dialog = MessageBox.Show($"Bạn có muốn in hóa đơn không?", "Xác nhận hoàn tất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            };
            ClearTextBox();
            txtTotalAmount.Text = "0";
            orderDetails.Clear();
            LoadOrderDetailTable();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font regularFont = new Font("Arial", 14);
            int yPosition = 20;
            if (e.Graphics == null) return;
            string title = "Hóa Đơn";
            SizeF headerSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, (e.PageBounds.Width - headerSize.Width) / 2, yPosition);
            yPosition += 60;
            e.Graphics.DrawString($"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", regularFont, Brushes.Black, 20, yPosition);
            yPosition += 40;

            // Column Headers
            e.Graphics.DrawString("Tên sản phẩm", headerFont, Brushes.Black, 20, yPosition);
            e.Graphics.DrawString("Đơn vị", headerFont, Brushes.Black, 300, yPosition);
            e.Graphics.DrawString("Đơn giá", headerFont, Brushes.Black, 400, yPosition);
            e.Graphics.DrawString("SL", headerFont, Brushes.Black, 500, yPosition);
            e.Graphics.DrawString("Thành tiền", headerFont, Brushes.Black, 600, yPosition);
            yPosition += 30;

            foreach (OrderDetailDTO detail in orderDetails)
            {
                e.Graphics.DrawString(detail.ProductDTO.ProductName, regularFont, Brushes.Black, 20, yPosition);
                e.Graphics.DrawString(detail.UnitDTO.UnitName, regularFont, Brushes.Black, 300, yPosition);
                e.Graphics.DrawString(detail.UnitPrice.ToString("N0"), regularFont, Brushes.Black, 400, yPosition);
                e.Graphics.DrawString(detail.Quantity.ToString(), regularFont, Brushes.Black, 500, yPosition);
                e.Graphics.DrawString((detail.Quantity * detail.UnitPrice).ToString("N0"), regularFont, Brushes.Black, 600, yPosition);
                yPosition += 30;
            }

            // Footer
            yPosition += 20;
            e.Graphics.DrawString($"Tổng tiền: {int.Parse(txtTotalAmount.Text):N0} VND", titleFont, Brushes.Black, 20, yPosition);

            yPosition += 30;
            e.Graphics.DrawString("Cảm ơn quý khách và hẹn gặp lại", regularFont, Brushes.Black, 20, yPosition);
        }

    }
}
