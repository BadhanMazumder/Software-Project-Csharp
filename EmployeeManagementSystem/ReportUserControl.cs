using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class ReportUserControl : UserControl
    {
        ReportDocument rd = new ReportDocument(); 
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void Edetailsbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReportSerachBox.Text))
            {
                MessageBox.Show("Plz Input Something!!!");

            }
            else
            {
                string idget = ReportSerachBox.Text;
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
                string query = "select * from tbl_employee_info where id = " + idget;
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds, "tbl_employee_info");
                rd.Load(@"C:\Users\Badhan Mazumder\Documents\Visual Studio 2013\Projects\EmployeeManagementSystem\EmployeeManagementSystem\EDetailsCrystalReport.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;

            }
        }

        private void Eattendencebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReportSerachBox.Text))
            {
                MessageBox.Show("Plz Input Something!!!");

            }
            else
            {
                string idget = ReportSerachBox.Text;
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
                string query = "select * from tbl_employee_attendence where id = " + idget;
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds, "tbl_employee_attendence");
                rd.Load(@"C:\Users\Badhan Mazumder\Documents\Visual Studio 2013\Projects\EmployeeManagementSystem\EmployeeManagementSystem\EAttendenceCrystalReport.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
            }
        }

        private void EleaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReportSerachBox.Text))
            {
                MessageBox.Show("Plz Input Something!!!");

            }
            else
            {
                string idget = ReportSerachBox.Text;
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
                string query = "select * from tbl_employee_leave where id = " + idget;
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds, "tbl_employee_leave");
                rd.Load(@"C:\Users\Badhan Mazumder\Documents\Visual Studio 2013\Projects\EmployeeManagementSystem\EmployeeManagementSystem\EleaveCrystalReport.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
            }
        }

        private void ESalarybtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReportSerachBox.Text))
            {
                MessageBox.Show("Plz Input Something!!!");

            }
            else
            {
                string idget = ReportSerachBox.Text;
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
                string query = "select * from tbl_employee_salary where id = " + idget;
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds, "tbl_employee_salary");
                rd.Load(@"C:\Users\Badhan Mazumder\Documents\Visual Studio 2013\Projects\EmployeeManagementSystem\EmployeeManagementSystem\EsalaryCrystalReport.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
            }
        }
    }
}
