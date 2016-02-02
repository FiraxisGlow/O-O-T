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
            bool luku3;
            bool luku4;
            //adding outputfiles.
            StreamWriter outputFile2 = new StreamWriter(@"d:\T2Int.txt");
            StreamWriter outputFile1 = new StreamWriter(@"d:\T2Float.txt");


            //Figuring if number is int or float
            Console.Write("Give a number: ");
            line = Console.ReadLine();
            do {
                int luku;
                luku3 = int.TryParse(line, out luku);
                if (luku3 == true)
                {
                    outputFile1.WriteLine(luku);
                }
            } while (luku3 == false );

            do
            {
                float luku2;
             luku4 =   float.TryParse(line, out luku2);
                if (luku4 == true)
                {
                    outputFile2.Write(luku2);
                }
            } while (luku4 == false );
            
           try
            {
                //avataan tiedosto
                string text1 = File.ReadAllText(@"d:\T2Int.txt");
                string text2 = File.ReadAllText(@"d:\T2Float.txt");
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

        }
    }
}