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
using static System.Net.Mime.MediaTypeNames;

namespace NeaApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAddNewItems_Click(object sender, EventArgs e)
        {

        }

        public void Form5_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lblItemSeller_Click(object sender, EventArgs e)
        {

        }
        // this button event takes product name and product price from textbox and stores it in the database while also displaying them in the datagridview
        private void btnAddnewItems_Click(object sender, EventArgs e)
        {
            
            
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = "Insert into product_list(Product_name,Product_price) values(@product_name,@product_price)";
            MySqlCommand cmd1 = new MySqlCommand(query, conn);

            cmd1.Parameters.AddWithValue("@product_name", txtItemName.Text);
            cmd1.Parameters.AddWithValue("@product_price", txtItemPriceperPiece.Text);
            
            cmd1.ExecuteNonQuery();

            txtItemName.Clear();
            txtItemPriceperPiece.Clear();

            string query2 = "select product_list.Product_Name, product_list.Product_price from product_list";
            MySqlDataAdapter da = new MySqlDataAdapter(query2, c_string);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            // Set the product name column to 600 pixels
            dataGridView1.Columns["Product_name"].Width = 600;

            // Set the width of the product price column to 200 pixels
            dataGridView1.Columns["Product_price"].Width = 200;

            conn.Close();

            









        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        public void cmbSeller_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
    

