using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dice dice = new Dice();
            int x;
            int y = 0;
            double avg;
            int[] numbers = new int[7];

            Console.WriteLine("How many times do you want to throw?");
            
            x = int.Parse(Console.ReadLine());


            //rollataan käyttäjän määrän mukaan
            for (int i = 0; i <= x; i++)
            {
                dice.Throw();
               
                //otetaan talteen numerot keskiarvoa varten
                y = (y + dice.rndnumb);
                numbers[dice.rndnumb]++;
            }
            avg = y / x; //keskiarvo

            for(int i = 1; i <= 6; i++)
            {
                Console.WriteLine( i + " occurred " + numbers[i] + "" );
            }

                Console.WriteLine("Avarage is: " + avg + "\nYou have rolled " + x + "times.");



        }
    }
}
