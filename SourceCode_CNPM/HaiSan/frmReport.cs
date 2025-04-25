using BUS;
using Infrastructure; 
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
//using static System.Runtime.InteropServices.JavaScript.JSType;


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
            LoadTopSellingProductsPieChart(DateTime.Now.Date, DateTime.Now.AddDays(1));
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
            DateTime current = fromDate;
            while (current < toDate)
            {
                bool hasData = dt.AsEnumerable().Any(row =>
                    Convert.ToDateTime(row["OrderDate"]).Date == current.Date);

                if (!hasData)
                {
                    dt.Rows.Add(current.Date, 0, 0); // OrderDate, NumOrder, Revenue
                }

                current = current.AddDays(1);
            }

            // Cấu hình biểu đồ
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Series doanh thu (trục Y bên trái)
            Series seriesRevenue = new Series("Doanh thu");
            seriesRevenue.ChartType = SeriesChartType.Column;
            seriesRevenue.Color = Color.DodgerBlue;
            seriesRevenue.YAxisType = AxisType.Primary;
            seriesRevenue.XValueMember = "OrderDate";
            seriesRevenue.YValueMembers = "Revenue";

            // Series số hóa đơn (trục Y bên phải)
            Series seriesOrders = new Series("Số hóa đơn");
            seriesOrders.ChartType = SeriesChartType.Column;
            seriesOrders.Color = Color.Orange;
            seriesOrders.YAxisType = AxisType.Secondary;
            seriesOrders.XValueMember = "OrderDate";
            seriesOrders.YValueMembers = "NumOrder";

            // Thêm series vào chart
            chartDoanhThu.Series.Add(seriesRevenue);
            chartDoanhThu.Series.Add(seriesOrders);

            // Gắn datasource và vẽ
            chartDoanhThu.DataSource = dt;
            chartDoanhThu.DataBind();
        }


        // top 5  sp ban chay
        private void LoadTopSellingProductsPieChart(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = ordBUS.GetTopProduct(fromDate, toDate);

            chartTopSell.Series.Clear();
            chartTopSell.Titles.Clear();

            var series = new Series("Top sản phẩm");
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                string productName = row["ProductName"].ToString();
                int totalSold = Convert.ToInt32(row["TotalSold"]);

                series.Points.AddXY(productName, totalSold);
            }

            chartTopSell.Series.Add(series);

            // Optional: hiển thị phần trăm
            foreach (DataPoint point in series.Points)
            {
                point.Label = string.Format("{0} ({1:P1})", point.AxisLabel, point.YValues[0] / series.Points.Sum(p => p.YValues[0]));
            }

            chartTopSell.Titles.Add("Top 5 sản phẩm bán chạy");

        }


        // kich hoạt thong kê
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            DateTime frDate = dtpkFromDate.Checked ? dtpkFromDate.Value.Date : new DateTime(2025, 1, 1).Date;
            DateTime toDate = dtpkToDate.Checked ? dtpkToDate.Value.Date : DateTime.Now.Date;
            toDate = toDate.Date.AddDays(1);

            loadThongKe(frDate, toDate);
            LoadRevenueChart(frDate, toDate);
            LoadTopSellingProductsPieChart(frDate, toDate);
        }

        // xuat file thong ke 
        public void ExportToCSV(DataTable dt)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV Files|*.csv";
            saveFile.Title = "Lưu file CSV";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("\"Doanh thu theo ngày\"");
                    // Chỉnh sửa header nếu cần
                    var header = dt.Columns.Cast<DataColumn>().Select(c =>
                    {
                        if (c.ColumnName == "OrderDate") // Nếu cột là OrderDate thì đổi thành "Ngày Đặt Hàng"
                            return "\"Ngày Đặt Hàng\"";
                        else if (c.ColumnName == "NumOrder") // Tương tự cho các cột khác
                            return "\"Số Đơn Hàng\"";
                        else if (c.ColumnName == "Revenue")
                            return "\"Doanh Thu\"";
                        else
                            return "\"" + c.ColumnName + "\"";
                    });

                    writer.WriteLine("Doanh thu theo ngày");
                    writer.WriteLine(string.Join(",", header));

                    // Duyệt qua các dòng dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        var fields = row.ItemArray.Select(f =>
                        {
                            if (f is DateTime) // Nếu giá trị là DateTime, định dạng lại
                                return "\"" + ((DateTime)f).ToString("yyyy-MM-dd") + "\"";
                            else
                                return "\"" + f.ToString() + "\"";
                        });

                        writer.WriteLine(string.Join(",", fields));
                    }
                }

                new frmSuccces("Xuất file", "Xuất file doanh thu thành công").ShowDialog();
            }
        }


        private void btnExportFile_Click(object sender, EventArgs e)
        { 
            DataTable dt = ordBUS.GetRevenueByDay(dtpkFromDate.Value.Date, dtpkToDate.Value.Date.AddDays(1));
            ExportToCSV(dt); 
        }
    }
}
