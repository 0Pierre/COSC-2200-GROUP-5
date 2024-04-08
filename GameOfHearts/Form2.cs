using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfHearts
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        private Button[] buttons;
        private Dictionary<Button, Card> buttonCardMap;
        private const int CardsPerRow = 13; // Number of cards to display in each row
        private const int ButtonWidth = 80;
        private const int ButtonHeight = 120;
        private const int SpacingX = 5;
        private const int SpacingY = 5;
        private const int StartX = 272; // X position to start displaying buttons
        private const int StartY = 306; // Y position to start displaying buttons

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

            // Initialize buttons array with appropriate size
            buttons = new Button[52];
            buttonCardMap = new Dictionary<Button, Card>();

            int row = 0;
            int col = 0;

            // Create a shuffled list of card indices
            var cardIndices = new int[52];
            for (int i = 0; i < cardIndices.Length; i++)
            {
                cardIndices[i] = i;
            }
            Shuffle(cardIndices);

            // Loop through each card index
            foreach (int index in cardIndices)
            {
                // Create a new Card instance for each card
                Suit suit = GetSuit(index);
                Rank rank = GetRank(index);
                string imagePath = $"../images/{rank}_of_{suit}.png"; // Assuming images are stored locally
                Card card = new Card(suit, rank, imagePath);

                // Create Button for each card
                buttons[index] = new Button();

                // Set button properties
                buttons[index].Size = new Size(ButtonWidth, ButtonHeight);
                buttons[index].Location = new Point(StartX + col * (ButtonWidth + SpacingX), StartY + row * (ButtonHeight + SpacingY));
                buttons[index].BackgroundImage = card.GetCardImage(); // Use BackgroundImage instead of Image
                buttons[index].BackgroundImageLayout = ImageLayout.Zoom; // Set BackgroundImageLayout to Zoom to resize the image within the button
                buttons[index].Text = ""; // Hide text

                // Ensure button displays image in color
                buttons[index].FlatStyle = FlatStyle.Flat;
                buttons[index].FlatAppearance.BorderSize = 0;
                buttons[index].ImageAlign = ContentAlignment.MiddleCenter;
                buttons[index].Enabled = true;


                // Assign name to the button based on the card's suit and rank
                buttons[index].Name = $"Button{rank}_of_{suit}";

                // Add Button to the form's controls
                this.Controls.Add(buttons[index]);

                // Add card and button mapping to the dictionary
                buttonCardMap.Add(buttons[index], card);

                // Update row and column for the next button
                col++;
                if (col >= CardsPerRow)
                {
                    row++;
                    col = 0;
                }
            }

            // Assign a single event handler for all buttons
            foreach (var button in buttons)
            {
                button.Click += Button_Click;
                Console.WriteLine($"Event handler attached to button {button.Name}");
            }

        }


        private void Button_Click(object? sender, EventArgs e)
        {
            // Check if sender is a Button and not null before accessing it
            if (sender is Button clickedButton)
            {
                // Get the card associated with the clicked button
                if (buttonCardMap.TryGetValue(clickedButton, out Card? clickedCard))
                {
                    // Handle button click event here, for example, display the card info
                    MessageBox.Show($"Clicked: {clickedCard.Rank} of {clickedCard.Suit}");

                    Console.WriteLine($"Clicked: {clickedCard.Rank} of {clickedCard.Suit}");
                }
            }
        }




        private Rank GetRank(int index)
        {
            int rankValue = index % 13 + 2; // Adjust for zero-based index and start at 2
            switch (rankValue)
            {
                case 11:
                    return Rank.jack;
                case 12:
                    return Rank.queen;
                case 13:
                    return Rank.king;
                case 14:
                    return Rank.ace;
                default:
                    return (Rank)rankValue;
            }
        }

        private Suit GetSuit(int index)
        {
            if (index >= 0 && index <= 12)
                return Suit.hearts;
            else if (index >= 13 && index <= 25)
                return Suit.diamonds;
            else if (index >= 26 && index <= 38)
                return Suit.clubs;
            else if (index >= 39 && index <= 51)
                return Suit.spades;
            else
                throw new ArgumentException("Invalid card index");
        }

        private static Random rng = new Random();

        // Fisher-Yates shuffle algorithm
        private static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
        }
    }
}
