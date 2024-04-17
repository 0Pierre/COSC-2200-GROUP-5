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

    /// <summary>
    /// Method to add a card to the player's hand
    /// </summary>
    /// <param name="card"></param>

    public void AddCardToHand(Card card)

    {

        Hand.Add(card);

    }

    /// <summary>
    /// Method to remove a card from the player's hand
    /// </summary>
    /// <param name="card"></param>

    public void RemoveCardFromHand(Card card)

    {

        Hand.Remove(card);

    }

    /// <summary>
    /// Method to clear the player's hand
    /// </summary>

    public void ClearHand()

    {

        Hand.Clear();

    }

    /// <summary>
    /// Method to add won cards to the player's collection
    /// </summary>
    /// <param name="cards"></param>

    public void AddWonCards(IEnumerable<Card> cards)

    {

        WonCards.AddRange(cards);

    }

    /// <summary>
    /// Method to clear won cards from the player's collection
    /// </summary>

    public void ClearWonCards()

    {

        WonCards.Clear();

    }

    /// <summary>
    /// Method to check if the player has cards of a specific suit
    /// </summary>
    /// <param name="suit"></param>
    /// <returns></returns>

    public bool HasSuit(Suit suit)

    {

        return Hand.Exists(card => card.Suit == suit);

    }

    /// <summary>
    /// Method to check if the player has hearts
    /// </summary>
    /// <returns></returns>

    public bool HasHearts()

    {

        return Hand.Exists(card => card.Suit == Suit.hearts);

    }


}
