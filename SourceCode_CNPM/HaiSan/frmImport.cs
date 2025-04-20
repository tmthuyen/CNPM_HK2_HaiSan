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
    public partial class frmImport : Form
    {
        private ProductBUS pBUS;
        private ImportBUS impBUS;
        private List<ImportDetail> importDetailList;
        public frmImport(ProductBUS pBUS)
        {
            importDetailList = new List<ImportDetail>();
            this.pBUS = pBUS;
            impBUS = new ImportBUS();
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            txtImportId.Text = "";
            txtQuantity.Text = "";
            txtTotalDetail.Text = "";
            //dgvImportList.Rows.Clear();
            importDetailList.Clear();

            btnSaveImport.Enabled = false; 
            grInputPro.Enabled = false;

            loadProduct(cbbPro, pBUS.getAll());
        }

        // load product
        private void loadProduct(ComboBox c, List<Product> l)
        {
            c.DataSource = l;
            c.ValueMember = "ProductId";
            c.DisplayMember = "ProductName";
            c.SelectedIndex = 0;
        }

        private void btnCreateImport_Click(object sender, EventArgs e)
        {
            txtImportId.Text = impBUS.CreateNewId();
            dtpkImportDate.Enabled = true;
            grInputPro.Enabled = true;
            btnSaveImport.Enabled = true; 

        }


        // luu databse
        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            if(importDetailList.Count > 0)
            {
                Import i = new Import(txtImportId.Text, dtpkImportDate.Value.Date, importDetailList.Count, importDetailList);
                

                if(i != null && impBUS.Add(i))
                {
                    new frmSuccces("Nhập hàng", "Nhập hàng thành công").ShowDialog();
                    frmImport_Load(sender, e);
                }
            }
            else
            {
                new frmError("Nhập hàng", "Chưa có sản phẩm nhập hàng").ShowDialog();
            }
        } 

        // check input
        private bool checkInput()
        {
            if(cbbPro.SelectedIndex < 0 || txtQuantity.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        // dua don nhap vao view
        private void loadImportList(DataGridView dgv, List<ImportDetail> l)
        {

            dgv.DataSource = null;
            dgv.DataSource = importDetailList;

            dgv.Columns["ImportId"].HeaderText = "Mã Phiếu";
            dgv.Columns["ProductId"].HeaderText = "Mã SP";
            dgv.Columns["Quantity"].HeaderText = "Số Lượng Nhập";
            dgv.Columns["Remaining"].HeaderText = "Tồn Kho";
            dgv.Columns["PurchasePrice"].HeaderText = "Giá Nhập";
            dgv.Columns["Expire"].HeaderText = "Hạn Sử Dụng";
            dgv.Columns["TotalPrice"].HeaderText = "Thành Tiền";
        }

        // them detail
        private void btnAddProImport_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string importId = txtImportId.Text;
                string productId = cbbPro.SelectedValue.ToString();
                float quantity = float.Parse(txtQuantity.Text);
                int purchasePrice = int.Parse(txtPurchasePrice.Text);
                DateTime expire = dtpkExprire.Value.Date;

                // Tìm sản phẩm đã có trong danh sách
                ImportDetail existingDetail = importDetailList.FirstOrDefault(x => x.ProductId == productId);

                if (existingDetail != null)
                {
                    // Cập nhật số lượng và tồn
                    existingDetail.Quantity += quantity;
                    existingDetail.Remaining += quantity;

                    // Nếu muốn cập nhật giá mới và ngày hết hạn → tuỳ logic
                    existingDetail.PurchasePrice = purchasePrice;
                    existingDetail.Expire = expire;
                     
                }
                else
                {
                    // Thêm mới nếu chưa tồn tại
                    ImportDetail iDetail = new ImportDetail(importId, productId, quantity, quantity, purchasePrice, expire);

                    importDetailList.Add(iDetail);
                }

                loadImportList(dgvImportList, importDetailList);

            }
            else
            {
                new frmError("Nhập hàng", "Nhập đúng số lượng và chọn đúng sản phẩm").ShowDialog();
            }
        }
         

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (cbbPro.SelectedIndex >= 0)
            {
                string productId = cbbPro.SelectedValue.ToString();

                // Tìm và xoá sản phẩm khỏi danh sách
                var itemToRemove = importDetailList.FirstOrDefault(x => x.ProductId == productId);

                if (itemToRemove != null)
                {
                    importDetailList.Remove(itemToRemove);

                    // Làm mới DataGridView
                    loadImportList(dgvImportList, importDetailList);
                }
                else
                {
                    new frmError("Nhập hàng", "Sản phẩm chưa có trong đơn").ShowDialog();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPro.SelectedIndex >= 0)
            {
                Product p = (Product)cbbPro.SelectedItem;
                txtUnit.Text = p.Unit;
                txtPurchasePrice.Text = p.PurchasePrice + "";
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn không cho nhập
            }
        }
         

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text.Trim() != "")
            {
                int sum = int.Parse(txtPurchasePrice.Text) * int.Parse(txtQuantity.Text);
                txtTotalDetail.Text = sum.ToString();
            }
        }
    }
}
