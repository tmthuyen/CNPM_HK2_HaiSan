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
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Diagnostics;
using BUS;
using Microsoft.IdentityModel.Tokens;
using Infrastructure;
namespace GUI
{
    public partial class frmOrder : Form
    {
        List<Voucher> vouchers; // applicablVouchers
        private ProductBUS productBUS;
        private OrderBUS orderBUS;
        List<Product> products;
        private int selectedRow = -1;

        public frmOrder()
        {
            productBUS = new ProductBUS();
            orderBUS = new OrderBUS();
            products = productBUS.getAll();
            InitializeComponent();
            customControl();
            showOrderList(new List<Order>() { new Order("d", DateTime.Now, 2, 2, 2, "", "", "", "vou1", new List<OrderDetail>()) });
            loadDataIntoCombox();
            clearControl();
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
        private void processNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.')
                return;
            if (e.KeyChar == ',')
            {
                // Insert '.' at the current cursor position
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Insert(selectionStart, ".");
                textBox.SelectionStart = selectionStart + 1; // move caret after inserted '.'
                e.Handled = true; // prevent the original ',' from being added
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
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
            
            comboBoxProductName.SelectedItem = null;
            textBoxUnit.Text = "";
            soLuongTextBox.Text = "";
            textBoxPrice.Text = "";
            textBoxRemaining.Text = "";
            selectedRow = -1;

            delBtn.Enabled = false;
            editBtn.Enabled = false;
            addBtn.Enabled = true;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //
        // load data
        //
        private void loadDataIntoCombox()
        {

            List<Product> products = productBUS.getAll();
            if (products != null)
            {
                comboBoxProductName.Items.Clear();

                foreach (Product product in products)
                {
                    comboBoxProductName.Items.Add(product);
                }
            }
            else
            {
                new frmError("Dữ liệu", "Dữ liệu bị null").ShowDialog();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductName.SelectedItem != null)
            {
                Product selectedItem = (Product)comboBoxProductName.SelectedItem;
                textBoxUnit.Text = selectedItem.Unit;
                textBoxRemaining.Text = formatNumber(selectedItem.Remaining);
                textBoxPrice.Text = formatNumber(selectedItem.RetailPrice);
            }

            comboBoxVoucher.SelectedIndex = -1;
        }


        // pressing enter
        private void soLuongTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (selectedRow >= 0)
                {
                    editBtn_Click(sender, e);
                }
                else
                {
                    addBtn_Click(sender, e);
                }
            }

        }

        private void dataGridViewOrderDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editBtn.Enabled = true;
                delBtn.Enabled = true;
                btnSave.Enabled = false;
                selectedRow = e.RowIndex;

