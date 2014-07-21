using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }
        Employee anEmployee=new Employee();
        private void showMeSalary_Click(object sender, EventArgs e)
        {
            anEmployee.employeeName = employeeNameTextBox.Text;
            anEmployee.basicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
            anEmployee.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            anEmployee.medicalAllowace = Convert.ToDouble(medicalAllowanceTextBox.Text);
            anEmployee.GetSalary();


        }
    }
}
