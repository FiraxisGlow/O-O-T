using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a new decks
            List<Deck> decks = new List<Deck>();
         
            decks.Add(new Deck("Deck 1"));
            decks.Add(new Deck("Deck 2"));
         //shuffle the decks
            foreach (Deck deck in decks)
            {
                deck.PrintCards();
              
                deck.Shuffle(1);
                deck.PrintCards();
            }

    

        }
    }
}
