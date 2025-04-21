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

namespace GUI
{
    public partial class frmImportDetail : Form
    {
        private Import imp;
        public frmImportDetail(Import imp)
        {
            this.imp = imp;
            InitializeComponent();
        }


        private void frmImportDetail_Load(object sender, EventArgs e)
        {
            loadDetail(dgvImportList, imp);
        }

        private void loadDetail(DataGridView dgv, Import imp)
        {
            txtImportId.Text = imp.ImportId;
            txtImportDate.Text = imp.ImportDate + "";
            txtQuantityImport.Text = imp.NumOfProducts + "";
            txtTotalAmount.Text = imp.TotalAmount + "";

            if (imp.ImportDetails != null)
            {
                dgv.DataSource = imp.ImportDetails;

                dgv.Columns["ImportId"].HeaderText = "Mã nhập";
                dgv.Columns["ProductId"].HeaderText = "Mã sp";
                dgv.Columns["Quantity"].HeaderText = "Số lượng";
                dgv.Columns["Remaining"].HeaderText = "Còn lại";
                dgv.Columns["PurchasePrice"].HeaderText = "Giá nhập";
                dgv.Columns["Expire"].HeaderText = "Ngày hết hạn";
                dgv.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
