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
            if (txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "select * from fees where mobileNo =" + Int64.Parse(txtMobile.Text) + " and fmonth='" + dataTimePicker.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = dataTimePicker.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    query = "insert into fees values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Fees Paid.");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("No dues of " + dataTimePicker.Text + " Left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
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