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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnExecuteTransaction_Click(object sender, EventArgs e)
        {
            CashFlow cashFlow = new CashFlow();
            decimal running_total = cashFlow.RunningTotal();
            try
            {
                // if the chosen choice in the dropdown list is withdrawls
                if (cmbtransactionChoices.Text == "Withdrawals" | cmbtransactionChoices.Text == "withdrawals")
                {   
                    if(running_total > Convert.ToDecimal(txtAmount.Text))
                    {
                        string description = "Withdrawing money";
                        string category = "Withdrawal";
                        decimal amount = Convert.ToDecimal(txtAmount.Text);
                        amount = amount * -1;

                        cashFlow.Outflow(description, category, amount);
                    }

                    else
                    {
                        throw new ArgumentException("Do not have enough funds to withdraw");
                    }




                    
                }

                

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            try
            {
                // if the chosen choice in the dropdown list is deposit
                if (cmbtransactionChoices.Text == "Deposit" | cmbtransactionChoices.Text == "deposit")
                {
                    string description = "Funds deposit";
                    string category = "Deposit";
                    decimal amount = Convert.ToDecimal(txtAmount.Text);



                    cashFlow.Inflow(description, category, amount);

                }

                else
                {

                }

            }

            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

            
            
            

        }
        // check balance
        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            // the object has been created for the cash flow class
            CashFlow cashFlow = new CashFlow();

            decimal balance = cashFlow.RunningTotal();

            lblBalanceAmount.Text = balance.ToString();
        }

        private void btnCloseandOpenMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
