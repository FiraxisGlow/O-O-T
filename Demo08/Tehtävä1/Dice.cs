using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Dice
    {
        public int rndnumb;

        //heitto metodi
        public void Throw()
        {
            Random rnd = new Random();

            
            rndnumb = rnd.Next(1, 6);
            Console.WriteLine("You rolled: " + rndnumb);
          
          
        }
     
    }
}
