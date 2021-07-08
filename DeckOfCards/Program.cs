using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program : IDeckCards
    {
        
            
            static string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            static string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            static int totalCards = suits.Length * ranks.Length;
            static string[] deckOfCards = new string[totalCards];

            public void shuffleofcards()
            {
                Random random = new Random();
                for (int i = 0; i < totalCards; i++)
                {
                    //Random random = new Random();
                    int randomnum = random.Next(0, totalCards);
                    String temp = deckOfCards[randomnum];
                    deckOfCards[randomnum] = deckOfCards[i];
                    deckOfCards[i] = temp;
                }
            }
            public void TwoDArrayofcards()
            {
                string[,] arr = new string[4, 9];
                int k = 0;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("For player {0}....", i + 1);
                    for (int j = 0; j < 9; j++)
                    {
                        arr[i, j] = deckOfCards[k];
                        Console.WriteLine(arr[i, j]);
                        k++;
                    }

                }
            }
            static void Main(string[] args)
            {
            Console.WriteLine("Welcome To DeckOfCards Problem");
            for (int i = 0; i < ranks.Length; i++)
                {
                    for (int j = 0; j < suits.Length; j++)
                    {
                        deckOfCards[suits.Length * i + j] = ranks[i] + " of " + suits[j];
                    }
                }
                Program obj = new Program();
                obj.shuffleofcards();
                obj.TwoDArrayofcards();
            }

        }
    }
}
