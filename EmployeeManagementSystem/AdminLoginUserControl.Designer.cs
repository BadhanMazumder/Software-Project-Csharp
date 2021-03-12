namespace EmployeeManagementSystem
{
    partial class AdminLoginUserControl
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
            this.RPGroupBox = new System.Windows.Forms.GroupBox();
            this.CpassTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ResetPassLabel = new System.Windows.Forms.Label();
            this.ResetPassBtn2 = new System.Windows.Forms.Button();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPassTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.ForgetLabel = new System.Windows.Forms.Label();
            this.ForgetBtn = new System.Windows.Forms.Button();
            this.PassCheckBox = new System.Windows.Forms.CheckBox();
            this.AdminLoginLabel = new System.Windows.Forms.Label();
            this.ResetPassBtn1 = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginPassTextBox = new System.Windows.Forms.TextBox();
            this.LogInPasswordLabel = new System.Windows.Forms.Label();
            this.LoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginUsernameLabel = new System.Windows.Forms.Label();
            this.RPGroupBox.SuspendLayout();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RPGroupBox
            // 
            this.RPGroupBox.BackColor = System.Drawing.Color.White;
            this.RPGroupBox.Controls.Add(this.CpassTextBox);
            this.RPGroupBox.Controls.Add(this.ConfirmPasswordLabel);
            this.RPGroupBox.Controls.Add(this.ResetPassLabel);
            this.RPGroupBox.Controls.Add(this.ResetPassBtn2);
            this.RPGroupBox.Controls.Add(this.NewPassTextBox);
            this.RPGroupBox.Controls.Add(this.NewPasswordLabel);
            this.RPGroupBox.Controls.Add(this.OldPassTextBox);
            this.RPGroupBox.Controls.Add(this.OldPasswordLabel);
            this.RPGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPGroupBox.ForeColor = System.Drawing.Color.Transparent;
            this.RPGroupBox.Location = new System.Drawing.Point(237, 256);
            this.RPGroupBox.Name = "RPGroupBox";
            this.RPGroupBox.Size = new System.Drawing.Size(430, 209);
            this.RPGroupBox.TabIndex = 12;
            this.RPGroupBox.TabStop = false;
            this.RPGroupBox.Visible = false;
            // 
            // CpassTextBox
            // 
            this.CpassTextBox.Location = new System.Drawing.Point(211, 117);
            this.CpassTextBox.Name = "CpassTextBox";
            this.CpassTextBox.PasswordChar = '*';
            this.CpassTextBox.Size = new System.Drawing.Size(157, 26);
            this.CpassTextBox.TabIndex = 11;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(35, 123);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(153, 20);
            this.ConfirmPasswordLabel.TabIndex = 10;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // ResetPassLabel
            // 
            this.ResetPassLabel.AutoSize = true;
            this.ResetPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ResetPassLabel.Location = new System.Drawing.Point(108, 0);
            this.ResetPassLabel.Name = "ResetPassLabel";
            this.ResetPassLabel.Size = new System.Drawing.Size(203, 29);
            this.ResetPassLabel.TabIndex = 9;
            this.ResetPassLabel.Text = "Reset Password";
            // 
            // ResetPassBtn2
            // 
            this.ResetPassBtn2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResetPassBtn2.ForeColor = System.Drawing.Color.Black;
            this.ResetPassBtn2.Location = new System.Drawing.Point(131, 164);
            this.ResetPassBtn2.Name = "ResetPassBtn2";
            this.ResetPassBtn2.Size = new System.Drawing.Size(157, 35);
            this.ResetPassBtn2.TabIndex = 5;
            this.ResetPassBtn2.Text = "Reset ";
            this.ResetPassBtn2.UseVisualStyleBackColor = false;
            this.ResetPassBtn2.Click += new System.EventHandler(this.ResetPassBtn2_Click);
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Location = new System.Drawing.Point(211, 80);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.PasswordChar = '*';
            this.NewPassTextBox.Size = new System.Drawing.Size(157, 26);
            this.NewPassTextBox.TabIndex = 3;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.NewPasswordLabel.Location = new System.Drawing.Point(35, 86);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(125, 20);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "New Password";
            this.NewPasswordLabel.Click += new System.EventHandler(this.NewPasswordLabel_Click);
            // 
            // OldPassTextBox
            // 
            this.OldPassTextBox.Location = new System.Drawing.Point(211, 41);
            this.OldPassTextBox.Name = "OldPassTextBox";
            this.OldPassTextBox.PasswordChar = '*';
            this.OldPassTextBox.Size = new System.Drawing.Size(157, 26);
            this.OldPassTextBox.TabIndex = 1;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.OldPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.OldPasswordLabel.Location = new System.Drawing.Point(35, 47);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(118, 20);
            this.OldPasswordLabel.TabIndex = 0;
            this.OldPasswordLabel.Text = "Old Password";
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.Color.White;
            this.LoginGroupBox.Controls.Add(this.ForgetLabel);
            this.LoginGroupBox.Controls.Add(this.ForgetBtn);
            this.LoginGroupBox.Controls.Add(this.PassCheckBox);
            this.LoginGroupBox.Controls.Add(this.AdminLoginLabel);
            this.LoginGroupBox.Controls.Add(this.ResetPassBtn1);
            this.LoginGroupBox.Controls.Add(this.LoginBtn);
            this.LoginGroupBox.Controls.Add(this.LoginPassTextBox);
            this.LoginGroupBox.Controls.Add(this.LogInPasswordLabel);
            this.LoginGroupBox.Controls.Add(this.LoginUsernameTextBox);
            this.LoginGroupBox.Controls.Add(this.LoginUsernameLabel);
            this.LoginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.ForeColor = System.Drawing.Color.Transparent;
            this.LoginGroupBox.Location = new System.Drawing.Point(293, 3);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(326, 247);
            this.LoginGroupBox.TabIndex = 11;
            this.LoginGroupBox.TabStop = false;
            // 
            // ForgetLabel
            // 
            this.ForgetLabel.AutoSize = true;
            this.ForgetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ForgetLabel.Location = new System.Drawing.Point(22, 162);
            this.ForgetLabel.Name = "ForgetLabel";
            this.ForgetLabel.Size = new System.Drawing.Size(164, 20);
            this.ForgetLabel.TabIndex = 12;
            this.ForgetLabel.Text = "Forget Password??";
            // 
            // ForgetBtn
            // 
            this.ForgetBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ForgetBtn.ForeColor = System.Drawing.Color.Black;
            this.ForgetBtn.Location = new System.Drawing.Point(192, 155);
            this.ForgetBtn.Name = "ForgetBtn";
            this.ForgetBtn.Size = new System.Drawing.Size(110, 35);
            this.ForgetBtn.TabIndex = 11;
            this.ForgetBtn.Text = "Click Here";
            this.ForgetBtn.UseVisualStyleBackColor = false;
            this.ForgetBtn.Click += new System.EventHandler(this.ForgetBtn_Click);
            // 
            // PassCheckBox
            // 
            this.PassCheckBox.AutoSize = true;
            this.PassCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PassCheckBox.Location = new System.Drawing.Point(105, 125);
            this.PassCheckBox.Name = "PassCheckBox";
            this.PassCheckBox.Size = new System.Drawing.Size(154, 24);
            this.PassCheckBox.TabIndex = 10;
            this.PassCheckBox.Text = "Show Password";
            this.PassCheckBox.UseVisualStyleBackColor = true;
            this.PassCheckBox.CheckedChanged += new System.EventHandler(this.PassCheckBox_CheckedChanged);
            // 
            // AdminLoginLabel
            // 
            this.AdminLoginLabel.AutoSize = true;
            this.AdminLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.AdminLoginLabel.Location = new System.Drawing.Point(74, 0);
            this.AdminLoginLabel.Name = "AdminLoginLabel";
            this.AdminLoginLabel.Size = new System.Drawing.Size(158, 29);
            this.AdminLoginLabel.TabIndex = 9;
            this.AdminLoginLabel.Text = "Admin Login";
            // 
            // ResetPassBtn1
            // 
            this.ResetPassBtn1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResetPassBtn1.ForeColor = System.Drawing.Color.Black;
            this.ResetPassBtn1.Location = new System.Drawing.Point(145, 201);
            this.ResetPassBtn1.Name = "ResetPassBtn1";
            this.ResetPassBtn1.Size = new System.Drawing.Size(157, 35);
            this.ResetPassBtn1.TabIndex = 5;
            this.ResetPassBtn1.Text = "Reset Password";
            this.ResetPassBtn1.UseVisualStyleBackColor = false;
            this.ResetPassBtn1.Click += new System.EventHandler(this.ResetPassBtn1_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(30, 201);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(99, 35);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginPassTextBox
            // 
            this.LoginPassTextBox.Location = new System.Drawing.Point(145, 88);
            this.LoginPassTextBox.Name = "LoginPassTextBox";
            this.LoginPassTextBox.PasswordChar = '*';
            this.LoginPassTextBox.Size = new System.Drawing.Size(157, 26);
            this.LoginPassTextBox.TabIndex = 3;
            // 
            // LogInPasswordLabel
            // 
            this.LogInPasswordLabel.AutoSize = true;
            this.LogInPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogInPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.LogInPasswordLabel.Location = new System.Drawing.Point(26, 94);
            this.LogInPasswordLabel.Name = "LogInPasswordLabel";
            this.LogInPasswordLabel.Size = new System.Drawing.Size(86, 20);
            this.LogInPasswordLabel.TabIndex = 2;
            this.LogInPasswordLabel.Text = "Password";
            // 
            // LoginUsernameTextBox
            // 
            this.LoginUsernameTextBox.Location = new System.Drawing.Point(145, 44);
            this.LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            this.LoginUsernameTextBox.Size = new System.Drawing.Size(157, 26);
            this.LoginUsernameTextBox.TabIndex = 1;
            // 
            // LoginUsernameLabel
            // 
            this.LoginUsernameLabel.AutoSize = true;
            this.LoginUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginUsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.LoginUsernameLabel.Location = new System.Drawing.Point(26, 50);
            this.LoginUsernameLabel.Name = "LoginUsernameLabel";
            this.LoginUsernameLabel.Size = new System.Drawing.Size(91, 20);
            this.LoginUsernameLabel.TabIndex = 0;
            this.LoginUsernameLabel.Text = "Username";
            // 
            // AdminLoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.RPGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "AdminLoginUserControl";
            this.Size = new System.Drawing.Size(883, 476);
            this.RPGroupBox.ResumeLayout(false);
            this.RPGroupBox.PerformLayout();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RPGroupBox;
        private System.Windows.Forms.TextBox CpassTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label ResetPassLabel;
        private System.Windows.Forms.Button ResetPassBtn2;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox OldPassTextBox;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Label ForgetLabel;
        private System.Windows.Forms.Button ForgetBtn;
        private System.Windows.Forms.CheckBox PassCheckBox;
        private System.Windows.Forms.Label AdminLoginLabel;
        private System.Windows.Forms.Button ResetPassBtn1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox LoginPassTextBox;
        private System.Windows.Forms.Label LogInPasswordLabel;
        private System.Windows.Forms.TextBox LoginUsernameTextBox;
        private System.Windows.Forms.Label LoginUsernameLabel;
    }
}
