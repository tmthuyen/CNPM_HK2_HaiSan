using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmReceipt : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public frmReceipt()
        {
            InitializeComponent();
        }

        public void PrintReceipt(DataGridView dgv, string voucherCode, string _voucherDiscount, string _totalAmount, string _pointsUsed)
        {
            decimal voucherDiscount;
            if (!decimal.TryParse(_voucherDiscount, out voucherDiscount))
            {
                voucherDiscount = 0;
            }
            decimal totalAmount;
            if (!decimal.TryParse(_totalAmount?.ToString(), out totalAmount))
            {
                totalAmount = 0;
            }

            int pointsUsed;
            if (!int.TryParse(_pointsUsed?.ToString(), out pointsUsed))
            {
                pointsUsed = 0;
            }


            printDocument = new PrintDocument();

            printDocument.PrintPage += (sender, e) =>
            {
                Font font = new Font("Courier New", 10);
                float lineHeight = font.GetHeight(e.Graphics) + 2;
                float x = 10, y = 10;

                List<string> lines = new List<string>
            {
                "------------------------------------------------------------",
                FormatLine("Product", "Qty", "Price", "Unit", "Total"),
                "------------------------------------------------------------"
            };

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string product = row.Cells[0].Value?.ToString() ?? "";
                        string qty = row.Cells[1].Value?.ToString() ?? "0";
                        string price = Convert.ToDecimal(row.Cells[2].Value ?? 0).ToString("N0");
                        string unit = row.Cells[3].Value?.ToString() ?? "";
                        string total = Convert.ToDecimal(row.Cells[4].Value ?? 0).ToString("N0");

                        lines.Add(FormatLine(product, qty, price, unit, total));
                    }
                }

                // Voucher section
                lines.Add("------------------------------------------------------------");
                lines.Add(FormatLine("Voucher Used", "", "", "", voucherCode));
                lines.Add(FormatLine("Voucher Discount", "", "", "", "-" + voucherDiscount.ToString("N0")));

                // Total & points
                lines.Add("------------------------------------------------------------");
                lines.Add(FormatLine("TOTAL", "", "", "", totalAmount.ToString("N0")));
                lines.Add(FormatLine("Points Used", "", "", "", pointsUsed.ToString()));
                lines.Add("------------------------------------------------------------");



                // 3. Set custom paper size (width: 300px, height: based on lines)
                int estimatedHeight = (int)(lines.Count * (lineHeight + 2));
                PaperSize paperSize = new PaperSize("Custom", 300, estimatedHeight + 20); // 20 for padding
                printDocument.DefaultPageSettings.PaperSize = paperSize;
                foreach (string line in lines)
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                    y += lineHeight;
                }
            };

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument
            };
            preview.ShowDialog();

            // Or just print directly:
            // printDocument.Print();
        }

        private string FormatLine(string product, string qty, string price, string unit, string total)
        {
            product = (product ?? "").Length > 15 ? product.Substring(0, 15) : product.PadRight(15);
            qty = (qty ?? "").PadLeft(5);
            price = (price ?? "").PadLeft(10);
            unit = (unit ?? "").PadLeft(8);
            total = (total ?? "").PadLeft(12);

            return product + qty + price + unit + total;
        }
    }



}
