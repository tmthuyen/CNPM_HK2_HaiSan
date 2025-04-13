//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using BUS;
//using GUI.Usercontrol;
//using DTO;
//using Microsoft.IdentityModel.Tokens;
//using System.Diagnostics;
//namespace GUI
//{
//    public partial class frmPromotion : Form
//    {
//        private List<Promotion> yourmom;
//        private PromotionControl usercontrol;
//        private string loadedUsercontrol;
//        public frmPromotion()
//        {
//            InitializeComponent();
//            loadDataOnGrid();
//        }




//        private void Form1_Load(object sender, EventArgs e)
//        {
//            groupBoxPrm.Enabled = false;
//            dataGridView1.Height = 400;
//            clearPanel();
//        }
//        public void clearPanel()
//        {
//            panel1.Visible = false;
//            panel1.Height = 0; // Panel starts hidden
//            panel1.Controls.Clear();

//        }

//        public void loadDataOnGrid()
//        {
//            if (yourmom == null)
//            {
//                yourmom = PromotionBUS.getAll();
//            }

//            dataGridView1.DataSource = PromotionBUS.getPromotionTable(yourmom);
//        }


//        private void LoadUserControlIntoPanel(UserControl userControl)
//        {
//            // Clear the panel before adding a new control (optional)
//            panel1.Controls.Clear();

//            // Set the desired properties for the user control (like size, location, etc.)
//            dataGridView1.Height = 100;
//            panel1.Height = 250;
//            panel1.Visible = true;
//            userControl.Dock = DockStyle.Fill;  // Makes the control fill the panel

//            // Add the UserControl to the panel
//            panel1.Controls.Add(userControl);
//        }

//        private void changeType(object sender, EventArgs e)
//        {
//            if (comboBoxType.SelectedItem == "Giảm giá")
//            {
//                LoadUserControlIntoPanel(new UCDiscount());
//            }
//            if (comboBoxType.SelectedItem == "Voucher toàn đơn")
//            {
//                LoadUserControlIntoPanel(new UCVoucher());
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            Form1_Load(sender, e);
//        }

//        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

//                string promotionId = row.Cells["PromotionId"].Value?.ToString();
//                string promotionType = row.Cells["PromotionType"].Value?.ToString();
//                txtBoxID.Text = promotionId;
//                txtBoxPromotionName.Text = row.Cells["PromotionName"].Value?.ToString();
//                // DailyTimeBegin
//                if (row.Cells["DailyTimeBegin"].Value == DBNull.Value || string.IsNullOrEmpty(row.Cells["DailyTimeBegin"].Value?.ToString()))
//                {
//                    dateTimePickerDailyStart.Format = DateTimePickerFormat.Time;
//                    dateTimePickerDailyStart.Value = DateTime.Today; // 00:00
//                }
//                else
//                {
//                    dateTimePickerDailyStart.Format = DateTimePickerFormat.Time;
//                    dateTimePickerDailyStart.Value = DateTime.Today.Add((TimeSpan)row.Cells["DailyTimeBegin"].Value);
//                }

//                // DailyTimeEnd
//                if (row.Cells["DailyTimeEnd"].Value == DBNull.Value || string.IsNullOrEmpty(row.Cells["DailyTimeEnd"].Value?.ToString()))
//                {
//                    dateTimePickerDailyEnd.Format = DateTimePickerFormat.Time;
//                    dateTimePickerDailyEnd.Value = DateTime.Today; // 00:00
//                }
//                else
//                {
//                    dateTimePickerDailyEnd.Format = DateTimePickerFormat.Time;
//                    dateTimePickerDailyEnd.Value = DateTime.Today.Add((TimeSpan)row.Cells["DailyTimeEnd"].Value);
//                }

