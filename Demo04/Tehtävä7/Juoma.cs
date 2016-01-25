using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä7
{
    class Juoma
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Volyme { get; set; }

        public Water()
        {

        }

        public Water(string name, double volyme)
        {
            Name = name;
            Volyme = volyme;
        }
        public void PersonMethod()
        {
            Console.WriteLine("The drink is ready for consumption.");
        }

        public override string ToString()
        {
            return Name + " " + Volyme + "l ";

        }
    }
}
