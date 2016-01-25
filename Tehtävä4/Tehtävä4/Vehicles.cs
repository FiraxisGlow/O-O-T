/*
* Copyright (C) Anton Kiri
*
*
* Olio-ohjelmointi
*
*
* 11.02.16
* Anton Kiri
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä4
{
    class Vehicles
    {
        //properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //method
        public void PrintData()
        {
            Console.WriteLine("Car name: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Current Tyres: " + Tyres);

        }
        public override string ToString()
        {
            return "Car Name: " +Name + "Car Speed" + Speed + "Number of tyres: " + Tyres; 
        }


    }
}
