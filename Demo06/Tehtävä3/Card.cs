using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Card
    {

        public string Suits { get; set; }
        public int Value { get; set; }
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public Card()
        {

        }
        
        //Definitions for cards above 10. 
        public Card(string suit, int value)
        {

            Suits = suit;
            if (value == 1 || value == 14) Value = "Ace";
            else if (value == 11) Value = "Jack";
            else if (value == 12) Value = "Queen";
            else if (value == 13) Value = "King";
            else Value = value.ToString();
        }
        
        //returning card value
        public override string ToString()
        {
            return Value + "of" + Suits + "s";
        }

    }
}
