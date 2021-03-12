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
    public partial class AttendenceUserControl : UserControl
    {
        public AttendenceUserControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2S_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();
            string inputid = updateSerachBox.Text;
            SqlCommand selectCommand = new SqlCommand("select id,name,shift,department  from tbl_employee_info where id ='" + inputid + "'", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string ID = dataFromDb["id"].ToString();
                    string name = dataFromDb["name"].ToString();
                    string shift = dataFromDb["shift"].ToString();
                    string department = dataFromDb["department"].ToString();




                    textBox1.Text = name;
                    textBox6.Text = ID;
                    textBox2.Text = shift;
                    textBox4.Text = department;
                    





                }
                catch (Exception esadsad)
                { }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            TimeSpan ts = d2 - d1;
            double  result = ts.TotalHours;
            textBox3.Text = result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(updateSerachBox.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Fill Up Boxes Properly!!!");
             
            }
            else 
            {
                

                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO [dbo].[tbl_employee_attendence] (id,name,attendence,intime,outtime,workduration,shift,date,department) VALUES (@ID,@Ename,@Eattendence,@Eintime,@Eouttime,@Eworkduration,@Eshift,@Edate,@Edepartment)", connection);

                insertCommand.Parameters.AddWithValue("@ID", textBox6.Text);
                insertCommand.Parameters.AddWithValue("@Ename", textBox1.Text);
                insertCommand.Parameters.AddWithValue("@Eattendence", comboBox3.Text);
                insertCommand.Parameters.AddWithValue("@Eintime", dateTimePicker1.Text);
                insertCommand.Parameters.AddWithValue("@Eouttime", dateTimePicker2.Text);
                insertCommand.Parameters.AddWithValue("@Eworkduration", textBox3.Text);
                insertCommand.Parameters.AddWithValue("@Eshift", textBox2.Text);
                insertCommand.Parameters.AddWithValue("@Edate", dateTimePicker3.Text);
                insertCommand.Parameters.AddWithValue("@Edepartment", textBox4.Text);





                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");




                clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            textBox6.Clear();
            comboBox3.Text = "";
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;

        }
    }
}
