using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
 public class Account
 {
     public string anAccountNumber;
     public string cutomerName;
     public double balance = 0.00;
     public double deposit;
     public double withdraw;
      public void CreateAccount()
      {

          MessageBox.Show(cutomerName+@" "+@"your Account is Succesfully created!");

      }
 public void Deposit()
 {
     MessageBox.Show(@"Your amount "+@"  "+ +deposit+@" " + @"deposited");

 }

     public void Withdraw()
     {
         if (withdraw < deposit)
         {
             balance = deposit - withdraw;
             deposit = balance;

             MessageBox.Show(@"Your transaction is succesfully completed! ");
         }
         else
         {
             MessageBox.Show("Insufficiant balance");
         }
     }

  public void Report()
     {
        balance = deposit;

      MessageBox.Show(cutomerName + @", " + @"your accountnumber is: " + @"  " + anAccountNumber + @"  " + @"and its balance " +balance + @"  " + @"taka");


     }


 }

    

}
