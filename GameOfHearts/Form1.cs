using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace GameOfHearts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

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
            string p2name = p2Input.Text;
            string p3name = p3Input.Text;
            string p4name = p4Input.Text;

            // Validation for player names and player score box

            if (!IsAlphabetic(p1Input.Text))
            {
                MessageBox.Show("Player 1 name should contain only alphabetical characters.");
                p1Input.Clear();

            }
            if (p1Input.Text.Length < 2)
            {
                MessageBox.Show("Player 1 name should be at least 2 characters long");
                p1Input.Clear();
            }
            else if (!IsAlphabetic(p2Input.Text))
            {
                MessageBox.Show("Player 2 name should contain only alphabetical characters.");
                p2Input.Clear();
            }
            else if (p2Input.Text.Length < 2)
            {
                MessageBox.Show("Player 2 name should be at least 2 characters long");
                p2Input.Clear();
            }
            else if (!IsAlphabetic(p3Input.Text))
            {
                MessageBox.Show("Player 3 name should contain only alphabetical characters.");
                p3Input.Clear();
            }
            else if (p3Input.Text.Length < 2)
            {
                MessageBox.Show("Player 3 name should be at least 2 characters long");
                p3Input.Clear();
            }
            else if (!IsAlphabetic(p4Input.Text))
            {
                MessageBox.Show("Player 4 name should contain only alphabetical characters.");
                p4Input.Clear();
            }
            else if (p4Input.Text.Length < 2)
            {
                MessageBox.Show("Player 4 name should be at least 2 characters long");
                p4Input.Clear();
            }
            // Validation for score
            else if (string.IsNullOrEmpty(TextBoxScore.Text))
            {
                MessageBox.Show("Please enter a score");
            }
            else if (!int.TryParse(TextBoxScore.Text, out int score))
            {
                MessageBox.Show("The score must be a numeric value");
                TextBoxScore.Clear();
            }

            // Function to check if an input is alphabetic
            bool IsAlphabetic(string input)
            {
                return Regex.IsMatch(input, @"^[a-zA-Z]+$");
            }



        }
    }
}