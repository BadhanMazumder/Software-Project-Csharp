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
    public partial class SearchUserControl : UserControl
    {
        byte[] bImageData1;
        public SearchUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1S_Click(object sender, EventArgs e)
        {

        }

        private void Sbutton_Click(object sender, EventArgs e)
        {
            ViewDataGridView.Rows.Clear();
            string CBox = ViewComboBox.Text;
            
                if (CBox == "ID")
                {
                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");



                    ViewDataGridView.Rows.Clear();
                    connection.Open();

                    SqlCommand selectCommand = new SqlCommand("select * from tbl_employee_info where id like '" + ViewTextBox.Text + "%'", connection);


                    SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                    while (dataFromDb.Read())
                    {

                        try
                        {
                            var index = ViewDataGridView.Rows.Add();


                            ViewDataGridView.Rows[index].Cells[0].Value = dataFromDb["name"].ToString();
                            ViewDataGridView.Rows[index].Cells[1].Value = dataFromDb["fathername"].ToString();
                            ViewDataGridView.Rows[index].Cells[2].Value = dataFromDb["mail"].ToString();
                            ViewDataGridView.Rows[index].Cells[3].Value = dataFromDb["age"].ToString();
                            ViewDataGridView.Rows[index].Cells[4].Value = dataFromDb["phonenumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[5].Value = dataFromDb["gender"].ToString();
                            ViewDataGridView.Rows[index].Cells[6].Value = dataFromDb["city"].ToString();
                            ViewDataGridView.Rows[index].Cells[7].Value = dataFromDb["dob"].ToString();
                            ViewDataGridView.Rows[index].Cells[8].Value = dataFromDb["joindate"].ToString();
                            ViewDataGridView.Rows[index].Cells[9].Value = dataFromDb["department"].ToString();
                            ViewDataGridView.Rows[index].Cells[10].Value = dataFromDb["designation"].ToString();
                            ViewDataGridView.Rows[index].Cells[11].Value = dataFromDb["basicsalary"].ToString();
                            ViewDataGridView.Rows[index].Cells[12].Value = dataFromDb["nidnumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[13].Value = dataFromDb["shift"].ToString();




                            byte[] storedImage = (byte[])dataFromDb["image"];
                            Image newImage;
                            MemoryStream stream = new MemoryStream(storedImage);
                            newImage = Image.FromStream(stream);




                            ViewDataGridView.Rows[index].Cells[14].Value = newImage;


                            ((DataGridViewImageColumn)ViewDataGridView.Columns[14]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                            ViewDataGridView.Rows[index].Height = 50;

                        }
                        catch (Exception esadsad)
                        { }
                    }
                }
                else if (CBox == "Name")
                {
                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");



                    ViewDataGridView.Rows.Clear();
                    connection.Open();

                    SqlCommand selectCommand = new SqlCommand("select * from tbl_employee_info where name like '" + ViewTextBox.Text + "%'", connection);


                    SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                    while (dataFromDb.Read())
                    {

                        try
                        {
                            var index = ViewDataGridView.Rows.Add();


                            ViewDataGridView.Rows[index].Cells[0].Value = dataFromDb["name"].ToString();
                            ViewDataGridView.Rows[index].Cells[1].Value = dataFromDb["fathername"].ToString();
                            ViewDataGridView.Rows[index].Cells[2].Value = dataFromDb["mail"].ToString();
                            ViewDataGridView.Rows[index].Cells[3].Value = dataFromDb["age"].ToString();
                            ViewDataGridView.Rows[index].Cells[4].Value = dataFromDb["phonenumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[5].Value = dataFromDb["gender"].ToString();
                            ViewDataGridView.Rows[index].Cells[6].Value = dataFromDb["city"].ToString();
                            ViewDataGridView.Rows[index].Cells[7].Value = dataFromDb["dob"].ToString();
                            ViewDataGridView.Rows[index].Cells[8].Value = dataFromDb["joindate"].ToString();
                            ViewDataGridView.Rows[index].Cells[9].Value = dataFromDb["department"].ToString();
                            ViewDataGridView.Rows[index].Cells[10].Value = dataFromDb["designation"].ToString();
                            ViewDataGridView.Rows[index].Cells[11].Value = dataFromDb["basicsalary"].ToString();
                            ViewDataGridView.Rows[index].Cells[12].Value = dataFromDb["nidnumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[13].Value = dataFromDb["shift"].ToString();




                            byte[] storedImage = (byte[])dataFromDb["image"];
                            Image newImage;
                            MemoryStream stream = new MemoryStream(storedImage);
                            newImage = Image.FromStream(stream);




                            ViewDataGridView.Rows[index].Cells[14].Value = newImage;


                            ((DataGridViewImageColumn)ViewDataGridView.Columns[14]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                            ViewDataGridView.Rows[index].Height = 50;

                        }
                        catch (Exception esadsad)
                        { }
                    }
                }
                else if (CBox == "Department")
                {
                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");



                    ViewDataGridView.Rows.Clear();
                    connection.Open();

                    SqlCommand selectCommand = new SqlCommand("select * from tbl_employee_info where department like '" + ViewTextBox.Text + "%'", connection);


                    SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                    while (dataFromDb.Read())
                    {

                        try
                        {
                            var index = ViewDataGridView.Rows.Add();


                            ViewDataGridView.Rows[index].Cells[0].Value = dataFromDb["name"].ToString();
                            ViewDataGridView.Rows[index].Cells[1].Value = dataFromDb["fathername"].ToString();
                            ViewDataGridView.Rows[index].Cells[2].Value = dataFromDb["mail"].ToString();
                            ViewDataGridView.Rows[index].Cells[3].Value = dataFromDb["age"].ToString();
                            ViewDataGridView.Rows[index].Cells[4].Value = dataFromDb["phonenumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[5].Value = dataFromDb["gender"].ToString();
                            ViewDataGridView.Rows[index].Cells[6].Value = dataFromDb["city"].ToString();
                            ViewDataGridView.Rows[index].Cells[7].Value = dataFromDb["dob"].ToString();
                            ViewDataGridView.Rows[index].Cells[8].Value = dataFromDb["joindate"].ToString();
                            ViewDataGridView.Rows[index].Cells[9].Value = dataFromDb["department"].ToString();
                            ViewDataGridView.Rows[index].Cells[10].Value = dataFromDb["designation"].ToString();
                            ViewDataGridView.Rows[index].Cells[11].Value = dataFromDb["basicsalary"].ToString();
                            ViewDataGridView.Rows[index].Cells[12].Value = dataFromDb["nidnumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[13].Value = dataFromDb["shift"].ToString();




                            byte[] storedImage = (byte[])dataFromDb["image"];
                            Image newImage;
                            MemoryStream stream = new MemoryStream(storedImage);
                            newImage = Image.FromStream(stream);




                            ViewDataGridView.Rows[index].Cells[14].Value = newImage;


                            ((DataGridViewImageColumn)ViewDataGridView.Columns[14]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                            ViewDataGridView.Rows[index].Height = 50;

                        }
                        catch (Exception esadsad)
                        { }
                    }
                }
                else if (CBox == "Designation")
                {
                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");



                    ViewDataGridView.Rows.Clear();
                    connection.Open();

                    SqlCommand selectCommand = new SqlCommand("select * from tbl_employee_info where designation like '" + ViewTextBox.Text + "%'", connection);


                    SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                    while (dataFromDb.Read())
                    {

                        try
                        {
                            var index = ViewDataGridView.Rows.Add();


                            ViewDataGridView.Rows[index].Cells[0].Value = dataFromDb["name"].ToString();
                            ViewDataGridView.Rows[index].Cells[1].Value = dataFromDb["fathername"].ToString();
                            ViewDataGridView.Rows[index].Cells[2].Value = dataFromDb["mail"].ToString();
                            ViewDataGridView.Rows[index].Cells[3].Value = dataFromDb["age"].ToString();
                            ViewDataGridView.Rows[index].Cells[4].Value = dataFromDb["phonenumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[5].Value = dataFromDb["gender"].ToString();
                            ViewDataGridView.Rows[index].Cells[6].Value = dataFromDb["city"].ToString();
                            ViewDataGridView.Rows[index].Cells[7].Value = dataFromDb["dob"].ToString();
                            ViewDataGridView.Rows[index].Cells[8].Value = dataFromDb["joindate"].ToString();
                            ViewDataGridView.Rows[index].Cells[9].Value = dataFromDb["department"].ToString();
                            ViewDataGridView.Rows[index].Cells[10].Value = dataFromDb["designation"].ToString();
                            ViewDataGridView.Rows[index].Cells[11].Value = dataFromDb["basicsalary"].ToString();
                            ViewDataGridView.Rows[index].Cells[12].Value = dataFromDb["nidnumber"].ToString();
                            ViewDataGridView.Rows[index].Cells[13].Value = dataFromDb["shift"].ToString();




                            byte[] storedImage = (byte[])dataFromDb["image"];
                            Image newImage;
                            MemoryStream stream = new MemoryStream(storedImage);
                            newImage = Image.FromStream(stream);




                            ViewDataGridView.Rows[index].Cells[14].Value = newImage;


                            ((DataGridViewImageColumn)ViewDataGridView.Columns[14]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                            ViewDataGridView.Rows[index].Height = 50;

                        }
                        catch (Exception esadsad)
                        { }
                    }
                }
                else if (string.IsNullOrWhiteSpace(ViewComboBox.Text) || string.IsNullOrWhiteSpace(ViewTextBox.Text))
                {
                    MessageBox.Show("Plz Select Seacrh State!!!");
                }
            
            
            
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FQBMN3R\\SQLEXPRESS;Initial Catalog=EmployeeDB; Integrated Security=true");



            ViewDataGridView.Rows.Clear();
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("select * from tbl_employee_info", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    var index = ViewDataGridView.Rows.Add();


                    ViewDataGridView.Rows[index].Cells[0].Value = dataFromDb["name"].ToString();
                    ViewDataGridView.Rows[index].Cells[1].Value = dataFromDb["fathername"].ToString();
                    ViewDataGridView.Rows[index].Cells[2].Value = dataFromDb["mail"].ToString();
                    ViewDataGridView.Rows[index].Cells[3].Value = dataFromDb["age"].ToString();
                    ViewDataGridView.Rows[index].Cells[4].Value = dataFromDb["phonenumber"].ToString();
                    ViewDataGridView.Rows[index].Cells[5].Value = dataFromDb["gender"].ToString();
                    ViewDataGridView.Rows[index].Cells[6].Value = dataFromDb["city"].ToString();
                    ViewDataGridView.Rows[index].Cells[7].Value = dataFromDb["dob"].ToString();
                    ViewDataGridView.Rows[index].Cells[8].Value = dataFromDb["joindate"].ToString();
                    ViewDataGridView.Rows[index].Cells[9].Value = dataFromDb["department"].ToString();
                    ViewDataGridView.Rows[index].Cells[10].Value = dataFromDb["designation"].ToString();
                    ViewDataGridView.Rows[index].Cells[11].Value = dataFromDb["basicsalary"].ToString();
                    ViewDataGridView.Rows[index].Cells[12].Value = dataFromDb["nidnumber"].ToString();
                    ViewDataGridView.Rows[index].Cells[13].Value = dataFromDb["shift"].ToString();




                    byte[] storedImage = (byte[])dataFromDb["image"];
                    Image newImage;
                    MemoryStream stream = new MemoryStream(storedImage);
                    newImage = Image.FromStream(stream);




                    ViewDataGridView.Rows[index].Cells[14].Value = newImage;


                    ((DataGridViewImageColumn)ViewDataGridView.Columns[14]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                    ViewDataGridView.Rows[index].Height = 50;

                }
                catch (Exception esadsad)
                { }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Details";

            for (int i = 1; i < ViewDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = ViewDataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < ViewDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < ViewDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = ViewDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void VClearBtn_Click(object sender, EventArgs e)
        {
            ViewDataGridView.Rows.Clear();
        }
    }
}
