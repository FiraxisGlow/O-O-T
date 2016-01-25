using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create one car instance
            Car car = new Car();
            //  Console.WriteLine("FuzzyDices = " + car.FuzzyDice);
            // Console.WriteLine("Model = " + car.Model);
            car.Model = "Lambo";
            car.Color = "Red";
            car.Engine = 15.6;
            car.FuzzyDice = true;
            car.Speed = 15;
            car.PrintData();

            Car nascar = new Car("Toyota");
          //  Console.WriteLine("FuzzyDices = " + nascar.FuzzyDice);
            //Console.WriteLine("Model = " + nascar.Model);
            
            nascar.Color = "White";
            nascar.Engine = 7.3;
            nascar.FuzzyDice = true;
            nascar.Speed = 200;
            nascar.PrintData();
            nascar.Accelerate(50);
            nascar.PrintData();
           
         

            Console.ReadLine();

        }
    }
}
