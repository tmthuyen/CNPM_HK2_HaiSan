////using System;
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
//    public partial class UCVoucher : PromotionControl
//    {
//        string promotionID;
//        private Voucher voucher;
//        public UCVoucher(string promotionID)
//        {
//            InitializeComponent();

//            this.promotionID = promotionID;
//            voucher = PromotionBUS.getVoucher(this.promotionID);
//            UCVoucher_Load();
//        }
//        public UCVoucher()
//        {
//            InitializeComponent();
//        }
//        private void processInputNumber(object sender, EventArgs e)
//        {
//            if (sender.GetType() == typeof(TextBox))
//            {
//                TextBox t = (TextBox) sender;
//                string strNum = t.Text;
//                if (strNum != "")
//                {
//                    bool ok = false;
//                    try
//                    {
//                        double num = double.Parse(strNum);
//                        ok = true;
//                        if (num < 0) ok = false;
//                    }
//                    catch
//                    {
//                        ok = false;
//                    }
//                    if (!ok)
//                    {
//                        t.Text = "";
//                    }
//                }
//            }
//        }
//        public override bool ValidateInput()
//        {
//            if (textBoxApply.Text.IsNullOrEmpty() || textBoxDiscountValue.Text.IsNullOrEmpty() || textBoxMaxApply.Text.IsNullOrEmpty())
//            {
//                return false;
//            }

//            return true;
//        }

//        private void clearTextBox()
//        {
//            textBoxApply.Clear();
//            textBoxDiscountValue.Clear();
//            radioButtonPercent.Checked = false;
//            radioButtonVND.Checked = false;
//            textBoxMaxApply.Clear();
//        }
        

//        private void UCVoucher_Load()
//        {
//            if (voucher != null)
//            {
//                textBoxApply.Text = voucher.ApplyAmount.ToString(); 
//                textBoxDiscountValue.Text = voucher.DiscountValue.ToString();
//                if (voucher.IsCash)
//                {
//                    radioButtonVND.Checked = true; 
//                }
//                else
//                {
//                    radioButtonPercent.Checked = true;
//                }
//                textBoxMaxApply.Text = voucher.MaxApply.ToString();
//                voucherDetails.Enabled = false;
//            }

//        }
//        private void btnEdit_Click(object sender, EventArgs e)
//        {
//            voucherDetails.Enabled = true;
//        }
//        private void btnCancelClick(object sender, EventArgs e)
//        {
//            if (voucher != null)
//            {
//                UCVoucher_Load();
//            }
//            else
//            {
//                clearTextBox();
//            }
//        }
//        private void btnSaveClick(object sender, EventArgs e)
//        {
            
//        }
//    }
//}
