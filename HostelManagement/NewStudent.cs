using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class NewStudent : Form
    {
        function fn = new function();
        string query;

        private Point targetLocation;
        private Size targetSize;

        public NewStudent()
        {
            InitializeComponent();
        }

        public NewStudent(Point location, Size size)
        {
            InitializeComponent();

            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Location = targetLocation;
            this.Size = targetSize;
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            comboRoomNo.Items.Clear();
        }

        private void LoadAvailableRooms()
        {
            comboRoomNo.Items.Clear();

            if (comboRoomType.SelectedIndex < 0)
            {
                return;
            }

            string type = comboRoomType.SelectedItem.ToString();
            query = @"
                SELECT r.roomNo 
                FROM rooms r
                INNER JOIN RoomTypes rt ON r.roomType = rt.roomType
                WHERE r.Booked = 0 
                AND r.currentOccupancy < rt.maxOccupancy
                AND r.roomType = @roomType";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@roomType", type)
            };
            try
            {
                DataSet ds = fn.getData(query, parameters);
                foreach (DataRow row in ds.Tables[0].Rows)
                    comboRoomNo.Items.Add(row[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load phòng: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAll()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtMobileNumber.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            comboRoomNo.SelectedIndex = -1;

            comboRoomType.SelectedIndexChanged -= comboRoomType_SelectedIndexChanged;
            comboRoomType.SelectedIndex = -1;
            comboRoomType.SelectedIndexChanged += comboRoomType_SelectedIndexChanged;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtFather.Text) ||
            string.IsNullOrWhiteSpace(txtStudentID.Text) ||
            string.IsNullOrWhiteSpace(txtMother.Text) ||
            string.IsNullOrWhiteSpace(txtPermanent.Text) ||
            string.IsNullOrWhiteSpace(txtCollege.Text) ||
            string.IsNullOrWhiteSpace(txtMobileNumber.Text) ||
            comboRoomType.SelectedIndex < 0 ||
            comboRoomNo.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập hết thông tin và chọn phòng.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long mobile;
            if (!long.TryParse(txtMobileNumber.Text, out mobile))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentID = txtStudentID.Text.Trim();
            string name = txtName.Text.Trim();
            string fname = txtFather.Text.Trim();
            string mname = txtMother.Text.Trim();
            string paddr = txtPermanent.Text.Trim();
            string college = txtCollege.Text.Trim();
            int roomNo = int.Parse(comboRoomNo.SelectedItem.ToString());
            DateTime startdate = dtpStartDate.Value;

            try
            {
                // Kiểm tra studentID đã tồn tại chưa
                query = "SELECT COUNT(*) FROM newStudent WHERE studentID = @studentID";
                SqlParameter[] checkParams = new SqlParameter[]
                {
                new SqlParameter("@studentID", studentID)
                };
                DataSet ds = fn.getData(query, checkParams);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (count > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // a) Thêm sinh viên
                query = "INSERT INTO newStudent (studentID, name, fname, mname, mobileNo, paddress, college, startdate, roomNo, living) " +
                        "VALUES (@studentID, @name, @fname, @mname, @mobileNo, @paddress, @college, @startdate, @roomNo, 1)";
                SqlParameter[] insertParams = new SqlParameter[]
                {
                new SqlParameter("@studentID", studentID),
                new SqlParameter("@name", name),
                new SqlParameter("@fname", fname),
                new SqlParameter("@mname", mname),
                new SqlParameter("@mobileNo", mobile),
                new SqlParameter("@paddress", paddr),
                new SqlParameter("@college", college),
                new SqlParameter("@startdate", startdate),
                new SqlParameter("@roomNo", roomNo)
                };
                fn.setData(query, "Đăng ký sinh viên thành công.", insertParams);

                // b) Tăng currentOccupancy
                query = "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo = @roomNo";
                SqlParameter[] updateOccupancyParams = new SqlParameter[]
                {
                new SqlParameter("@roomNo", roomNo)
                };
                fn.setData(query, "Cập nhật số người trong phòng.", updateOccupancyParams);

                // c) Nếu đủ người thì đánh dấu phòng đã được đặt (Booked = 1)
                query = "UPDATE rooms SET Booked = 1 " +
                        "WHERE roomNo = @roomNo AND currentOccupancy >= " +
                        "(SELECT maxOccupancy FROM RoomTypes WHERE RoomTypes.roomType = rooms.roomType)";
                SqlParameter[] updateBookedParams = new SqlParameter[]
                {
                new SqlParameter("@roomNo", roomNo)
                };
                fn.setData(query, "Cập nhật phòng thành công.", updateBookedParams);

                clearAll();
                LoadAvailableRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableRooms();
        }
    }
}
