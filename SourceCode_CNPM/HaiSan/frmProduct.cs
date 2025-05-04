using BUS;
using DTO;
using Infrastructure;
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
    public partial class frmProduct : Form
    {
        private ProductBUS proBUS;
        private CategoryBUS cateBUS;
        private SupplierBUS supBUS;


        // kiem tra la admin hay khong
        private bool IsAdmin = Session.Role.Equals("admin");
        public frmProduct()
        {
            proBUS = new ProductBUS();
            cateBUS = new CategoryBUS();
            supBUS = new SupplierBUS();

            InitializeComponent();

        }

        // load form and data
        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadCategory(cbbCategory, cateBUS.GetAll());
            showProductToView(proBUS.getAll());


            List<KeyValuePair<string, string>> sortOptions = new List<KeyValuePair<string, string>>()
                        {
                            new KeyValuePair<string, string>("RetailPrice ASC", "Giá tăng dần"),
                            new KeyValuePair<string, string>("RetailPrice DESC", "Giá giảm dần"),
                            new KeyValuePair<string, string>("CreatedAt DESC", "Ngày tạo mới nhất"),
                            new KeyValuePair<string, string>("CreatedAt ASC", "Ngày tạo cũ nhất"),
                        };

            cbbSortName.DataSource = sortOptions;
            cbbSortName.DisplayMember = "Value";
            cbbSortName.ValueMember = "Key";
            cbbCategory.SelectedIndex = -1;
            cbbSortName.SelectedIndex = -1;
            // enable control
            //btnEditPro.Enabled = false;
            btnDeletePro.Enabled = false;

            if (!IsAdmin)
            {
                btnAdd.Enabled = false;
                btnAddPro.Enabled = false;
                btnAddSup.Enabled = false;
                btnEditPro.Enabled = false;
                btnInventory.Enabled = false;
                btnDeletePro.Enabled = false;
                btnSaveCate.Enabled = false;
                btnSaveSup.Enabled = false;
                btnCancelCate.Enabled = false;
                btnCancelSup.Enabled = false; 
                btnAdd.Enabled = false;
                btnAdd.Enabled = false;
            }
        }


        // hien thị danh sách SẢN PHÂM
        private void showProductToView(List<Product> list)
        {
            // dua du lieu vao view
            dgvProduct.DataSource = list;

            // an cac cot khong can xem
            //if (!IsAdmin)
            //{
            //    dgvProduct.Columns["PurchasePrice"].Visible = false;
            //}
            //else
            //{
            //    dgvProduct.Columns["PurchasePrice"].HeaderText = "Giá nhập";
            //}

            // sua headertext
            dgvProduct.Columns["ProductID"].HeaderText = "Mã";
            //dgvProduct.Columns["SupplierId"].HeaderText = "Mã NCC";
            dgvProduct.Columns["CategoryId"].HeaderText = "Mã loại";
            dgvProduct.Columns["ProductName"].HeaderText = "Tên";
            dgvProduct.Columns["RetailPrice"].HeaderText = "Giá bán";
            dgvProduct.Columns["CreatedAt"].HeaderText = "Ngày tạo";

        }

        // them button xem chi tiet
        private void addDataButton()
        {
            // tao cot button vao cuoi cac dong
            DataGridViewButtonColumn viewDetailsButtonColumn = new DataGridViewButtonColumn();
            viewDetailsButtonColumn.Name = "btnViewDetails";
            viewDetailsButtonColumn.HeaderText = "Chi tiết";
            viewDetailsButtonColumn.Text = "Xem";
            viewDetailsButtonColumn.UseColumnTextForButtonValue = true;

            // them cot vao View
            dgvProduct.Columns.Add(viewDetailsButtonColumn);
        }

        // load danh muck
        private void loadCategory(ComboBox cbb, List<Category> list)
        {
            cbb.DataSource = list;
            cbb.SelectedIndex = 0;
            cbb.ValueMember = "CategoryId";
            cbb.DisplayMember = "CategoryName";
        }


        // load nhà cung cấp
        private void loadSupplier(DataGridView dgv, List<Supplier> list)
        {
            dgv.DataSource = list;
            dgv.Columns["SupplierId"].HeaderText = "Mã";
            dgv.Columns["SupplierName"].HeaderText = "Tên NCC";
            dgv.Columns["Phone"].HeaderText = "Số điện thoại";
            dgv.Columns["Email"].HeaderText = "Email";
        }
 

        // sự kiện that đôi giá trị cua combox trong tab DANH MỤC
        private void cbbCateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggleTab(false, 1);
            txtCateId.Text = cbbCateList.SelectedValue.ToString();
            txtCateName.Text = ((Category)cbbCateList.SelectedItem).CategoryName;
        }


        // them danh mục MỚI
        private void btnAdd_Click(object sender, EventArgs e)
        {
            toggleTab(true, 1);
        }


        // luu thông tin danh muc MỚI
        private void btnSaveCate_Click(object sender, EventArgs e)
        {
            if (txtCateId.Text != "" && txtCateName.Text != "")
            {
                if (cateBUS.Add(new Category(txtCateId.Text, txtCateName.Text)))
                {
                    new frmSuccces("Danh mục", "Thêm thành công").ShowDialog();
                    toggleTab(false, 1);
                    loadCategory(cbbCateList, cateBUS.GetAll());
                }
                else
                {
                    new frmError("Danh mục", "Thêm thất bại").ShowDialog();
                }
            }
            else
            {
                new frmError("Danh mục", "Nhập đủ thông tin").ShowDialog();
            }
        }

        // huy thay doi danh muc


        private void btnCancelCate_Click_1(object sender, EventArgs e)
        {

            grInfoCate.Enabled = false;
            btnCancelCate.Enabled = false;
            btnSaveCate.Enabled = false;
        }


        // su kien thay doi tab
        private void tabControlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlProduct.SelectedIndex == 1)
            {
                loadCategory(cbbCateList, cateBUS.GetAll());
                toggleTab(false, 1);
            }
            else if (tabControlProduct.SelectedIndex == 2)
            {
                toggleTab(false, 2);
                loadSupplier(dgvSupplier, supBUS.GetAll());
            }
        }


        // toggle cac control
        private void toggleTab(bool b, int tabIdx)
        {
            if (tabIdx == 1)
            {
                grInfoCate.Enabled = b;
                btnSaveCate.Enabled = b;
                btnCancelCate.Enabled = b;

                txtCateId.Focus();
                txtCateId.Text = "";
                txtCateName.Text = "";
            }
            else if (tabIdx == 2)
            {
                grInfoSup.Enabled = b;
                btnSaveSup.Enabled = b;
                btnCancelSup.Enabled = b;
                txtSupId.Enabled = false;
                txtSupId.Text = "";
                txtSupName.Text = "";
                txtSupPhone.Text = "";
                txtSupEmail.Text = "";
            }
        }


        // them nha cung cap moi
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            toggleTab(true, 2);
            txtSupName.Focus();
            txtSupId.Text = supBUS.CreateNewId();
        }


        // luu nha cung cap MOI
        private void btnSaveSup_Click(object sender, EventArgs e)
        {
            string name = txtSupName.Text.Trim();
            string phone = txtSupPhone.Text.Trim();
            string mail = txtSupEmail.Text.Trim();

            if (name == "" || phone == ""
                || mail == "")
            {
                new frmError("Nhà cung cấp", "Nhập đủ thông tin").ShowDialog();
            }
            else
            {
                if (supBUS.Add(new Supplier(txtSupId.Text, name, phone, mail)))
                {
                    new frmSuccces("Nhà cung cấp", "Thêm thành công").ShowDialog();
                    toggleTab(false, 2);
                    loadSupplier(dgvSupplier, supBUS.GetAll());
                }
                else
                {
                    new frmError("Nhà cung cấp", "Thêm thất bại").ShowDialog();
                }
            }
        }


        // huy input nha cung cap
        private void btnCancelSup_Click(object sender, EventArgs e)
        {
            toggleTab(false, 2);
        }


        // PRODUCT TAB

        // tim kiem theo tên
        private void txtProName_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(txtProId.Text.Trim(), txtProName.Text.Trim());

        }

        // tim kiem product 
        private void SearchProduct(string proId, string proName)
        {
            string cateId = cbbCategory.SelectedValue?.ToString();
            string filter = cbbSortName.SelectedValue?.ToString() ?? "RetailPrice ASC";

            var list = proBUS.Search(proId, proName, cateId, filter);
            showProductToView(list);
        }

        // click tim san pham
        private void btnSearchPro_Click(object sender, EventArgs e)
        {
            string proId = txtProId.Text.Trim();
            string proName = txtProName.Text.Trim();

            SearchProduct(proId, proName);
        }

        // clicc them san pham
        private void btnAddPro_Click(object sender, EventArgs e)
        {
            frmAddNewProduct frmAdd = new frmAddNewProduct(proBUS, cateBUS);

            frmAdd.ShowDialog();
        }


        // sua san pham
        private void btnEditPro_Click(object sender, EventArgs e)
        {
            frmEditProduct fEdit = new frmEditProduct(proBUS, supBUS);

            fEdit.ShowDialog();
        }


        // xác nhan xoa san pham
        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            if(txtProId.Text.Trim() != "")
            {
                DialogResult result = 
                    MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa

                    // kiem tra san phan co ton tai trong don hang nao khong
                    if (proBUS.Delete(txtProId.Text.Trim()))
                    {
                        btnDeletePro.Enabled = false;
                        frmProduct_Load(sender, e);
                        new frmSuccces("Sản phẩm", "Đã xóa sản phẩm").ShowDialog();

                    } else
                    {
                        new frmError("Sản phẩm", "Không không thể xóa sản phẩm").ShowDialog();
                        txtProId.Focus();
                    }
                }
            }
            else
            {
                new frmError("Sản phẩm", "Nhập mã sản phẩm cần xóa").ShowDialog();
                txtProId.Focus(); 
            }
        }

        // nhap hang 
        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory f = new frmInventory(proBUS);
            f.ShowDialog();
        }

        // click vao dòng cua grid view SẢN PHẨM
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                txtProId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProName.Text = row.Cells["ProductName"].Value?.ToString();

                btnDeletePro.Enabled = true;
            }
        }
    }
}
