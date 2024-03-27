namespace GameOfHearts
{
    public partial class Form2 : Form
    {
        private Form1 f1;

        // Constructor modified to accept references to all player objects
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

            // Assuming you have a PictureBox control named pictureBoxCard in your Windows Form

            // Create a new instance of a card representing the Ace of Spades
            Card aceOfSpades = new Card(Suit.Spades, Rank.Ace, "path/to/ace_of_spades_image.png");

            // Get the image associated with the card
            Image cardImage = aceOfSpades.GetCardImage();

            // Display the image on the PictureBox control
            pictureBoxCard1.Image = cardImage;

        }
    }
}