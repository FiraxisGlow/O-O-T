using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = null;
            //adding outputfiles.
            StreamWriter outputFile2 = new StreamWriter(@"d:\T2Int.txt");
            StreamWriter outputFile1 = new StreamWriter(@"d:\T2Float.txt");


            //Figuring if number is int or float
            Console.Write("Give a number: ");
            line = Console.ReadLine();
            do {
                int luku;
                int.TryParse(line, out luku);
            } while (!line.Equals = );

            do
            {
                float luku2;
                float.TryParse(line, out luku2);
            } while (!line.Equals = );
            
           

        }
    }
}