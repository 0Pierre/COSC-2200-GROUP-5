using System;
using System.Drawing;

public enum Suit
{
    hearts,
    diamonds,
    clubs,
    spades
}

public enum Rank
{
    ace, two=2, three=3, four=4, five=5, six=6,seven= 7,eight= 8,nine=  9,ten= 10,
    jack, queen, king
}

public class Card
{
    public Suit Suit { get; }
    public Rank Rank { get; }

    public string ImagePath { get; } // Path to the image file representing the card

    public Card(Suit suit, Rank rank, string imagePath)
    {
        Suit = suit;
        Rank = rank;
        ImagePath = imagePath;
    }

    public Image GetCardImage()
    {
        // Load the image from the file path stored in ImagePath
        Image image = Image.FromFile(ImagePath);
        return image;
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}
