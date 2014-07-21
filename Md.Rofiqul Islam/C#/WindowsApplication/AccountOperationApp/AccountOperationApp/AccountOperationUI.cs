using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }
        Account anCustomer=new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            anCustomer.anAccountNumber = accountNumberTextBox.Text;
            anCustomer.cutomerName = customerNameTextBox.Text;
            accountNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
            anCustomer.CreateAccount();
            
         


        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != "")
            {
                anCustomer.deposit = anCustomer.deposit + Convert.ToDouble(amountTextBox.Text);

                amountTextBox.Text = "";
                anCustomer.Deposit();
            }
            else
            {
                MessageBox.Show(@"please enter yyour amount");
            }


        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if(amountTextBox.Text!="")
            {
                anCustomer.withdraw = Convert.ToDouble(amountTextBox.Text);
               
                anCustomer.Withdraw();
                
            }
            else
            {
                //label3.Text = anCustomer.deposit.ToString();
            }
            amountTextBox.Text = "";



        }

        private void reportButton_Click(object sender, EventArgs e)
        {

           anCustomer.Report();
           
          //  label3.Text = anCustomer.balance.ToString();

        }

       
    }
}
