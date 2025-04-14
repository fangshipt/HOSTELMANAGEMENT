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
        function fn = new function();
        String query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select roomNo from rooms where roomStatus = 'yes' and Booked = 'No";
            DataSet ds = fn.getData(query);


            for (int i=0; i>ds.Tables[0].Rows.Count; ++i){
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCollege.Text!=""&&txtEmailId.Text!=""&&txtFather.Text!=""&&txtIdProof.Text!=""&&txtMobile.Text!="" && txtMother.Text != "" && txtName.Text != "")
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmailId.Text;
                String paddress = txtPermanent.Text;
                String colleage = txtCollege.Text;
                String idproof = txtIdProof.Text;
                Int64 roomNo = Int64.Parse(comboRoomNo.Text);
                query = "insert into newStudent (mobile, name, fname, mname, email, paddress, college, idproof, roomNo) " +
                    "values(" + mobile + ",'" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + colleage + "','" + idproof + "','" + roomNo + "') " +
                    "update rooms set Booked = 'Yes' where roomNo = " + roomNo + "";
                clearAll();

            }
            else
            {
                MessageBox.Show("Fill all empty space.","Information!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
