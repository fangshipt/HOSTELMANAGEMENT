using System;
using System.Data;
using System.Drawing;
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
            query = "SELECT roomNo FROM rooms WHERE Booked = 0";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }
        }

        private void LoadAvailableRooms()
        {
            comboRoomNo.Items.Clear();

            if (comboRoomType.SelectedIndex < 0)
            {
                return;
            }

            string type = comboRoomType.SelectedItem.ToString();
            query = "SELECT roomNo FROM rooms WHERE Booked = 0 AND roomType = '" + type + "'";
            try
            {
                DataSet ds = fn.getData(query);
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
            txtIdProof.Clear();
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
                string.IsNullOrWhiteSpace(txtIdProof.Text) ||
                string.IsNullOrWhiteSpace(txtMobileNumber.Text) ||
                comboRoomType.SelectedIndex < 0 ||
                comboRoomNo.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập hết thông tin và chọn phòng.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long mobile = long.Parse(txtMobileNumber.Text);
            string studentID = txtStudentID.Text.Trim();
            string name = txtName.Text.Trim();
            string fname = txtFather.Text.Trim();
            string mname = txtMother.Text.Trim();
            string paddr = txtPermanent.Text.Trim();
            string college = txtCollege.Text.Trim();
            string idp = txtIdProof.Text.Trim();
            int roomNo = int.Parse(comboRoomNo.SelectedItem.ToString());

            try
            {
                // a) Thêm sinh viên
                query = "INSERT INTO newStudent (studentID, name, fname, mname, mobileNo, paddress, college, idproof, roomNo) " +
                        "VALUES('" + studentID + "','" + name + "','" + fname + "','" + mname + "'," +
                        mobile + ",'" + paddr + "','" + college + "','" + idp + "'," + roomNo + ")";
                fn.setData(query, "Đăng ký sinh viên thành công.");

                // b) Tăng currentOccupancy
                query = "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 " +
                        "WHERE roomNo = " + roomNo;
                fn.setData(query, "Cập nhật số người trong phòng.");

                // c) Nếu đủ người thì đánh dấu phòng đã được đặt (Booked = 1)
                query = "UPDATE rooms SET Booked = 1 " +
                        "WHERE roomNo = " + roomNo + " AND currentOccupancy >= " +
                        "(SELECT maxOccupancy FROM RoomTypes WHERE RoomTypes.roomType = rooms.roomType)";
                fn.setData(query, "Cập nhật phòng thành công.");

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
