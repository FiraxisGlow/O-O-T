using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle : Tyres
    {
        public string Name { get; set; }
        public string Model { get; set; }

        
        public List<Tyres> Tyre { get; }
        public Vehicle() //listan konstruktori
        {
            Tyre = new List<Tyres>();
        }
        
        public void AddTyre(Tyres tyre)
        {
            Tyre.Add(tyre);
        }

        public override string ToString()
        {
            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + " Tyres:\n: ";
            foreach(Tyres tyre in Tyre)
            {
                sVehicle += tyre.ToString() + "\n";
            }
            return sVehicle;
        }


    }
}
