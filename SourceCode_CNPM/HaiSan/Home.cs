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
    public partial class Home : Form
    {
        public Home(Employee e)
        {
            InitializeComponent();
            customControl();
        }

        // thay doi button dieu huong form
        private void customControl()
        {
            for (int i = 0; i < pnSideBar.Controls.Count; i++)
            {
                if (pnSideBar.Controls[i] != null && pnSideBar.Controls[i] is Button b)
                {
                    UIHelper.ApplyRoundedCorners(b, 30);
                    UIHelper.UIMouseEvent(b, new List<Color> { Color.Aqua, Color.Transparent, Color.Red });

                    //b.MouseClick += (o, e) => b.BackColor = Color.Red;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbAvatar_MouseEnter(object sender, EventArgs e)
        {

            cmstAccount.Show(ptbAvatar.PointToScreen(new Point(ptbAvatar.Location.X, ptbAvatar.Height - 2)));
        }

        private void ptbAvatar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cmstAccount_MouseEnter(object sender, EventArgs e)
        {
            cmstAccount.Show();
        }

        private void profileCmstrItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile");
        }

        private void logoutTooltipMItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(home, btnHome);
        }


        // hien thi form con len panel form
        private void showForm(Form f, Button btn)
        {
            if (btn != null)
            {

                lblTitle.Text = btn.Text;
                this.pnForm.Controls.Clear();
                f.Width = pnForm.Width;
                f.Height = pnForm.Height;
                f.FormBorderStyle = FormBorderStyle.None;
                this.pnForm.Controls.Add(f);
                f.Show();
            }
        }


        private void cmstAccount_MouseLeave(object sender, EventArgs e)
        {
            cmstAccount.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnOrder);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnCustomer);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct f = new frmProduct()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, btnProduct);
        }

        private void buttonPromotion_Click(object sender, EventArgs e)
        {
            frmPromotion f = new frmPromotion()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true

            };
            showForm(f, buttonPromotion);
        }
    }
}
