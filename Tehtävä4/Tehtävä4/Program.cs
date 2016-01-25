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
    class Program
    {
        static void Main(string[] args)
        {

            Vehicles car = new Vehicles();
            car.Name = "Lada";
            car.Speed = 80;
            car.Tyres = 4;
            car.PrintData();
            Console.WriteLine(car.ToString());
            Console.ReadLine();

     
    }
    }
}
