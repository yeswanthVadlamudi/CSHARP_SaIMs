using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NeaApp
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        
        // here the product name and seller name as are retrieved from the respective SQL tables
        private void Form10_Load(object sender, EventArgs e)
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = ("Select product_list.Product_id,product_list.Product_name from product_list");

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable product_table = new DataTable();

            da.Fill(product_table);

            cmbProductlist.DataSource = product_table;

            cmbProductlist.DisplayMember = "Product_name";
            cmbProductlist.ValueMember = "Product_id";

            cmd.ExecuteNonQuery();

            string query2 = "Select seller_info.Seller_id, seller_info.Seller_name from seller_info";

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);

            DataTable seller_table = new DataTable();
            da2.Fill(seller_table);

            cmbSeller_name.DataSource = seller_table;

            cmbSeller_name.DisplayMember = "Seller_name";
            cmbSeller_name.ValueMember = "Seller_id";

            cmd2.ExecuteNonQuery();

            string query3 = "Select product_list.Product_price from product_list where Product_name= @productname";


            MySqlCommand cmd3  = new MySqlCommand(query3, conn);
            cmd3.Parameters.AddWithValue("@productname", cmbSeller_name.DisplayMember);

            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);

            DataTable price_table = new DataTable();

            da3.Fill(price_table);

            
            

            conn.Close();



            
        }
        //creates a product catalog by referencing product and sellers table to make a new table that specifies which seller sells which item.
        private void btnAddnewItems_Click(object sender, EventArgs e)
        {
            int selected_product_id = Convert.ToInt32(cmbProductlist.SelectedValue);

            string product_name = cmbProductlist.Text;

            int selected_seller_id = Convert.ToInt32(cmbSeller_name.SelectedValue);

            string seller_name = cmbSeller_name.Text;

            lblSelectedProduct_id.Text = selected_product_id.ToString();
            lblSelectedSeller_id.Text = selected_seller_id.ToString();

            lblSelectedSeller_id.Visible = false;
            lblSelectedProduct_id.Visible = false;

            cmbProductlist.Text = product_name;
            cmbSeller_name.Text = seller_name;

            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = ("insert into catalog(Product_id,Seller_id) values(@product_id,@seller_id)");

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@product_id",lblSelectedProduct_id.Text);
            cmd.Parameters.AddWithValue("@seller_id",lblSelectedSeller_id.Text);

            cmd.ExecuteNonQuery();

            string query2 = "select catalog.Catalog_id, product_list.Product_name,product_list.Product_price,seller_info.Seller_name from catalog join product_list on catalog.Product_id = product_list.Product_id join seller_info on catalog.Seller_id = seller_info.Seller_id order by product_list.Product_name ";

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            
            MySqlDataAdapter da = new MySqlDataAdapter(cmd2);

            DataTable dt = new DataTable();

            da.Fill(dt);
            
            dataGridView3.DataSource= dt;
            cmd2.ExecuteNonQuery();

            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSelectedProduct_id_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
