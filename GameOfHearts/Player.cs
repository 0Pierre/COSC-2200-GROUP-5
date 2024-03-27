using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
    {
        private string playerName;
        private int playerScore;

        // Constructor
        public Player(string playerName, int playerScore)
        {
            this.playerName = playerName;
            this.playerScore = playerScore;
        }

        // Getter and Setter for playerName
        public string Name
        {
            get { return playerName; }
            set { playerName = value; }
        }

        // Getter and Setter for playerScore
        public int PlayerScore
        {
            get { return playerScore; }
            set { playerScore = value; }
        }
    }

