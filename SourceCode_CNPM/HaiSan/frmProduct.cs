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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            loadCategory();
            showProductToView(new List<Product>() { new Product("sp1", "sp1", 1, 1, DateTime.Now, 1, 1, 1, "ca1") });
        }

        private void showProductToView(List<Product> list)
        {
            // dua du lieu vao view
            dgvProduct.DataSource = list;

            // an cac cot khong can xem
            dgvProduct.Columns["PurchasePrice"].Visible = false;
            dgvProduct.Columns["ExpirationPeriod"].Visible = false;

            // sua headertext
            dgvProduct.Columns["ProductID"].HeaderText = "Mã";
            dgvProduct.Columns["ProductName"].HeaderText = "Tên";
            dgvProduct.Columns["RetailPrice"].HeaderText = "Giá bán";
            dgvProduct.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProduct.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            dgvProduct.Columns["Status"].HeaderText = "Trạng thái";
            dgvProduct.Columns["CategoryId"].HeaderText = "Mã loại";

            // them button
            addDataButton();
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

        private void loadCategory()
        {
            cbbCategory.Items.Clear();
            List<Category> list = new List<Category>() { new Category("ca1", "cua") };

            cbbCategory.DataSource = list;
            cbbCategory.SelectedIndex = 0;
            cbbCategory.ValueMember = "CategoryId";
            cbbCategory.DisplayMember = "CategoryName";
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProduct.Columns["btnViewDetails"].Index)
            {
                // Lấy dữ liệu sản phẩm từ dòng được chọn
                string productId = dgvProduct.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();

                //frmProductDetail f = new frmProductDetail(productId);
                //f.show();

                // Hiển thị thông tin sản phẩm (ví dụ: mở form chi tiết sản phẩm)
                MessageBox.Show($"Mã sản phẩm: {productId}", "Thông tin sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCusId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
