namespace EmployeeManagementSystem
{
    partial class EmployeeLoginUserControl
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
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.EmpPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.BackColor = System.Drawing.Color.White;
            this.EmployeeGroupBox.Controls.Add(this.checkBox1);
            this.EmployeeGroupBox.Controls.Add(this.label2);
            this.EmployeeGroupBox.Controls.Add(this.button3);
            this.EmployeeGroupBox.Controls.Add(this.EmpPassTextBox);
            this.EmployeeGroupBox.Controls.Add(this.label3);
            this.EmployeeGroupBox.Controls.Add(this.EmpUserNameTextBox);
            this.EmployeeGroupBox.Controls.Add(this.label4);
            this.EmployeeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeGroupBox.ForeColor = System.Drawing.Color.Transparent;
            this.EmployeeGroupBox.Location = new System.Drawing.Point(283, 3);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(326, 255);
            this.EmployeeGroupBox.TabIndex = 14;
            this.EmployeeGroupBox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.checkBox1.Location = new System.Drawing.Point(102, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(69, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Employee Login";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(102, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmpPassTextBox
            // 
            this.EmpPassTextBox.Location = new System.Drawing.Point(142, 101);
            this.EmpPassTextBox.Name = "EmpPassTextBox";
            this.EmpPassTextBox.PasswordChar = '*';
            this.EmpPassTextBox.Size = new System.Drawing.Size(157, 26);
            this.EmpPassTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // EmpUserNameTextBox
            // 
            this.EmpUserNameTextBox.Location = new System.Drawing.Point(142, 57);
            this.EmpUserNameTextBox.Name = "EmpUserNameTextBox";
            this.EmpUserNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.EmpUserNameTextBox.TabIndex = 1;
            this.EmpUserNameTextBox.TextChanged += new System.EventHandler(this.EmpUserNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // EmployeeLoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.EmployeeGroupBox);
            this.Name = "EmployeeLoginUserControl";
            this.Size = new System.Drawing.Size(883, 476);
            this.EmployeeGroupBox.ResumeLayout(false);
            this.EmployeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox EmpPassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpUserNameTextBox;
        private System.Windows.Forms.Label label4;
    }
}
