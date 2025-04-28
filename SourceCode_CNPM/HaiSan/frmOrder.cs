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
        List<ProductImport> products; //all products to throw into combobox
        private OrderBUS orderBUS;
        private int selectedRow = -1; //variable to keep track of ui flow

        public frmOrder()
        {
            orderBUS = new OrderBUS();
            products = orderBUS.GetProductByLoHang();


            InitializeComponent();
            customControl();
            showOrderList(orderBUS.GetOrders());
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
        //
        // load data
        //
        private void loadDataIntoCombox()
        {
            products = orderBUS.GetProductByLoHang();
            if (products != null)
            {
                comboBoxProductName.Items.Clear();

                foreach (ProductImport product in products)
                {
                    comboBoxProductName.Items.Add(product);
                }
            }
            else
            {
                new frmError("Dữ liệu", "Dữ liệu bị null").ShowDialog();
            }
        }
        private void showOrderList(List<Order> l)
        {
            // dua du lieu vao view
            dgvOrderList.DataSource = l;
            AddViewButton();

            // sua headertext
            dgvOrderList.Columns["OrderId"].HeaderText = "Mã";
            dgvOrderList.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            dgvOrderList.Columns["TotalAmount"].HeaderText = "Tổng tiền";
            dgvOrderList.Columns["ReceivedAmount"].HeaderText = "Khách đưa";
            dgvOrderList.Columns["UsedPoint"].HeaderText = "Điểm dùng";
            dgvOrderList.Columns["PaymentMethod"].HeaderText = "Thanh toán";
            dgvOrderList.Columns["Phone"].HeaderText = "SĐT Khách";
            dgvOrderList.Columns["EmployeeId"].HeaderText = "Nhân viên";
            dgvOrderList.Columns["ChangeAmount"].HeaderText = "Tiền thối";

            dgvOrderList.Columns["CustomerId"].Visible = false;
            dgvOrderList.Columns["RawAmount"].Visible = false;

        }

        // them button xem chi tiet
        private void AddViewButton()
        {
            if (!dgvOrderList.Columns.Contains("ViewButton"))
            {
                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn
                {
                    Name = "ViewButton",
                    HeaderText = "Chi tiết",
                    Text = "Xem",
                    UseColumnTextForButtonValue = true
                };
                dgvOrderList.Columns.Add(viewButton);
            }
        }
        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrderList.Columns[e.ColumnIndex].Name == "ViewButton")
            {
                // Get selected order
                var order = dgvOrderList.Rows[e.RowIndex].DataBoundItem as Order;

                if (order != null)
                {
                    // Show a detail dialog
                    frmOrderDetail detailForm = new frmOrderDetail(order);
                    detailForm.ShowDialog();
                }
            }
        }
        //some general textbox input validation
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void NumberOnly_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox t = (TextBox)sender;
                string strNum = t.Text;

                if (decimal.TryParse(t.Text.Replace(",", ""), out decimal amount))
                {
                    t.TextChanged -= NumberOnly_TextChanged;
                    t.Text = formatNumber(amount);
                    t.SelectionStart = t.TextLength;
                    t.TextChanged += NumberOnly_TextChanged;
                }
            }
        }

        //for things that can be float
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
                // Check decimal precision
                string[] parts = strNum.Split('.');
                if (parts.Length == 2 && parts[1].Length > 3)
                {
                    // More than 3 decimal places — trim
                    t.Text = parts[0] + "." + parts[1].Substring(0, 3);
                    t.SelectionStart = t.Text.Length;
                }

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
            comboBoxProductName.SelectedIndexChanged -= comboBox_SelectedIndexChanged;

            comboBoxPayment.SelectedIndex = 0;


            textBoxUnit.Text = "";
            soLuongTextBox.Text = "";
            textBoxPrice.Text = "";
            textBoxRemaining.Text = "";
            selectedRow = -1;

            delBtn.Enabled = false;
            editBtn.Enabled = false;
            addBtn.Enabled = true;
            comboBoxProductName.SelectedIndexChanged += comboBox_SelectedIndexChanged;

        }

        

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductName.SelectedItem != null)
            {
                ProductImport selectedItem = (ProductImport)comboBoxProductName.SelectedItem;
                textBoxUnit.Text = selectedItem.Unit;
                textBoxRemaining.Text = selectedItem.Remaining.ToString();
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
                    comboBoxProductName.Focus();
                }
            }

        }

        private void dataGridViewOrderDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editBtn.Enabled = true;
                delBtn.Enabled = true;
                selectedRow = e.RowIndex;

                DataGridViewRow row = dataGridViewOrderDetail.Rows[e.RowIndex];
                foreach (ProductImport product in comboBoxProductName.Items)
                {
                    if (product.ToString() == row.Cells[0].Value.ToString())
                    {
                        comboBoxProductName.SelectedItem = product;
                        break;
                    }
                }
                soLuongTextBox.Text = row.Cells[1].Value.ToString();

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
                    if (addQuantity == 0)
                    {
                        new frmError("Số lượng không hợp lệ", "Không thể thêm 0 sản phẩm").ShowDialog();
                        soLuongTextBox.Focus();
                        return;
                    }

                    ProductImport product = row.Cells[0].Value as ProductImport;
                    if (!orderBUS.CheckAvailable(product, quantity))
                    {
                        new frmError("Số lượng không hợp lệ", "Không thể thêm nhiều hơn số lượng có").ShowDialog();
                        soLuongTextBox.Focus();
                        return;
                    }

                    row.Cells[1].Value = quantity;
                    row.Cells[4].Value = formatNumber(orderBUS.CalPrice(quantity, price)); // Total


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

                ProductImport p = (ProductImport)comboBoxProductName.SelectedItem;
                decimal quantity = changeAmountToDecimal(soLuongTextBox.Text);
                if (quantity == 0)
                {
                    new frmError("Số lượng không hợp lệ", "Không thể thêm 0 sản phẩm").ShowDialog();
                    soLuongTextBox.Focus();
                    return;
                }
                decimal price = changeAmountToDecimal(textBoxPrice.Text);

                if (!orderBUS.CheckAvailable(p, quantity))
                {
                    new frmError("Số lượng không hợp lệ", "Không thể thêm nhiều hơn số lượng có").ShowDialog();
                    soLuongTextBox.Focus();
                    return;
                }

                newRow.Cells[0].Value = comboBoxProductName.SelectedItem;                  // ProductName
                newRow.Cells[1].Value = quantity;   // Quantity
                newRow.Cells[2].Value = formatNumber(price);          // Price
                newRow.Cells[3].Value = textBoxUnit.Text;                          // Unit
                newRow.Cells[4].Value = formatNumber(orderBUS.CalPrice(quantity, price)); // Total

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
                    row.Cells[0].Value = ((ProductImport)comboBoxProductName.SelectedItem);
                }
                else
                {
                    new frmError("Sửa thất bại", "Sản phẩm không hợp lệ").ShowDialog();
                    comboBoxProductName.Focus();
                    return;
                }

                if (!soLuongTextBox.Text.IsNullOrEmpty())
                {
                    ProductImport p = new ProductImport();
                    foreach (ProductImport product in comboBoxProductName.Items)
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
                    row.Cells[4].Value = formatNumber(orderBUS.CalPrice(quantity, p.RetailPrice));
                    updateOnDetailChange(sender, e);
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

        //này giống thay đổi của những cái ở dưới hơn (point + cái voucher đang xài)
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
            processCash(sender, e);

        }
        //mỗi lần có gì thay đổi ở chi tiết đơn hàng thì phải cập nhật các text box với lấy mấy cái voucher hợp lệ
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
            dataGridViewVouchers.Columns["VoucherId"].HeaderText = "Id voucher";
            dataGridViewVouchers.Columns["VoucherName"].HeaderText = "Tên voucher";
            dataGridViewVouchers.Columns["ReleaseDate"].HeaderText = "Ngày phát hành";
            dataGridViewVouchers.Columns["ExpireDate"].HeaderText = "Ngày hết hạn";
            dataGridViewVouchers.Columns["ApplyAmount"].HeaderText = "Áp dụng từ";
            dataGridViewVouchers.Columns["MaxApply"].HeaderText = "Áp dụng lên tới";
            dataGridViewVouchers.Columns["DiscountValue"].HeaderText = "Giảm";
            dataGridViewVouchers.Columns["IsCash"].HeaderText = "Giảm tiền mặt";
            dataGridViewVouchers.Columns["IsDebuted"].Visible = false;
            dataGridViewVouchers.Columns["IsDeactivated"].Visible = false;
            dataGridViewVouchers.Columns["IsActive"].Visible = false;



            comboBoxVoucher.SelectedItem = "None";
            comboBoxVoucher.Text = string.Empty;
        }

        private void textBoxPoint_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            string strNum = t.Text;

            if (string.IsNullOrEmpty(strNum))
            {
                comboBoxVoucher_SelectedIndexChanged(sender, e);
                return; // Allow empty string
            }

            int num;
            if (int.TryParse(strNum, out num))
            {
                int pointHas = strToInt(textBoxCusPoint.Text);
                if (!orderBUS.validPoint(pointHas, num))
                {
                    new frmError("Điểm không hợp lệ", "Điểm sử dụng không thể nhiều hơn điểm có").ShowDialog();
                    t.Text = t.Text.Remove(t.Text.Length - 1); // Remove the last character
                    t.SelectionStart = t.Text.Length; // Put cursor at the end
                    return;
                }
                textBoxPoint.TextChanged -= textBoxPoint_TextChanged;
                textBoxPoint.Text = num.ToString();
                textBoxPoint.TextChanged += textBoxPoint_TextChanged;
                comboBoxVoucher_SelectedIndexChanged(sender, e);
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
            
        }
        private void textBoxGiven_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox t = (TextBox)sender;
                string strNum = t.Text;

                if (decimal.TryParse(t.Text.Replace(",", ""), out decimal amount))
                {
                    t.TextChanged -= textBoxGiven_TextChanged;
                    t.Text = formatNumber(amount);
                    t.SelectionStart = t.TextLength;
                    t.TextChanged += textBoxGiven_TextChanged;
                }
                processCash(sender, e);
            }
        }
        private void processCash(object sender, EventArgs e)
        {
            int realAmount = strToInt(textBoxRealSum.Text);
            int given = strToInt(textBoxGiven.Text);
            textBoxChange.Text = formatNumber(orderBUS.CalChange(realAmount, given));

        }
        //
        //buttons below
        //
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            comboBoxVoucher.SelectedItem = "None";
            textBoxGiven.Clear();
            textBoxPoint.Clear();
            textBoxCustomerName.Clear();
            textBoxPhone.Clear();
            textBoxCusPoint.Clear();
            textBoxPoint.Enabled = false;
        }

        public bool inputValidation()
        {
            //input validation
            if (dataGridViewOrderDetail.Rows.Count <= 0)
            {
                new frmError("Thiếu dữ liệu", "Vui lòng nhập chi tiết đơn hàng").ShowDialog();
                comboBoxProductName.Focus();
                return false;
            }

            if (comboBoxPayment.SelectedItem.ToString().IsNullOrEmpty())
            {
                new frmError("Thiếu dữ liệu", "Vui lòng chọn phương thức thanh toán").ShowDialog();
                comboBoxPayment.Focus();
                return false; ;
            }
            if (textBoxGiven.Text.IsNullOrEmpty())
            {
                new frmError("Thiếu dữ liệu", "Vui lòng nhập số tiền đưa").ShowDialog();
                textBoxGiven.Focus();
                return false ;
            }
            return true;
        }
        //
        //Tạo đơn (IMPORTANT!!!)
        //
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!inputValidation()) throw new Exception("");
            if (string.IsNullOrEmpty(textBoxCustomerName.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Nếu trống, sẽ lưu tên là ẩn danh",
                    "Bạn có chắc muốn bỏ trống tên?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    textBoxCustomerName.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn cần xác nhận với khách hàng rằng mình sẽ không được ưu đãi nếu bỏ trống",
                    "Bạn có chắc muốn bỏ trống SĐT?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    textBoxPhone.Focus();
                    return;
                }
            }



            //me when i rửa input
            int realTotal = strToInt(textBoxRealSum.Text);
            int received = strToInt(textBoxGiven.Text);
            if (!orderBUS.validGiven(received, realTotal))
            {
                new frmError("Sai dữ liệu", "Số tiền đưa không đủ").ShowDialog();
                textBoxGiven.Focus();
                return;
            }

            Voucher v = (comboBoxVoucher.SelectedIndex <= -1) ? null : (Voucher)comboBoxVoucher.SelectedItem;
            string voucherId = (v != null) ? v.VoucherId : null;
            string customerName = textBoxCustomerName.Text.IsNullOrEmpty() ? "Anonymous" : textBoxCustomerName.Text.Trim();
            string phone = textBoxPhone.Text.IsNullOrEmpty() ? "000000000000" : textBoxPhone.Text.Trim();
            int points = textBoxPoint.Text.IsNullOrEmpty() ? 0 : strToInt(textBoxPoint.Text);
            string payMethod = comboBoxPayment.SelectedItem.ToString() ?? "Tiền mặt"; //we just be defaulting

            //extracting info outta dgv
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (DataGridViewRow row in dataGridViewOrderDetail.Rows)
            {
                if (row.IsNewRow) continue;
                ProductImport product = row.Cells[0].Value as ProductImport;
                OrderDetail orderDetail = new OrderDetail
                {
                    ImportId = product.ImportId,
                    ProductId = product.ProductId,
                    Amount = changeAmountToDecimal(row.Cells[1].Value.ToString()),
                    RetailPrice = product.RetailPrice
                };
                orderDetails.Add(orderDetail);
            }
            try
            {
                orderBUS.CreateOrder(customerName, phone, voucherId, Session.UserID, realTotal, received, points, payMethod, orderDetails, products);
                int pointsGained = orderBUS.CalculatePoints(realTotal);
                //show that its successful
                using (var successForm = new frmSuccces("Đơn được lập thành công", $"Khách hàng đã được thêm {pointsGained} điểm"))
                {
                    successForm.ShowDialog();
                }

                //refresh order list
                showOrderList(orderBUS.GetOrders());
                //refresh product list
                loadDataIntoCombox();


                //preview print
                btnPreview_Click(sender, e);

                //clear all info 
                clearControl();
                btnCancel2_Click(sender, e);

                dataGridViewOrderDetail.RowEnter -= dataGridViewOrderDetail_RowEnter;
                dataGridViewOrderDetail.DataSource = null;
                dataGridViewOrderDetail.Rows.Clear();     // Clears manual rows
                dataGridViewOrderDetail.Columns.Clear();  // Clears manual columns
                dataGridViewOrderDetail.RowEnter += dataGridViewOrderDetail_RowEnter;

                textBoxRawSum.Clear();
                textBoxRealSum.Clear();
                textBoxChange.Clear();
            }
            catch (Exception ex)
            {
                new frmError("Lỗi", ex.Message).ShowDialog();
            }
        }
        //
        //Xem trc đơn in
        //
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!inputValidation()) return;

            string voucherId;
            Voucher voucher = comboBoxVoucher.SelectedItem as Voucher;

            voucherId = voucher?.VoucherId ?? "None";

            frmReceipt receipt = new frmReceipt();

            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataGridViewRow row in dataGridViewOrderDetail.Rows)
            {
                if (!row.IsNewRow)
                {
                    ProductImport p = row.Cells[0].Value as ProductImport;
                    if (p != null)
                    {
                        string name = p.ProductName;
                        decimal amount = changeAmountToDecimal(row.Cells[1].Value.ToString());
                        int price = strToInt(row.Cells[2].Value.ToString());
                        string unit = row.Cells[3].Value.ToString();
                        int total = strToInt(row.Cells[4].Value.ToString());
                        OrderItem oi = new OrderItem
                        {
                            Name = name,
                            Price = price,
                            Unit = unit,
                            Quantity = amount,
                            Total = total
                        };
                        orderItems.Add(oi);
                        Console.WriteLine(oi);
                    }
                }
            }

            receipt.PrintReceipt(orderBUS.ConsolidateOrderItems(orderItems), voucherId, voucherAmount.Text, textBoxRealSum.Text, textBoxPoint.Text);
        }
        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            //input rửa
            string phone = string.IsNullOrEmpty(textBoxPhone.Text) ? "" : textBoxPhone.Text;

            try
            {
                Customer customer = orderBUS.GetCustomer(phone);
                textBoxCusPoint.Text = customer.LoyaltyPoint.ToString();
                textBoxCustomerName.Text = customer.CustomerName.ToString();
                textBoxPoint.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cancelCustomer_Click(object sender, EventArgs e)
        {
            textBoxCusPoint.Clear();
            textBoxCustomerName.Clear();
            textBoxPoint.Enabled = false;
        }

        //
        //Phần xem đơn hàng
        //
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string cusId = txtCusId.Text;
            string phone = txtPhone.Text;
            string empId = txtEmpId.Text;
            int priceFrom = strToInt(txtFromPrice.Text);
            int priceTo = strToInt(txtToPrice.Text);
            if (priceFrom != 0 && priceTo != 0)
            if (!orderBUS.validPriceSort(priceFrom, priceTo))
            {
                    new frmError("Lỗi", "Giá lọc không hợp lệ").ShowDialog();
                    txtFromPrice.Focus();
                    return;
            }

            string sortBy;
            bool ASC;
            switch (cbbSortName.Text)
            {
                case "Giá tăng dần":
                    sortBy = "TotalAmount";
                    ASC = true;
                    break;
                case "Giá giảm dần":
                    sortBy = "TotalAmount";
                    ASC = false;
                    break;
                case "Ngày tạo mới nhất":
                    sortBy = "CreatedAt";
                    ASC = false;
                    break;
                case "Ngày tạo cũ nhất":
                    sortBy = "CreatedAt";
                    ASC = true;
                    break;
                default:
                    sortBy = "CreatedAt";
                    ASC = false;
                    break;
            }

            List<Order> newOrders = orderBUS.Sort(cusId,phone,empId,priceFrom,priceTo,sortBy,ASC);
            showOrderList(newOrders);
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
                if (item is ProductImport obj && obj.ToString().Equals(text, StringComparison.OrdinalIgnoreCase))
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
