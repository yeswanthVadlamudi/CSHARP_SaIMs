using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NeaApp
{
    internal class CashFlow
    {
        public string getSellerName(int ProductId)
        {
            Database_Config config= new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = "SELECT catalog.Seller_id FROM catalog WHERE catalog.Product_id = @Productid";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Productid", ProductId);


            int Seller_id = Convert.ToInt32(cmd.ExecuteScalar());

            string query2 = "SELECT seller_info.Seller_name FROM seller_info WHERE seller_info.Seller_id =@sellerid";

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);



            cmd2.Parameters.AddWithValue("@sellerid", Seller_id);
            string Seller_name = cmd2.ExecuteScalar().ToString(); 
            
            conn.Close();

            return Seller_name;
        }


        public void Inflow(string description, string category, decimal amount)
        {
            //string description = "";
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            DateTime date = DateTime.Now;

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();
            string query = "insert into cash_flow(Transaction_date, Transaction_description, Transaction_category, Transaction_amount) values(@date, @description, @category, @amount)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlParameter parameter = new MySqlParameter("@date", MySqlDbType.DateTime);
            parameter.Value = date;
            cmd.Parameters.Add(parameter);
            cmd.Parameters.AddWithValue("@description", description );
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@amount", amount);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("error");
;            }

            conn.Close();

        }

        public void Outflow(string description, string category, decimal amount)
        {
            //string description = "";
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            DateTime date = DateTime.Now;

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();
            string query = "insert into cash_flow(Transaction_date, Transaction_description, Transaction_category, Transaction_amount) values(@date, @description, @category, @amount)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlParameter parameter = new MySqlParameter("@date", MySqlDbType.DateTime);
            parameter.Value = date;
            cmd.Parameters.Add(parameter);
            cmd.Parameters.AddWithValue("@description", description );
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@amount", amount);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("error");
                
            }

            conn.Close();

        }


        public decimal RunningTotal()
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);

            conn.Open();

            string query = "select SUM(Transaction_amount) from cash_flow";

            MySqlCommand cmd = new MySqlCommand(query,conn);

            decimal Running_Total = Convert.ToDecimal(cmd.ExecuteScalar());

            conn.Close() ;
            return Running_Total;
            


        }
    }

    
}
