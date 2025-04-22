using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        GameSettings gameConfig = new GameSettings();
        Data c_data;
        PictureBox[] picBoxWinners;

        // Major issue right now is the way the AI would know what buttons it can click
        // Right now it just uses a int counter to see how many buttons are available. The issue with this is
        // When the counter decrements it will no longer click buttons 6 or 7.
        // Possibly Fixed (4-21-2025) ~ Matt


        // This holds how many time a button has been click.
        // Could be used to dictate if the game should end or
        // When a button should be disabled
        // Index will be unique *******************
        int[] buttonClick = { 0, 0, 0, 0, 0, 0, 0 };
        List<Button> btnList;
        // Index will be unique ^^^^^^^^^^^^^^^^^^^

        // ENABLE/DISABLE THIS FOR DEBUGGING PROMPTS
        const bool shouldDebug = false;
        //=========================================

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
            gameConfig.setCurrentPlayer(1);
            sing_lblCurrentPlayer.Text = string.Format("Player {0,0} Turn", gameConfig.getCurrentPlayer());
            sing_pictureBoxPlayerColor.BackColor = gameConfig.getColorOfCurrPlayer();

            // Stores each clickable column button into a List<Button>
            btnList = new List<Button>() { sing_btnCol1, sing_btnCol2, sing_btnCol3, sing_btnCol4, sing_btnCol5, sing_btnCol6, sing_btnCol7 };

            gameConfig.setGameStatus(true);
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
                            btnList.Remove(sing_btnCol1);
                            break;
                        case 1:
                            sing_btnCol2.Enabled = false;
                            btnList.Remove(sing_btnCol2);
                            break;
                        case 2:
                            sing_btnCol3.Enabled = false;
                            btnList.Remove(sing_btnCol3);
                            break;
                        case 3:
                            sing_btnCol4.Enabled = false;
                            btnList.Remove(sing_btnCol4);
                            break;
                        case 4:
                            sing_btnCol5.Enabled = false;
                            btnList.Remove(sing_btnCol5);
                            break;
                        case 5:
                            sing_btnCol6.Enabled = false;
                            btnList.Remove(sing_btnCol6);
                            break;
                        case 6:
                            sing_btnCol7.Enabled = false;
                            btnList.Remove(sing_btnCol7);
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
            // Here we would update the Struct that contains the game data. We would update how many times the game has been played
            // STATUS - NOT IMPLEMENTED

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
                    // Visual of what is happening in this loop ~ Uncomment to see what happens
                    //gameBoard.getCell(i, j).setCellColor(Color.Green.ToString());
                    //Thread.Sleep(100);
                    //Application.DoEvents(); // This will update anything that is in the application buffer, Right now it's just used to update the cell color visually ~ https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.doevents?view=windowsdesktop-9.0

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

            if (willPlayerWin("horizontal", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player horizontal win.");
                }
                makeMove(col);
                return;
            }
            if(willPlayerWin("vertical", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player vertical win.");
                }
                makeMove(col);
                return;
            }
            if(willPlayerWin("diagonalUp", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player diagonal-up win.");
                }
                makeMove(col);
                return;
            }
            if(willPlayerWin("diagonalDown", ref row, ref col))
            {
                if (shouldDebug)
                {
                    MessageBox.Show("The AI would place a piece at: " + "Row: " + row + " Col: " + col + "\nTo stop a player diagonal-down win.");
                }
                makeMove(col);
                return;
            }

            // Place a cell if it's possible to win with the AI
            // Place a cell in a random spot on the board if no win state is found
            // First find out if any buttons are disabled
            int randomCol;
            do
            {
                randomCol = getRandomNumber(btnList.Count);
            }
            while (randomCol >= btnList.Count || randomCol < 0);

            makeMove(randomCol);
        }

        private void makeMove(int col)
        {

            try
            {
                btnList[col].PerformClick();
            }
            catch (Exception e)
            {
                //string listOfButtons = "";
                //foreach (var btn in btnList)
                //{
                //    listOfButtons += btn.Name.ToString() + ",";
                //}

                //MessageBox.Show(e.Message + "\n" + btnList.Count.ToString() + "\n" + "Attempted to click: " + col.ToString() + "\n" + listOfButtons);


                // Disgusting hack to make this work...
                btnList[0].PerformClick();
            }

            // Dont think we need a swith case anymore
            //switch (col)
            //{
            //    case 0:
            //        btnList[col].PerformClick();
            //        break;
            //    case 1:
            //        btnList[col].PerformClick();
            //        break;
            //    case 2:
            //        btnList[col].PerformClick();
            //        break;
            //    case 3:
            //        btnList[col].PerformClick();
            //        break;
            //    case 4:
            //        btnList[col].PerformClick();
            //        break;
            //    case 5:
            //        btnList[col].PerformClick();
            //        break;
            //    case 6:
            //        btnList[col].PerformClick();
            //        break;
            //}
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

        //                                       ref is the same thing as & in CPP
        private bool willPlayerWin(string direction, ref int lastOpenRow, ref int lastOpenCol)
        {
            Color playerColor = Color.Yellow;
            int rows = gameBoard.getRows();
            int cols = gameBoard.getColumns();

            // We should check if the AI could win first THEN check if the player would win
            //Smuck Code: Added a switch case for directional checks
            switch (direction)
            {
                case "horizontal":
                    //Left to Right
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols - 3; j++)
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

                    }
                    break;
                case "vertical":
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
                case "diagonalUp":
                    for (int i = 3; i < rows; i++)
                    {
                        for (int j = 0; j < cols - 3; j++)
                        {
                            if (gameBoard.getCell(i, j).getCellColor() == playerColor
                                && gameBoard.getCell(i - 1, j + 1).getCellColor() == playerColor
                                && gameBoard.getCell(i - 2, j + 2).getCellColor() == playerColor
                                && gameBoard.getCell(i - 3, j + 3).getClaimedStatus() == false)
                            {
                                lastOpenRow = i - 3;
                                lastOpenCol = j + 3;
                                return true;
                            }
                        }
                    }
                    break;
                case "diagonalDown":
                    for (int i = 0; i < rows - 3; i++)
                    {
                        for (int j = 0; j < cols - 3; j++)
                        {
                            if (gameBoard.getCell(i, j).getCellColor() == playerColor
                                && gameBoard.getCell(i + 1, j + 1).getCellColor() == playerColor
                                && gameBoard.getCell(i + 2, j + 2).getCellColor() == playerColor
                                && gameBoard.getCell(i + 3, j + 3).getClaimedStatus() == false)
                            {
                                lastOpenRow = i + 3;
                                lastOpenCol = j + 3;
                                return true;
                            }
                        }
                    }
                    break;
            }

            return false;
        }

        // Search for a win condition of the player and save the last cell the player needs
        // Checks Horizontal win state. Left to Right
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols - 3; j++)
        //    {
        //        if (gameBoard.getCell(i, j).getCellColor() == playerColor)
        //        {
        //            ////This states that cells 1, 2, and 3 are claimed by the player and the fourth cell is unclaimed.
        //            if (gameBoard.getCell(i, j + 1).getCellColor() == playerColor
        //                && gameBoard.getCell(i, j + 2).getCellColor() == playerColor
        //                && gameBoard.getCell(i, j + 3).getClaimedStatus() == false)
        //            {
        //                lastOpenRow = i;
        //                lastOpenCol = j + 3;
        //                return true;
        //            }
        //        }
        //    }
        //}

        ////Checks Horizontal win state. Right to Left
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = gameBoard.getColumns() - 1; j > 3; j--)
        //    {
        //        if (gameBoard.getCell(i, j).getCellColor() == playerColor)
        //        {
        //            ////This states that cells 1, 2, and 3 are claimed by the player and the fourth cell is unclaimed.
        //            if (gameBoard.getCell(i, j - 1).getCellColor() == playerColor
        //                && gameBoard.getCell(i, j - 2).getCellColor() == playerColor
        //                && gameBoard.getCell(i, j - 3).getClaimedStatus() == false)
        //            {
        //                lastOpenRow = i;
        //                lastOpenCol = j - 3;
        //                return true;
        //            }
        //        }
        //    }
        //}


        //return false;
        //}

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
                //MessageBox.Show("Mouse Entered Buttton 1");
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
                //MessageBox.Show("Mouse Entered Buttton 1");
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
            statsAfterOnePlayerGame saspg = new statsAfterOnePlayerGame(gameConfig.getCurrentPlayer(), gameConfig.getColorOfCurrPlayer(), this);

            // Update the .txt file
            updatePersistantData();

            // Disable the buttons on the board
            setBoardState(1);

            saspg.ShowDialog(); // Display the SPG Complete form

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
            int numOfCycles = 10;

            while (numOfCycles > 0)
            {
                foreach (PictureBox picBox in picBoxWinners)
                {
                    picBox.BackColor = Color.White;
                    Thread.Sleep(200);
                    Application.DoEvents();
                    picBox.BackColor = gameConfig.getColorOfCurrPlayer();
                }
                numOfCycles--;
            }
        }
    }
}
