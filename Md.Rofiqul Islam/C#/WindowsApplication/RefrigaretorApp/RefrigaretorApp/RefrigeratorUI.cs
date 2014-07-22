using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigaretorApp
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        Refrigerator aRefrigerator=new Refrigerator();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.maximumWeight = Convert.ToDouble(maximumWeightTextBox.Text);
            MessageBox.Show(@"The maximum weight is counted");


        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.noOfItem = Convert.ToInt16(noOfItemTextBox.Text);
            aRefrigerator.weightPerUnit = Convert.ToDouble(weightPerUnitTextBox.Text);
            try
            {
                double presentWeight = aRefrigerator.Add(aRefrigerator.noOfItem, aRefrigerator.weightPerUnit);
                double remainweight = aRefrigerator.RemainWeight();
                currentWeightTextBox.Text = presentWeight.ToString();
                remainWeightTextBox.Text = remainweight.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("overflow");
            }
             

        }
    }
}
