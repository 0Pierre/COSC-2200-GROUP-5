using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

public class Player
{
    public string Name { get; set; }
    public List<Card> Hand { get; set; }
    public List<Card> WonCards { get; set; }
    public int Score { get; set; }

    public Player(string name, int score)
    {
        Name = name;
        Hand = new List<Card>();
        WonCards = new List<Card>();
        Score = score;
    }

    public void AddCardToHand(Card card)
    {
        Hand.Add(card);
    }

    public bool HasSuit(Suit suit)
    {
        return Hand.Any(card => card.Suit == suit);
    }

    public bool HasHearts()
    {
        return Hand.Any(card => card.Suit == Suit.hearts);
    }
}
