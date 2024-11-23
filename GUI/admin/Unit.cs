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
    public partial class Unit : Form
    {
        public Unit()
        {
            InitializeComponent();
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
