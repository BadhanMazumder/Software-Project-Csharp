namespace EmployeeManagementSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panelslide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LOutBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.MailBtn = new System.Windows.Forms.Button();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.AttendenceBtn = new System.Windows.Forms.Button();
            this.SearchBtn1 = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Menubutton = new System.Windows.Forms.Button();
            this.Outbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attendenceUserControl1 = new EmployeeManagementSystem.AttendenceUserControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addUserControl1 = new EmployeeManagementSystem.AddUserControl();
            this.updateUserControl1 = new EmployeeManagementSystem.UpdateUserControl();
            this.deleteUserControl1 = new EmployeeManagementSystem.DeleteUserControl();
            this.searchUserControl1 = new EmployeeManagementSystem.SearchUserControl();
            this.attendenceUserControl2 = new EmployeeManagementSystem.AttendenceUserControl();
            this.salaryUserControl1 = new EmployeeManagementSystem.SalaryUserControl();
            this.reportUserControl1 = new EmployeeManagementSystem.ReportUserControl();
            this.sendMailUserControl1 = new EmployeeManagementSystem.SendMailUserControl();
            this.leaveUserControl1 = new EmployeeManagementSystem.LeaveUserControl();
            this.panelslide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelslide.Controls.Add(this.label2);
            this.panelslide.Controls.Add(this.label1);
            this.panelslide.Controls.Add(this.Outbutton);
            this.panelslide.Controls.Add(this.Menubutton);
            this.panelslide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelslide.Location = new System.Drawing.Point(0, 0);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(49, 684);
            this.panelslide.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.LOutBtn);
            this.panel1.Controls.Add(this.ReportBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.MailBtn);
            this.panel1.Controls.Add(this.LeaveBtn);
            this.panel1.Controls.Add(this.SalaryBtn);
            this.panel1.Controls.Add(this.AttendenceBtn);
            this.panel1.Controls.Add(this.SearchBtn1);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(49, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 684);
            this.panel1.TabIndex = 7;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SidePanel.Location = new System.Drawing.Point(217, 27);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 70);
            this.SidePanel.TabIndex = 2;
            // 
            // LOutBtn
            // 
            this.LOutBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LOutBtn.FlatAppearance.BorderSize = 0;
            this.LOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LOutBtn.Image")));
            this.LOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LOutBtn.Location = new System.Drawing.Point(-3, 610);
            this.LOutBtn.Name = "LOutBtn";
            this.LOutBtn.Size = new System.Drawing.Size(204, 68);
            this.LOutBtn.TabIndex = 8;
            this.LOutBtn.Text = "Log Out";
            this.LOutBtn.UseVisualStyleBackColor = false;
            this.LOutBtn.Click += new System.EventHandler(this.LOutBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.Location = new System.Drawing.Point(-3, 542);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(204, 68);
            this.ReportBtn.TabIndex = 2;
            this.ReportBtn.Text = "Reports";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(-3, 27);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(204, 68);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add ";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MailBtn
            // 
            this.MailBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MailBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MailBtn.FlatAppearance.BorderSize = 0;
            this.MailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailBtn.Image = ((System.Drawing.Image)(resources.GetObject("MailBtn.Image")));
            this.MailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MailBtn.Location = new System.Drawing.Point(-3, 481);
            this.MailBtn.Name = "MailBtn";
            this.MailBtn.Size = new System.Drawing.Size(204, 68);
            this.MailBtn.TabIndex = 6;
            this.MailBtn.Text = "Send Mail";
            this.MailBtn.UseVisualStyleBackColor = false;
            this.MailBtn.Click += new System.EventHandler(this.MailBtn_Click);
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LeaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LeaveBtn.FlatAppearance.BorderSize = 0;
            this.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("LeaveBtn.Image")));
            this.LeaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeaveBtn.Location = new System.Drawing.Point(-3, 342);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(204, 68);
            this.LeaveBtn.TabIndex = 5;
            this.LeaveBtn.Text = "Leave ";
            this.LeaveBtn.UseVisualStyleBackColor = false;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SalaryBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SalaryBtn.FlatAppearance.BorderSize = 0;
            this.SalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalaryBtn.Image")));
            this.SalaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryBtn.Location = new System.Drawing.Point(-3, 407);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(204, 68);
            this.SalaryBtn.TabIndex = 4;
            this.SalaryBtn.Text = "Salary";
            this.SalaryBtn.UseVisualStyleBackColor = false;
            this.SalaryBtn.Click += new System.EventHandler(this.SalaryBtn_Click);
            // 
            // AttendenceBtn
            // 
            this.AttendenceBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AttendenceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AttendenceBtn.FlatAppearance.BorderSize = 0;
            this.AttendenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendenceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendenceBtn.Image = ((System.Drawing.Image)(resources.GetObject("AttendenceBtn.Image")));
            this.AttendenceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendenceBtn.Location = new System.Drawing.Point(-3, 278);
            this.AttendenceBtn.Name = "AttendenceBtn";
            this.AttendenceBtn.Size = new System.Drawing.Size(204, 68);
            this.AttendenceBtn.TabIndex = 3;
            this.AttendenceBtn.Text = "Attendence";
            this.AttendenceBtn.UseVisualStyleBackColor = false;
            this.AttendenceBtn.Click += new System.EventHandler(this.AttendenceBtn_Click);
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchBtn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchBtn1.FlatAppearance.BorderSize = 0;
            this.SearchBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn1.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn1.Image")));
            this.SearchBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn1.Location = new System.Drawing.Point(-3, 204);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(204, 68);
            this.SearchBtn1.TabIndex = 2;
            this.SearchBtn1.Text = "Search ";
            this.SearchBtn1.UseVisualStyleBackColor = false;
            this.SearchBtn1.Click += new System.EventHandler(this.SearchBtn1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtn.Location = new System.Drawing.Point(-3, 145);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(204, 68);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.Image")));
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(-3, 86);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(204, 68);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Update ";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_2);
            // 
            // Menubutton
            // 
            this.Menubutton.Image = ((System.Drawing.Image)(resources.GetObject("Menubutton.Image")));
            this.Menubutton.Location = new System.Drawing.Point(0, 3);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(49, 47);
            this.Menubutton.TabIndex = 9;
            this.Menubutton.UseVisualStyleBackColor = true;
            this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
            // 
            // Outbutton
            // 
            this.Outbutton.Image = ((System.Drawing.Image)(resources.GetObject("Outbutton.Image")));
            this.Outbutton.Location = new System.Drawing.Point(-3, 82);
            this.Outbutton.Name = "Outbutton";
            this.Outbutton.Size = new System.Drawing.Size(49, 47);
            this.Outbutton.TabIndex = 10;
            this.Outbutton.UseVisualStyleBackColor = true;
            this.Outbutton.Click += new System.EventHandler(this.Outbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exit";
            // 
            // attendenceUserControl1
            // 
            this.attendenceUserControl1.Location = new System.Drawing.Point(0, 15);
            this.attendenceUserControl1.Name = "attendenceUserControl1";
            this.attendenceUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.attendenceUserControl1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.attendenceUserControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 20);
            this.panel2.TabIndex = 8;
            // 
            // addUserControl1
            // 
            this.addUserControl1.Location = new System.Drawing.Point(282, 27);
            this.addUserControl1.Name = "addUserControl1";
            this.addUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.addUserControl1.TabIndex = 9;
            // 
            // updateUserControl1
            // 
            this.updateUserControl1.Location = new System.Drawing.Point(283, 27);
            this.updateUserControl1.Name = "updateUserControl1";
            this.updateUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.updateUserControl1.TabIndex = 10;
            // 
            // deleteUserControl1
            // 
            this.deleteUserControl1.Location = new System.Drawing.Point(283, 27);
            this.deleteUserControl1.Name = "deleteUserControl1";
            this.deleteUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.deleteUserControl1.TabIndex = 11;
            // 
            // searchUserControl1
            // 
            this.searchUserControl1.Location = new System.Drawing.Point(283, 26);
            this.searchUserControl1.Name = "searchUserControl1";
            this.searchUserControl1.Size = new System.Drawing.Size(1132, 655);
            this.searchUserControl1.TabIndex = 12;
            // 
            // attendenceUserControl2
            // 
            this.attendenceUserControl2.Location = new System.Drawing.Point(283, 26);
            this.attendenceUserControl2.Name = "attendenceUserControl2";
            this.attendenceUserControl2.Size = new System.Drawing.Size(1093, 655);
            this.attendenceUserControl2.TabIndex = 13;
            // 
            // salaryUserControl1
            // 
            this.salaryUserControl1.Location = new System.Drawing.Point(283, 26);
            this.salaryUserControl1.Name = "salaryUserControl1";
            this.salaryUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.salaryUserControl1.TabIndex = 14;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(283, 23);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.reportUserControl1.TabIndex = 15;
            // 
            // sendMailUserControl1
            // 
            this.sendMailUserControl1.Location = new System.Drawing.Point(283, 23);
            this.sendMailUserControl1.Name = "sendMailUserControl1";
            this.sendMailUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.sendMailUserControl1.TabIndex = 16;
            // 
            // leaveUserControl1
            // 
            this.leaveUserControl1.Location = new System.Drawing.Point(283, 26);
            this.leaveUserControl1.Name = "leaveUserControl1";
            this.leaveUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.leaveUserControl1.TabIndex = 17;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 684);
            this.Controls.Add(this.leaveUserControl1);
            this.Controls.Add(this.sendMailUserControl1);
            this.Controls.Add(this.reportUserControl1);
            this.Controls.Add(this.salaryUserControl1);
            this.Controls.Add(this.attendenceUserControl2);
            this.Controls.Add(this.searchUserControl1);
            this.Controls.Add(this.deleteUserControl1);
            this.Controls.Add(this.updateUserControl1);
            this.Controls.Add(this.addUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelslide);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panelslide.ResumeLayout(false);
            this.panelslide.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Button Outbutton;
        private System.Windows.Forms.Button Menubutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button LOutBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button MailBtn;
        private System.Windows.Forms.Button LeaveBtn;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button AttendenceBtn;
        private System.Windows.Forms.Button SearchBtn1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AttendenceUserControl attendenceUserControl1;
        private System.Windows.Forms.Panel panel2;
        private AddUserControl addUserControl1;
        private UpdateUserControl updateUserControl1;
        private DeleteUserControl deleteUserControl1;
        private SearchUserControl searchUserControl1;
        private AttendenceUserControl attendenceUserControl2;
        private SalaryUserControl salaryUserControl1;
        private ReportUserControl reportUserControl1;
        private SendMailUserControl sendMailUserControl1;
        private LeaveUserControl leaveUserControl1;


    }
}