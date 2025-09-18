using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Session;
using System.Reflection;
using System.Security.Cryptography;
using BCrypt.Net;

namespace NeaApp
{
   
    public partial class Form3 : Form
    {
        public const int Minimum_Length = 12;

        
        public Form3()
        {
            InitializeComponent();
        }


       // populates a dropdown list with all the employees name
        private void Form3_Load(object sender, EventArgs e)
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();
            string query = "select Staff_id,Forename from staff_details";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable Employee_list = new DataTable();

            da.Fill(Employee_list);

            cmbSelectEmployee.DataSource = Employee_list;

            cmbSelectEmployee.DisplayMember = "Forename";
            
            cmbSelectEmployee.ValueMember = "Staff_id";




        }




        




        // creates new login details for the employee selected
        public void btnCreateNewLogin_Click(object sender, EventArgs e)
        {
            int SelectedStaffid = Convert.ToInt32(cmbSelectEmployee.SelectedValue);
            string SelectedEmployeeForeName = cmbSelectEmployee.Text;
            lblSelectedStaff_id.Text = SelectedStaffid.ToString();
            lblSelectedStaff_id.Visible = false;
            cmbSelectEmployee.Text = SelectedEmployeeForeName;
            
            string new_password = txtNewPassword.Text;
            // method used to validate the password for format requirements
            PasswordValidator validator= new PasswordValidator();
            try
            {
                validator.ValidatePassword(new_password);

                //converting the password into salt and hash for secure SQL storage
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(new_password, salt);


                try
                {
                    Database_Config config = new Database_Config();
                    var c_string = config.get_ini();
                    MySqlConnection conn = new MySqlConnection(c_string);
                    conn.Open();
                    string query = "insert into staff_credentials(Employee_Username,Employee_Password_Salt,Employee_Password_Hash,Staff_id) values(@username,@passwordsalt,@passwordhash,@staffid)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", txtNewUsername.Text);
                    cmd.Parameters.AddWithValue("@passwordsalt", salt);
                    cmd.Parameters.AddWithValue("@passwordhash", hashedPassword);
                    cmd.Parameters.AddWithValue("@staffid", lblSelectedStaff_id.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Username and password created for the user");
                    }

                    else
                    {
                        MessageBox.Show("failed to create login credentials");
                    }

                    string query2 = $"select Email_Address from staff_details where Staff_id ={SelectedStaffid}";

                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    string emailAddress = cmd2.ExecuteScalar().ToString();

                    // Set the email address in the text box
                    txtEmailAddress.Text = emailAddress;

                    conn.Close();
                    



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }

            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        


            
            
            
            
            
        }

            
            



        


            





        //Environment.Exit(0);


        

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void lblCreateLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtRetypePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
