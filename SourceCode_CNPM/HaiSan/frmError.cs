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
    public partial class frmError : Form
    {
        public frmError(string tile, string content)
        {
            InitializeComponent();
            lblTitleMsg.Text = tile;
            lblMsgContent.Text = content;
        }

        private void frmSuccces_Load(object sender, EventArgs e)
        {

        }

        private void btnOkMsg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