//                txtBoxUsePoint.Text = row.Cells["UsePoints"].Value?.ToString();
//                string type;
//                switch (promotionType)
//                {
//                    case "DIS":
//                        type = "Giảm giá";
//                        break;
//                    case "COM":
//                        type = "Combo";
//                        break;
//                    case "COC":
//                        type = "Combo cho loại sản phẩm";
//                        break;
//                    case "BNG":
//                        type = "Mua n tặng n";
//                        break;
//                    case "VOU":
//                        type = "Voucher toàn đơn";
//                        break;
//                    default:
//                        return;
//                }
//                comboBoxType.SelectedItem = type;
//                if (!promotionId.IsNullOrEmpty())
//                {
//                    if ((promotionType == "DIS") && (loadedUsercontrol != "DIS"))
//                    {
//                        usercontrol = new UCDiscount(promotionId);
//                        loadedUsercontrol = "DIS";
//                        LoadUserControlIntoPanel(usercontrol);
//                    }
//                    else if (promotionType == "VOU" && loadedUsercontrol != "VOU")
//                    {
//                        usercontrol = new UCVoucher(promotionId);
//                        loadedUsercontrol = "VOU";
//                        LoadUserControlIntoPanel(usercontrol);

//                    }

//                }

//                else
//                {
//                    loadedUsercontrol = "Somethingelse";
//                }
//            }
//        }
//        private Boolean validateInput()
//        {
//            if (string.IsNullOrEmpty(txtBoxPromotionName.Text) ||
//                string.IsNullOrEmpty(comboBoxType.Text))
//            {
//                MessageBox.Show("Please fill in all the fields.");
//                return false;
//            }
//            return true;
//        }
//        private void addBtn_Click(object sender, EventArgs e)
//        {

//        }
//        private void saveBtn_Click(object sender, EventArgs e)
//        {
//            if (!validateInput())
//            {
//                MessageBox.Show("Please fill in all the fields.");
//                return;
//            }
//            bool innerValid;
//            switch (comboBoxType.Text)
//            {
//                case "Giảm giá":
//                    innerValid = usercontrol.ValidateInput();
//                    break;
//                case "Voucher toàn đơn":
//                    innerValid = usercontrol.ValidateInput();
//                    break;
//                case "Combo":
//                    innerValid = usercontrol.ValidateInput();
//                    break;
//                case "Combo cho loại sản phẩm":
//                    innerValid = usercontrol.ValidateInput();
//                    break;
//                case "Mua n tặng n":
//                    innerValid = usercontrol.ValidateInput();
//                    break;
//                default:
//                    MessageBox.Show("Invalid Promotion type");
//                    return;
//            }

//            if (!innerValid)
//            {
//                return;
//            }


//            try
//            {
//                //DataGridViewRow newRow = new DataGridViewRow();
//                //newRow.CreateCells(dataGridView1);

//                //newRow.Cells[0].Value = comboBoxProductName.Text;                  // PromotionId
//                //newRow.Cells[1].Value = decimal.Parse(me);                         // PromotionName
//                //newRow.Cells[2].Value = decimal.Parse(textBoxPrice.Text);          // ReleaseDate
//                //newRow.Cells[3].Value = textBoxUnit.Text;                          // ExpireDate
//                //newRow.Cells[4].Value = 0;                                         // PromotionType
//                //newRow.Cells[5].Value = decimal.Parse(me) * decimal.Parse(textBoxPrice.Text); // DailyTimeBegin
//                //                                                                   //DailyTimeEnd
//                //                                                                   //UsePoints

//                //dataGridView1.Rows.Add(newRow); // Add the row to the DataGridView

//            }
//            catch (FormatException)
//            {
//                MessageBox.Show("Invalid number format.");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred: " + ex.Message);
//            }
//        }
//        private void button2_Click(object sender, EventArgs e)
//        {

//        }

//        private void checkBox1_CheckedChanged(object sender, EventArgs e)
//        {
//            dateTimePickerDailyEnd.Enabled = checkBox1.Checked;
//            dateTimePickerDailyStart.Enabled = checkBox1.Checked;

//        }
//    }
//}
