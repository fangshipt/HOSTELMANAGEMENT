using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement
{
    public partial class StudentFees : Form
    {
        function fn = new function();
        String query;
        public StudentFees()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public StudentFees(Point location, Size size)
        {
            InitializeComponent();

            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Location = targetLocation;
            this.Size = targetSize;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {

            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MMMM yyyy";


            var dsTypes = fn.getData("SELECT roomType FROM RoomTypes");
            cbRoomType.DisplayMember = "roomType";
            cbRoomType.ValueMember = "roomType";
            cbRoomType.DataSource = dsTypes.Tables[0];
            cbRoomType.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text.Trim();
            if (string.IsNullOrEmpty(stuID))
            {
                MessageBox.Show("Vui lòng nhập Student ID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query =
              "SELECT s.name, s.mobileNo, s.roomNo, r.roomType " +
              "FROM newStudent s " +
              "  JOIN rooms r ON s.roomNo = r.roomNo " +
              "WHERE s.studentID = @studentID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentID", stuID)
            };
            var ds = fn.getData(query, parameters);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy Student ID này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
                return;
            }

            var row = ds.Tables[0].Rows[0];
            txtName.Text = row["name"].ToString();
            txtMobile.Text = row["mobileNo"].ToString();
            txtRoomNo.Text = row["roomNo"].ToString();
            cbRoomType.SelectedValue = row["roomType"].ToString();

            string roomType = row["roomType"].ToString();
            long duesAmount = 0;

            query = "SELECT price FROM RoomTypes WHERE roomType = @roomType";
            SqlParameter[] priceParams = new SqlParameter[]
            {
                new SqlParameter("@roomType", roomType)
            };
            var dsPrice = fn.getData(query, priceParams);
            if (dsPrice.Tables[0].Rows.Count > 0)
            {
                duesAmount = Convert.ToInt64(dsPrice.Tables[0].Rows[0]["price"]);
                txtAmount.Text = duesAmount.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin giá cho loại phòng: " + roomType,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Text = "0";
            }

            LoadPaymentHistory(stuID);
        }
        private void LoadPaymentHistory(string stuID)
        {
            query =
                    "SELECT transactionDate AS [Ngày GD], " +
                    "       monthYear       AS [Tháng],   " +
                    "       amount          AS [Số tiền] " +
                    "FROM fees " +
                    "WHERE studentID = @studentID " +
                    "ORDER BY transactionDate DESC";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentID", stuID)
            };
            var ds = fn.getData(query, parameters);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        public void setDataGrid(Int64 mobile)
        {
            query = "select * from fees where mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            string monthYear = dtpMonth.Value.ToString("yyyy-MM");
            string amountStr = txtAmount.Text.Trim();

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(amountStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query = "SELECT * FROM newStudent WHERE studentID = @studentID";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@studentID", studentID)
            };
            var dsCheck = fn.getData(query, checkParams);
            if (dsCheck.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            query = "SELECT * FROM fees WHERE studentID = @studentID AND monthYear = @monthYear";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentID", studentID),
                new SqlParameter("@monthYear", monthYear)
            };
            var ds = fn.getData(query, parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Sinh viên đã đóng phí cho tháng " + monthYear + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long amount;
            if (!long.TryParse(amountStr, out amount))
            {
                MessageBox.Show("Số tiền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            query = "INSERT INTO fees (studentID, transactionDate, monthYear, amount) VALUES (@studentID, @transactionDate, @monthYear, @amount)";
            SqlParameter[] insertParams = new SqlParameter[]
            {
                new SqlParameter("@studentID", studentID),
                new SqlParameter("@transactionDate", DateTime.Now),
                new SqlParameter("@monthYear", monthYear),
                new SqlParameter("@amount", amount)
            };
            fn.setData(query, "Đã thanh toán phí thành công.", insertParams);

            LoadPaymentHistory(studentID);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtRoomNo.Clear();
            cbRoomType.SelectedIndex = -1;
            txtAmount.Clear();
            guna2DataGridView1.DataSource = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giao dịch trong danh sách để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentID = txtStudentID.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tháng và năm từ dòng được chọn trong DataGridView
            var selectedRow = guna2DataGridView1.SelectedRows[0];
            string monthYear = selectedRow.Cells["Tháng"].Value.ToString(); // Cột "Tháng" trong DataGridView

            // Kiểm tra dữ liệu giao dịch cho sinh viên và tháng được chọn
            string query = "SELECT * FROM fees WHERE studentID = @studentID AND monthYear = @monthYear";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentID", studentID),
                new SqlParameter("@monthYear", monthYear)
            };

            function fn = new function();
            var dsCheck = fn.getData(query, parameters);
            if (dsCheck.Tables[0].Rows.Count == 0)
            {
                // Thêm gợi ý về các tháng có giao dịch
                query = "SELECT DISTINCT monthYear FROM fees WHERE studentID = @studentID";
                var availableMonths = fn.getData(query, new SqlParameter[] { new SqlParameter("@studentID", studentID) });
                string availableMonthsList = availableMonths.Tables[0].Rows.Count > 0
                    ? string.Join(", ", availableMonths.Tables[0].AsEnumerable().Select(row => row["monthYear"].ToString()))
                    : "chưa có giao dịch nào.";

                MessageBox.Show($"Không tìm thấy giao dịch cho tháng {monthYear}. " +
                                $"Các tháng có giao dịch của sinh viên {studentID}: {availableMonthsList}",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở form BienLai với dữ liệu từ dòng được chọn
            BienLai receiptForm = new BienLai(studentID, monthYear);
            receiptForm.ShowDialog();
        }
    }
}