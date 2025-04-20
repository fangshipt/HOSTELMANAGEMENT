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
            
            query = "select roomNo from rooms where roomStatus = 'yes' and Booked = 'No'";
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
                MessageBox.Show("Vui lòng chọn loại phòng trước.");
                return;
            }

            string type = comboRoomType.SelectedItem.ToString();
            query = "SELECT roomNo FROM rooms " +
                    "WHERE roomStatus = 'yes' AND Booked = 'No' AND roomType = '" + type + "'";
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
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailId.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            txtIdProof.Clear();
            comboRoomNo.SelectedIndex = -1;
            comboRoomType.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            if (string.IsNullOrWhiteSpace(txtName.Text)   ||
                string.IsNullOrWhiteSpace(txtFather.Text) ||
                string.IsNullOrWhiteSpace(txtMother.Text) ||
                string.IsNullOrWhiteSpace(txtEmailId.Text)||
                string.IsNullOrWhiteSpace(txtPermanent.Text)||
                string.IsNullOrWhiteSpace(txtCollege.Text)||
                string.IsNullOrWhiteSpace(txtIdProof.Text) ||
                string.IsNullOrWhiteSpace(txtMobile.Text)  ||
                comboRoomType.SelectedIndex < 0 ||
                comboRoomNo.SelectedIndex  < 0)
            {
                MessageBox.Show("Vui lòng nhập hết thông tin và chọn phòng.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy dữ liệu
            long   mobile = long.Parse(txtMobile.Text);
            string name   = txtName.Text.Trim();
            string fname  = txtFather.Text.Trim();
            string mname  = txtMother.Text.Trim();
            string email  = txtEmailId.Text.Trim();
            string paddr  = txtPermanent.Text.Trim();
            string college= txtCollege.Text.Trim();
            string idp    = txtIdProof.Text.Trim();
            int    roomNo = int.Parse(comboRoomNo.SelectedItem.ToString());

            try
            {
                // a) Insert new student
                query = "INSERT INTO newStudent (mobile,name,fname,mname,email,paddress,college,idproof,roomNo) " +
                        "VALUES(" +
                        mobile + ",'" +
                        name   + "','" +
                        fname  + "','" +
                        mname  + "','" +
                        email  + "','" +
                        paddr  + "','" +
                        college+ "','" +
                        idp    + "'," +
                        roomNo + ")";
                fn.setData(query, "Đăng ký sinh viên thành công.");

                // b) Tăng currentOccupancy
                query = "UPDATE rooms SET currentOccupancy = currentOccupancy + 1 " +
                        "WHERE roomNo = " + roomNo;
                fn.setData(query, "Cập nhật số người trong phòng.");

                // c) Nếu đạt ngưỡng maxOccupancy → đánh dấu phòng đầy
                query = "UPDATE rooms SET Booked = 'Yes' " +
                        "WHERE roomNo = " + roomNo +
                        " AND currentOccupancy >= maxOccupancy";
                fn.setData(query, "Kiểm tra và đánh dấu trạng thái phòng.");

                // 3. Làm sạch form + load lại phòng trống
                clearAll();
                LoadAvailableRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }

        private void comboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableRooms();
        }
      
    }
}
