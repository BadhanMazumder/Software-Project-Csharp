namespace EmployeeManagementSystem
{
    partial class SearchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1S = new System.Windows.Forms.Label();
            this.ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deapartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagee = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.VClearBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.Sbutton = new System.Windows.Forms.Button();
            this.ViewComboBox = new System.Windows.Forms.ComboBox();
            this.ViewTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1S
            // 
            this.label1S.AutoSize = true;
            this.label1S.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1S.Location = new System.Drawing.Point(413, 13);
            this.label1S.Name = "label1S";
            this.label1S.Size = new System.Drawing.Size(219, 29);
            this.label1S.TabIndex = 89;
            this.label1S.Text = "Search Employee";
            this.label1S.Click += new System.EventHandler(this.label1S_Click);
            // 
            // ViewDataGridView
            // 
            this.ViewDataGridView.AllowUserToAddRows = false;
            this.ViewDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.F_Name,
            this.Mail,
            this.Age,
            this.PhoneNo,
            this.Gender,
            this.City,
            this.DOB,
            this.JoinDate,
            this.Deapartment,
            this.Designation,
            this.BasicSalary,
            this.NID_No,
            this.Shift,
            this.Imagee});
            this.ViewDataGridView.Location = new System.Drawing.Point(3, 211);
            this.ViewDataGridView.Name = "ViewDataGridView";
            this.ViewDataGridView.ReadOnly = true;
            this.ViewDataGridView.RowHeadersWidth = 5;
            this.ViewDataGridView.Size = new System.Drawing.Size(1090, 367);
            this.ViewDataGridView.TabIndex = 96;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 64;
            // 
            // F_Name
            // 
            this.F_Name.HeaderText = "F_Name";
            this.F_Name.Name = "F_Name";
            this.F_Name.ReadOnly = true;
            this.F_Name.Width = 78;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 55;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 54;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "PhoneNo";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Width = 84;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 73;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 53;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 58;
            // 
            // JoinDate
            // 
            this.JoinDate.HeaderText = "JoinDate";
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            this.JoinDate.Width = 82;
            // 
            // Deapartment
            // 
            this.Deapartment.HeaderText = "Deapartment";
            this.Deapartment.Name = "Deapartment";
            this.Deapartment.ReadOnly = true;
            this.Deapartment.Width = 104;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            this.Designation.Width = 99;
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "BasicSalary";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            this.BasicSalary.Width = 98;
            // 
            // NID_No
            // 
            this.NID_No.HeaderText = "NID_No";
            this.NID_No.Name = "NID_No";
            this.NID_No.ReadOnly = true;
            this.NID_No.Width = 77;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.Width = 58;
            // 
            // Imagee
            // 
            this.Imagee.HeaderText = "Image";
            this.Imagee.Name = "Imagee";
            this.Imagee.ReadOnly = true;
            this.Imagee.Width = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(12, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 97;
            this.button1.Text = "Download in Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VClearBtn
            // 
            this.VClearBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.VClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VClearBtn.ForeColor = System.Drawing.Color.Black;
            this.VClearBtn.Location = new System.Drawing.Point(722, 151);
            this.VClearBtn.Name = "VClearBtn";
            this.VClearBtn.Size = new System.Drawing.Size(137, 34);
            this.VClearBtn.TabIndex = 104;
            this.VClearBtn.Text = "Clear";
            this.VClearBtn.UseVisualStyleBackColor = false;
            this.VClearBtn.Click += new System.EventHandler(this.VClearBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewBtn.Location = new System.Drawing.Point(722, 111);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(137, 34);
            this.ViewBtn.TabIndex = 103;
            this.ViewBtn.Text = "View All";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // Sbutton
            // 
            this.Sbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Sbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sbutton.ForeColor = System.Drawing.Color.Black;
            this.Sbutton.Location = new System.Drawing.Point(722, 71);
            this.Sbutton.Name = "Sbutton";
            this.Sbutton.Size = new System.Drawing.Size(137, 34);
            this.Sbutton.TabIndex = 102;
            this.Sbutton.Text = "Search";
            this.Sbutton.UseVisualStyleBackColor = false;
            this.Sbutton.Click += new System.EventHandler(this.Sbutton_Click);
            // 
            // ViewComboBox
            // 
            this.ViewComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewComboBox.FormattingEnabled = true;
            this.ViewComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Department",
            "Designation"});
            this.ViewComboBox.Location = new System.Drawing.Point(418, 75);
            this.ViewComboBox.Name = "ViewComboBox";
            this.ViewComboBox.Size = new System.Drawing.Size(142, 24);
            this.ViewComboBox.TabIndex = 101;
            this.ViewComboBox.Text = "Search By";
            // 
            // ViewTextBox
            // 
            this.ViewTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTextBox.Location = new System.Drawing.Point(579, 77);
            this.ViewTextBox.Name = "ViewTextBox";
            this.ViewTextBox.Size = new System.Drawing.Size(125, 22);
            this.ViewTextBox.TabIndex = 100;
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VClearBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.Sbutton);
            this.Controls.Add(this.ViewComboBox);
            this.Controls.Add(this.ViewTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewDataGridView);
            this.Controls.Add(this.label1S);
            //this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(1132, 655);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1S;
        private System.Windows.Forms.DataGridView ViewDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VClearBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button Sbutton;
        private System.Windows.Forms.ComboBox ViewComboBox;
        private System.Windows.Forms.TextBox ViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deapartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewImageColumn Imagee;
    }
}
