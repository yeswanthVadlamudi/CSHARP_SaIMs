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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnExecuteTransaction_Click(object sender, EventArgs e)
        {


            CashFlow cashFlow = new CashFlow();

            decimal Running_total = cashFlow.RunningTotal();
            if (Running_total > Convert.ToDecimal(txtAmount.Text))
            {
                if (cmbPaymentchoice.Text == "Rent")
                {
                    string description = "Shop rent";
                    string category = "Payments";
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    amount = amount * -1;


                    cashFlow.Outflow(description, category, amount);

                }

                if (cmbPaymentchoice.Text == "Electricity")
                {
                    string description = "Electricity bill ";
                    string category = "Payments";
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    amount = amount * -1;



                    cashFlow.Outflow(description, category, amount);

                }

                if (cmbPaymentchoice.Text == "Goods transport")
                {
                    string description = "Goods transport bill";
                    string category = "Payments";
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    amount = amount * -1;



                    cashFlow.Outflow(description, category, amount);

                }

            }
            
        }

        

        
    }
}
