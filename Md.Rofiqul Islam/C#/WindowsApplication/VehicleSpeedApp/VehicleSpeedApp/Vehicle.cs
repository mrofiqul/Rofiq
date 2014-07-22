using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedApp
{
    class Vehicle
    {
        public string vehicleName;
        public string regNo;
        public double speed;
        public double minSpeed=0.00;
        public double maxSpeed=0.00;
        public double avgSpeed;
        public int numberOfSpeed = 0;
        public double sumOfSpeed = 0.00;

        public string CreateVehicle()
        {
            return "Your Vehicle created";
        }

        public int NumberOfSpeed()
        {
            numberOfSpeed++;
            return numberOfSpeed;
        }

        public double SumOfSpeed()
        {
            sumOfSpeed +=  speed;

            return sumOfSpeed;
        }
        public string Speed()
        {
            return "Your vehicle speed is increased succesfully!";
        }
       
        public double MinSpeed()
        {
            if (numberOfSpeed == 1)
            {
                minSpeed = speed;
               
            }
            
                if (speed<=minSpeed)
                {
                    minSpeed = speed;
                }
                
        
            return minSpeed;


        }

        public double MaxSpeed()
        {
            if (numberOfSpeed == 1)
            {
                maxSpeed = speed;

            }
            
                if (speed >= maxSpeed)
                {
                    maxSpeed= speed;
                }
               
            return maxSpeed;


        }

        public double AvgSpeed()
        {
            avgSpeed = sumOfSpeed/numberOfSpeed;
            return avgSpeed;

        }

    }
}
