using System;

class Deck52Cards
{
    static void Main()
    {
        string[] deckNumbers = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] deckNames = { "Spades", "Hearts", "Diamonds", "Clubs" };

        foreach (string i in deckNames)
        {
            foreach (string n in deckNumbers)
            {
                Console.WriteLine("{0} of {1}", n, i);
            }
        }
    }
}
