using MySql.Data.MySqlClient;
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
using BCrypt.Net;

namespace NeaApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

       
        

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // will allow user to see the password in text when the checkbox is ticked and turn it back to dots when it is checked of
            if(chkShowPassword.Checked)
            {
                txtTypeNewPassword.UseSystemPasswordChar= false;
            }

            else
            {
                txtTypeNewPassword.UseSystemPasswordChar = true;
            }

        }

        private void chkShowPasswordRetype_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chkShowPasswordRetype.Checked)
            {
                txtRetypeNewPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txtRetypeNewPassword.UseSystemPasswordChar = true;
            }
        }

        

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // this value is the username whose password will be changed
            string username = Form1.setvalue;
            // new password
            string newPassword = txtTypeNewPassword.Text;
            
            try
            {
                // checks if the the retyped password matches the new password
                if (txtRetypeNewPassword.Text != txtTypeNewPassword.Text)
                {
                    txtTypeNewPassword.Clear();
                    txtRetypeNewPassword.Clear();
                    txtTypeNewPassword.Select();
                    throw new ArgumentException("Both password dont match please try again.");
                    
                }
                else
                {
                    // checks if the password meets the format requirements
                    PasswordValidator validator = new PasswordValidator();
                    validator.ValidatePassword(txtTypeNewPassword.Text);
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string HashPassword = BCrypt.Net.BCrypt.HashPassword(newPassword, salt);

                    
                    Database_Config config = new Database_Config();

                    

                    var c_string = config.get_ini();

                    MySqlConnection conn = new MySqlConnection(c_string);
                    conn.Open();
                    string query = "Update admin_credentials set admin_password_salt = @salt, admin_password_hash = @hash where admin_username = @username";


                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@salt", salt);
                    cmd.Parameters.AddWithValue("@hash", HashPassword);
                    cmd.Parameters.AddWithValue("@username", username);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Update Successful");
                    Environment.Exit(0);


                }

            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
