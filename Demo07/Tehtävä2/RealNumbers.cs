using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class RealNumbers
    {
        public float Number2
        {
            get
            {
                return Number2;
            }
            set
            {
           string line = Console.ReadLine();
                float.Parse(line);
                
            }
        }

         
        //writing data to external file.
        static void WriteNumber()
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("RealNumbers.txt");
            outputFile.WriteLine();
            outputFile.Close();
        }

    }
}

    

