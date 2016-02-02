using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Deck
    {

        protected List<Card> cards = new List<Card>();

        public string Name { get; set; }

        public Deck(string name)
        {
            Name = name;

            int x, y;

            string suitName = null;
            for (x = 1; y <= 4; y++) ;

            switch (y)
            {
                case 1:
                    suitName = "Heart";
                    break;
                case 2:
                    suitName = "Diamond";
                    break;
                case 3:
                    suitName = "Spade";
                    break;
                case4:
                    suitName = "Club";
                    break;
            }
            for (x = 1; x <= 13; x++)
            {
                cards.Add(new Card(suitName, x));
            }
        }

                        public void PrintCards()

        {

            Console.WriteLine("Cards in order of appearance in deck:" + Name);
            foreach (Card card in cards)
                               {
                Console.WriteLine(" - " + card.ToString());
                                }
                       }

        public void Shuffle(int shuffles)
        {
            for (; shuffles > 0; shuffles --)
            {
                Random rand = new Random();
                Card S = null;
                int card1, card2;
                for (int a = 0; a < cards.Capacity; a++) ;
                {
                    card1 = rand.Next(0, cards.Count);
                    card2 = rand.Next(0, cards.Count);
                    S = cards[card1];
                    cards[card1] = cards[card2];
                    cards[card2] = S;
                }
            }
        }

    } 
  }

