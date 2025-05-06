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
                MessageBox.Show("Please enter a Student ID to search.");
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
                txtIdProof.Text = row["idproof"].ToString();
                txtRoomNo.Text = row["roomNo"].ToString();

                // Sửa logic kiểm tra living status
                bool livingStatus = Convert.ToBoolean(row["living"]);
                comboBoxLiving.SelectedItem = livingStatus ? "Yes" : "No";
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
            int livingStatus = comboBoxLiving.SelectedItem.ToString() == "Yes" ? 1 : 0;

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(mname) || string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(paddress) ||
                string.IsNullOrEmpty(college) || string.IsNullOrEmpty(idproof) || string.IsNullOrEmpty(txtRoomNo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.");
                return;
            }

            if (!int.TryParse(txtRoomNo.Text, out roomNo))
            {
                MessageBox.Show("Vui lòng nhập đúng số phòng.");
                return;
            }

            try
            {
                // Sử dụng SqlParameter để truyền dữ liệu
                string updateQuery = "UPDATE newStudent SET name = @name, fname = @fname, mname = @mname, " +
                                    "mobileNo = @mobileNo, paddress = @paddress, college = @college, " +
                                    "idproof = @idproof, roomNo = @roomNo, living = @living " +
                                    "WHERE studentID = @studentID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@name", name),
                new SqlParameter("@fname", fname),
                new SqlParameter("@mname", mname),
                new SqlParameter("@mobileNo", mobile),
                new SqlParameter("@paddress", paddress),
                new SqlParameter("@college", college),
                new SqlParameter("@idproof", idproof),
                new SqlParameter("@roomNo", roomNo),
                new SqlParameter("@living", livingStatus),
                new SqlParameter("@studentID", studentID)
                };

                fn.setData(updateQuery, "Dữ liệu đã được cập nhật thành công.", parameters);

                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                clearAll();
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
                query = "DELETE FROM newStudent WHERE studentID = @studentID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@studentID", txtStudentID.Text.Trim())
                };
                fn.setData(query, "Student Record Deleted.", parameters);
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
            txtIdProof.Clear();
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
