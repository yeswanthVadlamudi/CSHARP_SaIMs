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
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace NeaApp
{
    public partial class Form1 : Form
    {
        int attemptsRemaining = 3;
        int tries = 3;
        public static string setvalue = "";

        public Form1()
        {
            InitializeComponent();
        }
            


    


        private void Form1_Load(object sender, EventArgs e)
        {


        }



        public void btnAdminSignIn_Click(object sender, EventArgs e)
        {
            // Field validation to check none of the fields are empty
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and password fields are empty, all fields are required");
                txtUsername.Select();

            }
            // to check for scenarios where only the username is empty
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("The username field is empty, all fields are required");
            }
            // to check for scenarios where only the password is empty
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("The password field is empty, all fields are required");

            }

            
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();
            string salt = "";
            string hashPassword = "";
            string query = "select admin_password_salt, admin_password_hash from admin_credentials where admin_username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);

            MySqlDataReader reader = cmd.ExecuteReader();
            //checks if there is an username corresponding to the textbox input
            if (reader.Read())
            {
                salt = reader.GetString(0);
                hashPassword = reader.GetString(1);
                reader.Close();


                // retrieving the password from the text
                string hashedEnteredPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
                if (BCrypt.Net.BCrypt.Verify(password, hashPassword))
                {
                    // Login successful
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    // each time the password is wrong the number of chances you are left with reduces
                    attemptsRemaining--;
                    if (attemptsRemaining > 0)
                    {
                        if (!string.IsNullOrEmpty(txtPassword.Text))
                        {
                            MessageBox.Show($"Incorrect password. {attemptsRemaining} attempts remaining.");
                            txtPassword.Clear();
                            txtPassword.Select();

                        }
                        else
                        {


                        }



                    }
                    else
                    {
                        MessageBox.Show("You have exceeded the maximum number of attempts p. Your account has been locked.");
                        // Lock the account or temporarily disable the login feature
                        this.Close();
                    }
                }
            }






           
                

               
            // if the username provided doesnt exist
            else
            {
                tries--;
                if (tries > 0 )
                {
                    if (!string.IsNullOrEmpty(txtUsername.Text))
                    {
                        MessageBox.Show($"Incorrect username or password. {tries} attempts remaining.");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Select();

                    }
                    else
                    {
                        


                    }
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("You have exceeded the maximum number of attempts.Your account has been locked.");
                    // Lock the account or temporarily disable the login feature
                    this.Close();
                }
            }

            

            conn.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //UserName = txtUsername.Text;


        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {


        }

        private void lnklForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //this is an option for resetting the password for the specific username, takes you to a landing page.
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    throw new ArgumentException("Username cannot be empty");
                }

                setvalue = txtUsername.Text;

                this.Hide();
                Form6 form6 = new Form6();
                form6.Show();

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

































































    }
}

