using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        Calculator aCalculator=new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = "";
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
           double total= aCalculator.Add();
            resulttextBox.Text = total.ToString();
           

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = "";
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double total = aCalculator.Sub();
            resulttextBox.Text = total.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = "";
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double total = aCalculator.Mul();
            resulttextBox.Text = total.ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = "";
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double total = aCalculator.div();
            resulttextBox.Text = total.ToString();

        }
    }
}
