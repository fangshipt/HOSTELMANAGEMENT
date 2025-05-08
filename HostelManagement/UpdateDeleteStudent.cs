using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class UpdateDeleteStudent : Form
    {
        function fn = new function();
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private Point targetLocation;
        private Size targetSize;

        public UpdateDeleteStudent(Point location, Size size)
        {
            InitializeComponent();

            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Location = targetLocation;
            this.Size = targetSize;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên để tìm kiếm.");
                return;
            }

            string query = "SELECT * FROM newStudent WHERE studentID = @studentID";
            SqlParameter[] parameters = new[] { new SqlParameter("@studentID", studentID) };
            DataSet ds = fn.getData(query, parameters);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                txtStudentID.Text = row["studentID"].ToString();
                txtName.Text = row["name"].ToString();
                txtFather.Text = row["fname"].ToString();
                txtMother.Text = row["mname"].ToString();
                txtMobileNumber.Text = row["mobileNo"].ToString();
                txtPermanent.Text = row["paddress"].ToString();
                txtCollege.Text = row["college"].ToString();
                txtRoomNo.Text = row["roomNo"].ToString();

                // Cập nhật comboBoxLiving
                bool livingStatus = Convert.ToBoolean(row["living"]);
                comboBoxLiving.SelectedItem = livingStatus ? "Đang ở" : "Đã rời đi";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với Mã sinh viên này.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();
            string name = txtName.Text.Trim();
            string fname = txtFather.Text.Trim();
            string mname = txtMother.Text.Trim();
            string mobile = txtMobileNumber.Text.Trim();
            string paddress = txtPermanent.Text.Trim();
            string college = txtCollege.Text.Trim();
            if (!int.TryParse(txtRoomNo.Text.Trim(), out int newRoomNo))
            {
                MessageBox.Show("Số phòng phải là số nguyên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số phòng có nằm trong danh sách cho phép không
            bool isValidRoom = (newRoomNo >= 101 && newRoomNo <= 105) || (newRoomNo >= 201 && newRoomNo <= 205);
            if (!isValidRoom)
            {
                MessageBox.Show($"Phòng số {newRoomNo} không tồn tại trong hệ thống.\n" +
                                "Chỉ chấp nhận:\n- Phòng 4 người: 101 đến 105\n- Phòng 6 người: 201 đến 205",
                                "Phòng không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newLiving = comboBoxLiving.SelectedItem?.ToString() == "Đang ở" ? 1 : 0;

            if (string.IsNullOrEmpty(studentID) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(mname) ||
                string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(paddress) ||
                string.IsNullOrEmpty(college))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng thông tin.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dsOld = fn.getData(@"
                    SELECT living, roomNo 
                    FROM newStudent 
                    WHERE studentID = @studentID",
                    new[] { new SqlParameter("@studentID", studentID) });

                if (dsOld.Tables[0].Rows.Count == 0)
                    throw new Exception("Không tìm thấy sinh viên để cập nhật.");

                var oldRow = dsOld.Tables[0].Rows[0];
                int oldLiving = Convert.ToInt32(oldRow["living"]);
                int oldRoomNo = Convert.ToInt32(oldRow["roomNo"]);
                // Nếu sinh viên đang ở phòng X và tiếp tục chọn đúng phòng X → thông báo
                if (oldLiving == 1 && newLiving == 1 && oldRoomNo == newRoomNo)
                {
                    MessageBox.Show($"Sinh viên đã ở phòng {newRoomNo} rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (oldLiving == 0 && newLiving == 0)
                {
                    MessageBox.Show("Sinh viên này đã rời đi. Nếu muốn chỉnh sửa, vui lòng thay đổi tình trạng cư trú sang 'Đang ở'.",
                                    "Không thể chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool enteringNewRoom = (oldLiving == 0 && newLiving == 1) ||
                    (oldLiving == 1 && newLiving == 1 && oldRoomNo != newRoomNo);

                if (enteringNewRoom)
                {
                    var dsCheck = fn.getData(
                        "SELECT currentOccupancy, maxOccupancy FROM rooms r JOIN RoomTypes rt ON r.roomType=rt.roomType WHERE r.roomNo=@rno",
                        new[] { new SqlParameter("@rno", newRoomNo) });
                    if (dsCheck.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show($"Phòng {newRoomNo} không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int curr = Convert.ToInt32(dsCheck.Tables[0].Rows[0][0]);
                    int max = Convert.ToInt32(dsCheck.Tables[0].Rows[0][1]);
                    if (curr >= max)
                    {
                        MessageBox.Show($"Phòng {newRoomNo} đã đầy.", "Phòng đầy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                fn.setData(@"
                    UPDATE newStudent
                       SET name     = @name,
                           fname    = @fname,
                           mname    = @mname,
                           mobileNo = @mobileNo,
                           paddress = @paddress,
                           college  = @college,
                           roomNo   = @newRoomNo,
                           living   = @newLiving
                     WHERE studentID = @studentID",
                    "Thông tin sinh viên đã được cập nhật.",
                    new[]
                    {
                        new SqlParameter("@name", name),
                        new SqlParameter("@fname", fname),
                        new SqlParameter("@mname", mname),
                        new SqlParameter("@mobileNo", mobile),
                        new SqlParameter("@paddress", paddress),
                        new SqlParameter("@college", college),
                        new SqlParameter("@newRoomNo", newRoomNo),
                        new SqlParameter("@newLiving", newLiving),
                        new SqlParameter("@studentID", studentID)
                    });

                // Cập nhật currentOccupancy
                if (oldLiving == 1 && newLiving == 0)
                {
                    fn.setData("UPDATE rooms SET currentOccupancy = currentOccupancy - 1 WHERE roomNo = @r", null,
                               new[] { new SqlParameter("@r", oldRoomNo) });
                }
                else if (oldLiving == 0 && newLiving == 1)
                {
                    fn.setData("UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo = @r", null,
                               new[] { new SqlParameter("@r", newRoomNo) });
                }
                else if (oldRoomNo != newRoomNo && newLiving == 1)
                {
                    fn.setData("UPDATE rooms SET currentOccupancy = currentOccupancy - 1 WHERE roomNo = @r", null,
                               new[] { new SqlParameter("@r", oldRoomNo) });
                    fn.setData("UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo = @r", null,
                               new[] { new SqlParameter("@r", newRoomNo) });
                }

                // Cập nhật trạng thái Booked
                Action<int> updateBooked = r =>
                    fn.setData(@"
                        UPDATE rooms
                           SET Booked = CASE 
                                          WHEN currentOccupancy >= rt.maxOccupancy THEN 1
                                          ELSE 0
                                        END
                          FROM rooms r
                          JOIN RoomTypes rt ON r.roomType = rt.roomType
                         WHERE r.roomNo = @r", null,
                        new[] { new SqlParameter("@r", r) });

                updateBooked(oldRoomNo);
                updateBooked(newRoomNo);

                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txtRoomNo.Clear();
            comboBoxLiving.SelectedIndex = -1;
        }
               

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            comboBoxLiving.Items.Clear();
            comboBoxLiving.Items.Add("Đang ở");
            comboBoxLiving.Items.Add("Đã rời đi");
        }
    }
}
