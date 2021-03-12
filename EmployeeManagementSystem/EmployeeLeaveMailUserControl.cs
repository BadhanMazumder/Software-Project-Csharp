using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class EmployeeLeaveMailUserControl : UserControl
    {
        ArrayList alAttachments;
        MailMessage mailMessage;
        public EmployeeLeaveMailUserControl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox6.Text.Contains("@") && !textBox6.Text.Contains(".com"))
            {

                label14.ForeColor = Color.Red;
                MessageBox.Show("Input Mail Address In Proper Format!!!");
            }
            else
            {
                label14.ForeColor = Color.Blue;
            }
            if (!textBox2.Text.Contains("@") && !textBox2.Text.Contains(".com"))
            {

                label2.ForeColor = Color.Red;
                MessageBox.Show("Input Mail Address In Proper Format!!!");
            }
            else
            {
                label2.ForeColor = Color.Blue;
            }

            if (textBox2.Text != null && textBox2.Text.Contains("@") && textBox2.Text.Contains(".com") && textBox6.Text.Contains("@") && textBox6.Text.Contains(".com") && richTextBox2.Text != String.Empty && richTextBox1.Text != String.Empty)
            {
                try
                {
                    if (textBox1.Text != null && textBox6.Text != null)
                    {
                        mailMessage = new MailMessage(textBox6.Text, textBox2.Text);

                        mailMessage.Subject = richTextBox2.Text;
                        mailMessage.Body = richTextBox1.Text;
                        mailMessage.IsBodyHtml = true;

                        /* Set the SMTP server and send the email with attachment */

                        SmtpClient smtpClient = new SmtpClient();

                        // smtpClient.Host = emailServerInfo.MailServerIP;
                        //this will be the host in case of gamil and it varies from the service provider

                        smtpClient.Host = "smtp.gmail.com";
                        //smtpClient.Port = Convert.ToInt32(emailServerInfo.MailServerPortNumber);
                        //this will be the port in case of gamil for dotnet and it varies from the service provider

                        smtpClient.Port = 587;
                        smtpClient.UseDefaultCredentials = true;

                        //smtpClient.Credentials = new System.Net.NetworkCredential(emailServerInfo.MailServerUserName, emailServerInfo.MailServerPassword);
                        smtpClient.Credentials = new NetworkCredential(textBox6.Text, textBox1.Text);

                        //Attachment
                        Attachment attachment = new Attachment(textBox4.Text);
                        if (attachment != null)
                        {
                            mailMessage.Attachments.Add(attachment);
                        }


                        //this will be the true in case of gamil and it varies from the service provider
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mailMessage);
                    }

                    string msg = "Message Send Successfully:";
                    msg += "\n To :" + textBox2.Text;

                    MessageBox.Show(msg.ToString());

                    /* clear the controls */
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    richTextBox2.Text = string.Empty;
                    textBox6.Clear();
                    richTextBox1.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Fill Up Boxes Properly!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    textBox4.Text = ofdlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            richTextBox2.Text = string.Empty;
            textBox6.Clear();
            richTextBox1.Text = string.Empty;
        }
    }
}
