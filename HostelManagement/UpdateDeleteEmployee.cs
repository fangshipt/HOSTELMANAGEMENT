using System;
using System.Collections;
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
    public partial class UpdateDeleteEmployee : Form
    {
        //function fn = new function();
        String query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public UpdateDeleteEmployee(Point location, Size size)
        {
            InitializeComponent();

            this.targetLocation = location;
            this.targetSize = size;

            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Location = targetLocation;
            this.Size = targetSize;
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(350, 170);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /**
            query = "select * from newEmployee where emobile =" + txtMobile.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmailID.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtUnique.Text = ds.Tables[0].Rows[0][7].ToString();
                txtDesignation.Text = ds.Tables[0].Rows[0][8].ToString();
                txtWorking.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
            */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String email = txtEmailID.Text;
            String paddress = txtPermanent.Text;
            String id = txtUnique.Text;
            String designation = txtDesignation.Text;
            String working = txtWorking.Text;
            /*
            query = "update newEmployee set ename='" + name + "', efname='" + fname + "', emname='" + mname +
                    "', eemail='" + email + "', epaddress='" + paddress + "', eidproof='" + id + "',edesignation='" + designation +
                    "', working='" + working + "' where emobile=" + mobile + "";
            fn.setData(query, "Data Updation Successful.");
            */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile=" + txtMobile.Text + "";
                fn.setData(query, "Employee Record Deleted.");
                clearAll();
            }
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailID.Clear();
            txtPermanent.Clear();
            txtUnique.Clear();
            txtDesignation.SelectedIndex = -1;
            txtWorking.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
