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
        Form1 twoplayerForm;

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
            twoplayerForm = tp;

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                gameConfig.setGameRunning(false);
            }
        }

        public void twoplayerFormPass(Form1 tp)
        {
            twoplayerForm = tp;
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

            if (areFourCellsConnected())
            {
                MessageBox.Show("Four cells found connected");
            }
        }

        // Clean up
        private void cleanUpGame()
        {
            foreach (var cell in gameBoard.getEntireBoard())
            {
                cell.setClaimStatus(false);
                cell.setCellColor(SystemColors.ScrollBar.ToString());
            }

            for (int i = 0; i < buttonClick.Length; i++)
            {
                buttonClick[i] = 0;
            }

            foreach (Control button in this.Controls)
            {
                if (button is Button && (string)button.Tag == "btnColumn")
                {
                    button.Enabled = true;
                }
            }

            // Start game back with player one
            gameConfig.setCurrentPlayer(1);
            gameConfig.setPlayerColor("Yellow");
            lblCurrentPlayer.Text = String.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
            pictureBoxPlayerColor.BackColor = Color.FromName(gameConfig.getPlayerColor());
        }

        private bool areFourCellsConnected()
        {
            // Checking Horizontal Rows
            List<List<string>> colorGrid = new List<List<string>>(gameBoard.getRows());

            for (int i = 0; i < gameBoard.getRows(); i++)
            {
                List<string> colors = new List<string>(gameBoard.getColumns());
                for (int j = 0; j < gameBoard.getColumns(); j++)
                {
                    if (gameBoard.getCell(i,j).getClaimedStatus() == true)
                    {
                        colors.Add(gameBoard.getCell(i,j).getCellColor());
                    }
                }
                colorGrid.Add(colors);
            }

            int counter = 1;

            for (int i = 0; i < colorGrid.Count; i++)
            {
                for (int j = 0; j < colorGrid[i].Count - 1; j++)
                {
                    if (colorGrid[i][j] == colorGrid[i][j + 1])
                    {
                        counter++;

                        if (counter == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        // The next color was not the same as the previous one,
                        // reset the counter , while checking a row
                        counter = 1;
                    }
                }
                // New row so we set the counter back to 1
                counter = 1;
            }


            return false;
        }
    }
}
