using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class WholeNumbers
    {
        public int Number
        {
            get
            {
                return Number;
            }
                set
                    {
             Console.ReadLine();
            }
        }


        //writing data to external file.
        static void WriteNumber()
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("WholeNumbers.txt");
            outputFile.WriteLine();
            outputFile.Close();
        }

    }
}
