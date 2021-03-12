using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class AddUserControl : UserControl
    {
        byte[] bImageData1;
        public AddUserControl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


       
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("@") && !textBox2.Text.Contains(".com"))
            {

                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Blue;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^a-zA-Z]"))
                {
                    label14.ForeColor = Color.Red;
                    MessageBox.Show("Please Use Both UpperCase and LowerCase");
                 
                }
                else
                {
                    label14.ForeColor = Color.Blue;
                }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^a-zA-Z]"))
            {
                label13.ForeColor = Color.Red;
                MessageBox.Show("Please Use Both UpperCase and LowerCase");

            }
            else
            {
                label13.ForeColor = Color.Blue;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, "[^a-zA-Z]"))
            {
                label6.ForeColor = Color.Red;
                MessageBox.Show("Please Use Both UpperCase and LowerCase");

            }
            else
            {
                label6.ForeColor = Color.Blue;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^a-zA-Z]") && System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^a-zA-Z]") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, "[^a-zA-Z]") &&
                textBox3.Text != null && textBox6.Text != null && textBox5.Text != null && 
                textBox2.Text != null && textBox2.Text.Contains("@") && textBox2.Text.Contains(".com")
                && textBox8.Text != null && textBox9.Text != null && textBox11.Text != null && dateTimePicker1.Value < DateTime.Today && dateTimePicker2.Value < DateTime.Today && comboBox3.Text != null && comboBox2.Text != null && comboBox4.Text != null && textBox16.Text != null && textBox17.Text != null && EPictureBox.Image != null) 
            {
            try
            {
                byte[] bImageData = GetImageData();

         
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO [dbo].[tbl_employee_info] (id,name,fathername,mail,age,phonenumber,gender,city,dob,joindate,department,shift,designation,basicsalary,nidnumber,image ) VALUES (@ID,@Ename,@Efathername,@Email,@Eage,@Ephonenumber,@Egender,@Ecity,@Edob,@Ejoindate,@Edepartment,@Eshift,@Edesignation,@Ebasicsalary,@Enidnumber,@Eimage)", connection);

                insertCommand.Parameters.AddWithValue("@ID", textBox3.Text);
                insertCommand.Parameters.AddWithValue("@Ename", textBox6.Text);
                insertCommand.Parameters.AddWithValue("@Efathername", textBox5.Text);
                insertCommand.Parameters.AddWithValue("@Email", textBox2.Text);
                insertCommand.Parameters.AddWithValue("@Eage", textBox8.Text);
                insertCommand.Parameters.AddWithValue("@Ephonenumber", textBox9.Text);
                insertCommand.Parameters.AddWithValue("@Egender", comboBox1.Text);
                insertCommand.Parameters.AddWithValue("@Ecity", textBox11.Text);
                insertCommand.Parameters.AddWithValue("@Edob", dateTimePicker1.Text);
                insertCommand.Parameters.AddWithValue("@Ejoindate", dateTimePicker2.Text);
                insertCommand.Parameters.AddWithValue("@Edepartment", comboBox3.Text);
                insertCommand.Parameters.AddWithValue("@Eshift", comboBox2.Text);
                insertCommand.Parameters.AddWithValue("@Edesignation", comboBox4.Text);
                insertCommand.Parameters.AddWithValue("@Ebasicsalary", textBox16.Text);
                insertCommand.Parameters.AddWithValue("@Enidnumber", textBox17.Text);
                insertCommand.Parameters.AddWithValue("@Eimage", bImageData);


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
                MessageBox.Show(" Follow Proper Way!!");
            }

        }
        public byte[] GetImageData()
        {
            Image img = Image.FromFile(ImageTextBox.Text);

            ImageConverter ic = new ImageConverter();

            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                ImageTextBox.Text = ofd.FileName;


                EPictureBox.Image = Image.FromFile(@ofd.FileName);
            }

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            textBox3.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "";
            textBox11.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox3.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            textBox16.Clear();
            textBox17.Clear();
            ImageTextBox.Clear();
            EPictureBox.Image = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
