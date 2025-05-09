﻿using System;
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
        function fn = new function(); //funtion
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
            try
            {
                LoadRoomsByType("4");
                LoadRoomsByType("6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
        }

        private void comboBox4PersonRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox4PersonRooms.SelectedItem != null)
            {
                int selectedRoomNo = int.Parse(comboBox4PersonRooms.SelectedItem.ToString());
                LoadStudentsInRoom(selectedRoomNo);
            }
        }

        private void comboBox6PersonRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6PersonRooms.SelectedItem != null)
            {
                int selectedRoomNo = int.Parse(comboBox6PersonRooms.SelectedItem.ToString());
                LoadStudentsInRoom(selectedRoomNo);
            }
        }
        private void LoadStudentsInRoom(int roomNo)
        {
            string query = $"SELECT studentID, name, mobileNo FROM newStudent WHERE roomNo = {roomNo}";
            DataSet ds = fn.getData(query);

            dataGridViewStudents.Columns.Clear();
            dataGridViewStudents.Columns.Add("studentID", "Student ID");
            dataGridViewStudents.Columns.Add("name", "Name");
            dataGridViewStudents.Columns.Add("mobileNo", "Mobile No");

            dataGridViewStudents.Rows.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataGridViewStudents.Rows.Add(row["studentID"], row["name"], row["mobileNo"]);
            }

            dataGridViewStudents.AutoResizeColumns();
        }




        private void LoadRoomsByType(string roomType)
        {
            string query = $"SELECT roomNo FROM rooms WHERE roomType = '{roomType}' AND Booked = 0";
            DataSet ds = fn.getData(query);

            List<string> roomNumbers = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                roomNumbers.Add(row["roomNo"].ToString());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
