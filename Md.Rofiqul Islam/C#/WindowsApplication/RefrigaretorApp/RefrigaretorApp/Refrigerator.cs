using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigaretorApp
{
    class Refrigerator
    {
        public double maximumWeight;
        public double currentWeight=0.00;
        public double remainWeight=0.00;
        public int noOfItem;
        public double weightPerUnit;
        

        public double Add(double noOfItem, double weightPerUnit)
        {
            currentWeight += noOfItem*weightPerUnit;
            if (currentWeight <=maximumWeight )
            {
                return currentWeight;
                
            }
            else
            {
                throw new Exception();
            }
       

        }

        public double RemainWeight()
        {
            try
            {
                if (maximumWeight >= currentWeight)
                {
                    remainWeight = maximumWeight - currentWeight;
                    return remainWeight;
                }
                
            }
            catch (Exception)
            {
                
              
            }
            return Convert.ToDouble("");

        }
        

    }
}
