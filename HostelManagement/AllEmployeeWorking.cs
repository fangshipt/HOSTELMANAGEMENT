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
    public partial class AllEmployeeWorking : Form
    {
        public AllEmployeeWorking()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public AllEmployeeWorking(Point location, Size size)
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllEmployeeWorking_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(350, 170);
        }
    }
}
