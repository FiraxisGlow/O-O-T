using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä6
{
    class Viina
    {
        private double volyme;
        private readonly double minvol = 0.1;
        private readonly double maxvol = 10.0;
        public double Volyme
        {
         get
            {
                return Volyme;
            }

            set
            {
                Volyme = volyme;
                if (volyme > maxvol) 
                Console.WriteLine("Tynnyristäkö sä juot?!?!?!?");
                else 
                Console.WriteLine("Sinulla on " + volyme + "l viinaa");
                if (volyme < minvol)
                    Console.WriteLine("Oletko toipuva alkoholisti");
                else
                    Console.WriteLine("Sinulla on" + volyme + "l viinaa");
            }
          }


    }
}
