using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// This class contains settings
// that will be called throughout the program
namespace Connect4_Group1
{
    internal class GameSettings
    {
        private bool gameOver; // This is used to tell the program if the game is running or is over
        private bool playerTurn; // Used to save what turn we are on
        private int currentPlayer; // P1 = 1, P2 = 2
        private Color playerColor; // Color of Player 1
        private Color playerTwoColor; // Player 2 and AI will always be RED

        // Location to the player piece png files
        private string playOneImage = @"..\..\..\Resources\Player_1.png";
        private string playTwoImage = @"..\..\..\Resources\Player_2.png";

        // Constructor for singleplayer, This can be changed depending on how the Form is setup
        public GameSettings()
        {
            this.gameOver = false;

            // Set the colors of the players
            this.playerColor = Color.Yellow;
            this.playerTwoColor = Color.Red;

            // Set the first player to player one
            this.currentPlayer = 1; // The human will always go first on this
        }

        // Constructor for Two Player
        public GameSettings(Color P1Color, Color P2Color, int PlayerStart, bool gameState)
        {
            // Set the colors of the players
            this.playerColor = P1Color;
            this.playerTwoColor = P2Color;

            // Choose what player goes first
            this.currentPlayer = PlayerStart;

            this.gameOver = gameState;
        }

        // =================== GETTERS ===============
        // Returns the game status
        public bool getGameStatus()
        {
            return this.gameOver;
        }

        // Returns if the player goes next turn
        public bool getPlayerTurn()
        {
            return this.playerTurn;
        }

        // Returns the AI color
        //public Color getAIColor()
        //{
        //    return this.AIColor;
        //}

        // Returns the player color, DEPRICATED use getColorOfCurrPlayer()
        public Color getPlayerColor()
        {
            return this.playerColor;
        }

        // Returns what player goes next
        public int getCurrentPlayer()
        {
            return this.currentPlayer;
        }

        public string getPlayerOneImage()
        {
            return this.playOneImage;
        }

        public string getPlayerTwoImage()
        {
            return this.playTwoImage;
        }

        // Gets the color of the current player based on the currentPlayer int
        public Color getColorOfCurrPlayer()
        {
            if (this.currentPlayer == 1)
            {
                return this.playerColor;
            }
            else
            {
                return this.playerTwoColor;
            }
        }
        // =================== GETTERS ===============

        // =================== SETTERS ===============
        // Set the game status
        public void setGameStatus(bool gameStatus)
        {
            this.gameOver = gameStatus;
        }
        
        // Set if the player goes next
        public void setPlayerTurn(bool currentPlayer)
        {
            this.playerTurn = currentPlayer;
        }

        // Set the color of Player
        public void setPlayerColor(Color color)
        {
            this.playerColor = color;
        }

        // Set player two color
        public void setPlayerTwoColor(Color color)
        {
            this.playerTwoColor = color;
        }

        // Set what player goes next
        public void setCurrentPlayer(int currentPlayer)
        {
            this.currentPlayer = currentPlayer;
        }
        // =================== SETTERS ===============
    }
}
