using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagement
{
    public partial class CustomerQueueManagementUI : Form
    {
        public CustomerQueueManagementUI()
        {
            InitializeComponent();
        }
        
        Queue<Customer>aqQueue=new Queue<Customer>();
        int serial = 0;
        
        private void ebQueueButton_Click(object sender, EventArgs e)
        {
            if(nameEnTextBox.Text!=""&&complainEnTextBox.Text!="")
            {
                serial++;
                Customer cusCustomer = new Customer();
                cusCustomer.serialNo = serial;
                cusCustomer.name = nameEnTextBox.Text;
                cusCustomer.complain = complainEnTextBox.Text;

                aqQueue.Enqueue(cusCustomer);

                ListViewItem aViewItem = new ListViewItem();
                aViewItem.Text = cusCustomer.serialNo.ToString();
                aViewItem.SubItems.Add(cusCustomer.name);
                aViewItem.SubItems.Add(cusCustomer.complain);

                waitListView.Items.Add(aViewItem);
                nameEnTextBox.Text = "";
                complainEnTextBox.Text = "";
            }
            else
            {
                MessageBox.Show(@"please enter customer name and complain");
            }





        }

        private void deQueueButton_Click(object sender, EventArgs e)
        {

            if (aqQueue.Count == 0)
            {
                MessageBox.Show("No more customer");
                serialDequeueTextBox.Text = "";
                nameDequeueTextBox.Text = "";
                complainDequeueTextBox.Text = "";
                return;
            }
            Customer cusCustomer = new Customer();
            cusCustomer = aqQueue.Dequeue();
            serialDequeueTextBox.Text = cusCustomer.serialNo.ToString();
            nameDequeueTextBox.Text = cusCustomer.name;
            complainDequeueTextBox.Text = cusCustomer.complain;
            
            //ListViewItem aViewItem = new ListViewItem();

            waitListView.Items.RemoveAt(0);

            //foreach ( Class1 acustomer in aqQueue)
            //{

              
            //    aViewItem.Text = acustomer.serialNo.ToString();
            //    aViewItem.SubItems.Add(acustomer.name);
            //    aViewItem.SubItems.Add(acustomer.complain);

                
            //    waitListView.Items.Add(aViewItem);
            //   //waitListView.Items.RemoveAt(0);
                
            //}

        }

        
        
    }
}
