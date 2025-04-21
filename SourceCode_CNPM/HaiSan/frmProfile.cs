using BUS;
using DTO;
using Infrastructure;
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
    public partial class frmProfile : Form
    {
        private Employee emp;
        private EmployeeBUS empBUS;
        public frmProfile(Employee emp)
        {
            this.emp = emp;
            this.empBUS =  new EmployeeBUS();
            InitializeComponent();
        }


        private void frmProfile_Load(object sender, EventArgs e)
        {
            showInfo(richtbProfile, emp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // show thogn tin nhan vien
        private void showInfo(RichTextBox textBox, Employee e)
        {
            string info = 
                $"Mã nhân viên: {e.EmployeeId}\n" +
                $"Tên: {e.EmployeeName} \n" +
                $"Email: {e.Email}\n" +
                $"Địa chỉ: {e.Address} \n" +
                $"Giới tinh: {e.Gender}\n" +
                $"Số điện thoại: {e.Phone}\n" +
                $"Ngày sinh: {e.DateOfBirth}\n";

            textBox.Text = info;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();

            if (oldPass == "")
            {
                new frmError("Tài khoản", "Nhập thiếu mật khẩu cũ").ShowDialog();
                return;
            }

            if (newPass == "")
            {
                new frmError("Tài khoản", "Nhập thiếu mật khẩu mới").ShowDialog();
                return;
            }

            if(empBUS.Login(Session.Username, oldPass) == null)
            {
                new frmError("Tài khoản", "Nhập sai mật khẩu cũ").ShowDialog();
                return;
            }

            empBUS.ChangePassword(Session.UserID, oldPass, newPass);
            new frmSuccces("Tài khoản", "Đổi mật khâu thành công").ShowDialog();
        }

    }
}
