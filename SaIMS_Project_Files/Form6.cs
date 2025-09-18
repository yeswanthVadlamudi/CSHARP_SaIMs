using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace NeaApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        // from email address and password
        string FromMailAddress = "do.not.reply.stockninventory2005@gmail.com";
        string Password = "xrrwrqwagczquknv";

        

        
        public void btnSendCode_Click(object sender, EventArgs e)
        {
            // created an object for the class
            EmailValidation validateEmail = new EmailValidation();

            var validation = validateEmail.ValidateEmail(txtEmailbox.Text);
            // this will make sure the email is in the correct format to proceed
            if (validation)
            {
                SmtpClient client = new SmtpClient();
                MailMessage mm = new MailMessage();

                mm.From = new MailAddress(FromMailAddress);
                mm.To.Add(new MailAddress(txtEmailbox.Text));
                mm.Subject = "Verification code for password change request";
                mm.IsBodyHtml = true;
                mm.Body = "The verification code for password change is: " + random.ToString();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(FromMailAddress, Password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mm);

                MessageBox.Show("E-Mail Sent!");



            }
            else
            {
                MessageBox.Show("Email address is invalid (format)");
            }















        }
        // random code generator that produces 7 digit code for verification
        static Random r = new Random();

        int random = r.Next(1000000, 10000000);

        public void btnok_Click(object sender, EventArgs e)
        {
            
            if (random.ToString() == txtVerificationCode.Text)
            {
                MessageBox.Show("Verified!");
                this.Hide();
                Form7 form7 = new Form7();
                form7.Show();

            }

            else
            {
                txtVerificationCode.Clear();
                MessageBox.Show("The verification entered is incorrect, please try again by using a new verification code");
            }

        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
