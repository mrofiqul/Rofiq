using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    class Employee
    {
        public string employeeName ;
        public double basicSalary;
        public double houseRent;
        public double medicalAllowace;
        public double totalSalary = 0.00;

      
        public double HouseRent()
        {
            houseRent = (houseRent*basicSalary)/100;
            return houseRent;

        }

        public double MedicalAllowance()
        {
            medicalAllowace = (medicalAllowace*basicSalary)/100;
            return medicalAllowace;

        }

        public double GetSalary()
        {
            totalSalary += basicSalary + HouseRent() + MedicalAllowance();
            MessageBox.Show(@"your total alary is : " + totalSalary+"\n House Rent:"+HouseRent()+"\n Medical Allowance:"+MedicalAllowance());
            return 0;
        }


    }
}
