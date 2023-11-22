using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_2023
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Year
        {
            get { return year; }
            // set { year = value; }
            set
            {
                if(value<1980)
                {
                    throw new Exception("Please pass a correct value");

                }
                else
                {
                    year= value;
                }
            }
        }


        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }

        public Car(string nameName)
        {
            name = nameName;
        }

        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at the speed of" + maxSpeed);
        }
    }
}
