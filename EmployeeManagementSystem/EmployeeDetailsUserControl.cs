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
    public partial class EmployeeDetailsUserControl : UserControl
    {
        public EmployeeDetailsUserControl()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeDetailsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(updateSerachBox.Text))
            {
                MessageBox.Show("Plz Input Something!!!");

            }
            else
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

                        textBox12.Text = dob;
                        textBox13.Text = joindate;
                        textBox10.Text = department;
                        textBox4.Text = shift;
                        textBox7.Text = designation;

                        textBox11.Text = city;

                        updatepictureBox2.Image = newImage;





                    }
                    catch (Exception esadsad)
                    { }

                }
            
            }
            
        }
        void clear()
        {

            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox1.Clear();

            textBox12.Clear();
            textBox13.Clear();
            textBox10.Clear();
            textBox4.Clear();
            textBox7.Clear();

            textBox11.Clear();

            updatepictureBox2.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
