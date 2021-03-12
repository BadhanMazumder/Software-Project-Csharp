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
    public partial class SalaryUserControl : UserControl
    {
        public SalaryUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {    int TotalLeave = int.Parse(textBox3.Text);
            double allowance = 0;
            if (listBox1.SelectedIndex == 0)
            {
                allowance = 2.5;
            }
            if (listBox1.SelectedIndex == 1)
            {
                allowance = 2.5;
            }
            if (listBox1.SelectedIndex == 2)
            {
                allowance = 2.5;
            }
            if (listBox1.SelectedIndex == 3)
            {
                allowance = 3.5;
            }
            double salary = 0;
            salary += int.Parse(textBox2.Text);
            
            if (HousingCheckBox.Checked == true)
            {
                salary += 5000;
            }
            if (ConveyenceCheckBox2.Checked == true)
            {
                salary += 3000;
            }
            if (MedicalCheckBox.Checked == true)
            {
                salary += 4000;
            }
            if (OtherCheckBox.Checked == true)
            {
                salary += salary* (allowance/100);
            }
            if (AbsenceCheckBox.Checked == true)
            {
                salary -= 2000;
            }
            if (LeaveCheckBox.Checked == true)
            {
                salary -= TotalLeave*500;
            }
            TotalSalaryTextBox.Text = salary.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2S_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();
            string inputid = updateSerachBox.Text;
            SqlCommand selectCommand = new SqlCommand("select id,name,department,designation,basicsalary  from tbl_employee_info where id ='" + inputid + "'", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string ID = dataFromDb["id"].ToString();
                    string name = dataFromDb["name"].ToString();

                    string department = dataFromDb["department"].ToString();
                    string designation = dataFromDb["designation"].ToString();
                    string basicsalary = dataFromDb["basicsalary"].ToString();




                    textBox1.Text = name;
                    textBox6.Text = ID;
                    textBox7.Text = department;
                    textBox5.Text = designation;
                    textBox2.Text = basicsalary;






                }
                catch (Exception esadsad)
                { }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();
            string inputid = updateSerachBox.Text;

            SqlCommand selectCommand = new SqlCommand("select totalleave  from tbl_employee_leave where id ='" + inputid + "'and leavegrantdate between @date1 and @date2", connection);

            selectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Text);
            selectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Text);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string totalleave = dataFromDb["totalleave"].ToString();


                    textBox3.Text = totalleave;


                }
                catch (Exception esadsad)
                { }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TotalSalaryTextBox.Text !=null && updateSerachBox.Text != null && textBox3.Text != null && dateTimePicker1.Value < dateTimePicker2.Value && OtherCheckBox.Checked && AbsenceCheckBox.Checked && LeaveCheckBox.Checked)
            {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO [dbo].[tbl_employee_salary] (id,name,department,designation,basicsalary,totalleave,date,totalsalary) VALUES (@ID,@Ename,@Edepartment,@Edesignation,@Ebasicsalary,@Etotalleave,@Edate,@Etotalsalary)", connection);

                insertCommand.Parameters.AddWithValue("@ID", textBox6.Text);
                insertCommand.Parameters.AddWithValue("@Ename", textBox1.Text);
                insertCommand.Parameters.AddWithValue("@Edepartment", textBox7.Text);
                insertCommand.Parameters.AddWithValue("@Edesignation", textBox5.Text);
                insertCommand.Parameters.AddWithValue("@Edate", dateTimePicker3.Text);
                insertCommand.Parameters.AddWithValue("@Ebasicsalary", textBox2.Text);
                insertCommand.Parameters.AddWithValue("@Etotalleave", textBox3.Text);
                insertCommand.Parameters.AddWithValue("@Etotalsalary", TotalSalaryTextBox.Text);



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
            textBox7.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            TotalSalaryTextBox.Clear();

            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            listBox1.ClearSelected();
            HousingCheckBox.Checked = false;
            ConveyenceCheckBox2.Checked = false;
            MedicalCheckBox.Checked = false;
            OtherCheckBox.Checked = false;
            AbsenceCheckBox.Checked = false;
            LeaveCheckBox.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

     
    }
}
