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


        // tạo nhập hàng mới
        private void btnImportPro_Click(object sender, EventArgs e)
        {
            frmImport f = new frmImport(proBUS);

            f.ShowDialog();
        }

        // xuat file nhap hang
        public void ExportToCSV(List<Import> lImp)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV Files|*.csv";
            saveFile.Title = "Lưu file CSV";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
                {
                    // Ghi tiêu đề gộp một ô
                    writer.WriteLine("Danh sách nhập hàng");

                    // Ghi dòng header
                    writer.WriteLine("Mã nhập hàng,Ngày nhập,Số lượng sản phẩm,Tổng tiền nhập");

                    // Ghi dữ liệu
                    foreach (var imp in lImp)
                    {
                        writer.WriteLine($"{imp.ImportId},{imp.ImportDate:yyyy-MM-dd},{imp.NumOfProducts},{imp.TotalAmount}");
                    }
                }

                new frmSuccces("Xuất file", "Xuất file danh sách nhập hàng thành công").ShowDialog();
            }
        }


        // xuất file danh sách nhập hàng
        private void btnExportImport_Click(object sender, EventArgs e)
        {
            ExportToCSV(impBUS.GetAll());
        }

        // load du lieu nhap hang
        private void loadImport(DataGridView dgv, List<Import> l)
        {
            if (l != null)
            {
                dgv.DataSource = l;

                dgv.Columns["ImportId"].HeaderText = "Mã";
                dgv.Columns["SupplierId"].HeaderText = "Mã NCC";
                dgv.Columns["ImportDate"].HeaderText = "Ngày nhập";
                dgv.Columns["NumOfProducts"].HeaderText = "Số sản phẩm";
                dgv.Columns["TotalAmount"].HeaderText = "Tổng tiền";
            }
        }


        // chon mot dong import dua du lieu le text box
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


        // xem chi tiet nhap hang
        private void btnSeeImport_Click(object sender, EventArgs e)
        {
            if (txtImportId.Text != "")
            {
                frmImportDetail f = new frmImportDetail(importCur);
                f.ShowDialog();
            }
        }


        // lay doi tuong import
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


        // bỏ
        private void tabPageExpire_Click(object sender, EventArgs e)
        {

        }


        // chuyen tab import và hết hạn
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
            dgv.Columns["ImportId"].HeaderText = "Mã Nhập hàng";
            dgv.Columns["Quantity"].HeaderText = "Số sản phẩm";
            dgv.Columns["TotalLoss"].HeaderText = "Tổng tiền lỗ";
            dgv.Columns["ExpiredDate"].HeaderText = "Ngày hết hạn";
        }


        // tìm sản phâm hết hạn theo id hoac rneen
        private void txtProId_TextChanged(object sender, EventArgs e)
        {
            loadExpirePro(dgvExpire, expBUS.Search(txtProId.Text.Trim(), txtProName.Text.Trim()));
        }

        private void txtProName_TextChanged(object sender, EventArgs e)
        {
            loadExpirePro(dgvExpire, expBUS.Search(txtProId.Text.Trim(), txtProName.Text.Trim()));
        }

        private void btnLoadImp_Click(object sender, EventArgs e)
        {
            frmInventory_Load(sender, e);
        }
    }
}
