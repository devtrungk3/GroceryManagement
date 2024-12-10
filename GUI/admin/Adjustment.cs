using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.admin
{
    public partial class Adjustment : Form
    {
        private AdjustmentBUS adjustmentBUS = new AdjustmentBUS();
        private List<AdjustmentDTO> adjustments;
        public Adjustment()
        {
            InitializeComponent();
            this.Activated += MainForm_Activated;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadAdjustmentTable();
        }
        private void LoadAdjustmentTable()
        {
            adjustments = adjustmentBUS.GetAdjustmentsByAdjustmentDate(dtpCreateAdjustment.Value.ToString("yyyy-MM-dd"));
            viewAdjustment.Items.Clear();
            ListViewItem item;
            foreach (AdjustmentDTO a in adjustments)
            {
                item = new ListViewItem(a.AdjustmentID.ToString());
                item.SubItems.Add(a.ProductDTO.ProductName);
                item.SubItems.Add(a.Quantity.ToString());
                item.SubItems.Add(a.Reason);
                item.SubItems.Add(a.AdjustmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
                viewAdjustment.Items.Add(item);
            }
        }
        private void Adjustment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dtpCreateAdjustment_ValueChanged(object sender, EventArgs e)
        {
            LoadAdjustmentTable();
        }
    }
}
