using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class EmployeeLoginUserControl : UserControl
    {
        public EmployeeLoginUserControl()
        {
            InitializeComponent();
        }
        void clear()
        {

            EmpUserNameTextBox.Clear();
            EmpPassTextBox.Clear();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            string username1 = EmpUserNameTextBox.Text;
            string password1 = EmpPassTextBox.Text;

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand(" select * from tbl_employee_login where employeeusername = '" + username1 + "' and employeepassword ='" + password1 + "'", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();
            if (dataFromDb.HasRows)
            {


                EmployeeDashBoard featureform = new EmployeeDashBoard();
                featureform.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
            clear();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EmpPassTextBox.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void EmpUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
