﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Connect4_Group1
{
    public partial class Singleplayer : Form
    {
        Form1 mainMenuForm;

        Board gameBoard = new Board();
        GameSettings gameConfig;

        // This holds how many time a button has been click.
        // Could be used to dictate if the game should end or
        // When a button should be disabled
        int[] buttonClick = { 0, 0, 0, 0, 0, 0, 0 };

        public Singleplayer()
        {
            InitializeComponent();
            /*this.FormBorderStyle = FormBorderStyle.Fixed3D; // Disable the ability to resize
            this.StartPosition = FormStartPosition.CenterScreen; // Open the form at the center of the users screen*/
            //The commented-out code didn't work when I tested it (before commenting it out, of course). Why is that?

            //I figured out how to make that work; I realized this constructor is kind of useless since we have
            //the Form1 sp one already. (I also don't want to delete it incase VS gets mad about the default constructor)
            //But I added the center screen down below. -Marcus
        }

        public Singleplayer(Form1 sp)
        {
            InitializeComponent();
            mainMenuForm = sp;
            this.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                setBoardCellData();

                // For Debugging
                gameBoard.getEntireBoard();

                setupGameSettings();

                gameConfig.setGameRunning(true); // Setup completed so the game can proceed

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                gameConfig.setGameRunning(false);
            }
        }

        private void setupGameSettings()
        {
            gameConfig = new GameSettings();

            sing_pictureBoxPlayerColor.BackColor = gameConfig.getPlayerColor();
        }

        private void setBoardCellData()
        {
            string tagName;
            int col;
            int row;
            Cell c;

            // This will loop over each PictureBox and find the ones that have a Tag and a specific color, This is because I designed the board with picture boxes
            foreach (var control in this.Controls.OfType<PictureBox>())
            {
                if (control is PictureBox && (string)control.Tag != "" && control.BackColor == Color.White)
                {
                    // Split-Strings Reference
                    // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split

                    // This is the way I did it for Homework 03 when we created that Car application
                    tagName = (string)control.Tag;

                    // This can also be done using .Split()
                    string[] parts = tagName.Split(',');

                    row = Int32.Parse(parts[0]);
                    col = Int32.Parse(parts[1]);

                    c = new Cell(row, col, control, false);

                    // Add the new cell to the game board
                    gameBoard.setGameBoardCell(c);
                }
            }
        }

        // Handles which button is clicked on the form
        // The names will be updated automatically when changed on the form
        private void button_click_handler(object sender, EventArgs e)
        {
            if (gameConfig.getGameRunning() == true)
            {
                if (sender == sing_btnCol1)
                {
                    // Add a token to column 1 ; (0,0) -> (0,6)
                    updateGameCells(0);
                }
                else if (sender == sing_btnCol2)
                {
                    // Add a token to column 2 (1,0) -> (1,6)
                    updateGameCells(1);
                }
                else if (sender == sing_btnCol3)
                {
                    // Add a token to column 3 (2,0) -> (2,6)
                    updateGameCells(2);
                }
                else if (sender == sing_btnCol4)
                {
                    // Add a token to column 4 (3,0) -> (3,6)
                    updateGameCells(3);
                }
                else if (sender == sing_btnCol5)
                {
                    // Add a token to column 5 (4,0) -> (4,6)
                    updateGameCells(4);
                }
                else if (sender == sing_btnCol6)
                {
                    // Add a token to column 6 (5,0) -> (5,6)
                    updateGameCells(5);
                }
                else if (sender == sing_btnCol7)
                {
                    // Add a token to column 7 (6,0) -> (6,6)
                    updateGameCells(6);
                }

                CheckGameStatus();

            }
        }

        // Update the cells and GUI
        private void updateGameCells(int currentCol)
        {
            switch (currentCol)
            {
                case 0:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;

                            // This is for testing using an image for a cell instead of a color 4-13-2025
                            // This does work but the images are offset from the center
                            //if (gameConfig.getPlayerColor() == "Yellow")
                            //{
                            //    gameBoard.getCell(i, currentCol).setCellImage(gameConfig.getPlayerOneImage());
                            //}
                            //else if (gameConfig.getPlayerColor() == "Red")
                            //{
                            //    gameBoard.getCell(i, currentCol).setCellImage(gameConfig.getPlayerTwoImage());
                            //}

                            break;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;
                            break;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;
                            break;
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;
                            break;
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;
                            break;
                        }
                    }
                    break;
                case 6:
                    for (int i = 0; i < gameBoard.getRows(); i++)
                    {
                        if (gameBoard.getCell(i, currentCol).getClaimedStatus() == false)
                        {
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getColorOfCurrPlayer());
                            gameBoard.getCell(i, currentCol).setClaimStatus(true);
                            buttonClick[currentCol]++;
                            break;
                        }
                    }
                    break;
            }

            // Perform a check if the button should be disabled
            for (int i = 0; i < buttonClick.Length; i++)
            {
                if (buttonClick[i] == gameBoard.getRows())
                {
                    switch (i)
                    {
                        case 0:
                            sing_btnCol1.Enabled = false;
                            break;
                        case 1:
                            sing_btnCol2.Enabled = false;
                            break;
                        case 2:
                            sing_btnCol3.Enabled = false;
                            break;
                        case 3:
                            sing_btnCol4.Enabled = false;
                            break;
                        case 4:
                            sing_btnCol5.Enabled = false;
                            break;
                        case 5:
                            sing_btnCol6.Enabled = false;
                            break;
                        case 6:
                            sing_btnCol7.Enabled = false;
                            break;
                    }
                }
            }
        }

        // See if the game is over
        private void CheckGameStatus()
        {
            int totalCells = gameBoard.getEntireBoard().Length;
            int filledCells = 0;

            foreach (var cell in gameBoard.getEntireBoard())
            {
                if (cell.getClaimedStatus())
                {
                    filledCells++;
                }
            }

            // Every space on the grid is filled
            if (filledCells == totalCells)
            {
                gameConfig.setGameStatus(false);

                // For Debugging
                MessageBox.Show("Every Cell Is Filled", "Game Status");

                cleanUpGame();
            }
            else
            {
                if (areFourCellsConnected())
                {
                    if (gameConfig.getCurrentPlayer() == 1)
                    {
                        sing_lblCurrentPlayer.Text = "Player 1 Wins!";

                        gameConfig.setGameStatus(false);
                        gameConfig.setGameRunning(false);
                    }
                    else if (gameConfig.getCurrentPlayer() == 2)
                    {
                        sing_lblCurrentPlayer.Text = "AI Wins!";

                        gameConfig.setGameStatus(false);
                        gameConfig.setGameRunning(false);
                    }

                    MessageBox.Show("Four cells found connected, Resetting Game!");
                    cleanUpGame();
                }
                else
                {
                    // No connect 4 and the board still has cells
                    updatePlayerTurn();
                }
            }
        }

        // Clean up
        private void cleanUpGame()
        {
            // Here we would update the Struct that contains the game data. We would update how many times the game has been played
            // STATUS - NOT IMPLEMENTED


            foreach (var cell in gameBoard.getEntireBoard())
            {
                cell.setClaimStatus(false);
                cell.setCellColor(Color.White);
            }

            for (int i = 0; i < buttonClick.Length; i++)
            {
                buttonClick[i] = 0;
            }

            // The game is over so set each button enabled status to false
            foreach (Control button in this.Controls)
            {
                if (button is Button && (string)button.Tag == "btnColumn")
                {
                    button.Enabled = true;
                }
            }

            // Implement a New game button that will start the next game
            //  ~ INSERT CODE HERE FOR THAT LATER ~ 4 / 11 / 2025

            // Start game back with player one
            //(This needs to be edited for AI implementation)
            gameConfig.setCurrentPlayer(1);
            sing_lblCurrentPlayer.Text = string.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
            sing_pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

            // For debugging purposes I will reenable the game to continue playing, This can be changed later
            gameConfig.setGameRunning(true);
        }

        private bool areFourCellsConnected()
        {
            // Checking Horizontal Rows
            // Counter is 1 because we are counting the first cell
            int counter = 1;

            // Go over each row in the gameBoard
            for (int rows = 0; rows < gameBoard.getRows(); rows++)
            {
                // Go over each cell inside of the gameBoard - 1 because we are checking for cells in advance
                for (int cols = 0; cols < gameBoard.getColumns() - 1; cols++)
                {
                    if ((gameBoard.getCell(rows, cols).getCellColor() != Color.White && gameBoard.getCell(rows, cols + 1).getCellColor() != Color.White) && gameBoard.getCell(rows, cols).getCellColor() == gameBoard.getCell(rows, cols + 1).getCellColor())
                    {
                        counter++;

                        if (counter == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                // New row so we set the counter back to 1
                counter = 1;
            }

            // Check for a Connect 4 Vertically now
            // Go through each row and search + 1 of each column

            // Check each column
            for (int cols = 0; cols < gameBoard.getColumns(); cols++)
            {
                // Checks every element in row[0 -> 5] - 1
                for (int rows = 0; rows < gameBoard.getRows() - 1; rows++)
                {
                    if ((gameBoard.getCell(rows, cols).getCellColor() != Color.White && gameBoard.getCell(rows + 1, cols).getCellColor() != Color.White) && gameBoard.getCell(rows, cols).getCellColor() == gameBoard.getCell(rows + 1, cols).getCellColor())
                    {
                        counter++;

                        if (counter == 4)
                        {
                            return true;
                        }
                    }
                }
                counter = 1;
            }

            // Check Diagonally , Checks from bottom left to top right of the board
            // This would be checking the first cell and going row + 1 and col + 1, So when doing the for loop rows and cols would be - 1 on each check ; Putting more thought into this, I don't think this is the solution.

            // How this would work
            // {0,0}, {1,1}, {2,2} , {3,3} would be diagonally

            for (int i = 0; i < gameBoard.getRows() - 3; i++)
            {
                for (int j = 0; j < gameBoard.getColumns() - 3; j++)
                {
                    // Visual of how this functions ~ Uncomment to see what happens
                    //gameBoard.getCell(i, j).setCellColor(Color.Green.ToString());
                    //Thread.Sleep(100);
                    //Application.DoEvents(); // This will update anything that is in the application buffer, Right now it's just used to update the cell color visually ~ https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.doevents?view=windowsdesktop-9.0

                    if (gameBoard.getCell(i, j).getCellColor() != Color.White)
                    {
                        // This checks left to upper right, We need another check going left to bottom right 
                        if (gameBoard.getCell(i, j).getCellColor() == gameBoard.getCell(i + 1, j + 1).getCellColor() && gameBoard.getCell(i + 1, j + 1).getCellColor() == gameBoard.getCell(i + 2, j + 2).getCellColor() && gameBoard.getCell(i + 2, j + 2).getCellColor() == gameBoard.getCell(i + 3, j + 3).getCellColor())
                        {
                            return true;
                        }
                    }
                }
            }

            // Check Diagonally Reverse, Checks from top left to the bottom right of the board
            // {5,0} -> {0, 6}
            // Start from the top left most cell
            for (int i = gameBoard.getRows() - 1; i > 2; i--)
            {
                // Move through each index in the columns now
                for (int j = 0; j < gameBoard.getColumns() - 3; j++)
                {
                    // Visual of what is happening in this loop ~ Uncomment to see what happens
                    //gameBoard.getCell(i, j).setCellColor(Color.Green.ToString());
                    //Thread.Sleep(100);
                    //Application.DoEvents(); // This will update anything that is in the application buffer, Right now it's just used to update the cell color visually ~ https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.doevents?view=windowsdesktop-9.0

                    if (gameBoard.getCell(i, j).getCellColor() != Color.White)
                    {
                        if (gameBoard.getCell(i, j).getCellColor() == gameBoard.getCell(i - 1, j + 1).getCellColor() && gameBoard.getCell(i - 1, j + 1).getCellColor() == gameBoard.getCell(i - 2, j + 2).getCellColor() && gameBoard.getCell(i - 2, j + 2).getCellColor() == gameBoard.getCell(i - 3, j + 3).getCellColor())
                        {
                            return true;
                        }
                    }

                }
            }


            return false;
        }

        //Function for AI movement
        //private void AI_Move()
        //{
        //    //Debugging
        //    Console.WriteLine("AI Turn Triggered");
        //
        //    gameConfig.setPlayerColor(gameConfig.getAIColor());
        //    Color playerColor = gameConfig.getPlayerColor();
        //    Color aiColor = gameConfig.getAIColor();
        //
        //    for (int col = 0; col < gameBoard.getColumns(); col++)
        //    {
        //        int row = GetAvailableRow(col);
        //
        //        if (row == -1)
        //            continue;
        //
        //        Cell simulatedCell = gameBoard.getCell(row, col);
        //
        //        //Simulate the player placing a coin
        //        simulatedCell.setClaimStatus(true);
        //        simulatedCell.setCellColor(playerColor);
        //
        //        //Pretend its player1 turn for check
        //        gameConfig.setPlayerColor(playerColor);
        //
        //        //Check if the player is about to win
        //        if(areFourCellsConnected())
        //        {
        //            //Undo simulation
        //            simulatedCell.setClaimStatus(false);
        //            //Make this the "empty" color
        //            simulatedCell.setCellColor(Color.White);
        //
        //            gameConfig.setAIColor(aiColor);
        //
        //
        //            // Right here lets do a switch case to click the column button instead.
        //            // Clicking the button performs all the required updates and checks
        //            // SMUCK CODE
        //            //AI blocks the player here
        //            //updateGameCells(col);
        //            // END SMUCK CODE
        //
        //            switch (col)
        //            {
        //                case 0:
        //                    sing_btnCol1.PerformClick();
        //                    break;
        //                case 1:
        //                    sing_btnCol2.PerformClick();
        //                    break;
        //                case 2:
        //                    sing_btnCol3.PerformClick();
        //                    break;
        //                case 3:
        //                    sing_btnCol4.PerformClick();
        //                    break;
        //                case 4:
        //                    sing_btnCol5.PerformClick();
        //                    break;
        //                case 5:
        //                    sing_btnCol6.PerformClick();
        //                    break;
        //                case 6:
        //                    sing_btnCol7.PerformClick();
        //                    break;
        //            }
        //
        //            CheckGameStatus();
        //
        //            return;
        //        }
        //
        //        //Undo full simulation
        //        simulatedCell.setClaimStatus(false);
        //        simulatedCell.setCellColor(Color.White);
        //    }
        //
        //    //If there isn't a player win threat, pick the first column
        //    for (int col = 0; col < gameBoard.getColumns(); col++)
        //    {
        //        int row = GetAvailableRow(col);
        //        if (row != -1)
        //        {
        //            gameConfig.setAIColor(aiColor);
        //            //updateGameCells(col);
        //            return;
        //        }
        //    }
        //
        //}

        // Matt W, AI implementation
        private void AI_MoveV2()
        {
            // This would be the Row and Col that the ai would place its piece if a win for the player is possible
            int row = -1;
            int col = -1;

            if (willPlayerWin(ref row, ref col))
            {
                MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\n To stop a player horizontal win");

                // Place a piece based on what col is returned
                switch (col)
                {
                    case 0:
                        sing_btnCol1.PerformClick();
                        break;
                    case 1:
                        sing_btnCol2.PerformClick();
                        break;
                    case 2:
                        sing_btnCol3.PerformClick();
                        break;
                    case 3:
                        sing_btnCol4.PerformClick();
                        break;
                    case 4:
                        sing_btnCol5.PerformClick();
                        break;
                    case 5:
                        sing_btnCol6.PerformClick();
                        break;
                    case 6:
                        sing_btnCol7.PerformClick();
                        break;
                }

                return;
            }

            // Place a cell if it's possible to win with the AI

            // Place a cell in a random spot on the board if no win state is found

            // First find out if any buttons are disabled
            int goodButtons = 0;
            foreach (var btnEnabled in buttonClick)
            {
                if (btnEnabled != 6)
                {
                    goodButtons++;
                }
            }

            int randomCol = getRandomNumber(goodButtons);

            switch (randomCol)
            {
                case 0:
                    sing_btnCol1.PerformClick();
                    break;
                case 1:
                    sing_btnCol2.PerformClick();
                    break;
                case 2:
                    sing_btnCol3.PerformClick();
                    break;
                case 3:
                    sing_btnCol4.PerformClick();
                    break;
                case 4:
                    sing_btnCol5.PerformClick();
                    break;
                case 5:
                    sing_btnCol6.PerformClick();
                    break;
                case 6:
                    sing_btnCol7.PerformClick();
                    break;
            }
        }

        private int GetAvailableRow(int col)
        {
            for (int row = gameBoard.getRows() - 1; row >= 0; row--)
            {
                if (!gameBoard.getCell(row, col).getClaimedStatus())
                    return row;
            }

            //Column full
            return -1;
        }

        private void updatePlayerTurn()
        {
            if (gameConfig.getCurrentPlayer() == 1)
            {
                // Since this is single player we now want to call the AI move
                gameConfig.setCurrentPlayer(2);
                sing_lblCurrentPlayer.Text = System.String.Format("AI's Turn", gameConfig.getCurrentPlayer());
                sing_pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

                //AI_Move();
                AI_MoveV2();
            }
            else if (gameConfig.getCurrentPlayer() == 2)
            {
                // Set the next player to player one
                gameConfig.setCurrentPlayer(1);
                sing_lblCurrentPlayer.Text = System.String.Format("Your Turn", gameConfig.getCurrentPlayer());
                sing_pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();


            }
        }

        private void singleBtn_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return to the main menu?\nThis game will not be saved.", "Confirm Exit?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                mainMenuForm.Show();
                this.Close();
            }
        }

        //                          ref is the same thing as & in CPP
        private bool willPlayerWin(ref int lastOpenRow, ref int lastOpenCol)
        {
            Color playerColor = gameConfig.getPlayerColor();
            int rows = gameBoard.getRows();
            int cols = gameBoard.getColumns();


            // Search for a win condition of the player and save the last cell the player needs
            // Checks Horizontal win state. Left to Right
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 3; j++)
                {
                    if (gameBoard.getCell(i,j).getCellColor() == playerColor)
                    {
                        // This states that cells 1, 2, and 3 are claimed by the player and the fourth cell is unclaimed.
                        if (gameBoard.getCell(i, j + 1).getCellColor() == playerColor 
                            && gameBoard.getCell(i, j + 2).getCellColor() == playerColor
                            && gameBoard.getCell(i, j + 3).getClaimedStatus() == false)
                        {
                            lastOpenRow = i;
                            lastOpenCol = j + 3;
                            return true;
                        }
                    }
                }
            }

            // Checks Horizontal win state. Right to Left
            for (int i = 0; i < rows; i++)
            {
                for (int j = gameBoard.getColumns() - 1; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        // This states that cells 1, 2, and 3 are claimed by the player and the fourth cell is unclaimed.
                        if (gameBoard.getCell(i, j - 1).getCellColor() == playerColor
                            && gameBoard.getCell(i, j - 2).getCellColor() == playerColor
                            && gameBoard.getCell(i, j - 3).getClaimedStatus() == false)
                        {
                            lastOpenRow = i;
                            lastOpenCol = j - 3;
                            return true;
                        }
                    }
                }
            }


            return false;
        }

        private int getRandomNumber(int num)
        {
            Random rnd = new Random();

            return rnd.Next(num);
        }
    }
}
