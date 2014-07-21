using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultApp
{
    internal class Result
    {
        public double phyMarks;
        public double cheMarks;
        public double mathMarks;
        public double avgMarks;

        public double Avg()
        {
            avgMarks = (phyMarks + cheMarks + mathMarks)/3;
            return avgMarks;

        }

        public string GetResult()
        {
            if (phyMarks <= 50)
            {
                return "F";
            }
            else if (cheMarks<=50)
            {
                return "F";
            }
            else if (mathMarks <= 50)
            {
                return "F";
            }

        
            else if (avgMarks < 50)
            {
                return "F";

            }

            else if (avgMarks >= 80)
            {
                return "A+";

            }
            else if (avgMarks >= 70)
            {
                return "B+";

            }

            else if (avgMarks >= 60)
            {
                return "C+";

            }

            else if (avgMarks >= 50)
            {
                return "D+";

            }
            else
            {
                return "Invalid";
            }





        }
    }
}