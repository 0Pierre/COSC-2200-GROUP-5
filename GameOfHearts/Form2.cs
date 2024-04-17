using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameOfHearts
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        private Button[] buttons;
        private Dictionary<Button, Card> buttonCardMap;
        // Number of cards to display in each row
        private const int CardsPerRow = 13;
        // Set button attributes 
        private const int ButtonWidth = 80;
        private const int ButtonHeight = 120;
        private const int SpacingX = 5;
        private const int SpacingY = 5;
        // X position to start displaying buttons
        private const int StartX = 272;
        // Y position to start displaying buttons
        private const int StartY = 306;

        // Define players
        private Player[] players;

        // Keep track of current player index
        private int currentPlayerIndex;

        // Keep track of cards played in the current trick
        private List<Card> currentTrick;

        // Keep track of which player started the trick
        private int trickStarter;

        public Form2(Form1 parentForm, Player humanPlayer, Player[] aiPlayers)
        {
            InitializeComponent();
            f1 = parentForm;

            // Hide main form
            f1.Hide();

            // Initialize players array
            players = new Player[4];
            players[0] = humanPlayer;
            Array.Copy(aiPlayers, 0, players, 1, 3);

            playerName1.Text = humanPlayer.Name;

            // Initialize buttons array with appropriate size
            buttons = new Button[52];
            buttonCardMap = new Dictionary<Button, Card>();

            int row = 0;
            int col = 0;

            // Create a shuffled list of card indices
            var cardIndices = Enumerable.Range(0, 52).ToArray();
            Shuffle(cardIndices);

            // Loop through each card index
            foreach (int index in cardIndices)
            {
                // Create a new Card instance for each card
                Suit suit = GetSuit(index);
                Rank rank = GetRank(index);
                string imagePath = $"../images/{rank}_of_{suit}.png"; // Assuming images are stored locally
                Card card = new Card(suit, rank, imagePath);

                // Add the card to each player's hand
                
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

            // Assign event handler for all buttons
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += Button_Click;
            }


            // Start the game with the human player
            currentPlayerIndex = 0;
            trickStarter = 0;
            currentTrick = new List<Card>();
            MessageBox.Show($"It's {players[currentPlayerIndex].Name}'s turn.");
            // Check if the current player is an AI player
            if (currentPlayerIndex != 0)
            {
                // AI player's turn
                PlayAI();
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            // Check if it's the human player's turn
            if (currentPlayerIndex == 0)
            {
                // Check if sender is a Button and not empty before accessing it
                if (sender is Button clickedButton)
                {
                    // Get the card associated with the clicked button
                    if (buttonCardMap.TryGetValue(clickedButton, out Card? clickedCard))
                    {
                        // Check if the move is valid
                        if (IsValidMove(players[0], clickedCard))
                        {
                            // Remove the card from the human player's hand
                            players[0].Hand.Remove(clickedCard);

                            // Add the card to the current trick
                            currentTrick.Add(clickedCard);

                            // Remove the button from the UI
                            clickedButton.Visible = false;

                            // Check if the trick is complete
                            if (currentTrick.Count == 4)
                            {
                                // Process the trick
                                ProcessTrick();

                                // Check if the round is complete
                                if (players[0].Hand.Count == 0)
                                {
                                    // End the round
                                    EndRound();
                                }
                                else
                                {
                                    // Start a new trick
                                    StartNewTrick();
                                }
                            }
                            else
                            {
                                // Move to the next player
                                currentPlayerIndex = (currentPlayerIndex + 1) % 4;
                                MessageBox.Show($"It's {players[currentPlayerIndex].Name}'s turn.");

                                // Check if the next player is an AI player
                                if (currentPlayerIndex != 0)
                                {
                                    // AI player's turn
                                    PlayAI();
                                }
                            }
                        }
                        else
                        {
                            // Invalid move, notify the player
                            MessageBox.Show("Invalid move. You must follow suit if possible and hearts cannot be led until they have been played in a previous trick.");
                        }
                    }
                }
            }
        }

        private void PlayAI()
        {
            Player currentPlayer = players[currentPlayerIndex];

            // Determine the lead suit of the current trick
            Suit leadSuit = currentTrick.Count > 0 ? currentTrick[0].Suit : Suit.hearts;

            // Select a card for the AI player to play
            Card selectedCard = SelectAICard(currentPlayer, leadSuit);

            // Add the card to the current trick
            currentTrick.Add(selectedCard);

            // Update the UI to hide the selected card button
            UpdateUI(selectedCard);

            // Check if the trick is complete
            if (currentTrick.Count == 4)
            {
                // Process the trick
                ProcessTrick();

                // Check if the round is complete
                if (currentPlayer.Hand.Count == 0)
                {
                    // End the round
                    EndRound();
                }
                else
                {
                    // Start a new trick
                    StartNewTrick();
                }
            }
            else
            {
                // Move to the next player
                currentPlayerIndex = (currentPlayerIndex + 1) % 4;
                MessageBox.Show($"It's {players[currentPlayerIndex].Name}'s turn.");
                // Check if the next player is an AI player
                if (currentPlayerIndex != 0)
                {
                    // AI player's turn
                    PlayAI();
                }
            }
        }

        Random rand = new Random();
        private Card SelectAICard(Player aiPlayer, Suit leadSuit)
        {
            // Filter out cards that don't follow the lead suit
            List<Card> validCards = aiPlayer.Hand.Where(card => card.Suit == leadSuit || card.Suit == Suit.hearts).ToList();

            // Check if there are valid cards to play
            if (validCards.Count > 0)
            {
                // Select a random valid card
                return validCards[rand.Next(validCards.Count)];
            }
            else
            {
                // If there are no valid cards to play, select a random card from the AI player's hand
                return aiPlayer.Hand[rand.Next(aiPlayer.Hand.Count)];
            }
        }




        private bool IsValidMove(Player player, Card card)
        {
            // Check if the player is following suit
            if (currentTrick.Count > 0)
            {
                Suit leadSuit = currentTrick[0].Suit;
                if (player.HasSuit(leadSuit) && card.Suit != leadSuit)
                {
                    // Player has the lead suit but did not follow it
                    MessageBox.Show($"Player {player.Name} must follow suit: {leadSuit}");
                    return false;
                }
            }

            // Hearts cannot be led until they have been played in a previous trick
            if (currentTrick.Count == 0 && card.Suit == Suit.hearts && !player.HasHearts())
            {
                MessageBox.Show($"Player {player.Name} cannot lead with hearts.");
                return false;
            }

            // Valid move
            return true;
        }


        private void ProcessTrick()
        {
            // Find the winner of the trick
            int winnerIndex = FindTrickWinner();

            // Add the cards from the trick to the winner's won cards
            players[winnerIndex].WonCards.AddRange(currentTrick);

            // Clear the current trick
            currentTrick.Clear();

            // Set the next trick starter
            trickStarter = winnerIndex;
        }

        private int FindTrickWinner()
        {
            Suit leadSuit = currentTrick[0].Suit;
            int highestRankIndex = 0;
            for (int i = 1; i < currentTrick.Count; i++)
            {
                if (currentTrick[i].Suit == leadSuit && currentTrick[i].Rank > currentTrick[highestRankIndex].Rank)
                {
                    highestRankIndex = i;
                }
            }
            int winnerIndex = (trickStarter + highestRankIndex) % 4;
            return winnerIndex;
        }

        private void StartNewTrick()
        {
            // Reset current player index to the trick starter
            currentPlayerIndex = trickStarter;
            MessageBox.Show($"It's {players[currentPlayerIndex].Name}'s turn.");
            // Check if the current player is an AI player
            if (currentPlayerIndex != 0)
            {
                // AI player's turn
                PlayAI();
            }
        }

        private void EndRound()
        {
            // Calculate scores
            int[] scores = CalculateScores();

            // Display scores
            string scoreMessage = "";
            for (int i = 0; i < 4; i++)
            {
                scoreMessage += $"{players[i].Name}: {scores[i]} points\n";
            }
            MessageBox.Show(scoreMessage);

            // Check for game end condition
            if (scores.Any(score => score >= 100))
            {
                // End the game
                EndGame();
            }
            else
            {
                // Start a new round
                StartNewRound();
            }
        }

        private int[] CalculateScores()
        {
            int[] scores = new int[4];
            for (int i = 0; i < 4; i++)
            {
                foreach (var card in players[i].WonCards)
                {
                    if (card.Suit == Suit.hearts)
                    {
                        scores[i]++;
                    }
                    else if (card.Suit == Suit.spades && card.Rank == Rank.queen)
                    {
                        scores[i] += 5;
                    }
                }
            }
            return scores;
        }

        private void EndGame()
        {
            // Determine the winner
            int[] scores = CalculateScores();
            int minScore = scores.Min();
            List<Player> winners = new List<Player>();
            for (int i = 0; i < 4; i++)
            {
                if (scores[i] == minScore)
                {
                    winners.Add(players[i]);
                }
            }

            // Display winner(s)
            string winnerMessage = "Winner(s):\n";
            foreach (var winner in winners)
            {
                winnerMessage += $"{winner.Name}\n";
            }
            MessageBox.Show(winnerMessage);

            // Close the game
            this.Close();
        }

        private void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
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


        private void StartNewRound()
        {
            // Reset players' hands and won cards
            foreach (var player in players)
            {
                player.Hand.Clear();
                player.WonCards.Clear();
            }

            // Deal cards
            DealCards();

            // Start the new round with the player to the left of the dealer
            currentPlayerIndex = (currentPlayerIndex + 1) % 4;
            trickStarter = currentPlayerIndex;

            // Inform whose turn it is
            MessageBox.Show($"It's {players[currentPlayerIndex].Name}'s turn.");
            // Check if the current player is an AI player
            if (currentPlayerIndex != 0)
            {
                // AI player's turn
                PlayAI();
            }
        }

        private void DealCards()
        {
            // Create a shuffled deck
            var deck = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                Suit suit = GetSuit(i);
                Rank rank = GetRank(i);
                deck.Add(new Card(suit, rank, $"../images/{rank}_of_{suit}.png"));
            }

            Shuffle<Card>(deck.ToArray());


            // Deal cards to players
            for (int i = 0; i < 52; i++)
            {
                players[i % 4].Hand.Add(deck[i]);
            }
        }



        private void UpdateUI(Card selectedCard)
        {
            // Iterate through the buttonCardMap to find the button associated with the selected card
            foreach (var pair in buttonCardMap)
            {
                if (pair.Value == selectedCard)
                {
                    // Hide the button associated with the selected card
                    pair.Key.Location = new Point(1550, 328);
                    // No need to continue iterating once the button is found
                    break;
                }
            }
        }

    }
}
