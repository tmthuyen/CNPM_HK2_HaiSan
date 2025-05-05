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
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class frmEmployee : Form
    {
        private EmployeeBUS empBUS;
        private bool isAdd = false;
        public frmEmployee()
        {
            empBUS = new EmployeeBUS();
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // tat cac chuc nang
            grInfo.Enabled = false;
            btnSee.Enabled = false;
            btnDelete.Enabled = false;

            // enable tab chwuc nang
            grInput.Enabled = false;


            // chon san trong combobox

            cbbGender.SelectedIndex = 0;
            cbbRole.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;

            loadData(dgvEmployee, empBUS.GetAll());
        }

        private void loadData(DataGridView dgv, List<Employee> l)
        {
            dgv.DataSource = l;

            // Đặt tiêu đề các cột
            dgv.Columns["EmployeeId"].HeaderText = "Mã nhân viên";
            dgv.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
            dgv.Columns["Email"].HeaderText = "Email";
            dgv.Columns["Status"].HeaderText = "Trạng thái";
            dgv.Columns["RoleName"].HeaderText = "Vai trò";
            dgv.Columns["Gender"].HeaderText = "Giới tính";

            // Ẩn các cột không cần thiết (nếu có)
            dgv.Columns["Avatar"].Visible = false;
            dgv.Columns["Phone"].Visible = false;
            dgv.Columns["Address"].Visible = false;
            dgv.Columns["DateOfBirth"].Visible = false;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // bat chuc nang
                btnSee.Enabled = true;
                btnDelete.Enabled = true;

                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

                txtEmpId.Text = row.Cells["EmployeeId"].Value.ToString();
                txtEmpName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtRole.Text = row.Cells["RoleName"].Value.ToString();
            }
        }

        // click de them moi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            grInput.Enabled = true;
            tabEmployee.SelectedIndex = 1;

            isAdd = true;

            txtId.Text = empBUS.CreateNewId();
            txtId.Enabled = false;
            txtEmpName.Focus();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }


        // xem nhan vien
        private void btnSee_Click(object sender, EventArgs e)
        {
            tabEmployee.SelectedIndex = 1;
            isAdd = false;
            btnSave.Enabled = false;
            grInput.Enabled = false;
            btnCancel.Enabled = false;

            showInfo();
        }

        // hien thi thong tin chi tiet nhan vien
        private void showInfo()
        {
            txtId.Text = txtEmpId.Text;
            Employee emp = empBUS.FindById(txtEmpId.Text);
            txtName.Text = emp.EmployeeName;
            txtMail.Text = emp.Email;
            txtPhone.Text = emp.Phone;
            txtAddress.Text = emp.Address;
            cbbGender.Text = emp.Gender;
            cbbStatus.Text = emp.Status;
            cbbRole.Text = emp.RoleName;
            dateTimePicker1.Value = emp.DateOfBirth;
            lblImg.Text = emp.Avatar;
        }

        private void dgvEmployee_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        // chon anh dai dien avatar
        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(sourcePath);

                // lay duong dan toi thu nmuc goc
                string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                // tao ten thu muc chua anh
                string imageFolder = Path.Combine(projectPath, "Images/Avatars");

                // chua co thi tao thu nuc
                if (!Directory.Exists(imageFolder))
                {
                    Directory.CreateDirectory(imageFolder);
                }

                // luu anh toi thu muc dich
                string destPath = Path.Combine(imageFolder, fileName);
                File.Copy(sourcePath, destPath, true); // true để ghi đè nếu trùng tên


                lblImg.Text = fileName;
            }
        }

        // sua thong tin
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            grInput.Enabled = true;
            // id va mail lhong duoc sửa
            txtId.Enabled = false;
            txtMail.Enabled = false;
            btnCancel.Enabled = false;
        }


        // luu khi sua hoac xóa
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                string mail = txtMail.Text.Trim();
                if(IsValidEmail(mail)){

                    if(empBUS.CheckMailExist(mail)){
                        new frmError("Nhân viên", "Email đã tồn tại").ShowDialog();
                        txtMail.Text = "";
                        txtMail.Focus(); 
                        return;
                    }

                    Employee newEmp = new Employee(
                        txtId.Text.Trim(), txtName.Text.Trim(), txtPhone.Text.Trim()
                        , txtMail.Text.Trim(), cbbGender.Text.Trim(), cbbStatus.Text.Trim()
                        , cbbRole.Text.Trim(), lblImg.Text.Trim(), txtAddress.Text.Trim(), dateTimePicker1.Value
                    );

                    // kiem tra luu hay sua
                    if (isAdd)
                    {
                        empBUS.Add(newEmp);
                        new frmSuccces("Nhân viên", "Thêm thành công").ShowDialog();
                    }
                    else
                    {
                        empBUS.Update(newEmp);
                        new frmSuccces("Nhân viên", "Sửa thành công").ShowDialog();
                    }
                    tabEmployee.SelectedIndex = 0;
                    frmEmployee_Load(sender, e);
                }
                else {
                    new frmError("Nhân viên", "Đúng định dang gmail  VD:t@gmail.com").ShowDialog();

                    txtMail.Focus(); 
                    return;
                } 
            }
            else
            {
                frmError f = new frmError("Nhân viên", "Thay đổi thất bại");
                f.ShowDialog();
            }
        }

        // kiem tra thong tin can nhu id, name, mail, gioi tinhm, vai tro, trang thai, avatar
        private bool checkEmpty()
        {
            return !(string.IsNullOrWhiteSpace(txtId.Text) ||
                     string.IsNullOrWhiteSpace(txtName.Text) ||
                     string.IsNullOrWhiteSpace(txtMail.Text) ||
                     cbbGender.SelectedIndex < 0 ||
                     cbbRole.SelectedIndex < 0 ||
                     cbbStatus.SelectedIndex < 0 ||
                     string.IsNullOrWhiteSpace(lblImg.Text));
        }

        // kiem tra dinh dang mail
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtEmpId.Text.Trim().Equals(Session.UserID)){
                new frmError("Nhân viên", "Xóa thất bại. Bạn là người dùng hiện tại.").ShowDialog();
                return;
            }
 ;
            if (empBUS.Delete(txtEmpId.Text.Trim()))
            {
                new frmSuccces("Nhân viên", "Xóa thành công").ShowDialog();
                frmEmployee_Load(sender, e);
            }
            else
            {
                new frmError("Nhân viên", "Xóa thất bại!!! Nhân viên đã lưu trong đơn hàng.").ShowDialog();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(isAdd)
            {
                foreach(Control control in this.Controls)
                {
                    if (control is TextBox textbox)
                    {
                        textbox.Text = "";
                    } 
                    if(control is ComboBox c)
                    {
                        c.SelectedIndex = -1;
                    }
                }
                lblImg.Text = "";
            }
        }
    }
}
