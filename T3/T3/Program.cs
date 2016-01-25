using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {

            float number1, number2, number3;
            
                
            Console.Write("Anna 3 lukua: ");

            string N1 = Console.ReadLine();

            number1 = int.Parse(N1);

            string N2 = Console.ReadLine();

            number2 = int.Parse(N2);

            string N3 = Console.ReadLine();

            number3 = int.Parse(N3);

            Console.WriteLine("Numeroiden keskiarvo on: " + (number1 + number2 + number3 )/3 );


        }
    }
}
