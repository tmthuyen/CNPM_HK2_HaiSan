using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class frmOrderDetail : Form
    {

        public frmOrderDetail(Order order)
        {
            InitializeComponent();
            txtOrderId.Text = order.OrderId;
            txtPhone.Text = order.Phone;
            txtEmpId.Text = order.EmployeeId;
            txtCreatedDate.Text = order.CreatedAt.ToString();
            txtPayment.Text = order.PaymentMethod;
            txtUsedPoint.Text = order.UsedPoint.ToString();
            txtRawAmount.Text = order.RawAmount.ToString();
            txtTotalAmount.Text = order.TotalAmount.ToString();
            txtChangeAmount.Text = order.ChangeAmount.ToString();
            txtReceivedAmount.Text = order.ReceivedAmount.ToString();

            dgvOrderDetail.DataSource = order.OrderDetailList;
            dgvOrderDetail.Columns["ProductId"].HeaderText = "Mã sản phẩm";
            dgvOrderDetail.Columns["ImportId"].HeaderText = "Lô hàng";
            dgvOrderDetail.Columns["RetailPrice"].HeaderText = "Giá bán";
            dgvOrderDetail.Columns["Amount"].HeaderText = "Số lượng";
            dgvOrderDetail.Columns["OrderId"].Visible = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
