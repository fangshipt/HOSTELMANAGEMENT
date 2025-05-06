namespace HostelManagement
{
    partial class CheckRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4PersonRooms = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox6PersonRooms = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(148, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 44);
            this.label2.TabIndex = 58;
            this.label2.Text = "4 - person room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(1143, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 42);
            this.label5.TabIndex = 60;
            this.label5.Text = "6 - person room";
            // 
            // comboBox4PersonRooms
            // 
            this.comboBox4PersonRooms.BackColor = System.Drawing.Color.Transparent;
            this.comboBox4PersonRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox4PersonRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4PersonRooms.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox4PersonRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox4PersonRooms.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4PersonRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox4PersonRooms.ItemHeight = 30;
            this.comboBox4PersonRooms.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.comboBox4PersonRooms.Location = new System.Drawing.Point(232, 208);
            this.comboBox4PersonRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox4PersonRooms.Name = "comboBox4PersonRooms";
            this.comboBox4PersonRooms.Size = new System.Drawing.Size(137, 36);
            this.comboBox4PersonRooms.TabIndex = 61;
            this.comboBox4PersonRooms.SelectedIndexChanged += new System.EventHandler(this.comboBox4PersonRooms_SelectedIndexChanged);
            // 
            // comboBox6PersonRooms
            // 
            this.comboBox6PersonRooms.BackColor = System.Drawing.Color.Transparent;
            this.comboBox6PersonRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox6PersonRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6PersonRooms.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox6PersonRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox6PersonRooms.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6PersonRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox6PersonRooms.ItemHeight = 30;
            this.comboBox6PersonRooms.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.comboBox6PersonRooms.Location = new System.Drawing.Point(1234, 208);
            this.comboBox6PersonRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox6PersonRooms.Name = "comboBox6PersonRooms";
            this.comboBox6PersonRooms.Size = new System.Drawing.Size(137, 36);
            this.comboBox6PersonRooms.TabIndex = 62;
            this.comboBox6PersonRooms.SelectedIndexChanged += new System.EventHandler(this.comboBox6PersonRooms_SelectedIndexChanged_1);
            // 
            // dataGridViewStudents
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStudents.ColumnHeadersHeight = 30;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.name,
            this.mobileNo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewStudents.Location = new System.Drawing.Point(34, 309);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 82;
            this.dataGridViewStudents.RowTemplate.Height = 33;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1582, 759);
            this.dataGridViewStudents.TabIndex = 64;
            this.dataGridViewStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewStudents.ThemeStyle.BackColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewStudents.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewStudents.ThemeStyle.ReadOnly = false;
            this.dataGridViewStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewStudents.ThemeStyle.RowsStyle.Height = 33;
            this.dataGridViewStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // studentID
            // 
            this.studentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.studentID.HeaderText = "Student ID";
            this.studentID.MinimumWidth = 6;
            this.studentID.Name = "studentID";
            this.studentID.Width = 219;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // mobileNo
            // 
            this.mobileNo.HeaderText = "Mobile No";
            this.mobileNo.MinimumWidth = 6;
            this.mobileNo.Name = "mobileNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(643, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 73);
            this.label3.TabIndex = 65;
            this.label3.Text = "Check Room";
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.MistyRose;
            this.btnExit.BorderThickness = 1;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.ForeColor = System.Drawing.Color.MistyRose;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.MistyRose;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(1548, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CheckRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1650, 1100);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.comboBox6PersonRooms);
            this.Controls.Add(this.comboBox4PersonRooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckRoom";
            this.Text = "CheckRoom";
            this.Load += new System.EventHandler(this.CheckRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox4PersonRooms;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox6PersonRooms;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
    }
}