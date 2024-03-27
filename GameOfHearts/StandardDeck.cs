

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

public class StandardDeck : Deck
{
    public StandardDeck() : base()
    {
        InitializeStandardDeck();
    }
    public List<Card> GetCards()
    {
        return cards;
    }

    private void InitializeStandardDeck()
    {
        foreach (string suit in new string[] { "Hearts", "Diamonds", "Clubs", "Spades" })
        {
            foreach (string rank in new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen" })
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }
}
