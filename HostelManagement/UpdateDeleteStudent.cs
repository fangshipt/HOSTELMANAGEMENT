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
        String query;
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
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@studentID", studentID)
            };

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

                // Gán giá trị trạng thái đang ở
                bool livingStatus = Convert.ToBoolean(row["living"]);
                comboBoxLiving.SelectedItem = livingStatus ? "Có" : "Không";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với Mã sinh viên này.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Lấy giá trị từ form
            string studentID = txtStudentID.Text.Trim();
            string name = txtName.Text.Trim();
            string fname = txtFather.Text.Trim();
            string mname = txtMother.Text.Trim();
            string mobile = txtMobileNumber.Text.Trim();
            string paddress = txtPermanent.Text.Trim();
            string college = txtCollege.Text.Trim();
            int newRoomNo;
            int newLiving = comboBoxLiving.SelectedItem != null && comboBoxLiving.SelectedItem.ToString() == "Yes" ? 1 : 0;

            // 2. Validate
            if (string.IsNullOrEmpty(studentID) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(mname) ||
                string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(paddress) ||
                string.IsNullOrEmpty(college) ||
                !int.TryParse(txtRoomNo.Text, out newRoomNo))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng thông tin.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Lấy trạng thái cũ của sinh viên
                string selectOld = @"
            SELECT living, roomNo 
            FROM newStudent 
            WHERE studentID = @studentID";
                SqlParameter[] pOld = {
            new SqlParameter("@studentID", SqlDbType.VarChar,50) { Value = studentID }
        };
                DataSet dsOld = fn.getData(selectOld, pOld);
                if (dsOld.Tables[0].Rows.Count == 0)
                    throw new Exception("Không tìm thấy sinh viên để cập nhật.");

                DataRow oldRow = dsOld.Tables[0].Rows[0];
                int oldLiving = Convert.ToInt32(oldRow["living"]);
                int oldRoomNo = Convert.ToInt32(oldRow["roomNo"]);

                // 4. Cập nhật bảng newStudent
                string updateSql = @"
            UPDATE newStudent
               SET name     = @name,
                   fname    = @fname,
                   mname    = @mname,
                   mobileNo = @mobileNo,
                   paddress = @paddress,
                   college  = @college,
                   roomNo   = @newRoomNo,
                   living   = @newLiving
             WHERE studentID = @studentID";
                SqlParameter[] pUpd = {
            new SqlParameter("@name",      SqlDbType.NVarChar,100) { Value = name },
            new SqlParameter("@fname",     SqlDbType.NVarChar,100) { Value = fname },
            new SqlParameter("@mname",     SqlDbType.NVarChar,100) { Value = mname },
            new SqlParameter("@mobileNo",  SqlDbType.VarChar,   20) { Value = mobile },
            new SqlParameter("@paddress",  SqlDbType.NVarChar,200) { Value = paddress },
            new SqlParameter("@college",   SqlDbType.NVarChar,100) { Value = college },
            new SqlParameter("@newRoomNo", SqlDbType.Int)        { Value = newRoomNo },
            new SqlParameter("@newLiving", SqlDbType.Int)        { Value = newLiving },
            new SqlParameter("@studentID", SqlDbType.VarChar,   50) { Value = studentID }
        };
                fn.setData(updateSql, "Thông tin sinh viên đã được cập nhật.", pUpd);

                // 5. Nếu trạng thái ở (living) thay đổi hoặc đổi phòng, điều chỉnh occupancy
                //    δ = +1 nếu vào phòng mới, δ = –1 nếu rời phòng cũ
                if (oldLiving == 1 && newLiving == 0)
                {
                    // sinh viên rời phòng cũ
                    string q1 = "UPDATE rooms SET currentOccupancy = currentOccupancy - 1 WHERE roomNo = @r";
                    fn.setData(q1, "", new[] {
                new SqlParameter("@r", SqlDbType.Int) { Value = oldRoomNo }
            });
                }
                else if (oldLiving == 0 && newLiving == 1)
                {
                    // sinh viên vào phòng mới
                    string q2 = "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo = @r";
                    fn.setData(q2, "", new[] {
                new SqlParameter("@r", SqlDbType.Int) { Value = newRoomNo }
            });
                }
                else if (oldRoomNo != newRoomNo && newLiving == 1)
                {
                    // đổi phòng: trừ cũ, cộng mới
                    string q3 = "UPDATE rooms SET currentOccupancy = currentOccupancy - 1 WHERE roomNo = @r";
                    fn.setData(q3, "", new[] {
                new SqlParameter("@r", SqlDbType.Int) { Value = oldRoomNo }
            });
                    string q4 = "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo = @r";
                    fn.setData(q4, "", new[] {
                new SqlParameter("@r", SqlDbType.Int) { Value = newRoomNo }
            });
                }

                // 6. Cập nhật cờ Booked cho cả hai phòng (cũ và mới)
                Action<int> updateBooked = (rNo) =>
                {
                    string qb = @"
                UPDATE rooms
                   SET Booked = CASE 
                                  WHEN currentOccupancy >= rt.maxOccupancy THEN 1
                                  ELSE 0
                                END
                  FROM rooms r
                  JOIN RoomTypes rt ON r.roomType = rt.roomType
                 WHERE r.roomNo = @r";
                    fn.setData(qb, "", new[] {
                new SqlParameter("@r", SqlDbType.Int) { Value = rNo }
            });
                };

                // nếu phòng cũ khác phòng mới, hoặc trạng thái 1→0, ta vẫn nên cập nhật cờ
                updateBooked(oldRoomNo);
                updateBooked(newRoomNo);

                // 7. Xóa form
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string studentID = txtStudentID.Text.Trim();
                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy roomNo trước khi xóa
                var roomDs = fn.getData(
                    $"SELECT roomNo FROM newStudent WHERE studentID=@studentID",
                    new[] { new SqlParameter("@studentID", studentID) });
                int roomNo = 0;
                if (roomDs.Tables[0].Rows.Count > 0)
                {
                    roomNo = Convert.ToInt32(roomDs.Tables[0].Rows[0]["roomNo"]);
                }

                // Xóa sinh viên
                string deleteSql = $"DELETE FROM newStudent WHERE studentID=@studentID";
                fn.setData(deleteSql, "Đã xóa thông tin sinh viên.", new[] { new SqlParameter("@studentID", studentID) });

                // Cập nhật số người trong phòng
                if (roomNo > 0)
                {
                    string updOcc = "UPDATE rooms SET currentOccupancy = currentOccupancy - 1 WHERE roomNo = @roomNo";
                    fn.setData(updOcc, null, new[] { new SqlParameter("@roomNo", roomNo) });

                    // Bỏ đánh dấu Booked nếu chưa đạt maxOccupancy
                    string unbookSql =
                        "UPDATE rooms SET Booked = 0 " +
                        "WHERE roomNo = @roomNo " +
                        " AND currentOccupancy < (SELECT maxOccupancy FROM RoomTypes WHERE roomType = rooms.roomType)";
                    fn.setData(unbookSql, null, new[] { new SqlParameter("@roomNo", roomNo) });
                }

                clearAll();
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
            comboBoxLiving.Items.Add("Yes");
            comboBoxLiving.Items.Add("No");
        }
    }
}
