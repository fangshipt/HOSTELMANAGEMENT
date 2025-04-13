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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            /*
            query = "select roomNo from rooms where roomStatus = 'yes' and Booked = 'No";
            DataSet ds = fn.getdata(query);


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
            txtUniqueId.Clear();
            txtMobile.Clear();
            txtDesignation.SelectedIndex = -1;
        }
    }
}
