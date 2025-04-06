using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
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

            if(!checkLogin(taiKhoan, matKhau))
            {
                frmError fe = new frmError("Đăng nhập thất bại", "Vui lòng nhập đúng thông tin!");
                fe.ShowDialog();
                txtTK.Text = "";
                txtMK.Text = "";
                txtTK.Focus();
            } 
        }

        private bool checkLogin(string taiKhoan, string matKhau)
        {

            // kiem tra tai khoan tu BUS
            Employee e = new Employee(null, null, taiKhoan, null, 1, matKhau, "admin", "", null);
            if(e != null)
            {
                Form f = new Home(e);
                if(e.RoleName.Equals("admin"))
                {
                    // dang nhap admin
                }
                else if(e.RoleName.Equals("sale"))
                {
                    // dang nhap sale
                    f = new Home(e);
                }

                this.Hide();
                f.ShowDialog();

                return true;
            }
            return false;
        }
    }
}
