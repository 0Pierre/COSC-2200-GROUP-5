using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace GameOfHearts
{
    public partial class Form1 : Form
    {
        private Player humanPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hearts Game Rules:\n\n" +
                           "Hearts is a trick-taking card game for four players.\n\n" +
                           "Setup:\n" +
                           "- 52-card deck is used.\n" +
                           "- The dealer is chosen randomly.\n" +
                           "- 13 cards are dealt to each player.\n\n" +
                           "The objective is to have the lowest score by avoiding hearts and the Queen of Spades.\n\n" +
                           "Card Ranking:\n" +
                           "- Cards are ranked from Ace (high) to 2 (low) in each suit.\n\n" +
                           "Round Play:\n" +
                           "- Each round consists of 13 tricks.\n" +
                           "- Players must follow suit if possible.\n" +
                           "- Hearts cannot be led until they have been played in a previous trick.\n\n" +
                           "Scoring:\n" +
                           "- Each heart card counts as 1 point.\n" +
                           "- The Queen of Spades counts as 5 points.\n\n" +
                           "Winning:\n" +
                           "- The game ends when a player reaches the predetermined score limit.\n" +
                           "- The player with the lowest score wins.\n", "Hearts Game Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hearts Game\n\n" +
                          "Version: 1.0\n" +
                          "Developed by: [Group 5]\n" +
                          "Date: [2024-03-06]\n\n" +
                          "This application is a C# implementation of the classic Hearts card game.\n" +
                          "Enjoy playing Hearts!\n", "About the Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Declare variables 
            string p1name = p1Input.Text;

            // Validation flags
            bool p1Valid = true, scoreValid = true;

            // Validation for player name
            if (!IsAlphabetic(p1name))
            {
                MessageBox.Show("Player name should contain only alphabetical characters.");
                p1Input.Clear();
                p1Valid = false;
            }
            else if (p1name.Length < 2)
            {
                MessageBox.Show("Player name should be at least 2 characters long");
                p1Input.Clear();
                p1Valid = false;
            }

            // Validation for score
            if (string.IsNullOrEmpty(TextBoxScore.Text))
            {
                MessageBox.Show("Please enter a score");
                scoreValid = false;
            }
            else if (!int.TryParse(TextBoxScore.Text, out int score))
            {
                MessageBox.Show("The score must be a numeric value");
                TextBoxScore.Clear();
                scoreValid = false;
            }

            // If all validations pass, create the Player object
            if (p1Valid && scoreValid)
            {
                // Assuming score is valid, otherwise handle this case separately
                int Score = int.Parse(TextBoxScore.Text);

                // Create Player object for the human player
                humanPlayer = new Player(p1name, Score);

                // Create AI players
                Player player2 = new Player("AI Player 2", Score);
                Player player3 = new Player("AI Player 3", Score);
                Player player4 = new Player("AI Player 4", Score);

                // Pass references to the human player and AI players to Form2 constructor
                Form2 f2 = new Form2(this, humanPlayer, new Player[] { player2, player3, player4 });
                f2.Show();
            }
        }

        // Function to check if an input is alphabetic
        bool IsAlphabetic(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        private void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot add a player at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDeletePlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not delete a player at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
