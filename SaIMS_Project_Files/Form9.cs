using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NeaApp
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        // takes in seller's information and inserts it into the seller_info table ad also dispaly it in the datagridview
        private void btnAddSellerInfo_Click(object sender, EventArgs e)
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();

            string query = " insert into seller_info(Seller_name,Seller_address_line1,Seller_address_line2, Seller_city, Seller_state, Seller_pincode,Seller_Phone_number) values(@name,@addressline1,@addressline2,@city,@state,@pincode,@phonenumber)";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name",txtSellerName.Text);
            cmd.Parameters.AddWithValue("@addressline1", txtaddressLine1.Text);
            cmd.Parameters.AddWithValue("@addressline2", txtaddressLine2.Text);
            cmd.Parameters.AddWithValue("@city",txtSeller_city.Text);
            cmd.Parameters.AddWithValue("@state",txtSeller_state.Text);
            cmd.Parameters.AddWithValue("@pincode",txtSeller_Pincode.Text);
            cmd.Parameters.AddWithValue("@phonenumber",txtSellerPhoneNumber.Text);

            cmd.ExecuteNonQuery();

            txtSellerName.Clear();
            txtaddressLine1.Clear();
            txtaddressLine2.Clear();
            txtSeller_city.Clear();
            txtSeller_state.Clear();
            txtSeller_Pincode.Clear();
            txtSellerPhoneNumber.Clear();
            txtSellerName.Select();

            string query2 = "select seller_info.Seller_name, seller_info.Seller_address_line1 , seller_info.Seller_address_line2 , seller_info.Seller_city , seller_info.Seller_state , seller_info.Seller_pincode from seller_info";
            
            MySqlDataAdapter da = new MySqlDataAdapter(query2, c_string);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];

            
            conn.Close();
        }

        private void btntaketolandingage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
