using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4_Group1
{
    public partial class Twoplayer : Form
    {
        Form1 mainMenuForm; // Pass the main menu form to this

        Board gameBoard = new Board(); // Creates the 2D Board
        GameSettings gameConfig; // Settings

        // Holds the info from the Data class
        Data c_data;

        // This array will hold the Picture boxes that caused the game to end 
        PictureBox[] picBoxWinners;

        // This holds how many time a button has been click.
        // Could be used to dictate if the game should end or
        // When a button should be disabled
        int[] buttonClick = { 0, 0, 0, 0, 0, 0, 0 };

        public Twoplayer()
        {
            InitializeComponent();
        }

        public Twoplayer(Form1 tp, Data p_data)
        {
            InitializeComponent();
            mainMenuForm = tp;

            this.FormBorderStyle = FormBorderStyle.Fixed3D; // Disable the ability to resize
            this.StartPosition = FormStartPosition.CenterScreen; // Open the form at the center of the users screen
            c_data = p_data;

            try
            {
                setBoardCellData();

                // For Debugging
                gameBoard.getEntireBoard();

                // Create the settings used for the game
                setupGameSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Init the game settings
        private void setupGameSettings()
        {

            // Use the constructor instead
            gameConfig = new GameSettings(Color.Yellow, Color.Red, 1, true);

            pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

        }

        // Called once at runtime to setup the 2D Array grid
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
                if (sender == btnCol1)
                {
                    // Add a token to column 1 ; (0,0) -> (0,6)
                    updateGameCells(0);
                }
                else if (sender == btnCol2)
                {

                    // Add a token to column 2 (1,0) -> (1,6)
                    updateGameCells(1);
                }
                else if (sender == btnCol3)
                {
                    // Add a token to column 3 (2,0) -> (2,6)
                    updateGameCells(2);
                }
                else if (sender == btnCol4)
                {
                    // Add a token to column 4 (3,0) -> (3,6)
                    updateGameCells(3);
                }
                else if (sender == btnCol5)
                {
                    // Add a token to column 5 (4,0) -> (4,6)
                    updateGameCells(4);
                }
                else if (sender == btnCol6)
                {
                    // Add a token to column 6 (5,0) -> (5,6)
                    updateGameCells(5);
                }
                else if (sender == btnCol7)
                {
                    // Add a token to column 7 (6,0) -> (6,6)
                    updateGameCells(6);
                }

                // Search the board for a win status
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

                            return;
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
                            return;
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
                            return;
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
                            return;
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
                            return;
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
                            return;
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
                            return;
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
                            btnCol1.Enabled = false;
                            break;
                        case 1:
                            btnCol2.Enabled = false;
                            break;
                        case 2:
                            btnCol3.Enabled = false;
                            break;
                        case 3:
                            btnCol4.Enabled = false;
                            break;
                        case 4:
                            btnCol5.Enabled = false;
                            break;
                        case 5:
                            btnCol6.Enabled = false;
                            break;
                        case 6:
                            btnCol7.Enabled = false;
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
                    // Here I would pass the game status to the new stats form and update the public struct of game data
                    // because areFourCellsConnected returned true meaning that a player has won the game
                    statsAfterTwoPlayerGame satpg = new statsAfterTwoPlayerGame(gameConfig.getCurrentPlayer(), gameConfig.getColorOfCurrPlayer(), this);

                    displayWinningPicBoxes();

                    satpg.ShowDialog(); // Display the TPG Complete form

                    // If the user close out of the form this will happen, Otherwise if the Exit button is clicked the entire program is closed
                    cleanUpGame();

                }
                else
                {
                    // No connect 4 and the board still has cells
                    updatePlayerTurn();
                }
            }
        }

        // Clean up ; Should only be called if A.) The entire board is filled, or B.) A player got connect 4
        private void cleanUpGame()
        {
            // Update the .txt file
            updatePersistantData();


            // Set each cell back to its default value
            foreach (var cell in gameBoard.getEntireBoard())
            {
                cell.setClaimStatus(false);
                cell.setCellColor(Color.White);
            }

            // Set the array of button clicks back to 0
            for (int i = 0; i < buttonClick.Length; i++)
            {
                buttonClick[i] = 0;
            }

            // Set each button for the coloums back to enabled
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
            gameConfig.setCurrentPlayer(1);
            gameConfig.setPlayerColor(Color.Yellow);
            lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
            pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

            // For debugging purposes I will reenable the game to continue playing, This can be changed later
            //gameConfig.setGameRunning(true);
        }

        // Check to see if a player has won the game
        private bool areFourCellsConnected()
        {
            // Checking Horizontal Rows
            // Version 2 not using a counter
            for (int rows = 0; rows < gameBoard.getRows(); rows++)
            {
                for (int cols = 0; cols < gameBoard.getColumns() - 3; cols++)
                {
                    if (gameBoard.getCell(rows, cols).getCellColor() == gameConfig.getColorOfCurrPlayer())
                    {
                        if (gameBoard.getCell(rows, cols + 1).getCellColor() == gameConfig.getColorOfCurrPlayer() && gameBoard.getCell(rows, cols + 2).getCellColor() == gameConfig.getColorOfCurrPlayer() && gameBoard.getCell(rows, cols + 3).getCellColor() == gameConfig.getColorOfCurrPlayer())
                        {
                            // Add the cells that caused the connect 4 to the array
                            picBoxWinners = new PictureBox[4];
                            picBoxWinners[0] = gameBoard.getCell(rows, cols).getPictureBox();
                            picBoxWinners[1] = gameBoard.getCell(rows, cols + 1).getPictureBox();
                            picBoxWinners[2] = gameBoard.getCell(rows, cols + 2).getPictureBox();
                            picBoxWinners[3] = gameBoard.getCell(rows, cols + 3).getPictureBox();

                            MessageBox.Show("Win State: Horizontal");
                            return true;
                        }
                    }
                }
            }

            // Check for a Connect 4 Vertically now
            // Goes through each column and checks each row + 1 for a connect 4

            // Check each column
            // Version 2 not using a counter
            for (int cols = 0; cols < gameBoard.getColumns(); cols++)
            {
                // Go up each row and see if four cells match
                for (int rows = 0; rows < gameBoard.getRows() - 3; rows++)
                {
                    // This is the first cell of the current player
                    if (gameBoard.getCell(rows, cols).getCellColor() == gameConfig.getColorOfCurrPlayer())
                    {
                        // Now we check for cell 2, 3, and 4
                        if (gameBoard.getCell(rows + 1, cols).getCellColor() == gameConfig.getColorOfCurrPlayer() && gameBoard.getCell(rows + 2, cols).getCellColor() == gameConfig.getColorOfCurrPlayer() && gameBoard.getCell(rows + 3, cols).getCellColor() == gameConfig.getColorOfCurrPlayer())
                        {
                            // The current player got a Horizontal connect 4
                            MessageBox.Show("Win State: Vertical");
                            return true;
                        }
                    }
                }
            }

            // Check Diagonally , Checks from bottom left to top right of the board
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
                            MessageBox.Show("Win State: Diagonal (B.Left to U.Right)");
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
                            MessageBox.Show("Win State: Diagonal (U.Left to B.Right)");
                            return true;
                        }
                    }
                }
            }


            return false;
        }

        // Change what player is currently placing a token
        private void updatePlayerTurn()
        {
            if (gameConfig.getCurrentPlayer() == 1)
            {
                //Set the next player to player two
                gameConfig.setCurrentPlayer(2);
                lblCurrentPlayer.Text = string.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
                pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();
            }
            else if (gameConfig.getCurrentPlayer() == 2)
            {
                // Set the next player to player one
                gameConfig.setCurrentPlayer(1);
                lblCurrentPlayer.Text = string.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
                pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();
            }
        }

        // This function will display where a players piece would go on the board if the button is clicked
        private void displayPiecePosition(int column)
        {
            for (int row = 0; row < gameBoard.getRows(); row++)
            {
                if (gameBoard.getCell(row, column).getClaimedStatus() == false)
                {
                    gameBoard.getCell(row, column).setCellColor(gameConfig.getColorOfCurrPlayer());
                    return;
                }
            }
        }

        // This function will remove the cell if the button was not clicked
        private void removePiecePosition(int column)
        {
            for (int row = 0; row < gameBoard.getRows(); row++)
            {
                if (gameBoard.getCell(row, column).getClaimedStatus() == false)
                {
                    gameBoard.getCell(row, column).setCellColor(Color.White);
                    return;
                }
            }
        }

        private void doubleBtn_Exit_Click(object sender, EventArgs e)
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

        // MouseEnter Handler for buttons
        private void btnCol_MouseEnter(object sender, EventArgs e)
        {
            if (sender == btnCol1)
            {
                //MessageBox.Show("Mouse Entered Buttton 1");
                displayPiecePosition(0);
            }
            else if(sender == btnCol2)
            {
                displayPiecePosition(1);
            }
            else if(sender == btnCol3)
            {
                displayPiecePosition(2);
            }
            else if(sender == btnCol4)
            {
                displayPiecePosition(3);
            }
            else if (sender == btnCol5)
            {
                displayPiecePosition(4);
            }
            else if (sender == btnCol6)
            {
                displayPiecePosition(5);
            }
            else if (sender == btnCol7)
            {
                displayPiecePosition(6);
            }
        }

        // MouseLeave Handler for buttons
        private void btnCol_MouseLeave(object sender, EventArgs e)
        {
            if (sender == btnCol1)
            {
                //MessageBox.Show("Mouse Entered Buttton 1");
                removePiecePosition(0);
            }
            else if (sender == btnCol2)
            {
                removePiecePosition(1);
            }
            else if (sender == btnCol3)
            {
                removePiecePosition(2);
            }
            else if (sender == btnCol4)
            {
                removePiecePosition(3);
            }
            else if (sender == btnCol5)
            {
                removePiecePosition(4);
            }
            else if (sender == btnCol6)
            {
                removePiecePosition(5);
            }
            else if (sender == btnCol7)
            {
                removePiecePosition(6);
            }
        }

        private void updatePersistantData()
        {
            // Will update the persistant data .txt file
            // Since this was called we can assume that a game has been played
            c_data.setTotalGames(c_data.getTotalGamesPlayed() + 1);

            // Only update the player wins here if the player that won was Player 1
            if (gameConfig.getCurrentPlayer() == 1)
            {
                c_data.setUserWins(c_data.getUserWins() + 1);
            }

            // Update the win percent of the user based on how many games have been played
            c_data.setUserWinPercent((c_data.getUserWins() / c_data.getTotalGamesPlayed()) * 100);

            // Right now I will just save this data and implement more later, Use this as a reference for Singleplayer! ! !
            c_data.writeToFile();
        }


        // This function will just be used to change the colors of the winning pictures boxes. Possibly strobe them...
        private void displayWinningPicBoxes()
        {
            int counter = 0;

            while (counter < 10)
            {
                foreach (PictureBox picBox in picBoxWinners)
                {
                    picBox.BackColor = Color.White;
                    Thread.Sleep(250);
                    Application.DoEvents();
                    picBox.BackColor = gameConfig.getColorOfCurrPlayer();
                }
                counter++;
            }
        }
    }
}
