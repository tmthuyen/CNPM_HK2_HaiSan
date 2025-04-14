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
    public partial class frmEditProduct : Form
    {
        private ProductBUS proBUS;
        private SupplierBUS supBUS;
        public frmEditProduct(ProductBUS proBUS, SupplierBUS supBUS)
        {
            this.proBUS = proBUS;
            this.supBUS = supBUS;
            InitializeComponent();
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            loadProduct(cbbProId, proBUS.getAll());
            loadSupplier(cbbSupplier, supBUS.GetAll());
            btnSavePro.Enabled = false;
            btnCancelPro.Enabled = false;
            cbbProId.Focus();
        }

        private void loadProduct(ComboBox c, List<Product> l)
        {
            c.DataSource = l;
            c.SelectedIndex = 0;
            c.ValueMember = "ProductName";
            c.DisplayMember = "ProductId";
        }

        private void loadSupplier(ComboBox c, List<Supplier> l)
        {
            c.DataSource = l;

            c.SelectedIndex = -1;
            c.ValueMember = "SupplierId";
            c.DisplayMember = "SupplierName";
        }

        private void cbbProId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product proSelected = cbbProId.SelectedItem as Product;

            if (proSelected != null)
            {
                txtProName.Text = proSelected.ProductName;
                cbbSupplier.SelectedValue = proSelected.SupplierId;
                txtRetailPrice.Text = proSelected.RetailPrice + "";
            }
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            btnCancelPro.Enabled = true;
            btnSavePro.Enabled = true;
        }

        private void btnSavePro_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Product pUpdate = cbbProId.SelectedItem as Product;
                pUpdate.ProductName = txtProName.Text;
                pUpdate.SupplierId = cbbSupplier.SelectedValue.ToString();
                pUpdate.RetailPrice = int.Parse(txtRetailPrice.Text);

                if (proBUS.Update(pUpdate))
                {
                    new frmSuccces("Sản phẩm", "Đã sửa thành công").ShowDialog();
                }
                else
                {
                    new frmError("Sản phẩm", "Sửa không thành công").ShowDialog();
                }
            }
            else
            {
                new frmError("Sản phẩm", "Sửa không thành công. Nhập đủ thông tin").ShowDialog();
            }
        }

        // kiem tra input sua
        private bool checkInput()
        {
            if (txtRetailPrice.Text.Trim() == "")
                return false;

            if (cbbProId.SelectedIndex < 0
                || txtProName.Text.Trim() == ""
                || Convert.ToInt32(txtRetailPrice.Text.Trim()) < 0)
            {
                return false;

            }
            return true;
        }

        private void btnCancelPro_Click(object sender, EventArgs e)
        {
            btnSavePro.Enabled = false;
            btnCancelPro.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
