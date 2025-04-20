using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            dataTimePicker.Format = DateTimePickerFormat.Custom;
            dataTimePicker.CustomFormat = "MMMM yyyy";


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

            // 3. Query lấy thông tin sinh viên + roomType
            query =
              "SELECT s.name, s.mobileNo, s.roomNo, r.roomType " +
              "FROM newStudent s " +
              "  JOIN rooms r ON s.roomNo = r.roomNo " +
              "WHERE s.studentID = '" + stuID + "'";
            var ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy Student ID này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
                return;
            }

            // 4. Điền dữ liệu lên Form
            var row = ds.Tables[0].Rows[0];
            txtName.Text = row["name"].ToString();
            txtMobile.Text = row["mobileNo"].ToString();
            txtRoomNo.Text = row["roomNo"].ToString();
            cbRoomType.SelectedValue = row["roomType"].ToString();

            string roomType = row["roomType"].ToString();
            long duesAmount = 0;

            // Truy vấn bảng RoomTypes để lấy giá tiền tương ứng roomType
            query = $"SELECT price FROM RoomTypes WHERE roomType = '{roomType}'";
            var dsPrice = fn.getData(query);
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

            // 5. Load lịch sử thanh toán
            LoadPaymentHistory(stuID);
        }
        private void LoadPaymentHistory(string stuID)
        {
            query =
               "SELECT transactionDate AS [Ngày GD], " +
               "       monthYear       AS [Tháng],   " +
               "       amount          AS [Số tiền] " +
               "FROM fees " +
               "WHERE studentID = '" + stuID + "' " +
               "ORDER BY transactionDate DESC";
            var ds = fn.getData(query);
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
            string month = dataTimePicker.Text;
            string amountStr = txtAmount.Text.Trim();

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(amountStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra sinh viên có tồn tại hay không (bảo vệ thêm)
            query = "SELECT * FROM newStudent WHERE studentID = '" + studentID + "'";
            var dsCheck = fn.getData(query);
            if (dsCheck.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tháng này đã đóng chưa
            query = "SELECT * FROM fees WHERE studentID = '" + studentID + "' AND monthYear = '" + month + "'";
            var ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Sinh viên đã đóng phí cho tháng " + month + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm thanh toán mới
            long amount = long.Parse(amountStr);
            query = "INSERT INTO fees (studentID, monthYear, amount) " +
                    "VALUES ('" + studentID + "', '" + month + "', " + amount + ")";
            fn.setData(query, "Đã thanh toán phí thành công.");

            // Cập nhật lại datagridview
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
    }
}