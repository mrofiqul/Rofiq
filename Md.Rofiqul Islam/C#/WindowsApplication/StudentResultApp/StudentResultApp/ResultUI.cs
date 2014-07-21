using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultApp
{
    public partial class ResultUI : Form
    {
        Result aResult = new Result();
        public ResultUI()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            aResult.phyMarks = Convert.ToDouble(physicsTextBox.Text);
            aResult.cheMarks = Convert.ToDouble(chemistryTextBox.Text);
            aResult.mathMarks = Convert.ToDouble(mathTextBox.Text);
            double avg = aResult.Avg();
            averageTextBox.Text = avg.ToString();

            string grade = aResult.GetResult();
            gradeTextBox.Text = grade;


        }
       //public void GetValue()
       //  {
             
           

       //  }

       
    }
}
