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
    public partial class Dashboard : Form
    {
        private Point picLocation;
        private Size picSize;


        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Đóng tất cả các form trừ Login
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i] != loginForm)
                {
                    Application.OpenForms[i].Close(); 
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            picLocation = guna2PictureBox1.PointToScreen(Point.Empty);
            picSize = guna2PictureBox1.Size;
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            CheckRoom anr = new CheckRoom(picLocation, picSize);
            anr.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {            
            NewStudent ns = new NewStudent(picLocation, picSize);
            ns.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees(picLocation, picSize);
            sf.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving(picLocation, picSize);
            asl.Show();
        }

        private void btnLeavedStudents_Click(object sender, EventArgs e)
        {
            LeavedStudent ls = new LeavedStudent(picLocation, picSize);
            ls.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent(picLocation, picSize);
            uds.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics(picLocation, picSize);
            s.Show();

        }
    }
}
