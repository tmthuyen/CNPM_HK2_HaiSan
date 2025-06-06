﻿using BUS;
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
        private SupplierBUS supBUS;
        private List<ImportDetail> importDetailList;
        public frmImport(ProductBUS pBUS)
        {
            importDetailList = new List<ImportDetail>();
            this.pBUS = pBUS;
            supBUS = new SupplierBUS();
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
            LoadImportList(dgvImportList, importDetailList);

            btnSaveImport.Enabled = false;
            grInputPro.Enabled = false;

            LoadSupplier(cbbSup, supBUS.GetAll());
            LoadProduct(cbbPro, pBUS.getAll());

            dtpkImportDate.Value = DateTime.Now;

            cbbSup.Focus();
        }

        // load sup
        private void LoadSupplier(ComboBox c, List<Supplier> l)
        {
            c.DataSource = l;
            c.ValueMember = "SupplierId";
            c.DisplayMember = "SupplierName";
            c.SelectedIndex = -1;
        }

        // load product
        private void LoadProduct(ComboBox c, List<Product> l)
        {
            c.DataSource = l;
            c.ValueMember = "ProductId";
            c.DisplayMember = "ProductName";
            c.SelectedIndex = -1;
        }

        private void btnCreateImport_Click(object sender, EventArgs e)
        {
            txtImportId.Text = impBUS.CreateNewId();
            dtpkImportDate.Enabled = true;
            grInputPro.Enabled = true;
            btnSaveImport.Enabled = true;
            cbbSup.Focus();

        }


        // luu databse
        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            if (importDetailList.Count > 0)
            {
                if (txtImportId.Text == "")
                {
                    new frmError("Nhập hàng", "Thiếu mã nhập").ShowDialog();
                    return;

                }
                if (cbbSup.SelectedIndex < 0)
                {
                    new frmError("Nhập hàng", "Thiếu nhà cung cấp").ShowDialog();
                    cbbSup.Focus();
                    return;
                }

                if (dtpkImportDate.Value.Date > DateTime.Now.Date)
                {
                    new frmError("Nhập hàng", "Ngày nhập không thể sau ngày hôm nay").ShowDialog();
                    dtpkImportDate.Focus();
                    return;
                }
    
                Import i = new Import(txtImportId.Text, cbbSup.SelectedValue + "", dtpkImportDate.Value.Date, importDetailList.Count, importDetailList);


                if (i != null && impBUS.Add(i))
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
            if (cbbPro.SelectedIndex < 0 || txtQuantity.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        // reset input
        private void ClearInput()
        {
            txtUnit.Text = "";
            txtPurchasePrice.Text = "";
            txtQuantity.Text = "";
            txtTotalDetail.Text = "";
            cbbPro.Text = "";
        }
        // dua don nhap vao view
        private void LoadImportList(DataGridView dgv, List<ImportDetail> l)
        {
            dgv.DataSource = null; // reset lại trước
            if (l != null && l.Count > 0)
            {
                dgv.DataSource = l;
                dgv.Columns["ImportId"].HeaderText = "Mã Phiếu";
                dgv.Columns["ProductId"].HeaderText = "Mã SP";
                dgv.Columns["Quantity"].HeaderText = "Số Lượng Nhập";
                dgv.Columns["Remaining"].HeaderText = "Tồn Kho";
                dgv.Columns["PurchasePrice"].HeaderText = "Giá Nhập";
                dgv.Columns["Expire"].HeaderText = "Hạn Sử Dụng";
                dgv.Columns["TotalPrice"].HeaderText = "Thành Tiền";
            }
        }

        // them detail
        private void btnAddProImport_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Product pAddImp = cbbPro.SelectedItem as Product;
                string importId = txtImportId.Text;
                string productId = pAddImp.ProductId.Trim();
                float quantity = float.Parse(txtQuantity.Text);
                int purchasePrice = int.Parse(txtPurchasePrice.Text);

                if (purchasePrice > pAddImp.RetailPrice)
                {
                    new frmError("Nhập hàng", "Giá nhập không thể lớn hơn giá bán hiện tại!!").ShowDialog();
                    txtPurchasePrice.Focus();
                    return;
                }
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

                LoadImportList(dgvImportList, importDetailList);
                ClearInput();

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
                    LoadImportList(dgvImportList, importDetailList);
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
            if (cbbPro.SelectedIndex >= 0)
            {
                Product p = (Product)cbbPro.SelectedItem;
                txtUnit.Text = p.Unit;
                txtRetail.Text = p.RetailPrice + "";
                dtpkExprire.Value = DateTime.Now.AddDays(30);
                txtPurchasePrice.Focus();

                //txtPurchasePrice.Text = p.PurchasePrice + "";
            }
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn không cho nhập
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
            if (txtQuantity.Text.Trim() != "" && txtPurchasePrice.Text.Trim() != "")
            {
                int sum = int.Parse(txtPurchasePrice.Text) * int.Parse(txtQuantity.Text);
                txtTotalDetail.Text = sum.ToString();
            }
        }

        // thay doi gia nhap tu tinh tong
        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() != "" && txtPurchasePrice.Text.Trim() != "")
            {
                int sum = int.Parse(txtPurchasePrice.Text) * int.Parse(txtQuantity.Text);
                txtTotalDetail.Text = sum.ToString();
            }
        }

        private void txtPurchasePrice_TextChanged_1(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() != "" && txtPurchasePrice.Text.Trim() != "")
            {
                int sum = int.Parse(txtPurchasePrice.Text) * int.Parse(txtQuantity.Text);
                txtTotalDetail.Text = sum.ToString();
            }
        }

        private void dgvImportList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvImportList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {  
                DataGridViewRow row = dgvImportList.Rows[e.RowIndex]; 
                Product p = pBUS.GetProduct(row.Cells["ProductId"].Value +"");
                if(p != null)
                {
                    string info = "Thông tin sản phẩm: \nTên" + p.ProductName.Trim() + "\nMã: " + p.ProductId.Trim() + "\nDanh mục: " + p.CategoryId.Trim() + "\nGiá bán: " + p.RetailPrice;
                    MessageBox.Show(info); 
                }
            }
        }
    }
}
