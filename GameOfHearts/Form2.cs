using System;
using System.Drawing; // Required for Image class
using System.Windows.Forms;

namespace GameOfHearts
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        private PictureBox[] pictureBox;

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

            // Loop through each card index

            
        }

        private void setImage()
        {
            try
            {
                string imagePath = @"./Images/2_of_clubs.png";

                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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

        private void TestLoop()
        {
            for (int i = 0; i < pictureBox.Length; i++)
            {
                // Create a new Card instance for each card
                Suit suit = GetSuit(i);
                Rank rank = GetRank(i);
                string imagePath = $".\\images\\{rank}_of_{suit}.png"; // Assuming images are stored locally
                Card card = new Card(suit, rank, imagePath);

                // Create PictureBox for each card
                pictureBox[i] = new PictureBox();

                // Load the image from the Card instance and assign it to PictureBox
                pictureBox[i].Image = card.GetCardImage();



            }
        }
    }
}
