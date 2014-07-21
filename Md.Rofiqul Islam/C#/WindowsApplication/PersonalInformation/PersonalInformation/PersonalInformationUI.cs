using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class PersonalInformationUI : Form
    {
        public PersonalInformationUI()
        {
            InitializeComponent();
        }
        Person aPerson=new Person();

        private void showTextBox_Click(object sender, EventArgs e)
        {
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middlNameTextBox.Text;
            aPerson.lastName = lastnameTextBox.Text;

             fullNameTextBox.Text=  aPerson.GetFullName();
            reverseFullNameTextBox.Text = aPerson.GetReverseName();


        }
    }
}
