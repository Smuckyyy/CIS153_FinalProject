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
        private bool gameOver;
        private bool playerTurn; 
        private int currentPlayer; // P1 = 1, P2 = 2
        private string playerColor;
        private string playerTwoColor;
        private string AIColor;
        private bool runGame;

        // Constructor for singleplayer
        public GameSettings()
        {
            this.playerColor = "Yellow";
            this.playerTwoColor = "Red";
            this.gameOver = false;
            this.playerColor = "Yellow";
            this.AIColor = "Red";
        }

        // Constructor for Two Player
        public GameSettings(string P1Color, string P2Color, int PlayerStart)
        {
            this.gameOver = false;
            this.playerColor = P1Color;
            this.playerTwoColor = P2Color;

            // Choose what player goes first
            this.currentPlayer = PlayerStart;

            this.runGame = false;
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
        public string getAIColor()
        {
            return this.AIColor;
        }

        // Returns the player color
        public string getPlayerColor()
        {
            return this.playerColor;
        }

        // Returns what player goes next
        public int getCurrentPlayer()
        {
            return this.currentPlayer;
        }

        // Return if the game is running
        public bool getGameRunning()
        {
            return this.runGame;
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
        public void setPlayerColor(string color)
        {
            this.playerColor = color;
        }

        // Set player two color
        public void setPlayerTwoColor(string color)
        {
            this.playerTwoColor = color;
        }

        // Set the color of AI
        public void setAIColor(string color)
        {
            this.AIColor = color;
        }

        // Set what player goes next
        public void setCurrentPlayer(int currentPlayer)
        {
            this.currentPlayer = currentPlayer;
        }

        // Set the game enabled state
        public void setGameRunning(bool runState)
        {
            this.runGame = runState;
        }
        // =================== SETTERS ===============
    }
}
