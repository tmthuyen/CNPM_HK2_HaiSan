using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class frmVoucher : Form
    {
        private bool isEditing;
        private string selectedVoucherId;
        private List<Voucher> vouchers;
        public frmVoucher()
        {
            InitializeComponent();
            vouchers = PromotionBUS.getVoucher();
            Voucher_Load();
        }
        private void processNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //block chữ nhưng cho ,
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void processInputNumber(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox t = (TextBox)sender;
                string strNum = t.Text;

                if (decimal.TryParse(t.Text.Replace(",", ""), out decimal amount))
                {
                    t.TextChanged -= processInputNumber;
                    t.Text = amount.ToString("N0");
                    t.SelectionStart = t.TextLength;
                    t.TextChanged += processInputNumber;
                }
            }
        }
        private void clearTextBox()
        {
            textBoxName.Clear();
            textBoxApply.Clear();
            textBoxDiscountValue.Clear();
            radioButtonPercent.Checked = false;
            radioButtonVND.Checked = false;
            textBoxMaxApply.Clear();

            dateTimePickerFrom.Checked = false;
            dateTimePickerFrom.Value = DateTime.Today;

            dateTimePickerTo.Checked = false;
            dateTimePickerTo.Value = DateTime.Today;

            btnSave.Enabled = false;
            btnEdit.Enabled = false;

        }


        private void Voucher_Load()
        {
            DataTable dt = PromotionBUS.GetVoucherDataTable();
            dataGridViewVoucher.DataSource = dt;
            voucherDetails.Enabled = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            voucherDetails.Enabled = true;
            isEditing = true;
            btnSave.Enabled = true;
        }
        private void btnCancelClick(object sender, EventArgs e)
        {
            if (vouchers != null)
            {
                Voucher_Load();
            }
            else
            {
                clearTextBox();
            }
        }

        private void validateInput()
        {
            if (textBoxName.Text.IsNullOrEmpty())
                throw new Exception("Vui lòng nhập tên voucher");
            if ((textBoxApply.Text.IsNullOrEmpty()))
                throw new Exception("Vui lòng nhập đơn áp dụng từ bao nhiêu vnd");
            if ((textBoxDiscountValue.Text.IsNullOrEmpty()))
                throw new Exception("Vui lòng nhập số lượng áp dụng");
            if ((textBoxMaxApply.Text.IsNullOrEmpty()))
                throw new Exception("Vui lòng nhập giới hạn khuyến mãi");
            if (radioButtonPercent.Checked == false && radioButtonVND.Checked == false)
                throw new Exception("Vui lòng chọn giảm vnd hay %");
            if (!isEditing && ((dateTimePickerFrom.Value < DateTime.Today) || (dateTimePickerTo.Value < DateTime.Today)))
                throw new Exception("Thời gian áp dụng không thể ở quá khứ");
            if ((dateTimePickerFrom.Value > dateTimePickerTo.Value))
                throw new Exception("Vui lòng nhập đúng thời gian");
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            try
            {
                validateInput();
            }
            catch (Exception ex)
            {
                (new frmError("Input chưa đúng", ex.Message)).ShowDialog();
                return;
            }

            string voucherName = textBoxName.Text;
            string applyAmount = textBoxApply.Text;
            string discountValue = textBoxDiscountValue.Text;
            string maxApply = textBoxMaxApply.Text;
            bool isCash = radioButtonVND.Checked;
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;

            try
            {
                if (!isEditing)
                {
                    PromotionBUS.addVoucher(voucherName, applyAmount, discountValue, maxApply, isCash, from, to);
                }
                else
                {
                    PromotionBUS.editVoucher(selectedVoucherId, voucherName, applyAmount, discountValue, maxApply, isCash, from, to);
                }
                (new frmSuccces("Nhập thành công", "Đã nhập thành công")).ShowDialog();
                Voucher_Load();

            }
            catch (Exception ex)
            {
                (new frmError("Input chưa đúng", ex.Message)).ShowDialog();
            }

        }

        private void dataGridViewVoucher_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            voucherDetails.Enabled = false;
            if (e.RowIndex >= 0)
            {
                isEditing = false;
                btnEdit.Enabled = true;
                btnDeactivate.Enabled = true;  
                btnSave.Enabled = false;
                DataGridViewRow row = dataGridViewVoucher.Rows[e.RowIndex];

                // Optional: Check for DBNulls to avoid crashes
                selectedVoucherId = row.Cells["VoucherId"].Value?.ToString() ?? "";
                textBoxName.Text = row.Cells["VoucherName"].Value?.ToString() ?? "";
                textBoxApply.Text = row.Cells["ApplyAmount"].Value?.ToString() ?? "0";
                textBoxDiscountValue.Text = row.Cells["DiscountValue"].Value?.ToString() ?? "0";
                textBoxMaxApply.Text = row.Cells["MaxApply"].Value?.ToString() ?? "0";

                if (Convert.ToBoolean(row.Cells["IsCash"].Value))
                    radioButtonVND.Checked = true;
                else
                    radioButtonPercent.Checked = true;

                if (DateTime.TryParse(row.Cells["ReleaseDate"].Value?.ToString(), out DateTime fromDate))
                {
                    dateTimePickerFrom.Value = fromDate;
                }

                if (DateTime.TryParse(row.Cells["ExpireDate"].Value?.ToString(), out DateTime toDate))
                {
                    dateTimePickerTo.Value = toDate;
                }
            }
            else
            {
                clearTextBox();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEditing = false;
            selectedVoucherId = "None";
            voucherDetails.Enabled = true;
            clearTextBox();
            btnSave.Enabled = true;


        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedVoucherId != "None" && !selectedVoucherId.IsNullOrEmpty())
            {
                if((MessageBox.Show("Bạn có muốn vô hiệu hóa không?",
                    "Vô hiệu hóa Voucher",MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes)
                {
                    try 
                    { 
                        PromotionBUS.deactivateVoucher(selectedVoucherId);
                        (new frmSuccces("Vô hiệu hóa thành công", "Voucher đã được vô hiệu hóa")).ShowDialog();
                        Voucher_Load();
                    }
                    catch(Exception ex)
                    {
                        (new frmError("Vô hiệu hóa thất bại",ex.Message)).ShowDialog();
                    }
                    
                }
            }
        }
    }
}
