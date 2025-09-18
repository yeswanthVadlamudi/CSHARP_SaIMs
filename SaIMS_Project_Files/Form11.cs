using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeaApp
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        // the main is to create new credentials for admins
        private void btnCreateNewAdminLogin_Click(object sender, EventArgs e)
        {
            string admin_username = txtNewAdminUsername.Text;
            string admin_password = txtNewAdminPassword.Text;
            // salting and hashing done here using Bcrypt nuget package
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(admin_password, salt);

            Database_Config config= new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = "insert into admin_credentials(admin_username,admin_password_salt,admin_password_hash) values(@username,@passwordsalt,@passwordhash)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username",txtNewAdminUsername.Text);
            cmd.Parameters.AddWithValue("@passwordsalt", salt);
            cmd.Parameters.AddWithValue("@passwordhash", hashedPassword);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
