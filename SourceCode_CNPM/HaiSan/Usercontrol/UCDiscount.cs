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
using DTO;
using Microsoft.IdentityModel.Tokens;

namespace GUI.Usercontrol
{
    public partial class UCDiscount : UserControl
    {
        OrderBUS? thing;
        List<Product>? products;
        HashSet<string> categories = new HashSet<string>();

        public UCDiscount()
        {
            InitializeComponent();
        }
        public UCDiscount(string server, string db)
        {
            InitializeComponent();
            thing = new OrderBUS(server, db);
        }

        private void UCDiscount_Load(object sender, EventArgs e)
        {
            overlayPanel.Location = new Point(405, 3);
            overlayPanel.Visible = false;
            //thêm product nếu chưa có
            if (thing != null && products == null)
                products = thing.GetProduct();

            //thêm v6 từng combobox những label tương ứng
            if (products != null)
            {
                comboBoxProductName.Items.Clear();
                foreach (Product product in products)
                {
                    comboBoxProductName.Items.Add(product.ProductName);
                    if (!categories.Contains(product.CategoryId))
                    {
                        categories.Add(product.CategoryId);
                        comboBoxFilterCateogry.Items.Add(product.CategoryId);
                        comboBoxAddCat.Items.Add(product.CategoryId);
                        comboBoxDelCat.Items.Add(product.CategoryId);
                    }
                }
            }
            else
            {
                MessageBox.Show("products is null.");
            }
        }
        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductName.SelectedItem != null)
            {
                string? selectedProductName = comboBoxProductName.SelectedItem.ToString();
                Product? selectedProductItem = null;

                if (products != null && products.Count > 0)
                    foreach (object item in products)
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
                    textBoxCategory.Text = selectedProductItem.CategoryId.ToString();
                    textBoxPrice.Text = selectedProductItem.RetailPrice.ToString();
                }
            }
        }


        


        private void button7_Click(object sender, EventArgs e)
        {
            UCDiscount_Load(sender, e);
        }

        private void buttonShowOverlay_Click(object sender, EventArgs e)
        {
            if (overlayPanel.Visible)
                overlayPanel.Visible = false;
            else
                overlayPanel.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            comboBoxFilterCateogry.Text="";
            textBoxPriceBegin.Clear();
            textBoxPriceEnd.Clear();
            textBoxSearchName.Clear();
            UCDiscount_Load(sender, e);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            overlayPanel.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal priceBegin;
            decimal priceEnd;

            
            if (textBoxPriceBegin.Text.IsNullOrEmpty())
                priceBegin = 0;
            else
                priceBegin = Convert.ToDecimal(textBoxPriceBegin.Text);
            if (textBoxPriceEnd.Text.IsNullOrEmpty())
                priceEnd = 0;
            else
                priceEnd = Convert.ToDecimal(textBoxPriceEnd.Text);
            if (priceBegin > priceEnd || priceBegin<0 || priceEnd < 0)
            {
                MessageBox.Show("Giá không hợp lệ.");
                return; 
            }
            if (comboBoxFilterCateogry.Text.IsNullOrEmpty()&& textBoxPriceBegin.Text.IsNullOrEmpty()&&textBoxPriceEnd.Text.IsNullOrEmpty()&& textBoxSearchName.Text.IsNullOrEmpty())
            {
                return;
            }
            List<Product> productsFiltered = thing.getFilteredProducts(comboBoxFilterCateogry.Text, textBoxPriceBegin.Text, textBoxPriceEnd.Text, textBoxSearchName.Text);
            if (productsFiltered != null && productsFiltered.Count > 0)
            {
                comboBoxProductName.SelectedItem = null;
                textBoxCategory.Clear();
                comboBoxProductName.Items.Clear();
                foreach (Product product in productsFiltered)
                {
                    comboBoxProductName.Items.Add(product);
                }
            }
            else
            {
                MessageBox.Show("Không tìm được kết quả");
            }
        }
    }
}
