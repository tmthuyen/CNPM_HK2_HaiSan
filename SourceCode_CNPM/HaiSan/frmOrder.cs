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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            customControl();
            showOrderList(new List<Order>() { new Order("d", DateTime.Now, 2,2,2,"", "", "")});
        }

        private void customControl()
        {
            for (int i = 0; i < pnFilter.Controls.Count; i++)
            {

                if (pnFilter.Controls[i] != null && pnFilter.Controls[i] is Button b)
                {
                    UIHelper.ApplyRoundedCorners(pnFilter.Controls[i], 20);
                    Color original = b.BackColor;
                    UIHelper.UIMouseEvent(b, new List<Color> { Color.Aqua, original, Color.Blue });

                    //b.MouseClick += (o, e) => b.BackColor = Color.Red;
                }
            }
        }

        private void showOrderList(List<Order> l)
        {
            // dua du lieu vao view
            dgvOrderList.DataSource = l;

            // sua headertext
            dgvOrderList.Columns["OrderId"].HeaderText = "Mã";
            dgvOrderList.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            dgvOrderList.Columns["TotalAmount"].HeaderText = "Tổng tiền";
            dgvOrderList.Columns["ReceivedAmount"].HeaderText = "Khách đưa";
            dgvOrderList.Columns["UsedPoint"].HeaderText = "Điểm dungf";
            dgvOrderList.Columns["PaymentMethod"].HeaderText = "Thanh toán";
            dgvOrderList.Columns["CustomerId"].HeaderText = "Khách hàng";
            dgvOrderList.Columns["EmployeeId"].HeaderText = "Nhân viên";

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
            dgvOrderList.Columns.Add(viewDetailsButtonColumn);


        }


        // xu ly input so khong dung 
        private void processInputNumber(TextBox t)
        {
            string strNum = t.Text;
            if (strNum != "")
            {
                bool ok = false;
                try
                {
                    double num = double.Parse(strNum);
                    ok = true;
                }
                catch
                {
                    ok = false;
                }
                if (!ok)
                {
                    t.Text = "";
                }
            }
        }


        private void txtFromPrice_TextChanged(object sender, EventArgs e)
        {
            processInputNumber(txtFromPrice);
        }

        private void txtToPrice_TextChanged(object sender, EventArgs e)
        {
            processInputNumber(txtToPrice);
        }
    }
}
