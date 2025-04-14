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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAVIGATOR BAR";
            // 
            // hmsLabel
            // 
            this.hmsLabel.AutoSize = true;
            this.hmsLabel.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hmsLabel.Location = new System.Drawing.Point(396, 4);
            this.hmsLabel.Name = "hmsLabel";
            this.hmsLabel.Size = new System.Drawing.Size(473, 54);
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
            this.btnLeavedEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLeavedEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedEmployee.Image = global::HostelManagement.Properties.Resources.Leaved_students;
            this.btnLeavedEmployee.Location = new System.Drawing.Point(11, 538);
            this.btnLeavedEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.Size = new System.Drawing.Size(188, 32);
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
            this.btnLogOut.Location = new System.Drawing.Point(938, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(188, 40);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "LogOut";
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
            this.btnExit.Location = new System.Drawing.Point(1131, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(46, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
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
            this.btnAllEmployeeWorking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllEmployeeWorking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAllEmployeeWorking.Image = global::HostelManagement.Properties.Resources.all_student_living1;
            this.btnAllEmployeeWorking.Location = new System.Drawing.Point(11, 479);
            this.btnAllEmployeeWorking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllEmployeeWorking.Name = "btnAllEmployeeWorking";
            this.btnAllEmployeeWorking.Size = new System.Drawing.Size(188, 50);
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
            this.btnEmployeePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployeePayment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployeePayment.Image = global::HostelManagement.Properties.Resources.Fees;
            this.btnEmployeePayment.Location = new System.Drawing.Point(11, 442);
            this.btnEmployeePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(188, 32);
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
            this.btnUpdateDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateDeleteEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteEmployee.Image = global::HostelManagement.Properties.Resources.Update___Delete_Student1;
            this.btnUpdateDeleteEmployee.Location = new System.Drawing.Point(11, 386);
            this.btnUpdateDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDeleteEmployee.Name = "btnUpdateDeleteEmployee";
            this.btnUpdateDeleteEmployee.Size = new System.Drawing.Size(188, 52);
            this.btnUpdateDeleteEmployee.TabIndex = 10;
            this.btnUpdateDeleteEmployee.Text = "Update and Delete Employee";
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
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNewEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewEmployee.Image = global::HostelManagement.Properties.Resources.new_student1;
            this.btnNewEmployee.Location = new System.Drawing.Point(11, 346);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(188, 32);
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
            this.btnLeavedStudents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLeavedStudents.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLeavedStudents.Image = global::HostelManagement.Properties.Resources.Leaved_students;
            this.btnLeavedStudents.Location = new System.Drawing.Point(11, 299);
            this.btnLeavedStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeavedStudents.Name = "btnLeavedStudents";
            this.btnLeavedStudents.Size = new System.Drawing.Size(188, 32);
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
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllStudentLiving.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAllStudentLiving.Image = global::HostelManagement.Properties.Resources.all_student_living;
            this.btnAllStudentLiving.Location = new System.Drawing.Point(11, 250);
            this.btnAllStudentLiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(188, 32);
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
            this.btnStudentFees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStudentFees.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStudentFees.Image = global::HostelManagement.Properties.Resources.Fees;
            this.btnStudentFees.Location = new System.Drawing.Point(11, 207);
            this.btnStudentFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(188, 32);
            this.btnStudentFees.TabIndex = 6;
            this.btnStudentFees.Text = "Student Fees";
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.BorderRadius = 19;
            this.btnUpdateDeleteStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateDeleteStudent.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteStudent.FillColor = System.Drawing.Color.MistyRose;
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateDeleteStudent.Image = global::HostelManagement.Properties.Resources.Update___Delete_Student;
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(-6, 147);
            this.btnUpdateDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(204, 55);
            this.btnUpdateDeleteStudent.TabIndex = 5;
            this.btnUpdateDeleteStudent.Text = "Update and Delete Students";
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BorderRadius = 19;
            this.btnNewStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewStudent.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewStudent.FillColor = System.Drawing.Color.MistyRose;
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNewStudent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewStudent.Image = global::HostelManagement.Properties.Resources.new_student;
            this.btnNewStudent.Location = new System.Drawing.Point(11, 110);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(188, 32);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BorderRadius = 19;
            this.btnManageRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageRooms.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManageRooms.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnManageRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageRooms.FillColor = System.Drawing.Color.MistyRose;
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManageRooms.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnManageRooms.Image = global::HostelManagement.Properties.Resources.room;
            this.btnManageRooms.Location = new System.Drawing.Point(11, 65);
            this.btnManageRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(188, 32);
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
            this.guna2PictureBox1.Location = new System.Drawing.Point(220, 65);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(984, 529);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1223, 648);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
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