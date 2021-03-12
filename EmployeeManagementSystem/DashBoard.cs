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
    public partial class DashBoard : Form
    {

        int panelwidth;
        bool hidden;

        public DashBoard()
        {
            InitializeComponent();
            panelwidth = panel1.Width;
            hidden = false;
            SidePanel.Height = AddBtn.Height;
            SidePanel.Top = AddBtn.Top;
            addUserControl1.BringToFront();
            
        }

       

        private void Menubutton_Click(object sender, EventArgs e)
        {
             timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(hidden)
            {
                panel1.Width = panel1.Width + 10;
                if (panel1.Width >= panelwidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {

                panel1.Width = panel1.Width - 10;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AddBtn.Height;
            SidePanel.Top = AddBtn.Top;
            addUserControl1.BringToFront();
        }

        private void UpdateBtn_Click_2(object sender, EventArgs e)
        {
            SidePanel.Height = UpdateBtn.Height;
            SidePanel.Top = UpdateBtn.Top;
            updateUserControl1.BringToFront();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DeleteBtn.Height;
            SidePanel.Top = DeleteBtn.Top;
            deleteUserControl1.BringToFront();
        }

        private void SearchBtn1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SearchBtn1.Height;
            SidePanel.Top = SearchBtn1.Top;
            searchUserControl1.BringToFront();
        }

        private void AttendenceBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AttendenceBtn.Height;
            SidePanel.Top = AttendenceBtn.Top;
            attendenceUserControl2.BringToFront();
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = LeaveBtn.Height;
            SidePanel.Top = LeaveBtn.Top;
            leaveUserControl1.BringToFront();
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalaryBtn.Height;
            SidePanel.Top = SalaryBtn.Top;
            salaryUserControl1.BringToFront();
        }

        private void MailBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MailBtn.Height;
            SidePanel.Top = MailBtn.Top;
            sendMailUserControl1.BringToFront();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ReportBtn.Height;
            SidePanel.Top = ReportBtn.Top;
            reportUserControl1.BringToFront();
        }

        private void LOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        private void Outbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }
    }
}
