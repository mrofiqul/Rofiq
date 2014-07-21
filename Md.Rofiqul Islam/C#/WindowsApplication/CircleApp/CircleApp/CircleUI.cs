using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class CircleUI : Form
    {
        public CircleUI()
        {
            InitializeComponent();
        }
        Circle aCircle=new Circle();

        private void areaButton_Click(object sender, EventArgs e)
        {
           GetRadius();
           double aArea= aCircle.Area();
            MessageBox.Show(@"The area of circle is: " + aArea);


        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
             GetRadius();
            double aPerimeter = aCircle.Perimeter();
            MessageBox.Show(@"The perimeter of circle is: " + aPerimeter);

        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
             GetRadius();
            double diameter = aCircle.Diameter();
            MessageBox.Show(@"The diameter of circle is: " + diameter);
        }

        private double GetRadius()
        {
            aCircle.radius = Convert.ToDouble(radiusTextBox.Text);
            return aCircle.radius;


        }
    }
}
