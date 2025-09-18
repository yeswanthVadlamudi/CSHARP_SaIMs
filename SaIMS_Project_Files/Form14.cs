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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btnExecuteTransaction_Click(object sender, EventArgs e)
        {
            string Employee_name = cmbEmployeename.Text;

            string description = "Paid salary to" + " " + Employee_name;

            string category = "Salary";

            decimal amount = Convert.ToDecimal(txtSalaryamount.Text);

            amount = amount * -1;

            CashFlow cashFlow = new CashFlow();
            decimal Running_total = cashFlow.RunningTotal();
            if (Running_total > Convert.ToDecimal(txtSalaryamount.Text))
            {
                cashFlow.Outflow(description, category, amount);

            }

            else
            {
                MessageBox.Show("Dont have enough funds for this transaction", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            Database_Config config = new Database_Config();

            var c_string = config.get_ini();

            MySqlConnection conn = new MySqlConnection(c_string);
            conn.Open();

            string query = "select Forename, Staff_id from staff_details";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbEmployeename.DataSource = dt;

            cmbEmployeename.DisplayMember = "Forename";
            cmbEmployeename.ValueMember = "Staff_id";
            conn.Close();
        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form14_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
