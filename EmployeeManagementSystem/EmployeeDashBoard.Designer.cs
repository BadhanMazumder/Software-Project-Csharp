namespace EmployeeManagementSystem
{
    partial class EmployeeDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.attendenceUserControl1 = new EmployeeManagementSystem.AttendenceUserControl();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.EDetailsBtn = new System.Windows.Forms.Button();
            this.LRMailBtn = new System.Windows.Forms.Button();
            this.employeeDetailsUserControl1 = new EmployeeManagementSystem.EmployeeDetailsUserControl();
            this.employeeLeaveMailUserControl1 = new EmployeeManagementSystem.EmployeeLeaveMailUserControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.attendenceUserControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 20);
            this.panel2.TabIndex = 7;
            // 
            // attendenceUserControl1
            // 
            this.attendenceUserControl1.Location = new System.Drawing.Point(0, 15);
            this.attendenceUserControl1.Name = "attendenceUserControl1";
            this.attendenceUserControl1.Size = new System.Drawing.Size(1093, 655);
            this.attendenceUserControl1.TabIndex = 10;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SidePanel.Location = new System.Drawing.Point(217, 12);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 70);
            this.SidePanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.EDetailsBtn);
            this.panel1.Controls.Add(this.LRMailBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 641);
            this.panel1.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-3, 160);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(201, 68);
            this.button10.TabIndex = 8;
            this.button10.Text = "Log Out";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // EDetailsBtn
            // 
            this.EDetailsBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EDetailsBtn.FlatAppearance.BorderSize = 0;
            this.EDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("EDetailsBtn.Image")));
            this.EDetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EDetailsBtn.Location = new System.Drawing.Point(-3, 12);
            this.EDetailsBtn.Name = "EDetailsBtn";
            this.EDetailsBtn.Size = new System.Drawing.Size(204, 68);
            this.EDetailsBtn.TabIndex = 7;
            this.EDetailsBtn.Text = "Employee Details";
            this.EDetailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EDetailsBtn.UseVisualStyleBackColor = false;
            this.EDetailsBtn.Click += new System.EventHandler(this.EDetailsBtn_Click);
            // 
            // LRMailBtn
            // 
            this.LRMailBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LRMailBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LRMailBtn.FlatAppearance.BorderSize = 0;
            this.LRMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LRMailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRMailBtn.Image = ((System.Drawing.Image)(resources.GetObject("LRMailBtn.Image")));
            this.LRMailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LRMailBtn.Location = new System.Drawing.Point(-3, 86);
            this.LRMailBtn.Name = "LRMailBtn";
            this.LRMailBtn.Size = new System.Drawing.Size(204, 68);
            this.LRMailBtn.TabIndex = 6;
            this.LRMailBtn.Text = "L.R Mail";
            this.LRMailBtn.UseVisualStyleBackColor = false;
            this.LRMailBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // employeeDetailsUserControl1
            // 
            this.employeeDetailsUserControl1.Location = new System.Drawing.Point(227, 16);
            this.employeeDetailsUserControl1.Name = "employeeDetailsUserControl1";
            this.employeeDetailsUserControl1.Size = new System.Drawing.Size(1124, 655);
            this.employeeDetailsUserControl1.TabIndex = 8;
            // 
            // employeeLeaveMailUserControl1
            // 
            this.employeeLeaveMailUserControl1.Location = new System.Drawing.Point(227, 16);
            this.employeeLeaveMailUserControl1.Name = "employeeLeaveMailUserControl1";
            this.employeeLeaveMailUserControl1.Size = new System.Drawing.Size(1127, 655);
            this.employeeLeaveMailUserControl1.TabIndex = 9;
            // 
            // EmployeeDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 641);
            this.Controls.Add(this.employeeLeaveMailUserControl1);
            this.Controls.Add(this.employeeDetailsUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDashBoard";
            this.Text = "EmployeeDashBoard";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private AttendenceUserControl attendenceUserControl1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button EDetailsBtn;
        private System.Windows.Forms.Button LRMailBtn;
        private EmployeeDetailsUserControl employeeDetailsUserControl1;
        private EmployeeLeaveMailUserControl employeeLeaveMailUserControl1;
    }
}