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
using System.Net.Mail;
using System.Net;


namespace EmployeeManagementSystem
{
    public partial class AdminLoginUserControl : UserControl
    {
        public AdminLoginUserControl()
        {
            InitializeComponent();
        }

        private void NewPasswordLabel_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {

            LoginUsernameTextBox.Clear();
            LoginPassTextBox.Clear();
            

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            string username = LoginUsernameTextBox.Text;
            string password = LoginPassTextBox.Text;

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand(" select * from tbl_admin_login where adminusername = '" + username + "' and adminpassword ='" + password + "'", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();
            if (dataFromDb.HasRows)
            {


                //this.Hide();
                DashBoard featureFrom = new DashBoard();
                featureFrom.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }

            clear();
            
            
            
        }

        private void ResetPassBtn1_Click(object sender, EventArgs e)
        {
            if (RPGroupBox.Visible == true)
                RPGroupBox.Visible = false;
            else
                RPGroupBox.Visible = true;

           

        }
        void clear1()
        {

            OldPassTextBox.Clear();
            NewPassTextBox.Clear();
            CpassTextBox.Clear();
            
        }
        private void ResetPassBtn2_Click(object sender, EventArgs e)
        {
            
            string value;
            string Pass = OldPassTextBox.Text;
            string NewPass = NewPassTextBox.Text;
            string ConfirmPass = CpassTextBox.Text;

             SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
             connection.Open();
            
             SqlCommand selectCommand = new SqlCommand(" select  adminpassword from tbl_admin_login   ", connection);
             value = selectCommand.ExecuteScalar().ToString();
             if (value != Pass)
             {
                 
                 OldPasswordLabel.ForeColor = Color.Red;
                 MessageBox.Show("Enter correct oldpassword");
                 
             }
             else
             {
                 OldPasswordLabel.ForeColor = Color.Blue;
                 
             }
             if (NewPass != ConfirmPass)
             {
                 
                 NewPasswordLabel.ForeColor = Color.Red;
                 ConfirmPasswordLabel.ForeColor = Color.Red;
                 MessageBox.Show("Enter same password");
             }
             else
             {
                 NewPasswordLabel.ForeColor = Color.Blue;
                 ConfirmPasswordLabel.ForeColor = Color.Blue;
             }


             if (value == Pass && Pass != null && NewPass != null && ConfirmPass != null && NewPass == ConfirmPass)
             {


                 SqlCommand updateCommand = new SqlCommand("Update tbl_admin_login SET adminpassword=@Password where adminpassword='" + OldPassTextBox.Text + "'", connection);

                 updateCommand.Parameters.AddWithValue("@Password", NewPassTextBox.Text);

                 if (connection.State == ConnectionState.Closed)
                     connection.Open();
                 updateCommand.ExecuteNonQuery();
                 MessageBox.Show("Password Reset  Successfully");
             }
             else
             {
                 MessageBox.Show("Password Reset  Unsuccessfull");
             }


             clear1();

           
        }

        private void PassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
            LoginPassTextBox.PasswordChar = PassCheckBox.Checked ? '\0' : '*';
        }

        private void ForgetBtn_Click(object sender, EventArgs e)
        {
            string PASSWORD;
            string email;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand(" select  adminpassword from tbl_admin_login   ", connection);
            PASSWORD = selectCommand.ExecuteScalar().ToString();

            SqlCommand selectCommand1 = new SqlCommand(" select  adminemail from tbl_admin_login   ", connection);
            email = selectCommand1.ExecuteScalar().ToString();

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("badhanmazumdar18@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Forgot Password Mail";
            mail.Body = PASSWORD;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("badhanmazumdar18", "________________________Give Password Here______________________");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("Check your email!");
        }
    }
}