                DataGridViewRow row = dataGridViewOrderDetail.Rows[e.RowIndex];
                foreach (Product product in comboBoxProductName.Items)
                {
                    if (product.ToString() == row.Cells[0].Value.ToString())
                    {
                        comboBoxProductName.SelectedItem = product;
                        break;
                    }
                }
                soLuongTextBox.Text = row.Cells[1].Value.ToString();

            }
            else
            {
                clearControl();
            }
        }

        //
        //buttons on top
        //
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrEmpty(comboBoxProductName.Text) ||
                string.IsNullOrEmpty(textBoxUnit.Text) ||
                string.IsNullOrEmpty(soLuongTextBox.Text) ||
                string.IsNullOrEmpty(textBoxPrice.Text) ||
                !Match(comboBoxProductName.Text, comboBoxProductName)
                )
            {
                MessageBox.Show("Chưa điền hoặc điền chưa đúng các dòng dữ liệu .");
                return;
            }



            //đây là cho cộng vào mấy product có trong đon r
            foreach (DataGridViewRow row in dataGridViewOrderDetail.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells[0].Value?.ToString();

                if (productName == comboBoxProductName.Text)
                {
                    decimal ogQuantity = changeAmountToDecimal(row.Cells[1].Value.ToString());
                    decimal addQuantity = changeAmountToDecimal(soLuongTextBox.Text);
                    decimal price = changeAmountToDecimal(row.Cells[2].Value.ToString());
                    decimal quantity = orderBUS.AddAmounts(ogQuantity, addQuantity);
                    row.Cells[1].Value = quantity;
                    row.Cells[4].Value =  formatNumber(orderBUS.CalPrice(quantity,price)); // Total


                    updateOnDetailChange(sender, e);
                    clearControl();
                    return;
                }
            }

            //thêm mới product chưa có
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewOrderDetail);

                Product p = (Product)comboBoxProductName.SelectedItem;
                newRow.Cells[0].Value = comboBoxProductName.SelectedItem;                  // ProductName
                decimal quantity = changeAmountToDecimal(soLuongTextBox.Text);
                newRow.Cells[1].Value = quantity;   // Quantity
                decimal price = changeAmountToDecimal(textBoxPrice.Text);
                newRow.Cells[2].Value = formatNumber(price);          // Price
                newRow.Cells[3].Value = textBoxUnit.Text;                          // Unit
                newRow.Cells[4].Value = orderBUS.CalPrice(quantity, price); // Total

                dataGridViewOrderDetail.Rows.Add(newRow);

                updateOnDetailChange(sender, e);
                clearControl();
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
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0 && selectedRow < dataGridViewOrderDetail.Rows.Count && !dataGridViewOrderDetail.Rows[selectedRow].IsNewRow)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc bạn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridViewOrderDetail.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    clearControl();
                }
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridViewOrderDetail.Rows[selectedRow];
                if (Match(comboBoxProductName.Text, comboBoxProductName))
                {
                    row.Cells[0].Value = ((Product)comboBoxProductName.SelectedItem);
                }
                else
                {
                    new frmError("Sửa thất bại", "Sản phẩm không hợp lệ").ShowDialog();
                    return;
                }

                if (!soLuongTextBox.Text.IsNullOrEmpty())
                {
                    Product p = new Product();
                    foreach (Product product in comboBoxProductName.Items)
                    {
                        if (product.ToString() == row.Cells[0].Value.ToString())
                        {
                            p = product;
                            break;
                        }
                    }
                    comboBoxProductName.SelectedItem = p;
                    decimal quantity = changeAmountToDecimal(soLuongTextBox.Text);
                    row.Cells[1].Value = quantity;
                    row.Cells[4].Value = orderBUS.CalPrice(quantity, p.RetailPrice);
                    updateOnDetailChange(sender,e);
                }
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearControl();
        }

        //
        //the voucher part
        //

        private void comboBoxVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVoucher.SelectedItem == null || comboBoxVoucher.SelectedItem.ToString() == "None")
            {
                voucherAmount.Text = "0";
                int rawAmount = strToInt(textBoxRawSum.Text);
                int point = strToInt(textBoxPoint.Text);
                int realAmount = orderBUS.CalOverAll(rawAmount, 0, point);
                textBoxRealSum.Text = formatNumber(realAmount);
                comboBoxVoucher.SelectedIndex = -1;
            }
            else
            {
                Voucher voucher = (Voucher)comboBoxVoucher.SelectedItem;
                int rawAmount = strToInt(textBoxRawSum.Text);
                int point = strToInt(textBoxPoint.Text);
                int discount = orderBUS.GetDiscount(rawAmount, voucher);
                voucherAmount.Text = formatNumber(discount);
                int realAmount = orderBUS.CalOverAll(rawAmount, discount, point);
                textBoxRealSum.Text = formatNumber(realAmount);
            }

        }
        //mỗi lần có gì thay đổi thì phải cập nhật các text box với lấy mấy cái voucher hợp lệ
        private void updateOnDetailChange(object sender, EventArgs e)
        {
            int rawTotal = GetRawSum();

            textBoxRawSum.Text = formatNumber(rawTotal);
            vouchers = orderBUS.GetVouchers(rawTotal);

            comboBoxVoucher.Items.Clear();
            foreach (Voucher voucher in vouchers)
            {
                comboBoxVoucher.Items.Add(voucher);
            }
            comboBoxVoucher.Items.Add("None");
            dataGridViewVouchers.DataSource = vouchers;
            comboBoxVoucher_SelectedIndexChanged(sender, e);
        }

        private void textBoxPoint_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            string strNum = t.Text;

            if (string.IsNullOrEmpty(strNum))
            {
                updateOnDetailChange(sender, e);
                return; // Allow empty string
            }

            double num;
            if (double.TryParse(strNum, out num))
            {
                textBoxPoint.TextChanged -= textBoxPoint_TextChanged;
                textBoxPoint.Text = num.ToString();
                textBoxPoint.TextChanged += textBoxPoint_TextChanged;
                updateOnDetailChange(sender, e);
                return; // Allow valid number
            }
            else
            {
                t.Text = t.Text.Remove(t.Text.Length - 1); // Remove the last character
                t.SelectionStart = t.Text.Length; // Put cursor at the end
            }
        }
        private void textBoxPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void processCash(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox t = (TextBox)sender;
                string strNum = t.Text;

                if (decimal.TryParse(t.Text.Replace(",", ""), out decimal amount))
                {
                    t.TextChanged -= processCash;
                    t.Text = formatNumber(amount);
                    t.SelectionStart = t.TextLength;
                    t.TextChanged += processCash;

                    int realAmount = strToInt(textBoxRealSum.Text);
                    int given = strToInt(textBoxGiven.Text);
                    textBoxChange.Text = formatNumber(orderBUS.CalChange(realAmount, given));
                }
            }
        }
        //
        //buttons below
        //
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            comboBoxVoucher.SelectedItem = "None";
            textBoxPoint.Clear();
            textBoxCustomerName.Clear();
            textBoxPhone.Clear();

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //input validation
            if (dataGridViewOrderDetail.Rows.Count<=0)
            {
                new frmError("Thiếu dữ liệu", "Vui lòng nhập chi tiết đơn hàng").ShowDialog();
                return;
            }
           

            //me when i rửa input
            Voucher v = (comboBoxVoucher.SelectedIndex <= -1)?null:(Voucher)comboBoxVoucher.SelectedItem;
            string voucherId = v!=null?v.VoucherId:"";
            string customerName = textBoxCustomerName.Text.IsNullOrEmpty() ? "Anonymous" : textBoxCustomerName.Text.Trim();
            string phone = textBoxPhone.Text.IsNullOrEmpty() ? "000000000000" : textBoxPhone.Text.Trim();
            int points = textBoxPoint.Text.IsNullOrEmpty() ? 0 : strToInt(textBoxPoint.Text);
            int realTotal = strToInt(textBoxRealSum.Text);


            List<OrderDetail> orderDetails = new List<OrderDetail>();

            // Assuming you have order details in a DataGridView
            foreach (DataGridViewRow row in dataGridViewOrderDetail.Rows)
            {
                if (row.IsNewRow) continue;
                Product product = row.Cells[0].Value as Product;
                OrderDetail orderDetail = new OrderDetail
                {
                    ProductId = product.ProductId,
                    Amount = changeAmountToDecimal(row.Cells[1].Value.ToString()),
                    RetailPrice = strToInt(row.Cells[2].Value.ToString())
                };
                orderDetails.Add(orderDetail);
            }

            //orderBUS.CreateOrder(customerName,phone,voucherId,Session.UserID,);
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            string voucherId;
            Voucher voucher = comboBoxVoucher.SelectedItem as Voucher;

            voucherId = voucher?.VoucherId ?? "None";

            frmReceipt receipt = new frmReceipt();
            receipt.PrintReceipt(dataGridViewOrderDetail, voucherId, voucherAmount.Text, textBoxRealSum.Text, textBoxPoint.Text);
        }


        //
        // the end rồi, dưới đây toàn
        //helper functions :(((
        //mà thôi
        public string formatNumber(decimal number)
        {
            return number.ToString("N0");
        }

        public int strToInt(string text)
        {
            int number = 0;
            if (int.TryParse(text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out int value))
            {
                number = value;
            }
            return number;
        }
        public decimal changeAmountToDecimal(string text)
        {
            decimal number = 0;
            if (decimal.TryParse(text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal value))
            {
                number = value;
            }
            return number;
        }
        public bool Match(string text, ComboBox comboBox)
        {
            foreach (var item in comboBox.Items)
            {
                if (item is Product obj && obj.ToString().Equals(text, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public int GetRawSum()
        {
            List<int> cellValues = new List<int>();

            foreach (DataGridViewRow row in dataGridViewOrderDetail.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    int value = (int)changeAmountToDecimal(row.Cells[4].Value.ToString());
                    cellValues.Add(value);
                }
            }

            int rawTotal = orderBUS.GetRawTotal(cellValues.ToArray());
            return rawTotal;
        }
    }
}
