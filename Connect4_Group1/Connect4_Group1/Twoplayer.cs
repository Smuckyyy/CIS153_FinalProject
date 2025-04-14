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
        Form1 mainMenuForm;

        Board gameBoard = new Board();
        GameSettings gameConfig = new GameSettings();

        // This holds how many time a button has been click.
        // Could be used to dictate if the game should end or
        // When a button should be disabled
        int[] buttonClick = { 0, 0, 0, 0, 0, 0, 0 };

        public Twoplayer()
        {
            InitializeComponent();
        }

        public Twoplayer(Form1 tp)
        {
            InitializeComponent();
            mainMenuForm = tp;

            this.FormBorderStyle = FormBorderStyle.Fixed3D; // Disable the ability to resize
            this.StartPosition = FormStartPosition.CenterScreen; // Open the form at the center of the users screen

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
            gameConfig.setCurrentPlayer(1); // Player 1 will start first
            gameConfig.setPlayerColor("Yellow");
            gameConfig.setPlayerTwoColor("Red");

            pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());
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

                // Most of this will need to be updated in CheckGameStatus 4-10-2025
                //if (gameConfig.getCurrentPlayer() == 1)
                //{
                //    // Set the next player to 2
                //    gameConfig.setCurrentPlayer(2);
                //    gameConfig.setPlayerColor("Red");
                //    lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
                //    pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());
                //}
                //else
                //{
                //    // Set the next player to 1
                //    gameConfig.setCurrentPlayer(1);
                //    gameConfig.setPlayerColor("Yellow");
                //    lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
                //    pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());
                //}

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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                            gameBoard.getCell(i, currentCol).setCellColor(gameConfig.getPlayerColor());
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
                    if (gameConfig.getCurrentPlayer() == 1)
                    {
                        lblCurrentPlayer.Text = "Player 1 Wins!";

                        gameConfig.setGameStatus(false);
                        gameConfig.setGameRunning(false);
                    }
                    else if (gameConfig.getCurrentPlayer() == 2)
                    {
                        lblCurrentPlayer.Text = "Player 2 Wins!";

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
                cell.setCellColor("White");
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
            gameConfig.setCurrentPlayer(1);
            gameConfig.setPlayerColor("Yellow");
            lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
            pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());

            // For debugging purposes I will reenable the game to continue playing, This can be changed later
            gameConfig.setGameRunning(true);
        }

        private bool areFourCellsConnected()
        {
            // Checking Horizontal Rows

            // This just takes extra computation time because we can just go over the gameBoard itself
            // instead of re-creating it this way
            //List<List<string>> colorGrid = new List<List<string>>(gameBoard.getRows());

            //for (int i = 0; i < gameBoard.getRows(); i++)
            //{
            //    List<string> colors = new List<string>(gameBoard.getColumns());
            //    for (int j = 0; j < gameBoard.getColumns(); j++)
            //    {
            //        if (gameBoard.getCell(i,j).getClaimedStatus() == true)
            //        {
            //            colors.Add(gameBoard.getCell(i,j).getCellColor());
            //        }
            //    }
            //    colorGrid.Add(colors);
            //}

            // Counter is 1 because we are counting the first cell
            int counter = 1;

            // Go over each row in the gameBoard
            for (int rows = 0; rows < gameBoard.getRows(); rows++)
            {
                // Go over each cell inside of the gameBoard - 1 because we are checking for cells in advance
                for (int cols = 0; cols < gameBoard.getColumns() - 1; cols++)
                {
                    if ((gameBoard.getCell(rows, cols).getCellColor() != Color.White.ToString() && gameBoard.getCell(rows, cols + 1).getCellColor() != Color.White.ToString()) && gameBoard.getCell(rows, cols).getCellColor() == gameBoard.getCell(rows, cols + 1).getCellColor())
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


                    //if (colorGrid[i][j] == colorGrid[i][j + 1])
                    //{
                    //    counter++;

                    //    if (counter == 4)
                    //    {
                    //        return true;
                    //    }
                    //}
                    //else
                    //{
                    //    // The next color was not the same as the previous one,
                    //    // reset the counter , while checking a row
                    //    counter = 1;
                    //}
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
                    if ((gameBoard.getCell(rows, cols).getCellColor() != Color.White.ToString() && gameBoard.getCell(rows + 1, cols).getCellColor() != Color.White.ToString()) && gameBoard.getCell(rows, cols).getCellColor() == gameBoard.getCell(rows + 1, cols).getCellColor())
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
            // This would be checking the first cell and going row + 1 and col + 1, So when doing the for loop rows and cols would be - 1 on each check ; Putting more though into this, I don't think this is the solution.

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

                    if (gameBoard.getCell(i, j).getCellColor() != Color.White.ToString())
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

                    if (gameBoard.getCell(i,j).getCellColor() != Color.White.ToString())
                    {
                        if (gameBoard.getCell(i,j).getCellColor() == gameBoard.getCell(i - 1, j + 1).getCellColor() && gameBoard.getCell(i - 1, j + 1).getCellColor() == gameBoard.getCell(i - 2, j + 2).getCellColor() && gameBoard.getCell(i - 2, j + 2).getCellColor() == gameBoard.getCell(i - 3, j + 3).getCellColor())
                        {
                            return true;
                        }
                    }

                }
            }


            return false;
        }

        private void updatePlayerTurn()
        {
            if (gameConfig.getCurrentPlayer() == 1)
            {
                //Set the next player to player two
                gameConfig.setCurrentPlayer(2);
                gameConfig.setPlayerColor("Red");
                lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
                pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());
            }
            else if (gameConfig.getCurrentPlayer() == 2)
            {
                // Set the next player to player one
                gameConfig.setCurrentPlayer(1);
                gameConfig.setPlayerColor("Yellow");
                lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
                pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());


            }
        }

        private void doubleBtn_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return to the main menu?\nThis game will not be saved.", "Confirm Exit?", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                mainMenuForm.Show();
                this.Close();
            }
            
        }
    }
}
