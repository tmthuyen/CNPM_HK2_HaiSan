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
using DTO;
using Infrastructure;

namespace GUI
{
    public partial class frmReceipt : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public frmReceipt()
        {
            InitializeComponent();
        }

        public void PrintReceipt(List<OrderItem> orderItems, string voucherCode, string _voucherDiscount, string _totalAmount, string _pointsUsed)
        {
            decimal voucherDiscount = decimal.TryParse(_voucherDiscount, out var vd) ? vd : 0;
            decimal totalAmount = decimal.TryParse(_totalAmount, out var ta) ? ta : 0;
            int pointsUsed = int.TryParse(_pointsUsed, out var pu) ? pu : 0;

            printDocument = new PrintDocument();
            Font regularFont = new Font("Courier New", 10);
            Font smallFont = new Font("Courier New", 6);
            // Set up a list of lines first
            List<string> lines = new List<string>
            {
                "------------------------------------",
                FormatLine("SP", "SL", "ĐV", "Giá", "Tổng"),
                "------------------------------------"
            };

            foreach (OrderItem oi in orderItems)
            {
                string product = oi.Name ?? "";
                string qty = oi.Quantity.ToString();
                string price = Convert.ToDecimal(oi.Price).ToString("N0");
                string unit = oi.Unit ?? "";
                string total = Convert.ToDecimal(oi.Total).ToString("N0");

                // Break long product names into chunks (max 20 chars)
                List<string> productLines = SplitByLength(product, 10);

                for (int i = 0; i < productLines.Count; i++)
                {
                    if (i == 0)
                    {
                        // First line with full row
                        lines.Add(FormatLine(productLines[i], qty, unit, price, total));
                    }
                    else
                    {
                        // Continuation lines — just the product name
                        lines.Add(FormatLine(productLines[i], "", "", "", ""));
                    }
                }
            }

            lines.Add("------------------------------------");
            lines.Add(FormatLine("Voucher", "", "", "", voucherCode == "None" ? "Không" : voucherCode));
            lines.Add(FormatLine("giảm", "", "", "", "-" + voucherDiscount.ToString("N0")));
            lines.Add("------------------------------------");
            lines.Add(FormatLine("Điểm", "", "", "", pointsUsed.ToString("N0")));
            lines.Add(FormatLine("TỔNG", "", "", "", totalAmount.ToString("N0")));
            lines.Add("------------------------------------");
            string dateline = "Hóa đơn được lập vào lúc " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            foreach (string line in SplitByLength(dateline,35))
            {
                lines.Add(line);

            }
            lines.Add("Nhân viên lập:" + Session.Username??"");
            lines.Add("------------------------------------");

            string[] thankYouMessage = ["Cảm ơn quý khách đã chọn Nhà Hàng Hải Sản A!", "Chúng tôi trân trọng sự ủng hộ của quý khách và hy vọng quý khách đã có một bữa ăn ngon miệng.",
            "Mọi thắc mắc hoặc góp ý, xin vui lòng liên hệ với chúng tôi:",
            "Điện thoại: [Số điện thoại]",
            "Email: nhahanghaisanA@gmail.com",
            "Hẹn gặp lại quý khách!"];
            //janky ass way of doing this
            foreach (var line in thankYouMessage)
            {
                foreach (var splitline in SplitByLength(line, 60))
                {
                    lines.Add(splitline);
                }              
            }
            lines.Add("------------------------------------");


            // Measure content height before setting PaperSize
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                float lineHeightRegular = regularFont.GetHeight(g) + 2;
                float lineHeightSmall = smallFont.GetHeight(g) +2;

                int regularLineCount = 0;
                int smallLineCount = 0;

                bool smallTextStarted = false;

                foreach (string line in lines)
                {
                    // Detect when small text section starts
                    if (!smallTextStarted && line.StartsWith("Hóa đơn được lập vào lúc"))
                    {
                        smallTextStarted = true;
                    }

                    // If it's a separator line (---), count it only as regular
                    if (line.Contains("---"))
                    {
                        regularLineCount++;
                    }
                    else if (smallTextStarted)
                    {
                        // After small text section starts, count lines as small
                        smallLineCount++;
                    }
                    else
                    {
                        // Before small text section, count as regular lines
                        regularLineCount++;
                    }
                }

                // Calculate total height for all lines
                int height = (int)((regularLineCount * lineHeightRegular) + (smallLineCount * lineHeightSmall)) + 20; // 20 for padding

                PaperSize paperSize = new PaperSize("Custom", 315, height);
                printDocument.DefaultPageSettings.PaperSize = paperSize;
            }

            printDocument.PrintPage += (sender, e) =>
            {
                float lineHeightRegular = regularFont.GetHeight(e.Graphics) + 2;
                float lineHeightSmall = smallFont.GetHeight(e.Graphics) + 2;
                float x = 2, y = 10;

                bool smallTextStarted = false;
                foreach (string line in lines)
                {
                    // Detect the line that starts the smaller text section (e.g., date and footer)
                    if (!smallTextStarted && line.StartsWith("Hóa đơn được lập vào lúc"))
                    {
                        smallTextStarted = true;
                    }

                    // Check if the current line is the last separator line and apply the regular font size
                    Font currentFont = (line.StartsWith("---"))
                                       ? regularFont  // Use regular font for the last line
                                       : (smallTextStarted ? smallFont : regularFont);
                    float currentLineHeight = (line.StartsWith("---"))
                                              ? lineHeightRegular  // Use regular line height for the last line
                                              : (smallTextStarted ? lineHeightSmall : lineHeightRegular);

                    e.Graphics.DrawString(line, currentFont, Brushes.Black, x, y);
                    y += currentLineHeight;
                }
            };


            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument
            };
            preview.ShowDialog();
        }


        private string FormatLine(string product, string qty, string unit, string price, string total)
        {
            product = product.Length > 10 ? product.Substring(0, 10) : product.PadRight(10);
            qty = qty.PadLeft(4);
            unit = unit.PadLeft(3);
            price = price.PadLeft(7);//just assuming its not gonna >=10 mil lol
            total = total.PadLeft(10);

            return product + qty + unit + price + total;
        }

        
        private List<string> SplitByLength(string text, int maxLength)
        {
            List<string> lines = new List<string>();
            int currentIndex = 0;

            while (currentIndex < text.Length)
            {
                // If the remaining text is shorter than the maxLength, add it and break
                if (text.Length - currentIndex <= maxLength)
                {
                    lines.Add(text.Substring(currentIndex));
                    break;
                }

                // Find the last whitespace character within the maxLength
                int lastWhitespaceIndex = text.LastIndexOf(' ', currentIndex + maxLength);

                // If no whitespace is found within the maxLength, force a split at maxLength
                if (lastWhitespaceIndex == -1 || lastWhitespaceIndex <= currentIndex)
                {
                    lines.Add(text.Substring(currentIndex, maxLength));
                    currentIndex += maxLength;
                }
                else
                {
                    // Split at the whitespace
                    lines.Add(text.Substring(currentIndex, lastWhitespaceIndex - currentIndex));
                    currentIndex = lastWhitespaceIndex + 1; // Move past the whitespace
                }
            }
            return lines;
        }
    }



}
