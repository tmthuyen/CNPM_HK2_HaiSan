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
using GUI.Usercontrol;

namespace GUI
{
    public partial class frmPromotion : Form
    {
        OrderBUS thing = new OrderBUS("DESKTOP-BP38G95\\SQLEXPRESS", "haisan");
        public frmPromotion()
        {
            InitializeComponent();
            loadDataOnGrid();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Height = 400;
            clearPanel();
            
        }
        public void clearPanel()
        {
            panel1.Visible = false;
            panel1.Height = 0; // Panel starts hidden
            panel1.Controls.Clear();

        }
        public void loadDataOnGrid()
        {
            if (dataGridView1.DataSource == null)
                dataGridView1.DataSource = thing.GetPromotions();
        }
        private void LoadUserControlIntoPanel(UserControl userControl)
        {
            // Clear the panel before adding a new control (optional)
            panel1.Controls.Clear();

            // Set the desired properties for the user control (like size, location, etc.)
            dataGridView1.Height = 130;
            panel1.Height = 300;
            panel1.Visible = true;
            userControl.Dock = DockStyle.Fill;  // Makes the control fill the panel

            // Add the UserControl to the panel
            panel1.Controls.Add(userControl);
        }
        private void changeType(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == "Giảm giá")
            {
                LoadUserControlIntoPanel(new UCDiscount("DESKTOP-BP38G95\\SQLEXPRESS", "haisan"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
