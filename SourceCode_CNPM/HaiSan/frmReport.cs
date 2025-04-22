using BUS;
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
    public partial class frmReport : Form
    {
        private OrderBUS ordBUS;
        private ImportBUS impBUS;
        private ExpireProductBUS expBUS; 

        public frmReport()
        {
            ordBUS = new OrderBUS();
            impBUS = new ImportBUS();
            expBUS = new ExpireProductBUS();
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            loadThongKe();
        }


        // load thong kee
        public void loadThongKe()
        {
            DateTime frDate = dtpkFromDate.Checked ? dtpkFromDate.Value : new DateTime(2025, 1, 1);
            DateTime toDate = dtpkToDate.Checked ? dtpkToDate.Value : DateTime.Now;

            DataTable dt = ordBUS.GetNumOrder_Revenue_NumCus(frDate, toDate);

            if (dt.Rows.Count > 0)
            {
                txtNumOrder.Text = dt.Rows[0]["NumOrders"].ToString();
                txtRevenueBefore.Text = dt.Rows[0]["RevenueBefore"].ToString();
                txtNumCus.Text = dt.Rows[0]["NumCustomers"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu đơn hàng!");
            }

            txtNumOrder.Text = dt.Rows[0]["NumOrders"] + "";
            txtRevenueBefore.Text = dt.Rows[0]["RevenueBefore"] + "";
            txtRevenueAfter.Text = 1 + "";
            txtNumCus.Text = dt.Rows[0]["NumCustomers"] + "";

            if (Session.Role.Equals("admin"))
            {
                dt = impBUS.GetNumImp_TotalImp(frDate, toDate);

                txtNumImp.Text = dt.Rows[0]["NumImports"] + "";
                txtTotalImp.Text = dt.Rows[0]["TotalImport"] + "";

                txtTotalLoss.Text = expBUS.GetTotalLoss(frDate, toDate) + "";
                txtProfit.Text = 0 + "";
            }
            else
            {
                txtNumImp.Text = "";
                txtTotalImp.Text = "";
                txtTotalLoss.Text = "";
                txtProfit.Text = "";
            }

        }

        // so khách hàng
        
        // kich hoạt thong kê
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            loadThongKe();
        }

    }
}
