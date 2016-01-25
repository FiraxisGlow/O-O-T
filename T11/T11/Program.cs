using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

              
            Console.Write("Anna luku: ");
            string input = Console.ReadLine();
            number = int.Parse(input);      //otetaan input talteen
            {
                for (int i = 0; i < number; i++)  //muunnetaan input tähdiksi uudelle riville tähti/rivi tyyliin
                    for (int o = 0; o < number; o++)
                    {

                        Console.Write("*");
                    }
                Console.Write("*\n");
            }
        }
    }
}
