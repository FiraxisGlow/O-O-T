using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program.Main();

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 1;
            Console.Write("Anna pisteet :");
            string rivi = Console.ReadLine();
            points = int.Parse(rivi);
                if (points <= 1 || points == 0)
                    Console.WriteLine("Arovosanasi on 0");
            
             else  if  (points > 1 && points < 4)
                    Console.WriteLine("Arvosanasi on 1");
            
            else if (points < 6 && points > 4)
                    Console.WriteLine("Arvosanasi on 2");
            
            else if (points < 8 && points > 5)
                    Console.WriteLine("Arvosanasi on 3");
            
            else if (points < 10 && points > 7)
                    Console.WriteLine("Arvosanasi on 4");
            
            else if (points < 15 && points > 9)
                    Console.WriteLine("Arovsanasi on 5");
            
            else Console.WriteLine("Reputit koska et syöttänyt pisteitäsi oikein");
                Console.ReadLine();
            }

        }
    }
