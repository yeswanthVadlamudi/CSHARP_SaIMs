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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace NeaApp
{
    public partial class Form15 : Form
    {
        
        public Form15()
        {
            InitializeComponent();
        }

        

        private void btnCompareprices_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductSelection.SelectedIndex >=0)
                {
                    MessageBox.Show("Please wait while we bring the information to you", "Please don't close the window", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Database_Config config = new Database_Config();

                    var c_string = config.get_ini();

                    MySqlConnection conn = new MySqlConnection(c_string);

                    conn.Open();
                    // retrieve the selected product name from the ComboBox
                    string selectedProduct = cmbProductSelection.Text;

                    string filePath = @"C:\\Users\\User\\Documents\\Visual Studio 2022\\projects\\NeaApp\\Product_links.txt";

                    File.WriteAllText(filePath, "");
                    // create a SQL query to retrieve all records for the selected product name
                    string query = "SELECT product_urls FROM product_links where Product_name = @product_name";

                    // create a command object and add the selected product name as a parameter
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@product_name", selectedProduct);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string productUrl = reader.GetString(0);

                        File.AppendAllText(filePath, productUrl + "\n");


                    }
                    reader.Close();
                   

                    // Start the Python script in a new process

                    ProcessStartInfo start = new ProcessStartInfo();
                    start.FileName = "C:\\Program Files\\Python310\\python.exe";
                    start.Arguments = "C:\\Users\\User\\Documents\\Python_projects\\Web_Scraping_prototype.py";
                    start.CreateNoWindow = true;
                    start.WindowStyle = ProcessWindowStyle.Hidden;

                    // Start the process
                    Process process = new Process();
                    process.StartInfo = start;
                    process.Start();

                    process.WaitForExit();



                    string filepath2 = "C:\\Users\\User\\Documents\\Visual Studio 2022\\projects\\NeaApp\\result.txt";









                    // Read the data from the file and add it to the DataTable
                    using (StreamReader rdr = new StreamReader(filepath2))
                    {
                         
                        while (!rdr.EndOfStream)
                        {
                            // Read the product name from the current line
                            string productName = rdr.ReadLine();

                            // Read the price from the next line
                            string price = rdr.ReadLine();

                            // Add a new row to the datagridview 
                            dataGridView1.Rows.Add(productName, price);
                        }
                    }

                    string query2 = "SELECT Product_id FROM product_links WHERE Product_name = @productname";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@productname", selectedProduct);
                    MySqlDataReader mySqlDataReader = cmd2.ExecuteReader();

                    List<int> ids = new List<int>();
                    while (mySqlDataReader.Read())
                    {
                        int id = mySqlDataReader.GetInt32(0);
                        ids.Add(id);
                    }
                    mySqlDataReader.Close();
                    int count = 0;
                    foreach (int id in ids)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            string query3 = "UPDATE product_list SET Product_name = @productName, Product_price = @productprice WHERE Product_id = @id";
                            MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                            cmd3.Parameters.AddWithValue("@productName", dataGridView1.Rows[count].Cells[0].Value.ToString());
                            cmd3.Parameters.AddWithValue("@productprice", dataGridView1.Rows[count].Cells[1].Value);
                            cmd3.Parameters.AddWithValue("@id", id);
                            cmd3.ExecuteNonQuery();
                            count++;
                        }
                    }

                    conn.Close();





                }

                else
                {
                    throw new ArgumentException("Please select an option!");

                }
            }


            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
            

            
            
           




        }

        private void Form15_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Product name";
            dataGridView1.Columns[1].Name = "Price";

            dataGridView1.Columns[0].Width = 570;
            dataGridView1.Columns[1].Width = 170;
            
            Database_Config config = new Database_Config();

            var c_string =  config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = "SELECT DISTINCT Product_name FROM product_links ";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbProductSelection.Items.Add(reader["Product_name"]);
            }

            // close the reader and connection
            reader.Close();
            conn.Close();
        }




    }
}
