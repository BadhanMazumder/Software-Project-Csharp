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
    public partial class UpdateUserControl : UserControl
    {
        byte[] bImageData1;
        public UpdateUserControl()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = "";
            textBox11.Clear();
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            comboBox3.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            textBox16.Clear();
            textBox17.Clear();
            textBox1.Clear();
            updatepictureBox2.Image = null;
            updateNewImagePicBox.Image = null;

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");
            connection.Open();
            string inputid =  updateSerachBox.Text;
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
                    comboBox1.Text = gender;
                    textBox11.Text = city;
                   dateTimePicker3.Text = dob;
                   dateTimePicker4.Text = joindate;
                   comboBox3.Text = department;
                    comboBox2.Text = shift;
                    comboBox4.Text = designation;
                    textBox16.Text = basicsalary;
                    textBox17.Text = nidnumber;

                    updatepictureBox2.Image = newImage;





                }
                catch (Exception esadsad)
                { }

            }

        }
        public byte[] GetImageDataForUpdate()
        {
            Image img = Image.FromFile(textBox1.Text);

            ImageConverter ic = new ImageConverter();

            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = ofd.FileName;


                updateNewImagePicBox.Image = Image.FromFile(@ofd.FileName);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
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

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^a-zA-Z]") &&    System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^a-zA-Z]") &&
              System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, "[^a-zA-Z]") &&
                updateSerachBox != null  && textBox6.Text != null && textBox5.Text != null && textBox2.Text != null && textBox2.Text.Contains("@") && textBox2.Text.Contains(".com") && textBox8.Text != null && textBox9.Text != null && textBox11.Text != null && dateTimePicker3.Value < DateTime.Today && dateTimePicker4.Value < DateTime.Today && comboBox3.Text != null && comboBox1.Text != null && comboBox2.Text != null && comboBox4.Text != null && textBox16.Text != null && textBox17.Text != null && updatepictureBox2.Image != null )
            {
                try
                {
                    string updateImageLocation = textBox1.Text;

                    SqlConnection dbCon = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog= EmployeeDB; Integrated Security=true");

                    if (updateImageLocation == null || updateImageLocation == "")
                    {
                        SqlCommand updateCommandWithoutImage = new SqlCommand("Update tbl_employee_info SET name=@Ename,fathername=@Efathername,mail=@Email,age=@Eage,phonenumber=@Ephonenumber,gender=@Egender,city=@Ecity,dob=@Edob,joindate=@Ejoindate,department=@Edepartment,shift=@Eshift ,designation=@Edesignation,basicsalary=@Ebasicsalary,nidnumber=@Enidnumber  where id ='" + updateSerachBox.Text + "'", dbCon);

                        updateCommandWithoutImage.Parameters.AddWithValue("@Ename", textBox6.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Efathername", textBox5.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Email", textBox2.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Eage", textBox8.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Ephonenumber", textBox9.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Egender", comboBox1.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Ecity", textBox11.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Edob", dateTimePicker3.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Ejoindate", dateTimePicker4.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Edepartment", comboBox3.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Eshift", comboBox2.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Edesignation", comboBox4.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Ebasicsalary", textBox16.Text);
                        updateCommandWithoutImage.Parameters.AddWithValue("@Enidnumber", textBox17.Text);



                        if (dbCon.State == ConnectionState.Closed)
                            dbCon.Open();
                        updateCommandWithoutImage.ExecuteNonQuery();
                        MessageBox.Show("Record Updated  Successfully");

                    }
                    else
                    {

                        byte[] bImageData = GetImageDataForUpdate();

                        SqlCommand updateCommandWithImage = new SqlCommand("Update tbl_employee_info SET name=@Ename,fathername=@Efathername,mail=@Email,age=@Eage,phonenumber=@Ephonenumber,gender=@Egender,city=@Ecity,dob=@Edob,joindate=@Ejoindate,department=@Edepartment,shift=@Eshift ,designation=@Edesignation,basicsalary=@Ebasicsalary,nidnumber=@Enidnumber ,image=@Eimage where id ='" + updateSerachBox.Text + "'", dbCon);
                        updateCommandWithImage.Parameters.AddWithValue("@Ename", textBox6.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Efathername", textBox5.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Email", textBox2.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Eage", textBox8.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Ephonenumber", textBox9.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Egender", comboBox1.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Ecity", textBox11.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Edob", dateTimePicker3.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Ejoindate", dateTimePicker4.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Edepartment", comboBox3.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Eshift", comboBox2.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Edesignation", comboBox4.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Ebasicsalary", textBox16.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Enidnumber", textBox17.Text);
                        updateCommandWithImage.Parameters.AddWithValue("@Eimage", bImageData);

                        if (dbCon.State == ConnectionState.Closed)
                            dbCon.Open();
                        updateCommandWithImage.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");

                    }





                }
                catch (Exception ex)
                { }

                clear();
            }
            else
            {
                MessageBox.Show(" Follow Proper Way!!");
            }

        }

        private void updateNewImagePicBox_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
