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
    public partial class EmployeeDashBoard : Form
    {
        public EmployeeDashBoard()
        {
            InitializeComponent();
            SidePanel.Height = EDetailsBtn.Height;
            SidePanel.Top = EDetailsBtn.Top;
            employeeDetailsUserControl1.BringToFront();
        }

        private void EDetailsBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EDetailsBtn.Height;
            SidePanel.Top = EDetailsBtn.Top;
            employeeDetailsUserControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SidePanel.Height = LRMailBtn.Height;
            SidePanel.Top = LRMailBtn.Top;
            employeeLeaveMailUserControl1.BringToFront();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }
    }
}
