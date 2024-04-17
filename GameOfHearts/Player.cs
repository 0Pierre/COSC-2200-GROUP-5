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

    // Method to add a card to the player's hand

    public void AddCardToHand(Card card)

    {

        Hand.Add(card);

    }

    // Method to remove a card from the player's hand

    public void RemoveCardFromHand(Card card)

    {

        Hand.Remove(card);

    }

    // Method to clear the player's hand

    public void ClearHand()

    {

        Hand.Clear();

    }

    // Method to add won cards to the player's collection

    public void AddWonCards(IEnumerable<Card> cards)

    {

        WonCards.AddRange(cards);

    }

    // Method to clear won cards from the player's collection

    public void ClearWonCards()

    {

        WonCards.Clear();

    }

    // Method to check if the player has cards of a specific suit

    public bool HasSuit(Suit suit)

    {

        return Hand.Exists(card => card.Suit == suit);

    }

    // Method to check if the player has hearts

    public bool HasHearts()

    {

        return Hand.Exists(card => card.Suit == Suit.hearts);

    }


}
