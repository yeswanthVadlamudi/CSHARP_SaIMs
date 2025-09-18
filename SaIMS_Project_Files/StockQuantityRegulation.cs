using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NeaApp
{
    internal class StockQuantityRegulation
    {
        public void AddStock(int product_id, int quantity)
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();

            string query2 = "Update inventory set Quantity = Quantity + @addquantity,Transaction_datetime = @transactiondatetime where Product_id = @productid";

            DateTime date = DateTime.Now;

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            MySqlParameter parameter = new MySqlParameter("@transactiondatetime", MySqlDbType.DateTime);
            parameter.Value = date;
            cmd2.Parameters.Add(parameter);
            cmd2.Parameters.AddWithValue("@addquantity", quantity);
            cmd2.Parameters.AddWithValue("@productid", product_id);



            int rowsaffected = cmd2.ExecuteNonQuery();

            if (rowsaffected == 0)
            {
                string query = "insert into inventory (Product_id, Quantity,Transaction_datetime) values (@productid, @addquantity,@transactiondatetime)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(parameter);
                cmd.Parameters.AddWithValue("@addquantity", quantity);
                cmd.Parameters.AddWithValue("@productid", product_id);
                cmd.ExecuteNonQuery();

            }


            conn.Close();
        }

        public void SellStock(int product_id, int quantity)
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();

            DateTime date = DateTime.Now;
            string query = "Update inventory set Quantity = Quantity - @addquantity where Product_id = @productid";

            MySqlCommand cmd2 = new MySqlCommand(query, conn);
            MySqlParameter parameter = new MySqlParameter("@transactiondatetime", MySqlDbType.DateTime);
            parameter.Value = date;
            cmd2.Parameters.Add(parameter);
            cmd2.Parameters.AddWithValue("@addquantity", quantity);
            cmd2.Parameters.AddWithValue("@productid", product_id);



            int rowsaffected = cmd2.ExecuteNonQuery();

            if (rowsaffected == 0)
            {
                string query2 = "insert into inventory (Product_id, Quantity,Transaction_datetime) values (@productid, @addquantity,@transactiondatetime)";
                MySqlCommand cmd = new MySqlCommand(query2, conn);
                cmd.Parameters.Add(parameter);
                cmd.Parameters.AddWithValue("@addquantity", quantity);
                cmd.Parameters.AddWithValue("@productid", product_id);
                cmd.ExecuteNonQuery();

            }


            conn.Close();


        }
    }
}
