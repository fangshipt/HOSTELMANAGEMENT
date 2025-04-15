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
            this.components = new System.ComponentModel.Container();
            this.lblNavigatorBar = new System.Windows.Forms.Label();
            this.hmsLabel = new System.Windows.Forms.Label();
            this.btnLeavedEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAllEmployeeWorking = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeePayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedStudents = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudentLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNavigatorBar
            // 
            this.lblNavigatorBar.AutoSize = true;
            this.lblNavigatorBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNavigatorBar.Font = new System.Drawing.Font("Mistral", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigatorBar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNavigatorBar.Location = new System.Drawing.Point(13, 11);
            this.lblNavigatorBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNavigatorBar.Name = "lblNavigatorBar";
            this.lblNavigatorBar.Size = new System.Drawing.Size(423, 85);
            this.lblNavigatorBar.TabIndex = 1;
            this.lblNavigatorBar.Text = "NAVIGATOR BAR";
            // 
            // hmsLabel
            // 
            this.hmsLabel.AutoSize = true;
            this.hmsLabel.Font = new System.Drawing.Font("Papyrus", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hmsLabel.Location = new System.Drawing.Point(808, 4);
            this.hmsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hmsLabel.Name = "hmsLabel";
            this.hmsLabel.Size = new System.Drawing.Size(1008, 118);
            this.hmsLabel.TabIndex = 2;
            this.hmsLabel.Tag = "";
            this.hmsLabel.Text = "Hostel Management System";
            // 
            // btnLeavedEmployee
            // 
            this.btnLeavedEmployee.BorderRadius = 19;
            this.btnLeavedEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLeavedEmployee.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLeavedEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedEmployee.FillColor = System.Drawing.Color.MistyRose;
            this.btnLeavedEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnLeavedEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedEmployee.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedEmployee.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLeavedEmployee.Image = global::HostelManagement.Properties.Resources.Leaved_students;
            this.btnLeavedEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeavedEmployee.Location = new System.Drawing.Point(13, 1107);
            this.btnLeavedEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.Size = new System.Drawing.Size(430, 75);
            this.btnLeavedEmployee.TabIndex = 13;
            this.btnLeavedEmployee.Text = "Leaved Employee";
            this.btnLeavedEmployee.Click += new System.EventHandler(this.btnLeavedEmployee_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.BorderRadius = 19;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Location = new System.Drawing.Point(1848, 1232);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(282, 62);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderThickness = 1;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.MistyRose;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(2061, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(69, 62);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAllEmployeeWorking
            // 
            this.btnAllEmployeeWorking.BorderRadius = 19;
            this.btnAllEmployeeWorking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllEmployeeWorking.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllEmployeeWorking.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAllEmployeeWorking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllEmployeeWorking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllEmployeeWorking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllEmployeeWorking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllEmployeeWorking.FillColor = System.Drawing.Color.MistyRose;
            this.btnAllEmployeeWorking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnAllEmployeeWorking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAllEmployeeWorking.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAllEmployeeWorking.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAllEmployeeWorking.Image = global::HostelManagement.Properties.Resources.all_student_living1;
            this.btnAllEmployeeWorking.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAllEmployeeWorking.Location = new System.Drawing.Point(13, 1013);
            this.btnAllEmployeeWorking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllEmployeeWorking.Name = "btnAllEmployeeWorking";
            this.btnAllEmployeeWorking.Size = new System.Drawing.Size(430, 75);
            this.btnAllEmployeeWorking.TabIndex = 12;
            this.btnAllEmployeeWorking.Text = "All Employee Working";
            this.btnAllEmployeeWorking.Click += new System.EventHandler(this.btnAllEmployeeWorking_Click);
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.BorderRadius = 19;
            this.btnEmployeePayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployeePayment.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployeePayment.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnEmployeePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeePayment.FillColor = System.Drawing.Color.MistyRose;
            this.btnEmployeePayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnEmployeePayment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployeePayment.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployeePayment.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnEmployeePayment.Image = global::HostelManagement.Properties.Resources.Fees;
            this.btnEmployeePayment.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployeePayment.Location = new System.Drawing.Point(13, 917);
            this.btnEmployeePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(430, 75);
            this.btnEmployeePayment.TabIndex = 11;
            this.btnEmployeePayment.Text = "Employee Payment";
            this.btnEmployeePayment.Click += new System.EventHandler(this.btnEmployeePayment_Click);
            // 
            // btnUpdateDeleteEmployee
            // 
            this.btnUpdateDeleteEmployee.BorderRadius = 19;
            this.btnUpdateDeleteEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateDeleteEmployee.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteEmployee.FillColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDeleteEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteEmployee.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteEmployee.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteEmployee.Image = global::HostelManagement.Properties.Resources.Update___Delete_Student1;
            this.btnUpdateDeleteEmployee.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnUpdateDeleteEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateDeleteEmployee.Location = new System.Drawing.Point(13, 823);
            this.btnUpdateDeleteEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateDeleteEmployee.Name = "btnUpdateDeleteEmployee";
            this.btnUpdateDeleteEmployee.Size = new System.Drawing.Size(430, 75);
            this.btnUpdateDeleteEmployee.TabIndex = 10;
            this.btnUpdateDeleteEmployee.Text = "Update && Delete Employee";
            this.btnUpdateDeleteEmployee.Click += new System.EventHandler(this.btnUpdateDeleteEmployee_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BorderRadius = 19;
            this.btnNewEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewEmployee.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNewEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewEmployee.FillColor = System.Drawing.Color.MistyRose;
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnNewEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewEmployee.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnNewEmployee.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNewEmployee.Image = global::HostelManagement.Properties.Resources.new_student1;
            this.btnNewEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewEmployee.Location = new System.Drawing.Point(13, 729);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(430, 75);
            this.btnNewEmployee.TabIndex = 9;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnLeavedStudents
            // 
            this.btnLeavedStudents.BorderRadius = 19;
            this.btnLeavedStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedStudents.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLeavedStudents.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLeavedStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedStudents.FillColor = System.Drawing.Color.MistyRose;
            this.btnLeavedStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnLeavedStudents.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedStudents.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedStudents.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnLeavedStudents.Image = global::HostelManagement.Properties.Resources.Leaved_students;
            this.btnLeavedStudents.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeavedStudents.Location = new System.Drawing.Point(13, 634);
            this.btnLeavedStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeavedStudents.Name = "btnLeavedStudents";
            this.btnLeavedStudents.Size = new System.Drawing.Size(430, 75);
            this.btnLeavedStudents.TabIndex = 8;
            this.btnLeavedStudents.Text = "Leaved Students";
            this.btnLeavedStudents.Click += new System.EventHandler(this.btnLeavedStudents_Click);
            // 
            // btnAllStudentLiving
            // 
            this.btnAllStudentLiving.BorderRadius = 19;
            this.btnAllStudentLiving.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllStudentLiving.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllStudentLiving.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAllStudentLiving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllStudentLiving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllStudentLiving.FillColor = System.Drawing.Color.MistyRose;
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnAllStudentLiving.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAllStudentLiving.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAllStudentLiving.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAllStudentLiving.Image = global::HostelManagement.Properties.Resources.all_student_living;
            this.btnAllStudentLiving.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAllStudentLiving.Location = new System.Drawing.Point(13, 540);
            this.btnAllStudentLiving.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(430, 75);
            this.btnAllStudentLiving.TabIndex = 7;
            this.btnAllStudentLiving.Text = "All Student Living";
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
            this.btnStudentFees.FillColor = System.Drawing.Color.MistyRose;
            this.btnStudentFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnStudentFees.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStudentFees.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnStudentFees.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnStudentFees.Image = global::HostelManagement.Properties.Resources.Fees;
            this.btnStudentFees.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStudentFees.Location = new System.Drawing.Point(13, 445);
            this.btnStudentFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(430, 75);
            this.btnStudentFees.TabIndex = 6;
            this.btnStudentFees.Text = "Student Fees";
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
            this.btnUpdateDeleteStudent.FillColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteStudent.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteStudent.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteStudent.Image = global::HostelManagement.Properties.Resources.Update___Delete_Student;
            this.btnUpdateDeleteStudent.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnUpdateDeleteStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(13, 353);
            this.btnUpdateDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(430, 75);
            this.btnUpdateDeleteStudent.TabIndex = 5;
            this.btnUpdateDeleteStudent.Text = "Update && Delete Students";
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
            this.btnNewStudent.FillColor = System.Drawing.Color.MistyRose;
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnNewStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewStudent.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnNewStudent.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNewStudent.Image = global::HostelManagement.Properties.Resources.new_student;
            this.btnNewStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewStudent.Location = new System.Drawing.Point(13, 261);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(430, 75);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "New Student";
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
            this.btnManageRooms.FillColor = System.Drawing.Color.MistyRose;
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnManageRooms.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnManageRooms.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnManageRooms.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnManageRooms.Image = global::HostelManagement.Properties.Resources.room;
            this.btnManageRooms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageRooms.Location = new System.Drawing.Point(13, 167);
            this.btnManageRooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(430, 75);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2PictureBox1.Image = global::HostelManagement.Properties.Resources.hostel;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = global::HostelManagement.Properties.Resources.hostel;
            this.guna2PictureBox1.Location = new System.Drawing.Point(480, 125);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1650, 1100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(2155, 1306);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeavedEmployee);
            this.Controls.Add(this.btnAllEmployeeWorking);
            this.Controls.Add(this.btnEmployeePayment);
            this.Controls.Add(this.btnUpdateDeleteEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnLeavedStudents);
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.hmsLabel);
            this.Controls.Add(this.lblNavigatorBar);
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
        private System.Windows.Forms.Label lblNavigatorBar;
        private System.Windows.Forms.Label hmsLabel;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnAllStudentLiving;
        private Guna.UI2.WinForms.Guna2Button btnLeavedStudents;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btnEmployeePayment;
        private Guna.UI2.WinForms.Guna2Button btnAllEmployeeWorking;
        private Guna.UI2.WinForms.Guna2Button btnLeavedEmployee;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}