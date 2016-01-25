using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        private readonly int maxspeed = 200;
        // member field
        private int speed;
        //property
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxspeed) speed = value;

                else
                {
                    Console.WriteLine("Too much speed - set to max!");
                    speed = maxspeed;
                }
            }

        }

    }
}