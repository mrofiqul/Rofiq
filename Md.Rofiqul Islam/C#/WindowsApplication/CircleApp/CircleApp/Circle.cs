using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radius;
        private const double PI = 3.1416;
        public double area;
        public double perimeter;
        public double diameter;

        public double Area()
        {
            area = PI*radius*radius;
            return area;

        }

        public double Diameter()
        {
            area = 2*radius;
            return area;

        }

        public double Perimeter()
        {
            perimeter = 2*PI*radius;
            return perimeter;
        }
    }
}
