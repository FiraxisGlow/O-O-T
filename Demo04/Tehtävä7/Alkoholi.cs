using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä7
{
    class Alkoholi : Juoma
    {
        public string Strength { get; set; }


        public Student()
        {
        }

        public Student(string Name, string Volyme, string strength) 
            : base(Name, Volyme)
        {
            Strength = strength;
        }
        public void AlchoholMethod()
        {
            Console.WriteLine("Drink is cold.");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Strength;
        }
    }
}
