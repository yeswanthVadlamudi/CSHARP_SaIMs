using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using System.Text.RegularExpressions;

namespace NeaApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void txtNewEmployeeName_TextChanged(object sender, EventArgs e)
        {
            

        }
        

        // adding new employees biodata and email address
        public void btnAddEmployeeDetails_Click(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text;
            //checking for the format of the email
            EmailValidation validateEmail= new EmailValidation();
            var validate = validateEmail.ValidateEmail(email);

            if (validate)
            {
                Database_Config config = new Database_Config();

                var c_string = config.get_ini();

                MySqlConnection con = new MySqlConnection(c_string);

                con.Open();





                string query = "insert into staff_details(Forename,DoB,Phone_Number,Email_Address,Gender) values (@forename,@dob,@phonenumber,@emailaddress,@gender)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@forename", txtNewEmployeeName.Text);

                cmd.Parameters.AddWithValue("@dob", txtNewEmployeeDoB.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txtNewEmployeePhoneNumber.Text);
                cmd.Parameters.AddWithValue("@emailaddress", txtEmailAddress.Text);
                cmd.Parameters.AddWithValue("@gender", txtNewEmployeeGender.Text);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("inserted successfully!");


                }

                con.Close();


            }

            else
            {
                MessageBox.Show("Email address is invalid (format)");
            }
                











            
        }

           
        

        private void lblNewEmployeeDetails_Click(object sender, EventArgs e)
        {

        }

        

        private void txtNewEmployeeAge_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void TmrAwaitBeforeClose_Tick(object sender, EventArgs e)
        {

        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
