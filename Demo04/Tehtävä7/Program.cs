using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä7
{
    class Program
    {
        static void Main(string[] args)
        {
            Juoma drink = new Juoma();
            drink.Name = "BonAqua";
            drink.Volyme = 0.5;          
            Console.WriteLine(drink.ToString());

            Alkoholi alcohol = new Alkoholi("Karhu", 0.33, "4,5%");
            Console.WriteLine(alcohol.ToString());

            

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();


        }
    }
}
