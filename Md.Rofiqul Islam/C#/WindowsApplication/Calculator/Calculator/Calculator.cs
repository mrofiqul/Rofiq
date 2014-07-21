using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double result = 0.00;

        public double Add()
        {
            result = firstNumber + secondNumber;
            return result;



        }

        public double Sub()
        {
            if (firstNumber > secondNumber)
            {
                result = firstNumber - secondNumber;
                return result;
            }
            else
            {
                result = secondNumber - firstNumber;
                return result;
                
            }

        }

        public double Mul()
        {
            result = firstNumber*secondNumber;
            return result;



        }

        public double div()
        {
            if (firstNumber > secondNumber)
            {
                result = firstNumber/secondNumber;
                return result;
            }
            else
            {
                result = secondNumber/firstNumber;
                return result;
            }

        }
    }
}
