using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class BienLai : Form
    {
        private string studentID;
        private string monthYear;
        public BienLai(string studentID, string monthYear)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.monthYear = monthYear;
            this.Size = new Size(578, 672);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void BienLai_Load(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(monthYear))
                {
                    MessageBox.Show("Mã sinh viên hoặc tháng năm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Tải dữ liệu từ dataset
                FeeReceiptDataSet ds = new FeeReceiptDataSet();
                FeeReceiptDataSetTableAdapters.feesTableAdapter adapter = new FeeReceiptDataSetTableAdapters.feesTableAdapter();
                adapter.FillByStudentIDAndMonthYear(ds.fees, studentID, monthYear);

                if (ds.fees.Rows.Count == 0)
                {
                    MessageBox.Show($"Không có dữ liệu để hiển thị cho sinh viên {studentID} trong tháng {monthYear}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                // Ghi log dữ liệu để kiểm tra
                string logMessage = $"Dữ liệu cho sinh viên {studentID} trong tháng {monthYear}:\n";
                foreach (DataRow row in ds.fees.Rows)
                {
                    logMessage += $"StudentID: {row["studentID"]}, MonthYear: {row["monthYear"]}, Amount: {row["amount"]}, " +
                                  $"Name: {row["name"]}, Mobile: {row["mobileNo"]}, IDProof: {row["idproof"]}\n";
                }
                File.WriteAllText("debug_log.txt", logMessage);

                // Kiểm tra sự tồn tại của tệp báo cáo
                string reportPath = Path.Combine(Application.StartupPath, "FeeReceipt.rpt");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"Không tìm thấy tệp báo cáo tại: {reportPath}. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Tải và hiển thị báo cáo
                ReportDocument report = new ReportDocument();
                report.Load(reportPath);
                report.SetDataSource(ds);

                // Đặt crystalReportViewer lấp đầy form
                crystalReportViewer.Dock = DockStyle.Fill;
                crystalReportViewer.ShowRefreshButton = false; // Ẩn nút làm mới
                crystalReportViewer.ShowZoomButton = false;    // Ẩn nút zoom
                crystalReportViewer.ShowGroupTreeButton = false; // Ẩn nút cây nhóm
                crystalReportViewer.ShowParameterPanelButton = false; // Ẩn panel tham số

                // Hiển thị báo cáo
                crystalReportViewer.ReportSource = report;
                crystalReportViewer.Zoom(1); // Zoom 1 để hiển thị theo kích thước thực của báo cáo
                crystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                string errorLog = $"Lỗi khi hiển thị hóa đơn: {ex.Message}\nChi tiết: {ex.StackTrace}\n";
                File.AppendAllText("error_log.txt", errorLog);
                MessageBox.Show("Lỗi khi hiển thị hóa đơn: " + ex.Message + "\nChi tiết lỗi đã được ghi vào error_log.txt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
