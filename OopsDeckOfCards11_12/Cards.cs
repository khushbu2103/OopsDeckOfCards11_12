using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDeckOfCards11_12
{
    public class Cards
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public Cards(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
    }
}
