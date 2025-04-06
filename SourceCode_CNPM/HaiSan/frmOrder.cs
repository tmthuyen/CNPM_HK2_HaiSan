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
using BUS;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Diagnostics;
namespace GUI
{
    public partial class frmOrder : Form
    {
        OrderBUS thing = new OrderBUS("DESKTOP-BP38G95\\SQLEXPRESS", "haisan");
        public frmOrder()
        {
            InitializeComponent();
            customControl();
            showOrderList(new List<Order>() { new Order("d", DateTime.Now, 2, 2, 2, "", "", "") });
            loadDataOntoGridView();
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

        private void soLuongTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            string strNum = t.Text;

            if (string.IsNullOrEmpty(strNum))
            {
                return; // Allow empty string
            }

            if (strNum.Length == 1 && (strNum == "," || strNum == "."))
            {
                return; // Allow the first comma or dot
            }

            double num;
            if (double.TryParse(strNum, out num))
            {
                return; // Allow valid number
            }
            else
            {
                // Invalid input
                t.Text = t.Text.Remove(t.Text.Length - 1); // Remove the last character
                t.SelectionStart = t.Text.Length; // Put cursor at the end
            }
        }
        private void clearControl()
        {
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadDataOntoGridView()
        {
            dataGridView1.DataSource = thing.GetPromotions();
            //combo

            List<Product> products = thing.GetProduct();
            if (products != null)
            {
                comboBoxProductID.Items.Clear(); // Clear any existing items
                comboBoxProductName.Items.Clear();

                foreach (Product product in products)
                {
                    comboBoxProductID.Items.Add(product);
                    comboBoxProductName.Items.Add(product.ProductName);
                }
            }
            else
            {
                MessageBox.Show("DataTable is null.");
            }


        }
        private void comboBoxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBoxProductID.SelectedItem != null)
            {
                Product selectedItem = (Product)comboBoxProductID.SelectedItem;
                comboBoxProductName.Text = selectedItem.ProductName;
                textBoxUnit.Text = selectedItem.Unit;
                textBoxRemaining.Text = selectedItem.Quantity.ToString();
                textBoxPrice.Text = selectedItem.RetailPrice.ToString();
            }
            

        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxProductName.SelectedItem != null)
            {
                string? selectedProductName = comboBoxProductName.SelectedItem.ToString();
                Product? selectedProductItem = null;

                foreach (object item in comboBoxProductID.Items)
                {
                    Product productItem = (Product)item;
                    if (productItem.ProductName == selectedProductName)
                    {
                        selectedProductItem = productItem;
                        break;
                    }
                }

                if (selectedProductItem != null)
                {
                    comboBoxProductID.Text = selectedProductItem.ProductId;
                    textBoxUnit.Text = selectedProductItem.Unit;
                    textBoxRemaining.Text= selectedProductItem.Quantity.ToString();
                    textBoxPrice.Text = selectedProductItem.RetailPrice.ToString();
                }
            }



        }

        private void addBtn_Click(object sender, EventArgs e)
        { 
            // Input Validation
            if (string.IsNullOrEmpty(comboBoxProductID.Text) ||
                string.IsNullOrEmpty(textBoxUnit.Text) ||
                string.IsNullOrEmpty(soLuongTextBox.Text) ||
                string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {

                // Correct way to create a new DataRow:
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);
                
                string me = soLuongTextBox.Text;
                if (me.Contains(","))
                    me = me.Replace(",", ".");

                newRow.Cells[0].Value = comboBoxProductName.Text;                  // ProductName
                newRow.Cells[1].Value = decimal.Parse(me);                         // Quantity
                newRow.Cells[2].Value = decimal.Parse(textBoxPrice.Text);          // Price
                newRow.Cells[3].Value = textBoxUnit.Text;                          // Unit
                newRow.Cells[4].Value = 0;                                         // Discount
                newRow.Cells[5].Value = decimal.Parse(me) * decimal.Parse(textBoxPrice.Text); // Total

                dataGridView2.Rows.Add(newRow); // Add the row to the DataGridView

                comboBoxProductID.SelectedItem = null;
                comboBoxProductName.SelectedItem = null;
                textBoxUnit.Text = "";
                soLuongTextBox.Text = "";
                textBoxPrice.Text = "";
                textBoxRemaining.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
