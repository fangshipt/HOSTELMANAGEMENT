using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class NewStudent : Form
    {
        private function fn = new function();
        private const string TABLE_STUDENT = "newStudent";

        public NewStudent()
        {
            InitializeComponent();
        }

        public NewStudent(Point location, Size size) : this()
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            Location = location;
            Size = size;
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
<<<<<<< HEAD
            LoadRoomTypes();
            LoadAvailableRooms();
        }

        private void LoadRoomTypes()
        {
            comboRoomType.Items.Clear();
            var ds = fn.getData("SELECT roomType FROM RoomTypes");
            foreach (DataRow r in ds.Tables[0].Rows)
                comboRoomType.Items.Add(r["roomType"].ToString());
=======
            comboRoomNo.Items.Clear();
>>>>>>> c3239728d02157c66875ee3521f28c02ae200a3f
        }

        private void LoadAvailableRooms()
        {
            comboRoomNo.Items.Clear();
            if (comboRoomType.SelectedIndex < 0) return;

<<<<<<< HEAD
            var p = new SqlParameter("@type", comboRoomType.SelectedItem.ToString());
            var ds = fn.getData("SELECT roomNo FROM rooms WHERE Booked=0 AND roomType=@type", new[] { p });
            foreach (DataRow r in ds.Tables[0].Rows)
                comboRoomNo.Items.Add(r[0].ToString());
=======
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
>>>>>>> c3239728d02157c66875ee3521f28c02ae200a3f
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtMobileNumber.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            dtpStartDate.Value = DateTime.Now;

            comboRoomType.SelectedIndexChanged -= comboRoomType_SelectedIndexChanged;
            comboRoomType.SelectedIndex = -1;
            comboRoomType.SelectedIndexChanged += comboRoomType_SelectedIndexChanged;
            comboRoomNo.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableRooms();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtFather.Text) ||
                string.IsNullOrWhiteSpace(txtMother.Text) ||
                string.IsNullOrWhiteSpace(txtPermanent.Text) ||
                string.IsNullOrWhiteSpace(txtCollege.Text) ||
                string.IsNullOrWhiteSpace(txtMobileNumber.Text) ||
                comboRoomType.SelectedIndex < 0 ||
                comboRoomNo.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn phòng.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Phone validation
            var mobileText = txtMobileNumber.Text.Trim();
            if (!long.TryParse(mobileText, out long mobile) || (mobileText.Length != 10 && mobileText.Length != 11))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (10 hoặc 11 chữ số).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var studentID = txtStudentID.Text.Trim();
            var name = txtName.Text.Trim();
            var fname = txtFather.Text.Trim();
            var mname = txtMother.Text.Trim();
            var paddr = txtPermanent.Text.Trim();
            var college = txtCollege.Text.Trim();
            var roomNo = int.Parse(comboRoomNo.SelectedItem.ToString());
            var startdate = dtpStartDate.Value;

            // 1. Capacity check
            var capDs = fn.getData(
                "SELECT r.currentOccupancy, t.maxOccupancy FROM rooms r JOIN RoomTypes t ON r.roomType=t.roomType WHERE r.roomNo=@roomNo",
                new[] { new SqlParameter("@roomNo", roomNo) });
            int curr = Convert.ToInt32(capDs.Tables[0].Rows[0][0]);
            int max = Convert.ToInt32(capDs.Tables[0].Rows[0][1]);
            if (curr >= max)
            {
                MessageBox.Show($"Phòng {roomNo} đã đầy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Unique studentID check
            var chkDs = fn.getData(
                $"SELECT COUNT(*) FROM {TABLE_STUDENT} WHERE studentID=@studentID", new[] { new SqlParameter("@studentID", studentID) });
            int cnt = Convert.ToInt32(chkDs.Tables[0].Rows[0][0]);
            if (cnt > 0)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Insert student
            fn.setData(
                $"INSERT INTO {TABLE_STUDENT} (studentID,name,fname,mname,mobileNo,paddress,college,startdate,roomNo,living) VALUES(" +
                "@studentID,@name,@fname,@mname,@mobile,@paddr,@college,@sd,@roomNo,1)",
                "Đăng ký sinh viên thành công.",
                new[] {
                    new SqlParameter("@studentID", studentID),
                    new SqlParameter("@name", name),
                    new SqlParameter("@fname", fname),
                    new SqlParameter("@mname", mname),
                    new SqlParameter("@mobile", mobile),
                    new SqlParameter("@paddr", paddr),
                    new SqlParameter("@college", college),
                    new SqlParameter("@sd", startdate),
                    new SqlParameter("@roomNo", roomNo)
                });

            // 4. Update occupancy
            fn.setData(
                "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo=@roomNo",
                "Cập nhật số người trong phòng.",
                new[] { new SqlParameter("@roomNo", roomNo) });

            // 5. Mark booked if full
            fn.setData(
                "UPDATE rooms SET Booked = 1 WHERE roomNo=@roomNo AND currentOccupancy >=" +
                "(SELECT maxOccupancy FROM RoomTypes WHERE roomType=rooms.roomType)",
                "Cập nhật trạng thái phòng.",
                new[] { new SqlParameter("@roomNo", roomNo) });

            ClearAll();
            LoadAvailableRooms();
        }
    }
}
