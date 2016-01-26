using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            // create tyres
            Tyres tyre = new Tyres { Name = "Nokia", Model ="Hakkpaeliitta", Size = "205R16" };

            //create a car
            Vehicle car = new Vehicle { Name = "Honda", Model = "Accord" };
            car.AddTyre(tyre); // car contains tyres...
            car.AddTyre(tyre); // car contains tyres...
            car.AddTyre(tyre); // car contains tyres...
            car.AddTyre(tyre); // car contains tyres...

            Console.WriteLine(car.ToString());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
