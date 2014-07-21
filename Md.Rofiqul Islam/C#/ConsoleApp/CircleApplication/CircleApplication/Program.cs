using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
           

            Console.WriteLine("enter the value of radius:");
            
         aCircle.radius =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of Area:"+  aCircle.Area(aCircle.radius));
            Console.WriteLine("enter the value of Area:" + aCircle.Diameter(aCircle.radius));
            Console.WriteLine("enter the value of Area:" + aCircle.Perimeter(aCircle.radius));
            Console.ReadKey();


        }

    }
}
