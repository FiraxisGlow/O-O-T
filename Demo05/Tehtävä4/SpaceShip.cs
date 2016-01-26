
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
    class SpaceShip
    {
        public string Name { get; set; }
        public string Model { get; set; }


        public List<Engine> Engines { get; }
        public SpaceShip() //Constructor
        {
            Engines = new List<Engine>();
        }

        public void AddEngines(Engine engine)
        {
            Engines.Add(engine);
        }

        public override string ToString()
        {
            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + " Tyres:\n: ";
            foreach (Engine engine in Engines)
            {
                sVehicle += engine.ToString() + "\n";
            }
            return sVehicle;
        }


    }
}
