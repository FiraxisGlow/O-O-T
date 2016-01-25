using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    class Heater
    {
        //properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        //method prints heater data
        public void PrintData()
        {
            Console.WriteLine("Heater:");
            Console.WriteLine("Is on " + IsOn);
            Console.WriteLine(" - Temperature: {0} Humidity {1}" ,Temperature,Humidity);
            
        }
        //method returns heater data
        public override string ToString()
        {
            return "Temperature : " + Temperature + " Humidity : " + Humidity + "Is on: " + IsOn;
        }

    }
}
