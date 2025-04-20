using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class LeavedStudent : Form
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
            //this.Location = new Point(350, 170);
            /*
            query = "select * from newStudent where living = 'No'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource=ds.Tables[0];
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
