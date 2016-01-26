
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
            {
                // create engine
                Engine engine = new Engine { Power = "16000", Thrust = "5000", Size = "5" };

                //create a Spaceship
                SpaceShip spaceship = new SpaceShip { Name = "Saturn", Model = "V" };
                spaceship.AddEngines(engine); 
                spaceship.AddEngines(engine); 
                spaceship.AddEngines(engine); 
                spaceship.AddEngines(engine);
                spaceship.AddEngines(engine);
                spaceship.AddEngines(engine);
                spaceship.AddEngines(engine);
                spaceship.AddEngines(engine);

                Console.WriteLine(spaceship.ToString());
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

            }
        }
    }
}
