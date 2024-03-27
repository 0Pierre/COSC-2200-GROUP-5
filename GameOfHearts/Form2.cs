using System.Windows.Forms;

namespace GameOfHearts
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        private PictureBox[] pictureBox; // Renamed to pictureBoxes

        public Form2(Form1 parentForm, Player player1, Player player2, Player player3, Player player4)
        {
            InitializeComponent();
            f1 = parentForm;

            // Now you can access all player objects if needed
            // For demonstration purpose, let's just display the name of player1
            playerName1.Text = player1.Name;
            playerName2.Text = player2.Name;
            playerName3.Text = player3.Name;
            playerName4.Text = player4.Name;

            f1.Hide();

            // Initialize pictureBoxes array with appropriate size
            pictureBox = new PictureBox[52];
            // Initialize each PictureBox in the array
            for (int i = 9; i < pictureBox.Length; i++)
            {
             
                // Construct the file name based on the card index
                string fileName = $"C:/Users/Moham/OneDrive/Desktop/OOP3/COSC-2200-GROUP-5/GameOfHearts/images/{i-8}_of_clubs.png"; // Update "suit" accordingly

                // Create a new instance of a card
                Card card = new Card(GetSuit(i), GetRank(i), fileName);

                // Get the image associated with the card
                Image cardImage = card.GetCardImage(fileName);

                // Display the image on the PictureBox control
                pictureBox[i].Image = cardImage; // Adjust the index accordingly
                                                   // Add the PictureBox control to the form's controls collection
                
            }
        }

        private Rank GetRank(int index)
        {
            int rankValue = index % 13 + 2; // Adjust for zero-based index
            return (Rank)rankValue;
        }

        private Suit GetSuit(int index)
        {
            if (index >= 0 && index <= 12)
                return Suit.Hearts;
            else if (index >= 13 && index <= 25)
                return Suit.Diamonds;
            else if (index >= 26 && index <= 38)
                return Suit.Clubs;
            else if (index >= 39 && index <= 51)
                return Suit.Spades;
            else
                throw new ArgumentException("Invalid card index");
        }
    }
}