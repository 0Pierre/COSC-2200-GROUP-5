using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        #region Initialize form
        /// <summary>
        /// Initialize the form, generate buttons and call the main functions such as DealCards() and PlayAI()
        /// </summary>
        /// <param name="parentForm"></param>
        /// <param name="humanPlayer"></param>
        /// <param name="aiPlayers"></param>
        public Form2(Form1 parentForm, Player humanPlayer, Player[] aiPlayers)
        {
            InitializeComponent();
            f1 = parentForm;

            // Hide main form
            f1.Hide();

            // Initialize players array
            players = new Player[4];
            // Set humanPlayer at index 0
            players[0] = humanPlayer;
            // Copy the aiPlayers list into players list starting at index 1 
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

            foreach (int index in cardIndices)
            {
                // Create a new Card instance for each card
                Suit suit = GetSuit(index);
                Rank rank = GetRank(index);
                string imagePath = $"../images/{rank}_of_{suit}.png";
                Card card = new Card(suit, rank, imagePath);

                // Add the card to each player's hand
                 players[index % 4].AddCardToHand(card);



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

            // Deal cards to players
            DealCards();
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
        #endregion

        #region Button Event handler ( Cards )
        /// <summary>
        ///  Event handler for when a button (card) is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                            // Remove the button from the UI
                            clickedButton.Visible = false;

                            // Move the card to the side
                            MoveCardToSide(clickedCard);

                            // Add the card to the current trick
                            currentTrick.Add(clickedCard);

                            // Check if the trick is complete (if current trick list has 4 cards)
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
                            MessageBox.Show("Invalid Move.");
                        }
                    }
                }
            }
        }
        #endregion

        #region Handles the logic for when an AI player is playing

        /// <summary>
        /// This is a function to handle AI player logic 
        /// </summary>
        private void PlayAI()
        {
            Player currentPlayer = players[currentPlayerIndex];

            // Determine the lead suit of the current trick
            Suit leadSuit = currentTrick.Count > 0 ? currentTrick[0].Suit : Suit.hearts;

            // Select a card for the AI player to play
            Card selectedCard = SelectAICard(currentPlayer, leadSuit);


            // Remove the selected card from the AI player's hand
            currentPlayer.Hand.Remove(selectedCard);


            Button selectedButton = null;
            foreach (var pair in buttonCardMap)
            {
                if (pair.Value == selectedCard)
                {
                    selectedButton = pair.Key;
                    break; // Stop searching once the matching button is found
                }
            }


            // Check if a matching button was found
            if (selectedButton != null)
            {
                // Replace the image of the button with the back of the card
                selectedButton.BackgroundImage = Image.FromFile("../images/back.png");

                // Ensure the background image layout is set to zoom
                selectedButton.BackgroundImageLayout = ImageLayout.Zoom;

                // Add the card to the current trick
                currentTrick.Add(selectedCard);
            }

            // Update the UI to hide the selected card button
            UpdateUI(selectedCard, false);


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

        #endregion

        #region Logic for AI players to select cards from the deck
        /// <summary>
        /// Method to check for valid cards to play for the AI player
        /// </summary>
        /// <param name="aiPlayer"></param>
        /// <param name="leadSuit"></param>
        /// <returns></returns>
        /// 
        Random rand = new Random();
        private Card SelectAICard(Player aiPlayer, Suit leadSuit)
        {

            // Filter out cards that follow the lead suit
            List<Card> validCards = aiPlayer.Hand.Where(card => card.Suit == leadSuit).ToList();

            // If there are no cards of the lead suit, filter out hearts cards unless hearts have been broken
            if (validCards.Count == 0 && currentTrick.All(card => card.Suit != Suit.hearts))
            {
                validCards = aiPlayer.Hand.Where(card => card.Suit != Suit.hearts).ToList();
            }

            // Check if there are valid cards to play
            if (validCards.Count > 0)
            {

                // Filter out cards that don't follow the lead suit
                validCards= aiPlayer.Hand.Where(card => card.Suit == leadSuit || card.Suit == Suit.hearts).ToList();
            }
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

        #endregion

        #region Logic to see if the human player is following a valid move
        /// <summary>
        /// Logic to check the non-AI player is choosing a valid move
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        private bool IsValidMove(Player player, Card card)
        {
            // Check if the player is following suit
            if (currentTrick.Count > 0)
            {
                // Determine the lead suit of the current trick
                Suit leadSuit = currentTrick[0].Suit;

                // Check to see if the player has the lead suit but did not follow it
                if (player.HasSuit(leadSuit) && card.Suit != leadSuit)
                {
                    // Let the player know about the requirement to follow suit
                    MessageBox.Show($"Player {player.Name} must follow suit: {leadSuit}");
                    return false;
                }
            }

            // Hearts cannot be led until they have been played in a previous trick
            if (currentTrick.Count == 0 && card.Suit == Suit.hearts && !player.HasHearts())
            {
                // Let the the player know about the rule regarding leading hearts
                MessageBox.Show($"Invalid move. You must follow suit if possible and hearts cannot be led until they have been played in a previous trick.");
                return false;
            }

            // If none of the above conditions are met, the move is valid
            return true;
        }
        #endregion

        #region Logic to process each trick (round)
        /// <summary>
        /// A method which finds the player who won the trick, adds the cards won to the list of won cards , sets the player 
        /// that starts the next round
        /// </summary>
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
        #endregion


        #region Logic to get the trick winner 
        /// <summary>
        /// Finds the winner of the current trick based on the lead suit and card ranks
        /// </summary>
        /// <returns></returns>
        private int FindTrickWinner()
        {
            // Get the lead suit of the current trick
            Suit leadSuit = currentTrick[0].Suit;

            // Initialize the index of the card with the highest rank to the first card in the trick
            int highestRankIndex = 0;

            // Loop through the rest of the cards in the trick
            for (int i = 1; i < currentTrick.Count; i++)
            {
                // Check if the current card has the lead suit and a higher rank than the card with the highest rank so far
                if (currentTrick[i].Suit == leadSuit && currentTrick[i].Rank > currentTrick[highestRankIndex].Rank)
                {
                    // Update the index of the card with the highest rank
                    highestRankIndex = i;
                }
            }

            // Calculate the indeex of the winnmer based on the index of the player who started the trick and the index of the card with the highest rank
            int winnerIndex = (trickStarter + highestRankIndex) % 4;

            // Display a message indicating the winner of the trick
            MessageBox.Show($"Player {players[winnerIndex].Name} won the trick!");

            // Return the winnder Index
            return winnerIndex;
        }
        #endregion


        #region Logic to start a new trick
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
        #endregion

        #region Logic to end round or trick
        /// <summary>
        /// Ends a round, by calculated score
        /// </summary>
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

            // Check for game end condition (i forgot to add the form 1's score here)
            if (scores.Any(score => score >= 15))
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
        #endregion

        #region Method to calculate scores 
        /// <summary>
        /// Calculates the scores for each player for the cards they have won
        /// </summary>
        /// <returns> scores </returns>
        private int[] CalculateScores()
        {
            // Initialize an array to store the scores for each player
            int[] scores = new int[4];
            // Loop trhough each player 
            for (int i = 0; i < 4; i++)
            {
                // Loop through each card collected by the current player
                foreach (var card in players[i].WonCards)
                {
                    // If the suit is hearts add 1 to the score
                    if (card.Suit == Suit.hearts)
                    {
                        scores[i]++;
                    }
                    // If the suit is spades and rand is queen add 5 to the score 
                    else if (card.Suit == Suit.spades && card.Rank == Rank.queen)
                    {
                        scores[i] += 5;
                    }
                }
            }
            return scores;
        }
        #endregion


        #region Logic to end the game 
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

            // Display winner
            string winnerMessage = "Winner(s):\n";
            foreach (var winner in winners)
            {
                winnerMessage += $"{winner.Name}\n";
            }
            MessageBox.Show(winnerMessage);

            // Close the game
            this.Close();
        }
        #endregion

        #region Logic to shuffle the cards 
        /// <summary>
        /// Method to shuffle : referenced https://stackoverflow.com/questions/69503717/how-to-use-random-class-to-shuffle-array-in-c-sharp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
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

        #endregion

        /// <summary>
        /// Get the Rank of a card
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Rank GetRank(int index)
        {
            int rankValue = index % 13 + 2;
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

        /// <summary>
        /// Get the Suit of a card 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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

        #region Logic to start a new round 
        /// <summary>
        /// Method to start a new round 
        /// </summary>
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
        #endregion

        #region Logic to Deal Cards 
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
                players[i % 4].AddCardToHand(deck[i]);
            }
        }
        #endregion


        #region Logic to Move cards to the side when played 
        private void MoveCardToSide(Card card)
        {
            // Create a new button to represent the played card on the side
            Button playedCardButton = new Button();
            playedCardButton.Location = new Point(1660, 439);

        }

        private void UpdateUI(Card selectedCard, bool isHumanPlayer)
        {
            // Loop through the buttonCardMap to find the button with the selected card
            foreach (var pair in buttonCardMap)
            {
                if (pair.Value == selectedCard)
                {
                    // Hide the button with the selected card
                    pair.Key.Visible = false;
 
                    // Move the selected card to the side
                    if (isHumanPlayer)
                    {
                        pair.Key.Location = new Point(1550, 328);
                    }
                    else
                    {
                        pair.Key.Location = new Point(50, 50); 
                    }
 
                    // break loop ince button is found
                    break;
                }
            }
        }
        #endregion


    }
}