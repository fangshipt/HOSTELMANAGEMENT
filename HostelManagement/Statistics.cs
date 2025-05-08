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
namespace HostelManagement
{
    public partial class Statistics : Form
    {
        function fn = new function();
        string query;
        private Point targetLocation;
        private Size targetSize;
        public Statistics()
        {
            InitializeComponent();
        }
        public Statistics(Point location, Size size)
        {
            InitializeComponent();

            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Location = targetLocation;
            this.Size = targetSize;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            LoadChartData();
            Load += Statistics_Load;
        }
        private void LoadChartData()
        {
            query = @"
                SELECT 
                    academicYear, 
                    COUNT(*) AS StudentCount
                FROM StudentRegistrations
                WHERE status = 1
                GROUP BY academicYear
                ORDER BY academicYear;
            ";

            DataSet ds = fn.getData(query);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = ds.Tables[0];
            chartRegistrations.Series.Clear();

            Series series = new Series("Số SV đang ở")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "academicYear",
                YValueMembers = "StudentCount",
                IsValueShownAsLabel = true
            };

            chartRegistrations.Series.Add(series);
            chartRegistrations.DataSource = dt;

            // Thiết lập ChartArea
            ChartArea area = chartRegistrations.ChartAreas[0];
            area.AxisX.Title = "Năm học";
            area.AxisY.Title = "Số sinh viên";
            area.AxisX.Interval = 1;

            chartRegistrations.DataBind();
            foreach (DataPoint point in chartRegistrations.Series[0].Points)
            {
                point.Color = Color.MidnightBlue;
            }
            chartRegistrations.Series[0].Color = Color.MidnightBlue;
            // Font cho trục X và Y
            chartRegistrations.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartRegistrations.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            // Font cho nhãn số trên cột
            chartRegistrations.Series[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Font cho chú thích (legend)
            chartRegistrations.Legends[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);

            if (chartRegistrations.Titles.Count > 0)
            {
                chartRegistrations.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
