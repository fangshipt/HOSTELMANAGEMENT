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

namespace HostelManagement
{
    public partial class UpdateDeleteStudentForm : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public UpdateDeleteStudentForm(Point location, Size size)
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
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
            txtRoomNo.Clear();
            comboBoxLiving.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text.Trim();  // Lấy thông tin từ TextBox cho studentID

            // Kiểm tra nếu studentID rỗng
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            // Thực hiện truy vấn tìm kiếm thông tin sinh viên theo studentID
            string query = "SELECT * FROM newStudent WHERE studentID = '" + studentID + "'";

            // Sử dụng fn.getData để lấy dữ liệu (truyền trực tiếp câu truy vấn với studentID)
            DataSet ds = fn.getData(query);  // Dùng phương thức getData hiện tại

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                // Nếu tìm thấy sinh viên, hiển thị thông tin lên form
                DataRow row = ds.Tables[0].Rows[0];
                txtStudentID.Text = row["studentID"].ToString();
                txtName.Text = row["name"].ToString();
                txtFather.Text = row["fname"].ToString();
                txtMother.Text = row["mname"].ToString();
                txtMobileNumber.Text = row["mobileNo"].ToString();
                txtPermanent.Text = row["paddress"].ToString();
                txtCollege.Text = row["college"].ToString();
                txtIdProof.Text = row["idproof"].ToString();
                txtRoomNo.Text = row["roomNo"].ToString();
                comboBoxLiving.SelectedItem = row["living"].ToString() == "1" ? "Living" : "Not Living";
            }
            else
            {
                MessageBox.Show("No student found with this Student ID.");
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
            string idproof = txtIdProof.Text.Trim();
            int roomNo;
            int livingStatus = comboBoxLiving.SelectedItem.ToString() == "Living" ? 1 : 0;

            // Kiểm tra nếu bất kỳ thông tin nào còn thiếu
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(mname) || string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(paddress) ||
                string.IsNullOrEmpty(college) || string.IsNullOrEmpty(idproof) || string.IsNullOrEmpty(txtRoomNo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.");
                return;
            }

            // Kiểm tra nếu RoomNo là số hợp lệ
            if (!int.TryParse(txtRoomNo.Text, out roomNo))
            {
                MessageBox.Show("Vui lòng nhập đúng số phòng.");
                return;
            }

            try
            {
                // Chỉ cập nhật những trường có thay đổi
                List<string> updateFields = new List<string>();
                if (!string.IsNullOrEmpty(name))
                    updateFields.Add($"name = '{name}'");
                if (!string.IsNullOrEmpty(fname))
                    updateFields.Add($"fname = '{fname}'");
                if (!string.IsNullOrEmpty(mname))
                    updateFields.Add($"mname = '{mname}'");
                if (!string.IsNullOrEmpty(mobile))
                    updateFields.Add($"mobileNo = '{mobile}'");
                if (!string.IsNullOrEmpty(paddress))
                    updateFields.Add($"paddress = '{paddress}'");
                if (!string.IsNullOrEmpty(college))
                    updateFields.Add($"college = '{college}'");
                if (!string.IsNullOrEmpty(idproof))
                    updateFields.Add($"idproof = '{idproof}'");
                if (roomNo > 0)
                    updateFields.Add($"roomNo = {roomNo}");
                updateFields.Add($"living = {livingStatus}");

                if (updateFields.Count > 0)
                {
                    string updateQuery = $"UPDATE newStudent SET {string.Join(", ", updateFields)} WHERE studentID = '{studentID}'";
                    fn.setData(updateQuery, "Dữ liệu đã được cập nhật thành công.");

                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                    clearAll();  // Clear all fields
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newStudent where mobile =" + txtStudentID.Text + "";
                fn.setData(query, "Student Record Deleted.");
                clearAll();
            }
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
        }
    }
}
