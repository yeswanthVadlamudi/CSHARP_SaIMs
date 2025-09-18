using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace NeaApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        // takes the user to landing page where the form will take in new employee's details
        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void btnAddStockItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void btnComparePrices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTakeInStockOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void btnSeller_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9(); 
            form9.Show();
        }

        private void btnCreateProductcatalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void btnSetNewLoginDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnAdminCredentials_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form11 =  new Form11();
            form11.Show();
        }

        private void btnDepositWithdrawalbalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();

        }

        private void lblAdminSignedInPage_Click(object sender, EventArgs e)
        {

        }
        // shows the products name and the current quantity of the all the products
        private void Form2_Load(object sender, EventArgs e)
        {
            
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();

            string query = "select inventory.Quantity,product_list.Product_name from inventory join product_list on inventory.Product_id = product_list.Product_id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource= dt;
            dataGridView1.Columns[0].Width = 500;
            dataGridView1.Columns[1].Width = 1000;

            // Iterate through all rows in the DataGridView

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Get the stock quantity of the current row
                    int stockQuantity = Convert.ToInt32(row.Cells[0].Value);

                    // Check if the stock quantity is less than or equal to 80
                    if (stockQuantity <= 80)
                    {
                        // Set the background color of the quantity cell to red
                        row.Cells[0].Style.BackColor = Color.Red;

                        // Set the font color of the quantity cell to white
                        row.Cells[0].Style.ForeColor = Color.White;

                        // Set the font of the quantity cell to bold
                        //row.Cells[0].Style.Font = new Font(row.Cells[0].Style.Font, FontStyle.Bold);
                    }

                }
                
            }

            conn.Close();

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 form14 = new Form14();
            form14.Show();
        }

        
    }
}
