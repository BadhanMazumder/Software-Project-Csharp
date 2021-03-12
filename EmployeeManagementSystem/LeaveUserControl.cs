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
    public partial class LeaveUserControl : UserControl
    {
        public LeaveUserControl()
        {
            InitializeComponent();
        }

        private void button2S_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();
            string inputid = updateSerachBox.Text;
            SqlCommand selectCommand = new SqlCommand("select id,name,shift,department,designation  from tbl_employee_info where id ='" + inputid + "'", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string ID = dataFromDb["id"].ToString();
                    string name = dataFromDb["name"].ToString();
                    string shift = dataFromDb["shift"].ToString();
                    string department = dataFromDb["department"].ToString();
                    string designation = dataFromDb["designation"].ToString();



                    textBox1.Text = name;
                    textBox6.Text = ID;
                    textBox2.Text = shift;
                    textBox5.Text = department;
                    textBox3.Text = designation;






                }
                catch (Exception esadsad)
                { }

            }
        }
       
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime FirstDate = dateTimePicker1.Value;
            DateTime SecondDate = dateTimePicker2.Value;
            TimeSpan ts = SecondDate - FirstDate;
            int totaldays = ts.Days;
            textBox4.Text = totaldays.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (updateSerachBox.Text != null && textBox4.Text != null && dateTimePicker1.Value < dateTimePicker2.Value && richTextBox1.Text != String.Empty)
            {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO [dbo].[tbl_employee_leave] (id,name,department,designation,shift,leavefromdate,leavetodate,leavegrantdate,totalleave,leavereason) VALUES (@ID,@Ename,@Edepartment,@Edesignation,@Eshift,@Eleavefromdate,@Eleavetodate,@Eleavegrantdate,@Etotalleave,@Eleavereason)", connection);

                insertCommand.Parameters.AddWithValue("@ID", textBox6.Text);
                insertCommand.Parameters.AddWithValue("@Ename", textBox1.Text);
                insertCommand.Parameters.AddWithValue("@Edepartment", textBox5.Text);
                insertCommand.Parameters.AddWithValue("@Edesignation", textBox3.Text);
                insertCommand.Parameters.AddWithValue("@Eleavefromdate", dateTimePicker1.Text);
                insertCommand.Parameters.AddWithValue("@Eleavetodate", dateTimePicker2.Text);
                insertCommand.Parameters.AddWithValue("@Eleavegrantdate", dateTimePicker3.Text);
                insertCommand.Parameters.AddWithValue("@Eshift", textBox2.Text);
                insertCommand.Parameters.AddWithValue("@Etotalleave", textBox4.Text);
                insertCommand.Parameters.AddWithValue("@Eleavereason", richTextBox1.Text);




                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");



            }
            catch (Exception ex)
            { }
            clear();
            }
            else {
                MessageBox.Show("Fill Up Boxes Properly!!!");
            }
        }

        void clear()
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
