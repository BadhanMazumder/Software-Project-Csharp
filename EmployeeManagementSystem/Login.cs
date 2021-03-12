using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoginGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void LoginTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassBtn2_Click(object sender, EventArgs e)
        {

        }

        private void LoginUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            DashBoard featureFrom = new DashBoard();
            featureFrom.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void RPGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EmLoginBtn_Click(object sender, EventArgs e)
        {
            employeeLoginUserControl1.BringToFront();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            adminLoginUserControl1.BringToFront();
        }

        private void adminLoginUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
