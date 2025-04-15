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
    public partial class EmployeePayment : Form
    {
        function fn = new function();
        String query;
        public EmployeePayment()
        {
            InitializeComponent();
        }
        private Point targetLocation;
        private Size targetSize;

        public EmployeePayment(Point location, Size size)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            if (txtMobile.Text != "")
            {
                query = "select ename, eemail, edesignation from newEmployee where emobile =" + txtMobile.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
                else
                {
                    MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter some data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            /*
            if (txtMobile.Text != "" && txtPaymentAmount.Text != "")
            {
                query = "select * from employeeSalary where mobileNo =" + txtMobile.Text + " and fmonth = '" + monthDateTime.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = monthDateTime.Text;
                    Int64 amount = Int64.Parse(txtPaymentAmount.Text);

                    query = "insert into employeeSalary values (" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Salary for month" + monthDateTime.Text + " Paid");
                    setDataGrid(mobile);
                }
                else
                {
                    MessageBox.Show("Payment of " + monthDateTime.Text + "Done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            */

        }
        public void setDataGrid(Int64 mobile)
        {
            /*
            query = "select * from employeeSalary where mobileNo=" + mobile + "";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            */
        }
        public void ClearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtPaymentAmount.Clear();
            txtDesignation.Clear();
            txtEmailId.Clear();
            guna2DataGridView1.DataSource = 0;
            monthDateTime.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearAll();
        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(350, 170);
            monthDateTime.Format = DateTimePickerFormat.Custom;
            monthDateTime.CustomFormat = "MMMM yyyy";
        }
    }
}