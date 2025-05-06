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
    public partial class frmAddNewProduct : Form
    {
        private ProductBUS proBUS;
        private CategoryBUS cateBUS;
        //private SupplierBUS supBUS;
        public frmAddNewProduct(ProductBUS proBUS, CategoryBUS cateBUS)
        {
            this.proBUS = proBUS;
            this.cateBUS = cateBUS;
            //this.supBUS = supBUS;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {
            loadCategory(cbbCategory, cateBUS.GetAll());
            //loadSupplier(cbbSupplier, supBUS.GetAll());
            clearInput(); 
            //cbbCategory.Focus();

            grInputPro.Enabled = false;
            //cbbCategory.Focus();
            btnCancelPro.Enabled = false;
            btnSavePro.Enabled = false;
        }


        // clear du lieu trong groupbox
        private void clearInput()
        {
            txtProId.Text = "";
            cbbCategory.SelectedIndex = -1; 
            txtProName.Text = "";
            cbbUnit.SelectedIndex = -1;
            //txtPurchasePrice.Text = "";
            txtRetailPrice.Text = "";
        }

        // load danh muck
        private void loadCategory(ComboBox cbb, List<Category> list)
        {
            cbb.DataSource = list;
            cbb.ValueMember = "CategoryId";
            cbb.DisplayMember = "CategoryName";
            cbb.SelectedIndex = 0;
        }


        // load nhà cung cấp
        //private void loadSupplier(ComboBox c, List<Supplier> list)
        //{
        //    c.DataSource = list;

        //    c.ValueMember = "SupplierId";
        //    c.DisplayMember = "SupplierName";
        //    c.SelectedIndex = -1;
        //}

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            grInputPro.Enabled = true;
            cbbCategory.Focus();
            btnCancelPro.Enabled = true;
            btnSavePro.Enabled = true;
        }

        private void btnSavePro_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string proId = txtProId.Text;
                string cateId = cbbCategory.SelectedValue.ToString().Trim(); 
                string name = txtProName.Text.Trim();
                //int purchase = Convert.ToInt32(txtPurchasePrice.Text);
                int retail = Convert.ToInt32(txtRetailPrice.Text);
                string unit = cbbUnit.Text;

                if (proBUS.Add(new Product(proId, cateId,  name
                        , retail, DateTime.Now, unit)))
                {
                    frmAddNewProduct_Load(sender, e);
                    new frmSuccces("Sản phẩm", "Thêm mới thành công").ShowDialog();

                }
                else
                {
                    new frmError("Sản phẩm", "Thêm thất bại.").ShowDialog();
                }
            }
            else
            {
                new frmError("Sản phẩm", "Thêm thất bại. Nhập đủ thông tin").ShowDialog();
            }
        }


        // kiem tra input san pham
        private bool checkInput()
        {

            if(txtRetailPrice.Text.Trim() == "" 
                || cbbCategory.SelectedIndex < 0)
                return false;

            //int purchase = Convert.ToInt32(txtPurchasePrice.Text.Trim());
            int retail = Convert.ToInt32(txtRetailPrice.Text.Trim());

            if (isEmpty(txtProName.Text) || isEmpty(cbbCategory.Text)
                || isEmpty(cbbUnit.Text) || retail < 0
                )
            {
                return false;
            }
            return true;
        }

        private bool isEmpty(string t)
        {
            return string.IsNullOrWhiteSpace(t);
        }

        private void btnCancelPro_Click(object sender, EventArgs e)
        {
            grInputPro.Enabled = false;
            clearInput();
            btnSavePro.Enabled = false;
            btnCancelPro.Enabled = false;
        }

        // chi cho nhap so voi gia tien
        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn không cho nhập
            }
        }

        private void txtRetailPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPurchasePrice_KeyPress(sender, e);
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedValue != null)
            {
                txtProId.Text = proBUS.CreateNewId(cbbCategory.SelectedValue.ToString());
            }
        }
    }
}
