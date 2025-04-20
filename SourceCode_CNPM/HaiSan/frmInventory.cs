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

namespace GUI
{
    public partial class frmInventory : Form
    {
        private ProductBUS proBUS;
        private ImportBUS impBUS;
        private ExpireProductBUS expBUS;

        private Import importCur = new Import();
        public frmInventory(ProductBUS proBUS)
        {
            this.proBUS = proBUS;
            this.impBUS = new ImportBUS();
            this.expBUS = new ExpireProductBUS();
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {


            loadImport(dgvImportList, impBUS.GetAll());
            btnSeeImport.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportPro_Click(object sender, EventArgs e)
        {
            frmImport f = new frmImport(proBUS);
            f.ShowDialog();
        }

        // load du lieu nhap hang
        private void loadImport(DataGridView dgv, List<Import> l)
        {
            if (l != null)
            {
                dgv.DataSource = l;

                dgv.Columns["ImportId"].HeaderText = "Mã";
                dgv.Columns["ImportDate"].HeaderText = "Ngày nhập";
                dgv.Columns["NumOfProducts"].HeaderText = "Số sản phẩm";
                dgv.Columns["TotalAmount"].HeaderText = "Tổng tiền";
            }
        }

        private void dgvImportList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvImportList.Rows[e.RowIndex];
                txtImportId.Text = row.Cells["ImportId"].Value?.ToString();
                txtImportDate.Text = row.Cells["ImportDate"].Value?.ToString();
                txtQuantityImport.Text = row.Cells["NumOfProducts"].Value?.ToString();
            }
        }

        private void btnSeeImport_Click(object sender, EventArgs e)
        {
            if (txtImportId.Text != "")
            {
                frmImportDetail f = new frmImportDetail(importCur);
                f.ShowDialog();
            }
        }

        private void dgvImportList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImportList.CurrentRow != null && dgvImportList.CurrentRow.DataBoundItem is Import selectedImport)
            {
                // Lấy danh sách chi tiết của phiếu nhập
                importCur = selectedImport;

                // Bật nút xem chi tiết
                btnSeeImport.Enabled = true;
            }
        }

        private void tabPageExpire_Click(object sender, EventArgs e)
        {

        }

        private void tabCtrlInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlInventory.SelectedIndex == 0)
            {

            }
            else if (tabCtrlInventory.SelectedIndex == 1)
            {
                loadExpirePro(dgvExpire, expBUS.GetAll());
            }
        }

        // load du lieu san pham het han
        private void loadExpirePro(DataGridView dgv, List<ExpireProduct> l)
        {
            dgv.DataSource = l;

            dgv.Columns["ExpireProductId"].HeaderText = "Mã hết hạn";
            dgv.Columns["ProductId"].HeaderText = "Mã SP";
            dgv.Columns["Quantity"].HeaderText = "Số sản phẩm";
            dgv.Columns["TotalLoss"].HeaderText = "Tổng tiền lỗ";
            dgv.Columns["ExpiredDate"].HeaderText = "Ngày hết hạn";
        }

        private void txtProId_TextChanged(object sender, EventArgs e)
        {
            loadExpirePro(dgvExpire, expBUS.Search(txtProId.Text.Trim(), txtProName.Text.Trim()));
        }

        private void txtProName_TextChanged(object sender, EventArgs e)
        {
            loadExpirePro(dgvExpire, expBUS.Search(txtProId.Text.Trim(), txtProName.Text.Trim()));
        }
    }
}
