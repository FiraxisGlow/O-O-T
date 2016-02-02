using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;

            StreamWriter outputFile = new StreamWriter(@"d:\T1Lines.txt");

            do
            {
                Console.Write("Give text line: (enter ends) ");
                line = Console.ReadLine();
                    outputFile.WriteLine(line); //kirjoitetaan levylle
                
            } while (line.Length != 0);


            outputFile.Close();

            try {
                //avaa tiedosto
                string text = File.ReadAllText(@"d:\T1Lines.txt");
                //näytä sisältö
                Console.WriteLine(text);
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
