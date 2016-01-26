using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä7
{
    class Limu : Juoma
    {
     
            public string Sugar { get; set; }

            public Limsa()
            {
            }

            public Jaffa(string Name, string Volyme, string limu)
                : base(Name, Volyme)
            {
               Sugar = limu;
            }
            public void LimuMethod()
            {
                Console.WriteLine("Softdrink is ready for consumption.");
            }
            public override string ToString()
            {
                return base.ToString();
            }
        }
}
