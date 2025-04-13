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
//using DTO;
//using Microsoft.IdentityModel.Tokens;

//namespace GUI.Usercontrol
//{

//    public partial class UCDiscount : PromotionControl
//    {
//        List<Product>? products;
        
//        string promotionID;
//        HashSet<string> categories = new HashSet<string>();

//        public UCDiscount()
//        {
//            InitializeComponent();
//        }

//        public UCDiscount(string PromotionID)
//        {
//            this.promotionID = PromotionID;
//            InitializeComponent();
//        }
//        public void loadDataOnGridview()
//        {
//            List<DiscountDetail> discountDetails = ProductBUS.getOrderDetails();
//            dataGridView1.DataSource = PromotionBUS.GetDetailsDataTable(products, discountDetails, promotionID);
//        }
//        private void UCDiscount_Load(object sender, EventArgs e)
//        {

//            overlayPanel.Location = new Point(405, 3);
//            overlayPanel.Visible = false;

//            if (products == null)
//                products = ProductBUS.getAll();
//            if (!promotionID.IsNullOrEmpty())
//                loadDataOnGridview();
//            //thêm v6 từng combobox những label tương ứng
//            if (products != null)
//            {
//                comboBoxProductName.Items.Clear();
//                foreach (Product product in products)
//                {
//                    comboBoxProductName.Items.Add(product.ProductName);
//                    if (!categories.Contains(product.CategoryId))
//                    {
//                        categories.Add(product.CategoryId);
//                        comboBoxFilterCateogry.Items.Add(product.CategoryId);
//                        comboBoxAddCat.Items.Add(product.CategoryId);
//                        comboBoxDelCat.Items.Add(product.CategoryId);
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("products is null.");
//            }
//        }
//        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (comboBoxProductName.SelectedItem != null)
//            {
//                string? selectedProductName = comboBoxProductName.SelectedItem.ToString();
//                Product? selectedProductItem = null;

//                if (products != null && products.Count > 0)
//                    foreach (object item in products)
//                    {
//                        Product productItem = (Product)item;
//                        if (productItem.ProductName == selectedProductName)
//                        {
//                            selectedProductItem = productItem;
//                            break;
//                        }
//                    }

//                if (selectedProductItem != null)
//                {
//                    textBoxCategory.Text = selectedProductItem.CategoryId.ToString();
//                    textBoxPrice.Text = selectedProductItem.RetailPrice.ToString();
//                }
//            }
//        }

//        private void clearControl(object sender, EventArgs e)
//        {
//            //Thêm sp
//            comboBoxProductName.SelectedIndex = 0;
//            textBoxPrice.Clear();
//            textBoxCategory.Clear();
//            textBoxDiscount.Clear();
//            radioButton3.Checked = false;
//            radioButton4.Checked = false;




//            buttonAdd.Enabled = true;
//            buttonDel.Enabled = false;
//            buttonEdit.Enabled = false;
//            buttonCancel.Enabled = true;
//            buttonSave.Enabled = true;

//            //Thêm nhóm
//            comboBoxAddCat.SelectedIndex = 0;
//            buttonAddGroup.Enabled = false;
//            radioButton1.Checked = false;
//            radioButton2.Checked = false;
//            textBoxGroupDiscount.Clear();

//            //Xóa nhóm
//            comboBoxDelCat.SelectedIndex = 0;
//            textBoxNumInCat.Clear();
//            buttonDelGroup.Enabled = false;
//            UCDiscount_Load(sender, e);
//        }



//        private void button7_Click(object sender, EventArgs e)
//        {
//            clearControl(sender, e);
//        }

//        private void buttonShowOverlay_Click(object sender, EventArgs e)
//        {
//            if (overlayPanel.Visible)
//                overlayPanel.Visible = false;
//            else
//                overlayPanel.Visible = true;
//        }

//        private void button11_Click(object sender, EventArgs e)
//        {
//            comboBoxFilterCateogry.Text = "";
//            textBoxPriceBegin.Clear();
//            textBoxPriceEnd.Clear();
//            textBoxSearchName.Clear();
//            UCDiscount_Load(sender, e);

//        }

//        private void button9_Click(object sender, EventArgs e)
//        {
//            overlayPanel.Visible = false;
//        }
//        public override bool ValidateInput()
//        {
//            if (dataGridView1.Rows.Count > 0)
//            {
//                return true;
//            }
//            return false;
//        }
//        private void button10_Click(object sender, EventArgs e)
//        {
//            decimal? priceBegin;
//            decimal? priceEnd;


//            if (textBoxPriceBegin.Text.IsNullOrEmpty())
//                priceBegin = null;
//            else
//                priceBegin = Convert.ToDecimal(textBoxPriceBegin.Text);
//            if (textBoxPriceEnd.Text.IsNullOrEmpty())
//                priceEnd = null;
//            else
//                priceEnd = Convert.ToDecimal(textBoxPriceEnd.Text);
//            if (priceBegin > priceEnd || priceBegin < 0 || priceEnd < 0)
//            {
//                MessageBox.Show("Giá không hợp lệ.");
//                return;
//            }

//            if (comboBoxFilterCateogry.Text.IsNullOrEmpty() && textBoxPriceBegin.Text.IsNullOrEmpty() && textBoxPriceEnd.Text.IsNullOrEmpty() && textBoxSearchName.Text.IsNullOrEmpty())
//            {
//                return;
//            }
//            if (products != null)
//            {
//                List<Product> productsFiltered = ProductBUS.Sort(products, priceBegin, priceEnd, comboBoxFilterCateogry.Text, textBoxSearchName.Text);
//                if (productsFiltered != null && productsFiltered.Count > 0)
//                {
//                    comboBoxProductName.SelectedItem = null;
//                    textBoxCategory.Clear();
//                    comboBoxProductName.Items.Clear();
//                    foreach (Product product in productsFiltered)
//                    {
//                        comboBoxProductName.Items.Add(product.ProductName);
//                    }
//                    MessageBox.Show("Lọc thành công");
//                }
//                else
//                {
//                    MessageBox.Show("Không tìm được kết quả");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Có product đâu mà sort");
//            }
//        }

//        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
//        {
            
//            buttonDel.Enabled = true;
//            buttonEdit.Enabled = true;
//            //textBoxPrice
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

//                string productName = row.Cells["ProductName"].Value?.ToString();
//                string categoryId = products?
//    .FirstOrDefault(p => p.ProductName == productName)?
//    .CategoryId;
//                int originalPrice = Convert.ToInt32(row.Cells["OriginalPrice"].Value);
//                int discountValue = Convert.ToInt32(row.Cells["DiscountValue"].Value);
//                string isCashOrPercent = row.Cells["IsCashOrPercent"].Value?.ToString();
//                int discountedPrice = Convert.ToInt32(row.Cells["DiscountedPrice"].Value);

//                // Example usage: populate UI fields
//                comboBoxProductName.SelectedItem = productName;
//                textBoxPrice.Text = originalPrice.ToString();
//                if (isCashOrPercent == "VND")
//                {
//                    radioButton3.Checked = true;
//                }
//                else radioButton4.Checked = true;
//                textBoxCategory.Text = categoryId;
//                textBoxDiscount.Text = discountValue.ToString();
//            }
//        }
//    }
//}
