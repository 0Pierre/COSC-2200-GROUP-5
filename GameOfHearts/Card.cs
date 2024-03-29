﻿using System;


    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum Rank
    {
        Ace = 0, Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
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

    public Image GetCardImage(string ImagePath)
    {
        // Load the image from the file path
        Image image = Image.FromFile(ImagePath);
        return image;
    }
    public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

