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
using System.Windows.Forms.DataVisualization.Charting;

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

            loadThongKe(DateTime.Now.Date, DateTime.Now.AddDays(1));
            LoadRevenueChart(DateTime.Now.Date, DateTime.Now.AddDays(1));
        }


        // load thong kee
        public void loadThongKe(DateTime frDate, DateTime toDate)
        { 
            DataTable dt = ordBUS.GetNumOrder_Revenue_NumCus(frDate, toDate);
             

            txtNumOrder.Text = dt.Rows[0]["NumOrders"] + "";
            txtRevenueBefore.Text = dt.Rows[0]["RevenueBefore"] + " VNĐ";
            txtRevenueAfter.Text = dt.Rows[0]["RevenueAfter"] + " VNĐ";
            txtNumCus.Text = dt.Rows[0]["NumCustomers"] + "";

            if (Session.Role.Equals("admin"))
            { 
                txtProfit.Text = dt.Rows[0]["Profit"] + " VNĐ";
                // table cho import
                dt = impBUS.GetNumImp_TotalImp(frDate, toDate);

                txtNumImp.Text = dt.Rows[0]["NumImports"] + "";
                txtTotalImp.Text = dt.Rows[0]["TotalImport"] + " VNĐ";

                txtTotalLoss.Text = expBUS.GetTotalLoss(frDate, toDate) + " VNĐ";
            }
            else
            {
                txtNumImp.Text = "";
                txtTotalImp.Text = "";
                txtTotalLoss.Text = "";
                txtProfit.Text = "";
            }

        }


        // load doanh thu vào chart
        private void LoadRevenueChart(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = ordBUS.GetRevenueByDay(fromDate, toDate);

            chartDoanhThu.Series.Clear();
            var series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column; // Biểu đồ cột

            foreach (DataRow row in dt.Rows)
            {
                DateTime day = Convert.ToDateTime(row["OrderDate"]);
                decimal revenue = Convert.ToDecimal(row["Revenue"]);
                series.Points.AddXY(day.ToString("dd/MM"), revenue);
            }

            chartDoanhThu.Series.Add(series);
        }

        // kich hoạt thong kê
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            DateTime frDate = dtpkFromDate.Checked ? dtpkFromDate.Value : new DateTime(2025, 1, 1);
            DateTime toDate = dtpkToDate.Checked ? dtpkToDate.Value : DateTime.Now;
            toDate = toDate.Date.AddDays(1);

            loadThongKe(frDate, toDate); 
            LoadRevenueChart(frDate, toDate);   
        }

    }
}
