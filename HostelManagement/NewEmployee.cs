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
    public partial class NewEmployee : Form
    {
        //function fn = new function();
        String query;
        public NewEmployee()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public NewEmployee(Point location, Size size)
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

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(350, 170);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text !=""&& txtName.Text !="" && txtFather.Text !="" && txtMother.Text !="" && txtEmailId.Text !="" && txtPermanent.Text!="" && txtUniqueId.Text!="" && txtDesignation.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname =txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmailId.Text;
                String address =txtPermanent.Text;
                String id = txtUniqueId.Text;
                String designation = txtDesignation.Text;

                //query = "insert into newEmployee (emobile,ename,efname, emname, eemail, epaddress, eidproof, edesignation) values (" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + address + "','" + id + "','" + designation + "') ";
                //fn.setData(query, "Employee Registration Successful.");
                clearAll();

            }
            else
            {
                MessageBox.Show("Fill all Required Data. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
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

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
