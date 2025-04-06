using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmOrderHistory : Form
    {
        public frmOrderHistory(string orderId, string cusId, string empId)
        {
            InitializeComponent();
            txtCusId.Text = orderId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
