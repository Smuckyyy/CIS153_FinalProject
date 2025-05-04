using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Connect4_Group1
{
    public partial class Singleplayer : Form
    {
        Form1 mainMenuForm;

        Board gameBoard = new Board();
        GameSettings gameConfig; // Initilized in game setup
        Data c_data;
        PictureBox[] picBoxWinners;


        // This holds how many time a button has been click.
        // Could be used to dictate if the game should end or
        // When a button should be disabled
        // Index will be unique *******************
        int[] buttonClick = { 0, 0, 0, 0, 0, 0, 0 };
        List<Button> btnList;

        // Variables for the counter
        const int weDefineCycleHere = 11;
        int displayCycles = weDefineCycleHere;

        // ENABLE/DISABLE THIS FOR DEBUGGING PROMPTS
        const bool shouldDebug = false;
        const bool shouldEnableAI = true; // Enable or Disable if you want the AI to actually place a piece
        const bool enableRandomAI = false;
        //=========================================

        public Singleplayer()
        {
            InitializeComponent();
        }

        public Singleplayer(Form1 sp, Data p_data)
        {
            InitializeComponent();
            mainMenuForm = sp;
            c_data = p_data;
            this.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                setBoardCellData();

                // For Debugging
                gameBoard.getEntireBoard();

                setupGameSettings();

                gameConfig.setGameStatus(true); // Setup completed so the game can proceed

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                gameConfig.setGameStatus(false);
            }
        }

        private void setupGameSettings()
        {
            // We can change to any piece color by changing these values
            gameConfig = new GameSettings(Color.Gold, Color.Purple, 1, true);

            sing_lblCurrentPlayer.Text = string.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
            sing_pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

            // Stores each clickable column button into a List<Button>
            btnList = new List<Button>() { sing_btnCol1, sing_btnCol2, sing_btnCol3, sing_btnCol4, sing_btnCol5, sing_btnCol6, sing_btnCol7 };
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
            if (gameConfig.getGameStatus())
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
                c_data.setGameTies(c_data.getGameTies() + 1);
                c_data.setTotalGames(c_data.getTotalGamesPlayed() + 1);
                c_data.writeToFile();

                // -1 will be consider a tie
                gameConfig.setCurrentPlayer(-1);

                displayAfterGameForm();


                // For Debugging
                if (shouldDebug)
                {
                    MessageBox.Show("Every Cell Is Filled", "Game Status");
                }

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
                    }
                    else if (gameConfig.getCurrentPlayer() == 2)
                    {
                        sing_lblCurrentPlayer.Text = "AI Wins!";

                        gameConfig.setGameStatus(false);
                    }

                    if (shouldDebug)
                    {
                        MessageBox.Show("Four cells found connected, Resetting Game!");
                    }

                    displayAfterGameForm();
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

            // Set every cell back to the starting color
            foreach (var cell in gameBoard.getEntireBoard())
            {
                cell.setClaimStatus(false);
                cell.setCellColor(Color.White);
            }

            // Set each index of buttonClick array back to 0
            for (int i = 0; i < buttonClick.Length; i++)
            {
                buttonClick[i] = 0;
            }

            // While cleaning up the game, Re-enable all the column buttons
            foreach (Control button in this.Controls)
            {
                if (button is Button && (string)button.Tag == "btnColumn")
                {
                    button.Enabled = true;
                }
            }

            // Sets everything back to square 1
            setupGameSettings();
        }

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

                            if (shouldDebug)
                            {
                                MessageBox.Show("Win State: Horizontal");
                            }

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

                            // Add the cells that caused the connect 4 to the array
                            picBoxWinners = new PictureBox[4];
                            picBoxWinners[0] = gameBoard.getCell(rows, cols).getPictureBox();
                            picBoxWinners[1] = gameBoard.getCell(rows + 1, cols).getPictureBox();
                            picBoxWinners[2] = gameBoard.getCell(rows + 2, cols).getPictureBox();
                            picBoxWinners[3] = gameBoard.getCell(rows + 3, cols).getPictureBox();

                            if (shouldDebug)
                            {
                                // The current player got a Horizontal connect 4
                                MessageBox.Show("Win State: Vertical");
                            }
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
                for (int j = 0; j < gameBoard.getColumns() - 3; j++) {
              

                    if (gameBoard.getCell(i, j).getCellColor() != Color.White)
                    {
                        // This checks left to upper right, We need another check going left to bottom right 
                        if (gameBoard.getCell(i, j).getCellColor() == gameBoard.getCell(i + 1, j + 1).getCellColor() && gameBoard.getCell(i + 1, j + 1).getCellColor() == gameBoard.getCell(i + 2, j + 2).getCellColor() && gameBoard.getCell(i + 2, j + 2).getCellColor() == gameBoard.getCell(i + 3, j + 3).getCellColor())
                        {
                            // Add the cells that caused the connect 4 to the array
                            picBoxWinners = new PictureBox[4];
                            picBoxWinners[0] = gameBoard.getCell(i, j).getPictureBox();
                            picBoxWinners[1] = gameBoard.getCell(i + 1, j + 1).getPictureBox();
                            picBoxWinners[2] = gameBoard.getCell(i + 2, j + 2).getPictureBox();
                            picBoxWinners[3] = gameBoard.getCell(i + 3, j + 3).getPictureBox();

                            if (shouldDebug)
                            {
                                MessageBox.Show("Win State: Diagonal (B.Left to U.Right)");
                            }
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
                    

                    if (gameBoard.getCell(i, j).getCellColor() != Color.White)
                    {
                        if (gameBoard.getCell(i, j).getCellColor() == gameBoard.getCell(i - 1, j + 1).getCellColor() && gameBoard.getCell(i - 1, j + 1).getCellColor() == gameBoard.getCell(i - 2, j + 2).getCellColor() && gameBoard.getCell(i - 2, j + 2).getCellColor() == gameBoard.getCell(i - 3, j + 3).getCellColor())
                        {
                            // Add the cells that caused the connect 4 to the array
                            picBoxWinners = new PictureBox[4];
                            picBoxWinners[0] = gameBoard.getCell(i, j).getPictureBox();
                            picBoxWinners[1] = gameBoard.getCell(i - 1, j + 1).getPictureBox();
                            picBoxWinners[2] = gameBoard.getCell(i - 2, j + 2).getPictureBox();
                            picBoxWinners[3] = gameBoard.getCell(i - 3, j + 3).getPictureBox();

                            if (shouldDebug)
                            {
                                MessageBox.Show("Win State: Diagonal (U.Left to B.Right)");
                            }

                            return true;
                        }
                    }
                }
            }


            return false;
        }

        // Matt W, AI implementation
        private void AI_MoveV2()
        {
            // This would be the Row and Col that the ai would place its piece if a win for the player is possible
            int row = -1;
            int col = -1;

            if (willAIWin("diagonal", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would win diagonally up by placing at: " + "Row: " + row + " Col: " + col);
                }
                makeMove(col);
                return;
            }
            if (willAIWin("horizontal", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would win horizontally by placing at: " + "Row: " + row + " Col: " + col);
                }
                makeMove(col);
                return;
            }
            if (willAIWin("vertical", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would win vertically by placing at: " + "Row: " + row + " Col: " + col);
                }
                makeMove(col);
                return;
            }

            if (willPlayerWin("diagonal", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player diagonal-up win.");
                }
                makeMove(col);
                return;
            }
            if (willPlayerWin("horizontal", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player horizontal win.");
                }
                makeMove(col);
                return;
            }
            if (willPlayerWin("vertical", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player vertical win.");
                }
                makeMove(col);
                return;
            }

            // Since none of the logic returned anything we ended up at this point
            if (shouldEnableAI)
            {
                if (enableRandomAI)
                {
                    makeMove(getRandomNumber());
                }
                else
                {
                    verySimpleAIStrat();
                }
            }
        }

        private void AI_MoveV3()
        {
            if (shouldEnableAI)
            {
                int col = -1;

                AICheckWinStates(ref col);

                if (col > 0)
                {
                    makeMove(col);
                }
                else
                {
                    if (enableRandomAI)
                    {
                        makeMove(getRandomNumber());
                    }
                    else
                    {
                        verySimpleAIStrat();
                    }
                }
            }
        }

        private void makeMove(int col)
        {
            // Cols go from 0 - 6 (Which is 7 total)
            if (buttonClick[col] != 6)
            {
                btnList[col].PerformClick();
            }
            else
            {
                // Will place a piece in the next available column, This happens if it tries to click a button that is disabled
                for (int i = 0; i < buttonClick.Length; i++)
                {
                    if (buttonClick[i] != 6)
                    {
                        btnList[i].PerformClick();
                        return;
                    }
                }
            }
        }

        private void updatePlayerTurn()
        {
            if (gameConfig.getCurrentPlayer() == 1)
            {
                // Since this is single player we now want to call the AI move
                gameConfig.setCurrentPlayer(2);
                sing_lblCurrentPlayer.Text = System.String.Format("Player 2's Turn", gameConfig.getCurrentPlayer());
                sing_pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

                //AI_MoveV2();
                AI_MoveV3();
            }
            else if (gameConfig.getCurrentPlayer() == 2)
            {
                // Set the next player to player one
                gameConfig.setCurrentPlayer(1);
                sing_lblCurrentPlayer.Text = System.String.Format("Player 1's Turn", gameConfig.getCurrentPlayer());
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

        //                                       ref is the same thing as & in CPP
        private bool willPlayerWin(string direction, ref int lastOpenRow, ref int lastOpenCol)
        {
            Color playerColor = gameConfig.getPlayerColor(); // This get will always be yellow btw
            int rows = gameBoard.getRows();
            int cols = gameBoard.getColumns();

            //Marcus Code: Added a switch case for directional checks
            switch (direction)
            {
                case "horizontal":
                    //Left to Right
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols - 3; j++)
                        {
                            if (i < 1)
                            {
                                if (gameBoard.getCell(i, j).getCellColor() == playerColor
                                && gameBoard.getCell(i, j + 1).getCellColor() == playerColor
                                && gameBoard.getCell(i, j + 2).getCellColor() == playerColor
                                && gameBoard.getCell(i, j + 3).getClaimedStatus() == false)
                                {
                                    lastOpenRow = i;
                                    lastOpenCol = j + 3;
                                    return true;
                                }
                            }
                            else
                            {
                                if (gameBoard.getCell(i, j).getCellColor() == playerColor
                                && gameBoard.getCell(i, j + 1).getCellColor() == playerColor
                                && gameBoard.getCell(i, j + 2).getCellColor() == playerColor
                                && gameBoard.getCell(i, j + 3).getClaimedStatus() == false
                                && gameBoard.getCell(i - 1, j + 3).getClaimedStatus() == true)
                                {
                                    lastOpenRow = i;
                                    lastOpenCol = j + 3;
                                    return true;
                                }
                            }
                        }
                    }

                    //Right to left
                    // Start on the lowest bottom row
                    for (int row = 0; row < gameBoard.getRows(); row++)
                    {
                        // Start at the last column and go left
                        for (int col = gameBoard.getColumns() - 1; col >= 3; col--)
                        {
                            if (row < 1)
                            {
                                if (gameBoard.getCell(row, col).getCellColor() == playerColor
                                && gameBoard.getCell(row, col - 1).getCellColor() == playerColor
                                && gameBoard.getCell(row, col - 2).getCellColor() == playerColor
                                && gameBoard.getCell(row, col - 3).getClaimedStatus() == false)
                                {
                                    lastOpenRow = row;
                                    lastOpenCol = col - 3;
                                    return true;
                                }
                            }
                            else
                            {
                                if (gameBoard.getCell(row, col).getCellColor() == playerColor
                                && gameBoard.getCell(row, col - 1).getCellColor() == playerColor
                                && gameBoard.getCell(row, col - 2).getCellColor() == playerColor
                                && gameBoard.getCell(row, col - 3).getClaimedStatus() == false
                                && gameBoard.getCell(row - 1, col - 3).getClaimedStatus() == true)
                                {
                                    lastOpenRow = row;
                                    lastOpenCol = col - 3;
                                    return true;
                                }
                            }
                        }
                    }
                    break;
                case "vertical":
                    // Bottom to Top, We only have to do this since all cells always go to the lowest point
                    for (int j = 0; j < cols; j++)
                    {
                        for (int i = 0; i < rows - 3; i++)
                        {
                            if (gameBoard.getCell(i, j).getCellColor() == playerColor
                                 && gameBoard.getCell(i + 1, j).getCellColor() == playerColor
                                 && gameBoard.getCell(i + 2, j).getCellColor() == playerColor
                                 && gameBoard.getCell(i + 3, j).getClaimedStatus() == false)
                            {
                                lastOpenRow = i + 3;
                                lastOpenCol = j;
                                return true;
                            }
                        }
                    }
                    break;
                case "diagonal":
                    // Matt W Code , Bottom left of board to Upper right of board Bottom left starts at {0,0} , Top right ends at {5,6}
                    for (int row = 0; row < rows - 3; row++)
                    {
                        for (int col = 0; col < cols - 3; col++)
                        {
                            if (gameBoard.getCell(row,col).getCellColor() == playerColor) // Found the first cell that contains the player color
                            {
                                // Now we check for cells 2, 3, and 4
                                if (gameBoard.getCell(row + 1, col + 1).getCellColor() == playerColor // Cell 2 is claimed by player
                                    && gameBoard.getCell(row + 2, col + 2).getCellColor() == playerColor // Cell 3 is claimed by player
                                    && gameBoard.getCell(row + 3, col + 3).getClaimedStatus() == false // Cell 4 is unclaimed and would lead to a win
                                    && gameBoard.getCell(row + 2, col + 3).getClaimedStatus() == true) // Safe check to see if the cell under is claimed so it doesn't waste a turn
                                {
                                    lastOpenRow = row + 3;
                                    lastOpenCol = col + 3;
                                    return true;
                                }
                            }
                        }
                    }

                    // Matt W Code, Bottom right to Upper Left of board, Bottom Right {0,6}, Upper Left {5,0}
                    for (int row = 0; row < rows - 3; row++)
                    {
                        for (int col = cols - 1; col >= 3; col--)
                        {
                            if (gameBoard.getCell(row,col).getCellColor() == playerColor)
                            {
                                // Now we check for cells 2, 3, and 4
                                if (gameBoard.getCell(row + 1, col - 1).getCellColor() == playerColor // Cell 2 is claimed by player
                                    && gameBoard.getCell(row + 2, col - 2).getCellColor() == playerColor // Cell 3 is claimed by player
                                    && gameBoard.getCell(row + 3, col - 3).getClaimedStatus() == false // Cell 4 is unclaimed and would lead to a win
                                    && gameBoard.getCell(row + 2, col - 3).getClaimedStatus() == true) // Safe check to see if the cell under is claimed so it doesn't waste a turn
                                {
                                    lastOpenRow = row + 3;
                                    lastOpenCol = col - 3;
                                    return true;
                                }
                            }
                        }
                    }



                    break;
            }

            return false;
        }

        private bool AICheckWinStates(ref int column)
        {
            // This will check any of these states,
            // -, X, X, X // Right -> Left
            // X, -, X, X // Diagonal
            // X, X, -, X // Diagonal
            // X, X, X, - // Left -> Right

            // i ; will always be rows
            // j ; will always be columns

            Color playerColor = gameConfig.getPlayerColor();
            Color AIColor = gameConfig.getPlayerTwoColor();

            int vectorRows = gameBoard.getRows() - 1;       // 5
            int vectorCols = gameBoard.getColumns() - 1;    // 6


            // DIAGONAL CHECKS ==============================================================
            // AI Win States
            // Left -> Right, X, X, X, -
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j + 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 2, j + 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 3, j + 3).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j + 3).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 3) + "," + (j + 3));
                            }
                            column = j + 3;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right, X, X, -, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j + 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 2, j + 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 3, j + 3).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 1, j + 2).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 2) + "," + (j + 2));
                            }
                            column = j + 2;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right, X, -, X, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j + 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j + 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 3, j + 3).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j + 1).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 1) + "," + (j + 1));
                            }
                            column = j + 1;
                            return true;
                        }
                    }
                }
            }
            // Right -> Left -, X, X, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j - 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 2, j - 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 3, j - 3).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j - 3).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 3) + "," + (j - 3));
                            }
                            column = j - 3;
                            return true;
                        }
                    }
                }
            }
            // Right -> Left X, -, X, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j - 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 2, j - 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 3, j - 3).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 1, j - 2).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 2) + "," + (j - 2));
                            }
                            column = j - 2;
                            return true;
                        }
                    }
                }
            }
            // Right -> Left X, X, -, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j - 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j - 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 3, j - 3).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j - 1).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 1) + "," + (j - 1));
                            }
                            column = j - 1;
                            return true;
                        }
                    }
                }
            }
            // END DIAGONAL CHECKS ==============================================================

            // VERTICAL CHECKS ==================================================================
            for (int j = 0; j < vectorCols; j++)
            {
                for (int i = 0; i < vectorRows - 3; i++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i + 1, j).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 2, j).getCellColor() == AIColor &&
                            gameBoard.getCell(i + 3, j).getClaimedStatus() == false)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 3) + "," + j);
                            }
                            column = j;
                            return true;
                        }
                    }
                }
            }
            // END VERTICAL CHECKS ==================================================================

            // HORIZONTAL CHECKS =================================================================
            // Left -> Right X, X, X, -
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i, j + 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j + 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j + 3).getClaimedStatus() == false)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j + 3));
                            }
                            column = j + 3;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right X, X, -, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i, j + 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j + 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j + 3).getCellColor() == AIColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j + 2));
                            }
                            column = j + 2;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right X, -, X, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i, j + 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j + 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j + 3).getCellColor() == AIColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j + 1));
                            }
                            column = j + 1;
                            return true;
                        }
                    }
                }
            }

            // Right -> Left -, X, X, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i, j - 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j - 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j - 3).getClaimedStatus() == false)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j - 3));
                            }
                            column = j - 3;
                            return true;
                        }
                    }
                }
            }

            // Right -> Left X, -, X, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i, j - 1).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j - 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j - 3).getCellColor() == AIColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j - 2));
                            }
                            column = j - 2;
                            return true;
                        }
                    }
                }
            }

            // Right -> Left X, X, -, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == AIColor)
                    {
                        if (gameBoard.getCell(i, j - 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j - 2).getCellColor() == AIColor &&
                            gameBoard.getCell(i, j - 3).getCellColor() == AIColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j - 1));
                            }
                            column = j - 1;
                            return true;
                        }
                    }
                }
            }
            // END HORIZONTAL CHECKS ==================================================================


            // DIAGONAL CHECKS ==============================================================
            // Player Win States
            // Left -> Right, X, X, X, -
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j + 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 2, j + 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 3, j + 3).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j + 3).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 3) + "," + (j + 3));
                            }
                            column = j + 3;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right, X, X, -, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j + 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 2, j + 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 3, j + 3).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 1, j + 2).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 2) + "," + (j + 2));
                            }
                            column = j + 2;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right, X, -, X, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j + 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j + 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 3, j + 3).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j + 1).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 1) + "," + (j + 1));
                            }
                            column = j + 1;
                            return true;
                        }
                    }
                }
            }
            // Right -> Left -, X, X, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j - 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 2, j - 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 3, j - 3).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j - 3).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 3) + "," + (j - 3));
                            }
                            column = j - 3;
                            return true;
                        }
                    }
                }
            }
            // Right -> Left X, -, X, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j - 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 2, j - 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 3, j - 3).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 1, j - 2).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 2) + "," + (j - 2));
                            }
                            column = j - 2;
                            return true;
                        }
                    }
                }
            }
            // Right -> Left X, X, -, X
            for (int i = 0; i < vectorRows - 3; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j - 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i + 2, j - 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 3, j - 3).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j - 1).getClaimedStatus() == true)
                        {
                            // A possible diagonal win was found
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 1) + "," + (j - 1));
                            }
                            column = j - 1;
                            return true;
                        }
                    }
                }
            }
            // END DIAGONAL CHECKS ==============================================================

            // VERTICAL CHECKS ==================================================================
            for (int j = 0; j < vectorCols; j++)
            {
                for (int i = 0; i < vectorRows - 3; i++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i + 1, j).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 2, j).getCellColor() == playerColor &&
                            gameBoard.getCell(i + 3, j).getClaimedStatus() == false)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + (i + 3) + "," + j);
                            }
                            column = j;
                            return true;
                        }
                    }
                }
            }
            // END VERTICAL CHECKS ==================================================================

            // HORIZONTAL CHECKS =================================================================
            // Left -> Right X, X, X, -
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i, j + 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j + 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j + 3).getClaimedStatus() == false)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j + 3));
                            }
                            column = j + 3;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right X, X, -, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i, j + 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j + 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j + 3).getCellColor() == playerColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j + 2));
                            }
                            column = j + 2;
                            return true;
                        }
                    }
                }
            }
            // Left -> Right X, -, X, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = 0; j < vectorCols - 3; j++)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i, j + 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j + 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j + 3).getCellColor() == playerColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j + 1));
                            }
                            column = j + 1;
                            return true;
                        }
                    }
                }
            }

            // Right -> Left -, X, X, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i, j - 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j - 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j - 3).getClaimedStatus() == false)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j - 3));
                            }
                            column = j - 3;
                            return true;
                        }
                    }
                }
            }

            // Right -> Left X, -, X, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i, j - 1).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j - 2).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j - 3).getCellColor() == playerColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j - 2));
                            }
                            column = j - 2;
                            return true;
                        }
                    }
                }
            }

            // Right -> Left X, X, -, X
            for (int i = 0; i < vectorRows; i++)
            {
                for (int j = vectorCols; j > 3; j--)
                {
                    if (gameBoard.getCell(i, j).getCellColor() == playerColor)
                    {
                        if (gameBoard.getCell(i, j - 1).getClaimedStatus() == false &&
                            gameBoard.getCell(i, j - 2).getCellColor() == playerColor &&
                            gameBoard.getCell(i, j - 3).getCellColor() == playerColor)
                        {
                            if (shouldDebug)
                            {
                                MessageBox.Show("A win would happen at " + i + "," + (j - 1));
                            }
                            column = j - 1;
                            return true;
                        }
                    }
                }
            }
            // END HORIZONTAL CHECKS ==================================================================

            return false;
        }

        //Marcus Code
        //This function is the exact same as willPlayerWin, but changes the color to red for the AI.
        //This is shown in the AI_MoveV2 code, to check if it can win first.
        private bool willAIWin(string direction, ref int lastOpenRow, ref int lastOpenCol)
        {
            Color aiColor = gameConfig.getPlayerTwoColor();
            int rows = gameBoard.getRows();
            int cols = gameBoard.getColumns();

            switch (direction)
            {
                case "horizontal":
                    //Left to Right
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols - 3; j++)
                        {
                            if (i < 1)
                            {
                                if (gameBoard.getCell(i, j).getCellColor() == aiColor
                                && gameBoard.getCell(i, j + 1).getCellColor() == aiColor
                                && gameBoard.getCell(i, j + 2).getCellColor() == aiColor
                                && gameBoard.getCell(i, j + 3).getClaimedStatus() == false)
                                {
                                    lastOpenRow = i;
                                    lastOpenCol = j + 3;

                                    return true;
                                }
                            }
                            else
                            {
                                // If greater than the first row perform a check to make sure that the cell below is claimed to not waste a move
                                if (gameBoard.getCell(i, j).getCellColor() == aiColor
                                && gameBoard.getCell(i, j + 1).getCellColor() == aiColor
                                && gameBoard.getCell(i, j + 2).getCellColor() == aiColor
                                && gameBoard.getCell(i, j + 3).getClaimedStatus() == false
                                && gameBoard.getCell(i - 1, j + 3).getClaimedStatus() == true)
                                {
                                    lastOpenRow = i;
                                    lastOpenCol = j + 3;

                                    return true;
                                }
                            }
                        }

                        //Right to left
                        // Start on the lowest bottom row
                        for (int row = 0; row < gameBoard.getRows(); row++)
                        {
                            // Start at the last column and go left
                            for (int col = gameBoard.getColumns() - 1; col >= 3; col--)
                            {
                                if (row < 1)
                                {
                                    if (gameBoard.getCell(row, col).getCellColor() == aiColor
                                    && gameBoard.getCell(row, col - 1).getCellColor() == aiColor
                                    && gameBoard.getCell(row, col - 2).getCellColor() == aiColor
                                    && gameBoard.getCell(row, col - 3).getClaimedStatus() == false)
                                    {
                                        lastOpenRow = row;
                                        lastOpenCol = col - 3;
                                        return true;
                                    }
                                }
                                else
                                {
                                    // If greater than the first row perform a check to make sure that the cell below is claimed to not waste a move
                                    if (gameBoard.getCell(row, col).getCellColor() == aiColor
                                    && gameBoard.getCell(row, col - 1).getCellColor() == aiColor
                                    && gameBoard.getCell(row, col - 2).getCellColor() == aiColor
                                    && gameBoard.getCell(row, col - 3).getClaimedStatus() == false
                                    && gameBoard.getCell(row - 1, col - 3).getClaimedStatus() == true)
                                    {
                                        lastOpenRow = row;
                                        lastOpenCol = col + 3;

                                        return true;
                                    }
                                }
                            }
                        }

                    }
                    break;
                case "vertical":
                    for (int j = 0; j < cols; j++)
                    {
                        for (int i = 0; i < rows - 3; i++)
                        {
                            if (gameBoard.getCell(i, j).getCellColor() == aiColor
                                 && gameBoard.getCell(i + 1, j).getCellColor() == aiColor
                                 && gameBoard.getCell(i + 2, j).getCellColor() == aiColor
                                 && gameBoard.getCell(i + 3, j).getClaimedStatus() == false)
                            {
                                lastOpenRow = i + 3;
                                lastOpenCol = j;

                                return true;
                            }

                        }
                    }
                    break;
                case "diagonal": // This only needs to check right to left & left to right
                    // Matt W Code , Bottom left of board to Upper right of board Bottom left starts at {0,0} , Top right ends at {5,6}
                    for (int row = 0; row < rows - 3; row++)
                    {
                        for (int col = 0; col < cols - 3; col++)
                        {
                            if (gameBoard.getCell(row, col).getCellColor() == aiColor) // Found the first cell that contains the player color
                            {
                                // Now we check for cells 2, 3, and 4
                                if (gameBoard.getCell(row + 1, col + 1).getCellColor() == aiColor // Cell 2 is claimed by player
                                    && gameBoard.getCell(row + 2, col + 2).getCellColor() == aiColor // Cell 3 is claimed by player
                                    && gameBoard.getCell(row + 3, col + 3).getClaimedStatus() == false // Cell 4 is unclaimed and would lead to a win
                                    && gameBoard.getCell(row + 2, col + 3).getClaimedStatus() == true) // Safe check to see if the cell under is claimed so it doesn't waste a turn
                                {
                                    lastOpenRow = row + 3;
                                    lastOpenCol = col + 3;
                                    return true;
                                }
                            }
                        }
                    }

                    // Matt W Code, Bottom right to Upper Left of board, Bottom Right {0,6}, Upper Left {5,0}
                    for (int row = 0; row < rows - 3; row++)
                    {
                        for (int col = cols - 1; col >= 3; col--)
                        {
                            if (gameBoard.getCell(row,col).getCellColor() == aiColor)
                            {
                                // Now we check for cells 2, 3, and 4
                                if (gameBoard.getCell(row + 1, col - 1).getCellColor() == aiColor // Cell 2 is claimed by player
                                    && gameBoard.getCell(row + 2, col - 2).getCellColor() == aiColor // Cell 3 is claimed by player
                                    && gameBoard.getCell(row + 3, col - 3).getClaimedStatus() == false // Cell 4 is unclaimed and would lead to a win
                                    && gameBoard.getCell(row + 2, col - 3).getClaimedStatus() == true) // Safe check to see if the cell under is claimed so it doesn't waste a turn
                                {
                                    lastOpenRow = row + 3;
                                    lastOpenCol = col - 3;
                                    return true;
                                }
                            }
                        }
                    }
                    break;
            }

            return false;
        }

        private int getRandomNumber()
        {
            Random rnd = new Random();

            int randomCol;
            do
            {
                randomCol = rnd.Next(btnList.Count);
            }
            while (randomCol >= btnList.Count || randomCol < 0);

            return randomCol;
        }

        private int getRandomNumber(int num)
        {
            Random rnd = new Random();

            return rnd.Next(num);
        }

        // These four functions handle displaying a users piece while mousing over a button
        // MouseEnter Handler for buttons
        private void btnCol_MouseEnter(object sender, EventArgs e)
        {
            if (sender == sing_btnCol1)
            {
                displayPiecePosition(0);
            }
            else if (sender == sing_btnCol2)
            {
                displayPiecePosition(1);
            }
            else if (sender == sing_btnCol3)
            {
                displayPiecePosition(2);
            }
            else if (sender == sing_btnCol4)
            {
                displayPiecePosition(3);
            }
            else if (sender == sing_btnCol5)
            {
                displayPiecePosition(4);
            }
            else if (sender == sing_btnCol6)
            {
                displayPiecePosition(5);
            }
            else if (sender == sing_btnCol7)
            {
                displayPiecePosition(6);
            }
        }

        // MouseLeave Handler for buttons
        private void btnCol_MouseLeave(object sender, EventArgs e)
        {
            if (sender == sing_btnCol1)
            {
                removePiecePosition(0);
            }
            else if (sender == sing_btnCol2)
            {
                removePiecePosition(1);
            }
            else if (sender == sing_btnCol3)
            {
                removePiecePosition(2);
            }
            else if (sender == sing_btnCol4)
            {
                removePiecePosition(3);
            }
            else if (sender == sing_btnCol5)
            {
                removePiecePosition(4);
            }
            else if (sender == sing_btnCol6)
            {
                removePiecePosition(5);
            }
            else if (sender == sing_btnCol7)
            {
                removePiecePosition(6);
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

        // Display the after report screen
        private void displayAfterGameForm()
        {
            // Here I would pass the game status to the new stats form and update the public struct of game data
            // because areFourCellsConnected returned true meaning that a player has won the game
            statsAfterOnePlayerGame saspg = new statsAfterOnePlayerGame(gameConfig.getCurrentPlayer(), gameConfig.getColorOfCurrPlayer(), this, c_data);

            // Update the .txt file
            updatePersistantData();

            // Disable the buttons on the board
            setBoardState(1);

            saspg.ShowDialog(); // Display the SPG Complete form

            // Disable the timer incase they clicked play again before it finished displaying and set the counter back to original state
            timer_display_winner.Enabled = false;
            displayCycles = weDefineCycleHere;

            // Enable the buttons on the board since "Play Again" was clicked
            setBoardState(0);

            // Clean up for a new game
            cleanUpGame();
        }

        // Update the game data file
        private void updatePersistantData()
        {
            // Since this was called we can assume that a game has been played
            c_data.setTotalGames(c_data.getTotalGamesPlayed() + 1);

            // Only update the player wins here if the player that won was Player 1
            if (gameConfig.getCurrentPlayer() == 1)
            {
                // Human
                c_data.setUserWins(c_data.getUserWins() + 1);

                // Update the win percent of the user based on how many games have been played
                c_data.setUserWinPercent((int)((double)c_data.getUserWins() / c_data.getTotalGamesPlayed() * 100));
            }
            else if (gameConfig.getCurrentPlayer() == 2)
            {
                // AI
                c_data.setAIWins(c_data.getAIWins() + 1);

                c_data.setAIWinPercent((int)((double)c_data.getAIWins() / c_data.getTotalGamesPlayed() * 100));
            }

            // Write the new data to the file
            c_data.writeToFile();
        }

        // Set the board state
        private void setBoardState(int value)
        {
            if (value == 1)
            {
                foreach (Control btn in this.Controls)
                {
                    if (btn is Button && (string)btn.Tag == "btnColumn")
                    {
                        btn.Visible = false;
                    }
                }
            }
            else if (value == 0)
            {
                foreach (Control btn in this.Controls)
                {
                    if (btn is Button && (string)btn.Tag == "btnColumn")
                    {
                        btn.Visible = true;
                    }
                }
            }
        }

        // This function will just be used to change the colors of the winning pictures boxes. Possibly strobe them...
        public void displayWinningPicBoxes()
        {
            timer_display_winner.Enabled = true;
        }

        private void timer_display_winner_Tick(object sender, EventArgs e)
        {
            // This timer runs on a seperate thread so the UI can display the winner while other things are happening
            if (displayCycles <= 0)
            {
                timer_display_winner.Enabled = false;

                displayCycles = weDefineCycleHere;
            }

            foreach (PictureBox winBox in picBoxWinners)
            {
                if (winBox.BackColor == gameConfig.getColorOfCurrPlayer())
                {
                    winBox.BackColor = Color.White;
                }
                else
                {
                    winBox.BackColor = gameConfig.getColorOfCurrPlayer();
                }
            }

            displayCycles--;
        }

        // Instead of just placing a piece at random, Place a piece in the first avaiable column
        private void verySimpleAIStrat()
        {
            int rows = gameBoard.getRows() - 1; // Will always be the very top piece of the board
            int cols = gameBoard.getColumns() - 1; // Will always be the last column of the board

            for (int i = 0; i < cols; i++)
            {
                if (gameBoard.getCell(rows, i).getClaimedStatus() == false)
                {
                    btnList[i].PerformClick();
                    return;
                }
            }

        }
    }
}
