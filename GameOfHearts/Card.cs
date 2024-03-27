

using System;

public class Card
{

    public string Suit { get; set; }
    public string Rank { get; set; }

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }


    public override string ToString()
    {
        return $"{Rank} {Suit}";
    }
}
