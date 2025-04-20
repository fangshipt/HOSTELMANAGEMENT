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
    public partial class AddNewRoom : Form
    {
        private SqlConnection connection;
        public AddNewRoom()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public AddNewRoom(Point location, Size size)
        {
            InitializeComponent();
            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None; 

            this.Location = targetLocation;
            this.Size = targetSize;
        }
        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=hostel;Persist Security Info=True;User ID=sa;Password=123456;Encrypt=True;TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();  // Mở kết nối
                LoadRoomsByType("4");  // Tải phòng loại 4 khi form được load
                LoadRoomsByType("6");  // Tải phòng loại 6 khi form được load
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void comboBox4PersonRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRoomNo = int.Parse(comboBox4PersonRooms.SelectedItem.ToString());
            LoadStudentsInRoom(selectedRoomNo);
        }

        private void comboBox6PersonRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRoomNo = int.Parse(comboBox6PersonRooms.SelectedItem.ToString());
            LoadStudentsInRoom(selectedRoomNo);
        }
        private void LoadStudentsInRoom(int roomNo)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); // Mở lại kết nối nếu chưa mở
            }

            string query = "SELECT studentID, name, mobileNo FROM newStudent WHERE roomNo = @roomNo";  // Sửa tên cột ở đây
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@roomNo", roomNo);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Xóa các cột cũ nếu có
                dataGridViewStudents.Columns.Clear();

                // Thêm các cột thủ công với tên cột
                dataGridViewStudents.Columns.Add("studentID", "Student ID");  // Tên cột là "Student ID"
                dataGridViewStudents.Columns.Add("name", "Name");              // Tên cột là "Name"
                dataGridViewStudents.Columns.Add("mobileNo", "Mobile No");     // Tên cột là "Mobile No"

                // Điền dữ liệu vào từng cột
                foreach (DataRow row in dt.Rows)
                {
                    dataGridViewStudents.Rows.Add(row["studentID"], row["name"], row["mobileNo"]);  // Dữ liệu sẽ được thêm vào cột tương ứng
                }

                // Tùy chọn: Tự động điều chỉnh kích thước cột
                dataGridViewStudents.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sinh viên: " + ex.Message);
            }
        }




        private void LoadRoomsByType(string roomType)
        {
            string query = "SELECT roomNo FROM rooms WHERE roomType = @roomType AND Booked = 0";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@roomType", roomType);

            SqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
                List<string> roomNumbers = new List<string>();

                while (reader.Read())
                {
                    roomNumbers.Add(reader["roomNo"].ToString());
                }

                if (roomType == "4")
                {
                    comboBox4PersonRooms.DataSource = roomNumbers;
                }
                else if (roomType == "6")
                {
                    comboBox6PersonRooms.DataSource = roomNumbers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }
    }
}
