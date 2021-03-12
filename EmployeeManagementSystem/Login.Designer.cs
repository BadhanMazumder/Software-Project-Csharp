namespace EmployeeManagementSystem
{
    partial class Login
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
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminLoginBtn = new System.Windows.Forms.Button();
            this.EmLoginBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.adminLoginUserControl1 = new EmployeeManagementSystem.AdminLoginUserControl();
            this.employeeLoginUserControl1 = new EmployeeManagementSystem.EmployeeLoginUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLabel.ForeColor = System.Drawing.Color.White;
            this.LoginTitleLabel.Location = new System.Drawing.Point(160, 6);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(536, 39);
            this.LoginTitleLabel.TabIndex = 0;
            this.LoginTitleLabel.Text = "Employee Management System";
            this.LoginTitleLabel.Click += new System.EventHandler(this.LoginTitleLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LoginTitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 45);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.AdminLoginBtn);
            this.panel2.Controls.Add(this.EmLoginBtn);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 100);
            this.panel2.TabIndex = 15;
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AdminLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AdminLoginBtn.FlatAppearance.BorderSize = 0;
            this.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.ForeColor = System.Drawing.Color.Black;
            this.AdminLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminLoginBtn.Location = new System.Drawing.Point(438, 3);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(429, 94);
            this.AdminLoginBtn.TabIndex = 9;
            this.AdminLoginBtn.Text = "Admin Login";
            this.AdminLoginBtn.UseVisualStyleBackColor = false;
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // EmLoginBtn
            // 
            this.EmLoginBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EmLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EmLoginBtn.FlatAppearance.BorderSize = 0;
            this.EmLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmLoginBtn.ForeColor = System.Drawing.Color.Black;
            this.EmLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmLoginBtn.Location = new System.Drawing.Point(3, 3);
            this.EmLoginBtn.Name = "EmLoginBtn";
            this.EmLoginBtn.Size = new System.Drawing.Size(434, 94);
            this.EmLoginBtn.TabIndex = 8;
            this.EmLoginBtn.Text = "Employee Login";
            this.EmLoginBtn.UseVisualStyleBackColor = false;
            this.EmLoginBtn.Click += new System.EventHandler(this.EmLoginBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.GreenYellow;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.linkLabel1.ImageKey = "(none)";
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(172, 654);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(550, 23);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed By PSTU CSE 13 Batch ID : 1502044 and ID : 1502068";
            this.linkLabel1.UseWaitCursor = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.GreenYellow;
            // 
            // adminLoginUserControl1
            // 
            this.adminLoginUserControl1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adminLoginUserControl1.ForeColor = System.Drawing.Color.Transparent;
            this.adminLoginUserControl1.Location = new System.Drawing.Point(0, 152);
            this.adminLoginUserControl1.Name = "adminLoginUserControl1";
            this.adminLoginUserControl1.Size = new System.Drawing.Size(867, 476);
            this.adminLoginUserControl1.TabIndex = 17;
            this.adminLoginUserControl1.Load += new System.EventHandler(this.adminLoginUserControl1_Load);
            // 
            // employeeLoginUserControl1
            // 
            this.employeeLoginUserControl1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.employeeLoginUserControl1.Location = new System.Drawing.Point(3, 152);
            this.employeeLoginUserControl1.Name = "employeeLoginUserControl1";
            this.employeeLoginUserControl1.Size = new System.Drawing.Size(864, 476);
            this.employeeLoginUserControl1.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 686);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.adminLoginUserControl1);
            this.Controls.Add(this.employeeLoginUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EmLoginBtn;
        private System.Windows.Forms.Button AdminLoginBtn;
        private EmployeeLoginUserControl employeeLoginUserControl1;
        private AdminLoginUserControl adminLoginUserControl1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

