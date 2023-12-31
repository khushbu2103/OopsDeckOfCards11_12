﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDeckOfCards11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //Console.WriteLine(deck.cards[52]);
            deck.Shuffle();
            //Console.WriteLine(deck.cards[0]);

            int players = 4;
            int cardsPerPlayer = 9;

            Cards[,] distributedCards = new Cards[players, cardsPerPlayer];

            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("Player {0}:", i + 1);
                for (int j = 0; j < cardsPerPlayer; j++)
                {
                    distributedCards[i, j] = deck.DrawCard();
                    Console.WriteLine(distributedCards[i, j]);
                    //ToString method automatically invoked as Card class's instance is being passed to console.WriteLine
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
