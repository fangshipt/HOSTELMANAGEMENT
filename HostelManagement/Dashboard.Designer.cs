namespace HostelManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hmsLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistics = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudentLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hmsLabel
            // 
            this.hmsLabel.AutoSize = true;
            this.hmsLabel.Font = new System.Drawing.Font("Verdana", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hmsLabel.Location = new System.Drawing.Point(562, 66);
            this.hmsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hmsLabel.Name = "hmsLabel";
            this.hmsLabel.Size = new System.Drawing.Size(1524, 84);
            this.hmsLabel.TabIndex = 2;
            this.hmsLabel.Tag = "";
            this.hmsLabel.Text = "Hệ Thống Quản Lý Ký Túc Xá An Home";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.BorderRadius = 19;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Location = new System.Drawing.Point(1878, 1344);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(280, 90);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnStatistics.BorderRadius = 19;
            this.btnStatistics.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStatistics.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStatistics.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnStatistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistics.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStatistics.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStatistics.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnStatistics.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnStatistics.Image = global::HostelManagement.Properties.Resources.List_of_Paid___Dues_Students;
            this.btnStatistics.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStatistics.Location = new System.Drawing.Point(14, 1139);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(450, 120);
            this.btnStatistics.TabIndex = 16;
            this.btnStatistics.Text = "Thống Kê";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnLeavedStudents
            // 
            this.btnLeavedStudents.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedStudents.BorderRadius = 19;
            this.btnLeavedStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedStudents.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLeavedStudents.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLeavedStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedStudents.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnLeavedStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLeavedStudents.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedStudents.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedStudents.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLeavedStudents.Image = global::HostelManagement.Properties.Resources.Leaved_students;
            this.btnLeavedStudents.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLeavedStudents.Location = new System.Drawing.Point(14, 987);
            this.btnLeavedStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeavedStudents.Name = "btnLeavedStudents";
            this.btnLeavedStudents.Size = new System.Drawing.Size(450, 120);
            this.btnLeavedStudents.TabIndex = 8;
            this.btnLeavedStudents.Text = "Đã Chuyển Đi";
            this.btnLeavedStudents.Click += new System.EventHandler(this.btnLeavedStudents_Click);
            // 
            // btnAllStudentLiving
            // 
            this.btnAllStudentLiving.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAllStudentLiving.BorderRadius = 19;
            this.btnAllStudentLiving.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllStudentLiving.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllStudentLiving.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAllStudentLiving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllStudentLiving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllStudentLiving.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAllStudentLiving.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAllStudentLiving.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAllStudentLiving.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAllStudentLiving.Image = global::HostelManagement.Properties.Resources.all_student_living;
            this.btnAllStudentLiving.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAllStudentLiving.Location = new System.Drawing.Point(14, 836);
            this.btnAllStudentLiving.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(450, 120);
            this.btnAllStudentLiving.TabIndex = 7;
            this.btnAllStudentLiving.Text = "Danh Sách Sinh Viên";
            this.btnAllStudentLiving.Click += new System.EventHandler(this.btnAllStudentLiving_Click);
            // 
            // btnStudentFees
            // 
            this.btnStudentFees.BorderRadius = 19;
            this.btnStudentFees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentFees.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStudentFees.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnStudentFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentFees.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnStudentFees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudentFees.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStudentFees.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnStudentFees.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnStudentFees.Image = global::HostelManagement.Properties.Resources.Fees;
            this.btnStudentFees.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStudentFees.Location = new System.Drawing.Point(13, 676);
            this.btnStudentFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(450, 120);
            this.btnStudentFees.TabIndex = 6;
            this.btnStudentFees.Text = "Phí KTX";
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteStudent.BorderRadius = 19;
            this.btnUpdateDeleteStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateDeleteStudent.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteStudent.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteStudent.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteStudent.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteStudent.Image = global::HostelManagement.Properties.Resources.Update___Delete_Student;
            this.btnUpdateDeleteStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(13, 522);
            this.btnUpdateDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(450, 120);
            this.btnUpdateDeleteStudent.TabIndex = 5;
            this.btnUpdateDeleteStudent.Text = "Cập Nhật";
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnNewStudent.BorderRadius = 19;
            this.btnNewStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewStudent.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewStudent.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewStudent.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnNewStudent.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNewStudent.Image = global::HostelManagement.Properties.Resources.new_student;
            this.btnNewStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNewStudent.Location = new System.Drawing.Point(14, 370);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(450, 120);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "Đăng Ký Mới";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnManageRooms.BorderRadius = 19;
            this.btnManageRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageRooms.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManageRooms.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnManageRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageRooms.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageRooms.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnManageRooms.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnManageRooms.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnManageRooms.Image = global::HostelManagement.Properties.Resources.room;
            this.btnManageRooms.ImageSize = new System.Drawing.Size(25, 25);
            this.btnManageRooms.Location = new System.Drawing.Point(14, 219);
            this.btnManageRooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(450, 120);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Tra Cứu Phòng";
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2PictureBox1.Image = global::HostelManagement.Properties.Resources.hostel;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = global::HostelManagement.Properties.Resources.hostel;
            this.guna2PictureBox1.Location = new System.Drawing.Point(508, 189);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1650, 1100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 25;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.LavenderBlush;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HostelManagement.Properties.Resources.Close_all_jframe1;
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(2083, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 75);
            this.btnExit.TabIndex = 27;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(2414, 1480);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeavedStudents);
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.hmsLabel);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label hmsLabel;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnAllStudentLiving;
        private Guna.UI2.WinForms.Guna2Button btnLeavedStudents;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnStatistics;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}