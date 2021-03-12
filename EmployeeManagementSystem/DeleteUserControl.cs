using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class DeleteUserControl : UserControl
    {
        public DeleteUserControl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1D_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();
            string inputid = updateSerachBox.Text;
            SqlCommand selectCommand = new SqlCommand("select *  from tbl_employee_info where id ='" + inputid + "'", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {

                    string name = dataFromDb["name"].ToString();
                    string fathername = dataFromDb["fathername"].ToString();
                    string mail = dataFromDb["mail"].ToString();
                    string age = dataFromDb["age"].ToString();
                    string phonenumber = dataFromDb["phonenumber"].ToString();
                    string gender = dataFromDb["gender"].ToString();
                    string city = dataFromDb["city"].ToString();
                    string dob = dataFromDb["dob"].ToString();
                    string joindate = dataFromDb["joindate"].ToString();
                    string department = dataFromDb["department"].ToString();
                    string shift = dataFromDb["shift"].ToString();
                    string designation = dataFromDb["designation"].ToString();
                    string basicsalary = dataFromDb["basicsalary"].ToString();
                    string nidnumber = dataFromDb["nidnumber"].ToString();



                    byte[] storedImage = (byte[])dataFromDb["image"];
                    Image newImage;
                    MemoryStream stream = new MemoryStream(storedImage);
                    newImage = Image.FromStream(stream);

                    textBox6.Text = name;
                    textBox5.Text = fathername;
                    textBox2.Text = mail;
                    textBox8.Text = age;
                    textBox9.Text = phonenumber;
                    textBox1.Text = gender;
                    
                    textBox3.Text = dob;
                    textBox4.Text = joindate;
                    textBox7.Text = department;
                    textBox12.Text = shift;
                    textBox10.Text = designation;
                    textBox16.Text = basicsalary;
                    textBox17.Text = nidnumber;
                    textBox11.Text = city;

                    updatepictureBox2.Image = newImage;





                }
                catch (Exception esadsad)
                { }

            
        }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox1.Clear();

            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox12.Clear();
            textBox10.Clear();
            textBox11.Clear();
            
            textBox16.Clear();
            textBox17.Clear();
           
            updatepictureBox2.Image = null;
            

        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string deletee = updateSerachBox.Text;

            if (string.IsNullOrWhiteSpace(updateSerachBox.Text))
            {

                MessageBox.Show("Fill Up Boxes Properly!!!");
            }
            else
            {
                

                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(" delete from tbl_employee_info where id = '" + deletee + "'", connection);


                selectCommand.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfully!!");
                
            }
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
