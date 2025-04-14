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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DTO;
using Infrastructure;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private EmployeeBUS empBUS;
        public frmLogin()
        {
            empBUS = new EmployeeBUS();
            InitializeComponent();
            customControl();
        }

        private void customControl()
        {
            UIHelper.ApplyRoundedCorners(btnLogin, 50);
            UIHelper.UIMouseEvent(btnLogin, new List<Color> { Color.Aqua, Color.DodgerBlue, Color.Blue });

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTK_Click(object sender, EventArgs e)
        {
            txtTK.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTK.Focus();
        }

        private void lblMK_Click(object sender, EventArgs e)
        {
            txtMK.Focus();
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtMK.UseSystemPasswordChar)
                txtMK.UseSystemPasswordChar = false;
            else
                txtMK.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTK.Text.Trim(); // so dien thoai cua tai khoan
            string matKhau = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan))
            {
                frmError fe = new frmError("Đăng nhập thất bại", "Vui lòng nhập tài khoản!");
                fe.ShowDialog();
                txtTK.Text = "";
                txtTK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                frmError fe = new frmError("Đăng nhập thất bại", "Vui lòng nhập mật khẩu!");
                fe.ShowDialog();
                txtMK.Text = "";
                txtMK.Focus();
                return;
            }

            if (!checkLogin(taiKhoan, matKhau))
            {
                frmError fe = new frmError("Đăng nhập thất bại", "Vui lòng nhập đúng thông tin và tài khoản còn hoạt động");
                fe.ShowDialog();
                txtTK.Text = "";
                txtMK.Text = "";
                txtTK.Focus();
            }
        }

        private bool checkLogin(string taiKhoan, string matKhau)
        {

            // kiem tra tai khoan tu BUS
            //Employee e = empBUS.Login(taiKhoan, matKhau);
            //
            // nhap tam cho nhanh khi login
            //
            Employee e = empBUS.Login("tranthuyen", "thuyen123");

            if (e != null)
            {

                Form f = new Home(e);
                frmSuccces succces;
                string msg = "";

                if (e.RoleName.Equals("admin"))
                {
                    msg = "Hi Admin";
                }
                else if (e.RoleName.Equals("sale"))
                {
                    msg = "Hi Sale";
                }

                succces = new frmSuccces("Đăng nhập", msg);
                succces.ShowDialog();

                Session.StartSession(e.EmployeeId, taiKhoan, e.RoleName);

                this.Hide();
                f.ShowDialog();

                return true;
            }
            return false;
        }

        private void txtMK_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm đăng nhập ở đây
                btnLogin_Click(sender, new EventArgs());
            }
        }
    }
}
