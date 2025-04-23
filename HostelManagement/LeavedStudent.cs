using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class LeavedStudent: Form
    {
        function fn = new function();
        String query;
        public LeavedStudent()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public LeavedStudent(Point location, Size size)
        {
            InitializeComponent();

            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Location = targetLocation;
            this.Size = targetSize;
        }
        private void LeavedStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);

            string query = @"
    SELECT 
        ns.studentID    AS [Mã SV],
        ns.name         AS [Họ Tên],
        ns.roomNo       AS [Số Phòng],
        r.roomType      AS [Loại Phòng],
        ns.mobileNo     AS [SĐT]
    FROM newStudent ns
    INNER JOIN rooms  r  ON ns.roomNo = r.roomNo
    WHERE ns.living = N'No'
";

            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];


            guna2DataGridView1.Columns["Mã SV"].HeaderText = "Mã SV";
            guna2DataGridView1.Columns["Họ Tên"].HeaderText = "Họ Tên";
            guna2DataGridView1.Columns["Số Phòng"].HeaderText = "Số Phòng";
            guna2DataGridView1.Columns["Loại Phòng"].HeaderText = "Loại Phòng";
            guna2DataGridView1.Columns["SĐT"].HeaderText = "SĐT";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
