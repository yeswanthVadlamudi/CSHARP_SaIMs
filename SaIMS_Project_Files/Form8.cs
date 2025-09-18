using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NeaApp
{
    public partial class Form8 : Form
    {
        public static decimal total_amount;
        public static List<int> ids = new List<int>();

        public Form8()
        {
            InitializeComponent();
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void btnPlace_purchase_order_Click(object sender, EventArgs e)
        {
            // creating an object for using the cash flow class' methods
            CashFlow cashFlow = new CashFlow();
            decimal Running_total = cashFlow.RunningTotal();
            total_amount = Convert.ToDecimal(lblAmount.Text);
            // checking if you have the money to make the purchase and you dont go below 0
            if (Running_total > 0 && Running_total > total_amount)
            {

                // the method used to update amount (increase) after purchase
                StockQuantityRegulation stock_manager = new StockQuantityRegulation();

                Database_Config config = new Database_Config();

                var c_string = config.get_ini();


                MySqlConnection conn = new MySqlConnection(c_string);
                conn.Open();

                DateTime date = DateTime.Now;
                try
                {


                    // runs until all the rows are covered
                    for (int i = 0; i < dataGridView5.Rows.Count; i++)
                    {


                        DataGridViewRow row = dataGridView5.Rows[i];


                        // to make sure the program doesnt loop through a null row
                        if (!row.IsNewRow)
                        {
                            int Product_id = (int)row.Cells["Product id"].Value;

                            int Quantity = (int)row.Cells["Quantity"].Value;

                            decimal PriceperProduct = (decimal)row.Cells["Total amount"].Value;

                            // since the company is buying products we need to update the quantity for the particular product
                            stock_manager.AddStock(Product_id, Quantity);

                            ids.Add(Product_id);
                            // to maintain a record in the cashflow table we need to know to whom the money has gone to, in this case "seller name"
                            string Seller_name = cashFlow.getSellerName(Product_id);
                            string description = "Stock purchase from" + " " + Seller_name;
                            // as money is exiting or theres is an outflow of money the value must be nagative
                            PriceperProduct = PriceperProduct * -1;

                            // the Sql statement to insert record for the transaction
                            string query = "insert into cash_flow(Transaction_date,Transaction_description,Transaction_category,Transaction_amount) values(@date,@description,@category,@amount)";

                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            MySqlParameter parameter = new MySqlParameter("@date", MySqlDbType.DateTime);
                            parameter.Value = date;
                            cmd.Parameters.Add(parameter);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@category", "Expense");
                            cmd.Parameters.AddWithValue("@amount", PriceperProduct);

                            cmd.ExecuteNonQuery();








                        }




                    }

                }

                catch (NullReferenceException ex)
                {
                    // Handle the null reference error
                    MessageBox.Show("Null reference error: {0}", ex.Message);
                }

                catch (Exception ex)
                {
                    // Handle any other errors
                    MessageBox.Show("Error:" + ex.Message);
                }

                conn.Close();

                MessageBox.Show("Transaction successful","Successful",MessageBoxButtons.OK,MessageBoxIcon.None);
            }

            else
            {
                MessageBox.Show("You only have" + " " + Running_total + " You dont have funds to purchase");
            }








        }









        private void Form8_Load(object sender, EventArgs e)
        {
            // creating the columns for the datagridview control
            dataGridView5.ColumnCount = 5;
            dataGridView5.Columns[0].Name = "Item";
            dataGridView5.Columns[1].Name = "Price";
            dataGridView5.Columns[2].Name = "Quantity";
            dataGridView5.Columns[3].Name = "Total amount";
            dataGridView5.Columns[4].Name = "Product id";

            // setting the column sizes
            dataGridView5.Columns["Item"].Width = 700;
            dataGridView5.Columns["Price"].Width = 200;
            dataGridView5.Columns["Quantity"].Width = 200;
            dataGridView5.Columns["Total amount"].Width = 400;
            dataGridView5.Columns["Product id"].Width = 50;
            dataGridView5.Columns["Product id"].Visible = false;
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();
            // getting the product id and product name from the Sql table
            string query = "Select Product_id, Product_name from product_list";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable products_table = new DataTable();

            da.Fill(products_table);
            //using the Sql data as the source of the dropdown list
            cmbOrderSelection.DataSource = products_table;
            cmbOrderSelection.DisplayMember = "Product_name";
            cmbOrderSelection.ValueMember = "Product_id";

            conn.Close();
        }
        private decimal cumulativeTotalPrice = 0.00M;


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // cant have null quantity
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    throw new ArgumentException("Field required cannot be left empty");
                }
                else
                {

                }

                string pattern = @"^\d+$";
                Regex regex = new Regex(pattern);

                // Check if the quantity input matches the pattern
                if (!regex.IsMatch(txtQuantity.Text))
                {
                    txtQuantity.Clear();
                    txtQuantity.Select();
                    throw new ArgumentException("Format error: Integer values only");

                }
                else
                {

                }
                // checking if the quantity is 0 
                if (Convert.ToInt32(txtQuantity.Text) == 0)
                {
                    txtQuantity.Clear();
                    txtQuantity.Select();
                    throw new ArgumentException("Quantity cannot be 0");




                }
                // picks up the id for the selected product name
                int Selectedproductid = Convert.ToInt32(cmbOrderSelection.SelectedValue);
                Database_Config config = new Database_Config();

                var c_string = config.get_ini();

                MySqlConnection conn = new MySqlConnection(c_string);

                conn.Open();
                // selecting the price for the specific product name selected using id
                string query2 = "Select Product_price from product_list where Product_id = @productid";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);

                cmd2.Parameters.AddWithValue("@productid", Selectedproductid);
                // the price of the selected product
                decimal price = Convert.ToDecimal(cmd2.ExecuteScalar());
                string products_name = cmbOrderSelection.Text;

                int quantity = Convert.ToInt32(txtQuantity.Text);

                // the total money you will have to spend on that product
                decimal totalpriceperproduct = price * quantity;

                dataGridView5.Rows.Add(products_name, price, quantity, totalpriceperproduct, Selectedproductid);


                // as more products are added the total bill to pay will add up
                cumulativeTotalPrice += totalpriceperproduct;

                // Update the label with the cumulative total price
                lblAmount.Text = cumulativeTotalPrice.ToString();



                // hidden label to capture the id of the selected product
                lblOrderSelection.Text = Selectedproductid.ToString();
                lblOrderSelection.Visible = false;

                cmbOrderSelection.Text = products_name;




            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }











        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                // Get the value of the selected row
                decimal rowValue = Convert.ToDecimal(dataGridView5.SelectedRows[0].Cells["Total amount"].Value);

                // Remove the selected row from the DataGridView
                dataGridView5.Rows.Remove(dataGridView5.SelectedRows[0]);

                // Get the current total bill


                // Subtract the row value from the total bill
                cumulativeTotalPrice -= rowValue;

                // Update the label with the new total bill
                lblAmount.Text = cumulativeTotalPrice.ToString();
            }

        }

        private void lblOrderSelection_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProduct_name_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
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

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView5.Columns["Item"].Index && e.RowIndex >= 0)
            {
                // Select the clicked row
                dataGridView5.Rows[e.RowIndex].Selected = true;
            }
        }







    }
}
