

using System;
using System.Collections.Generic;

public class Deck
{
    protected List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();
    }

    public void Shuffle()
    {
        Random random = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public List<Card> Deal(int count)
    {
        List<Card> dealtCards = new List<Card>();

        for (int i = 0; i < count; i++)
        {
            if (cards.Count > 0)
            {
                int lastIndex = cards.Count - 1;
                Card dealtCard = cards[lastIndex];
                cards.RemoveAt(lastIndex);
                dealtCards.Add(dealtCard);
            }
            else
            {
                Shuffle();
                if (cards.Count > 0)
                {
                    int lastIndex = cards.Count - 1;
                    Card dealtCard = cards[lastIndex];
                    cards.RemoveAt(lastIndex);
                    dealtCards.Add(dealtCard);
                }
                else
                {
                    break;
                }
            }
        }

        return dealtCards;
    }

    public List<Card> GetCards()
    {
        return cards;
    }
}
