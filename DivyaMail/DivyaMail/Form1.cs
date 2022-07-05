using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivyaMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSndmail_Click(object sender, EventArgs e)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("grapigztics@gmail.com");
                    mail.To.Add("stephenap@fourbends.com");
                    mail.CC.Add("sdndinesh@fourbends.com");
                    mail.Subject = "Divya P- Test mail using console application";
                    mail.Body = "<h1>Hi,This mail is sent by using the console application</h1>";
                    mail.IsBodyHtml = true;


                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("grapigztics@gmail.com", "Ktr1@hdsjc*^!");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        label1.Text = "Mail Sent";
                    }
                }

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }


    }
}
