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
        private bool isAdding;
        private string selectedVoucherId;
        private List<Voucher> vouchers;
        private PromotionBUS promotionBUS;
        public frmVoucher()
        {
            InitializeComponent();
            promotionBUS = new PromotionBUS();
            Voucher_Load();
            ClearTextBox();
        }

        private void ProcessNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //block ngoài số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        //đổi sang dạng 1,000,000
        private void ProcessInputNumber(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox t = (TextBox)sender;
                string strNum = t.Text;

                if (decimal.TryParse(t.Text.Replace(",", ""), out decimal amount))
                {
                    t.TextChanged -= ProcessInputNumber;
                    t.Text = amount.ToString("N0");
                    t.SelectionStart = t.TextLength;
                    t.TextChanged += ProcessInputNumber;
                }
            }
        }

        private void textBoxDiscountValue_TextChanged(object sender, EventArgs e)
        {
            ProcessInputNumber(sender, e);
            if (radioButtonVND.Checked)
            {
                textBoxMaxApply.Text = textBoxDiscountValue.Text;
            }
            else
            {
                if (!isEditing)
                    textBoxMaxApply.Enabled = true;
            }
        }

        //2 hàm khi radio thay đổi
        private void radioButtonVND_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVND.Checked && (isEditing || isAdding))
            {
                textBoxMaxApply.Text = textBoxDiscountValue.Text;
                textBoxMaxApply.Enabled = false;
            }
        }
        private void radioButtonPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPercent.Checked && (isEditing || isAdding))
            {
                textBoxMaxApply.Clear();
                textBoxMaxApply.Enabled = true;
            }
        }

        //clear hết textbox
        private void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxApply.Clear();
            textBoxDiscountValue.Clear();
            radioButtonPercent.Checked = false;
            radioButtonVND.Checked = true;
            textBoxMaxApply.Clear();
            dataGridViewVoucher.ClearSelection();

            dateTimePickerFrom.Checked = false;
            dateTimePickerFrom.Value = DateTime.Today;

            dateTimePickerTo.Checked = false;
            dateTimePickerTo.Value = DateTime.Today;

            selectedVoucherId = "None";
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            textBoxMaxApply.Enabled = false;

            isEditing = false;
            isAdding = false;
            btnAdd.Enabled = true;
            btnActivate.Enabled = false;
            btnDeactivate.Enabled = false;
        }

        //load voucher vo gridview
        private void Voucher_Load()
        {
            //DataTable dt = promotionBUS.GetVoucherDataTable();
            vouchers = promotionBUS.GetVoucher();
            dataGridViewVoucher.DataSource = vouchers;

            dataGridViewVoucher.Columns["VoucherId"].HeaderText = "Id voucher";
            dataGridViewVoucher.Columns["VoucherName"].HeaderText = "Tên voucher";
            dataGridViewVoucher.Columns["ReleaseDate"].HeaderText = "Ngày áp dụng";
            dataGridViewVoucher.Columns["ExpireDate"].HeaderText = "Ngày hết hạn";
            dataGridViewVoucher.Columns["ApplyAmount"].HeaderText = "Áp dụng từ";
            dataGridViewVoucher.Columns["MaxApply"].HeaderText = "Áp dụng lên tới";
            dataGridViewVoucher.Columns["DiscountValue"].HeaderText = "Giảm";
            dataGridViewVoucher.Columns["IsCash"].HeaderText = "Giảm tiền mặt";
            dataGridViewVoucher.Columns["IsDebuted"].HeaderText = "Đã ra mắt";
            dataGridViewVoucher.Columns["IsDeactivated"].HeaderText = "Đã bị thu hồi";
            dataGridViewVoucher.Columns["IsActive"].HeaderText = "Đang hoạt động";

            voucherDetails.Enabled = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            voucherDetails.Enabled = true;
            isEditing = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            if (radioButtonVND.Checked)
            {
                textBoxMaxApply.Enabled = false;
            }
            if (radioButtonPercent.Checked)
            {
                textBoxMaxApply.Enabled = true;
            }
        }
        private void btnCancelClick(object sender, EventArgs e)
        {
            if (vouchers == null)
            {
                Voucher_Load();
            }
            else
            {
                ClearTextBox();
                voucherDetails.Enabled = false;
            }
        }
        //hàm để check input
        private void ValidateInput()
        {
            if (textBoxName.Text.IsNullOrEmpty())
                throw new Exception("Vui lòng nhập tên voucher");
            if ((textBoxApply.Text.IsNullOrEmpty()))
                throw new Exception("Vui lòng nhập đơn áp dụng từ bao nhiêu vnd");
            if ((textBoxDiscountValue.Text.IsNullOrEmpty()))
                throw new Exception("Vui lòng nhập voucher giảm bao nhiêu");
            if ((textBoxMaxApply.Text.IsNullOrEmpty()))
                throw new Exception("Vui lòng nhập giảm tối đa bao nhiêu tiền");
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
                ValidateInput();
            }
            catch (Exception ex)
            {
                (new frmError("Input chưa đúng", ex.Message)).ShowDialog();
                return;
            }
            //parse hết inout
            string voucherName = textBoxName.Text;
            string _applyAmount = textBoxApply.Text;
            string _discountValue = textBoxDiscountValue.Text;
            string _maxApply = textBoxMaxApply.Text;
            bool isCash = radioButtonVND.Checked;
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;

            bool valid = true;
            List<string> errors = new List<string>();

            //validate + show dialog dựa trên lỗi
            if (!int.TryParse(_applyAmount.Replace(",", ""), out int applyAmount))
            {
                errors.Add("Nhập lại mức áp dụng");
                valid = false;
            }
            if (!int.TryParse(_discountValue.Replace(",", ""), out int discountValue))
            {
                errors.Add("Nhập lại số lượng giảm");
                valid = false;
            }
            if (!int.TryParse(_maxApply.Replace(",", ""), out int maxApply))
            {
                errors.Add("Nhập lại mức giảm tối đa");
                valid = false;
            }

            if (!valid)
            {
                new frmError("Input chưa đúng", string.Join("\n", errors)).ShowDialog();
                return;
            }

            try
            {
                //nhập mới
                if (!isEditing)
                {
                    Voucher v = new Voucher
                    {
                        VoucherName = voucherName,
                        ReleaseDate = from,
                        ExpireDate = to,
                        ApplyAmount = applyAmount,
                        MaxApply = maxApply,
                        DiscountValue = discountValue,
                        IsCash = isCash,
                    };
                    if (promotionBUS.AddVoucher(v))
                    {
                        (new frmSuccces("Nhập thành công", "Đã nhập thành công")).ShowDialog();
                    }


                }
                else
                {
                    //chỉnh 
                    Voucher oldV = vouchers.FirstOrDefault(v => v.VoucherId == selectedVoucherId);
                    Voucher newV = new Voucher
                    {
                        VoucherName = voucherName,
                        ReleaseDate = from,
                        ExpireDate = to,
                        ApplyAmount = applyAmount,
                        MaxApply = maxApply,
                        DiscountValue = discountValue,
                        IsCash = isCash,
                    };
                    (new frmSuccces("Nhập thành công",
                        promotionBUS.EditVoucher(oldV, newV)
                        )).ShowDialog();
                }
                dataGridViewVoucher.RowEnter -= dataGridViewVoucher_RowEnter;
                Voucher_Load();
                dataGridViewVoucher.RowEnter += dataGridViewVoucher_RowEnter;


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
                isAdding = false;

                btnEdit.Enabled = true;
                btnDeactivate.Enabled = true;
                btnActivate.Enabled = true;
                btnSave.Enabled = false;
                DataGridViewRow row = dataGridViewVoucher.Rows[e.RowIndex];

                //show hết data lên mấy textbox
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
                ClearTextBox();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //bởi vì bản thân tôi hay nhầm nên thêm cái này vào lol, ui problem
            if (isAdding)
            {
                if ((MessageBox.Show("Bạn đang thêm 1 voucher chưa được lưu, bạn có muốn thoát và thêm mới không?\nNếu bạn muốn đang muốn lưu voucher này vào database, vui lòng chọn lưu",
                    "Đang thêm voucher cũ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) != DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                isEditing = false;
                selectedVoucherId = "None";
                voucherDetails.Enabled = true;
                ClearTextBox();
                btnSave.Enabled = true;
                btnDeactivate.Enabled = false;
                btnActivate.Enabled = false;
                isAdding = true;

            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedVoucherId != "None" && !selectedVoucherId.IsNullOrEmpty())
            {
                if ((MessageBox.Show("Bạn có thực sự muốn thu hồi? Nếu thu hồi, sẽ không thể kích hoạt lại",
                    "Thu hồi Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    try
                    {
                        promotionBUS.deactivateVoucher(selectedVoucherId);
                        (new frmSuccces("Thu hồi thành công", "Voucher đã bị vô hiệu hóa")).ShowDialog();
                        Voucher_Load();
                    }
                    catch (Exception ex)
                    {
                        (new frmError("Thu hồi thất bại", ex.Message)).ShowDialog();
                    }

                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (selectedVoucherId != "None" && !selectedVoucherId.IsNullOrEmpty())
            {
                if ((MessageBox.Show("Bạn có muốn ra mắt voucher này? Nếu đã ra mắt bạn sẽ không thể sửa đổi nó mà không thu hồi",
                    "Ra mắt Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    try
                    {
                        promotionBUS.activateVoucher(selectedVoucherId);
                        (new frmSuccces("Ra mắt thành công", "Voucher đã được kích hoạt")).ShowDialog();
                        Voucher_Load();
                    }
                    catch (Exception ex)
                    {
                        (new frmError("Kích hoạt thất bại", ex.Message)).ShowDialog();
                    }

                }
            }
        }

        
    }
}
