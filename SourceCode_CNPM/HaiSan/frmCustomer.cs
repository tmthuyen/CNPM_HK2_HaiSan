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
using System.Xml.Linq;

namespace GUI
{
    public partial class frmCustomer : Form
    {
        private CustomerBUS cusBUS;
        public frmCustomer()
        {
            cusBUS = new CustomerBUS();
            InitializeComponent();
            customControl();
        }


        // bo goc, doi mau hieu ung
        private void customControl()
        {
            for (int i = 0; i < pnCusInfo.Controls.Count; i++)
            {
                UIHelper.ApplyRoundedCorners(pnCusInfo.Controls[i], 20);

                if (pnCusInfo.Controls[i] != null && pnCusInfo.Controls[i] is Button b)
                {
                    Color original = b.BackColor;
                    UIHelper.UIMouseEvent(b, new List<Color> { Color.Aqua, original, Color.Blue });

                    //b.MouseClick += (o, e) => b.BackColor = Color.Red;
                }
            }

            for (int i = 0; i < grbCusHistory.Controls.Count; i++)
            {
                UIHelper.ApplyRoundedCorners(grbCusHistory.Controls[i], 15);

                if (grbCusHistory.Controls[i] != null && grbCusHistory.Controls[i] is Button b)
                {
                    Color original = b.BackColor;
                    UIHelper.UIMouseEvent(b, new List<Color> { Color.Aqua, original, Color.Blue });

                    //b.MouseClick += (o, e) => b.BackColor = Color.Red;
                }
            }

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            enableControlBtn();
            // dua data vao view
            loadData(dgvCusList, cusBUS.GetAll());
        }

        private void loadData(DataGridView dgv, List<Customer> l)
        {
            dgv.DataSource = l;

            // Đặt tiêu đề các cột
            dgv.Columns["CustomerId"].HeaderText = "Mã";
            dgv.Columns["CustomerName"].HeaderText = "Tên";
            dgv.Columns["Phone"].HeaderText = "Số điện thoại";
            dgv.Columns["LoyaltyPoint"].HeaderText = "Điểm tích lũy";
        }

        // display button
        private void enableControlBtn()
        {
            txtCusPoint.Enabled = false;
            grbCusHistory.Enabled = txtCusId.Text != "";
            if (txtCusId.Text != "" || txtCusPhone.Text != "")
            {
                btnSearch.Enabled = true;
                //btnOrdHistory.Enabled = txtCusId.Text != "";
            }
            else
            {
                btnSearch.Enabled = false;
                //btnOrdHistory.Enabled = false;
            }
        }

        private List<Order> findOrderByCusId(string cusId)
        {
            Order order = new Order();
            order.OrderId = "hd1";
            Order order2 = new Order();
            order2.OrderId = "hd2";

            List<Order> orders = new List<Order>() { order, order2 };

            return orders;
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
            dgvCusList.Columns.Add(viewDetailsButtonColumn);


        }



        private void txtCusId_TextChanged(object sender, EventArgs e)
        {
            enableControlBtn();
            if (grbCusHistory.Enabled)
            {
                // cbbOrderCusList.Items.Clear();
                cbbOrderCusList.DataSource = findOrderByCusId(txtCusId.Text);
                cbbOrderCusList.ValueMember = "OrderId";
                cbbOrderCusList.DisplayMember = "OrderId";
            }
            btnSearch_Click(sender, e);
        }

        private void txtCusPhone_TextChanged(object sender, EventArgs e)
        {
            enableControlBtn();
            btnSearch_Click(sender, e);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCusList.DataSource = cusBUS.Search(txtCusId.Text, txtCusPhone.Text, txtCusName.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cbbOrderCusList.Focus();
        }

        private void btnSeeOrder_Click(object sender, EventArgs e)
        {
            if (cbbOrderCusList.DataSource != null || cbbOrderCusList.Items.Count > 0)
            {
                if (cbbOrderCusList.SelectedIndex >= 0)
                {
                    Order orderSelect = (Order)cbbOrderCusList.SelectedItem;
                    frmOrderHistory f = new frmOrderHistory(orderSelect.OrderId, "", "");

                    f.ShowDialog();
                }
            }
            else
            {
                frmError fe = new frmError("Tìm hóa đơn", "Sai mã khách hàng hoặc khách hàng chưa có hóa đơn");
                fe.ShowDialog();
                txtCusId.Focus();
            }
        }


        // xu ly su kien click cell 
        private void dgvCusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dgvCusList.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng và ép kiểu về Customer
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells["CustomerName"].Value?.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                int points = Convert.ToInt32(row.Cells[3].Value);

                // Hiển thị dữ liệu lên các TextBox (nếu có)
                txtCusId.Text = id;
                txtCusPhone.Text = phone;
                txtCusName.Text = name;
                txtCusPoint.Text = points.ToString();
            }
        }

        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
            enableControlBtn();
            btnSearch_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCustomer_Load(sender, e);
        }
    }
}
