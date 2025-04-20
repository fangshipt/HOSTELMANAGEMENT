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
    public partial class NewStudent : Form
    {
        function fn = new function();
        String query;
        public NewStudent()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

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
            //this.Location = new Point(480, 125);
            /*
            query = "select roomNo from rooms where roomStatus = 'yes' and Booked = 'No";
            DataSet ds = fn.getData(query);


            for (int i=0; i>ds.Tables[0].Rows.Count; ++i){
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }

           */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void clearAll()
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailId.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            txtIdProof.Clear();
            comboRoomNo.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            if(txtCollege.Text!="" && txtEmailId.Text!="" && txtFather.Text!="" && txtIdProof.Text!="" && txtMobile.Text!="" && txtMother.Text != "" && txtName.Text != "" && comboRoomType.Text != "" && comboRoomNo.Text != "")
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmailId.Text;
                String paddress = txtPermanent.Text;
                String college = txtCollege.Text;
                String idproof = txtIdProof.Text;
                Int64 roomNo = Int64.Parse(comboRoomNo.Text);

                // Thêm sinh viên mới
                query = "INSERT INTO newStudent (mobile, name, fname, mname, email, paddress, college, idproof, roomNo) " +
                        "VALUES (" + mobile + ", '" + name + "', '" + fname + "', '" + mname + "', '" + email + "', '" + paddress + "', '" + college + "', '" + idproof + "', " + roomNo + ")";
                fn.setData(query, "Student Registered.");

                // Cập nhật số người trong phòng
                query = "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 WHERE roomNo = " + roomNo;
                fn.setData(query, "Room occupancy updated.");

                // Nếu đã đủ người thì cập nhật Booked = 'Yes'
                query = "UPDATE rooms SET Booked = 'Yes' WHERE roomNo = " + roomNo + " AND currentOccupancy >= maxOccupancy";
                fn.setData(query, "Room status checked.");

                clearAll();

                // Load lại danh sách phòng sau khi lưu
                comboRoomType_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */

        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRoomNo.Items.Clear();
            query = "SELECT roomNo FROM rooms WHERE roomStatus = 'yes' AND Booked = 'No' AND roomType = '" + comboRoomType.Text + "'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboRoomNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
