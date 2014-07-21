using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class Circle
    {
        public double radius;
        private const double PI = 3.1416;
       

        public double Area(double radius)
        {

            return PI * radius * radius;

        }

        public double Diameter(double radius)
        {
        
            return 2 * radius;

        }

        public double Perimeter(double radius)
        {
    
            return 2 * PI * radius;
        }
    }
}
