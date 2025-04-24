using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// This class creates the Connect 4 Board
namespace Connect4_Group1
{
    internal class Board
    {
        private const int totalRows = 6;
        private const int totalCols = 7;

        // Creates a 2D array of cells
        // Cells will not have any values
        Cell[,] gameBoard = new Cell[totalRows, totalCols];

        // Default Constructor
        public Board()
        {

        }

        // =================== GETTERS ===============
        // Returns the total rows of the game
        public int getRows()
        {
            return totalRows;
        }

        // Returns the total columns of the game
        public int getColumns()
        {
            return totalCols;
        }

        // Returns the entire array of cells
        public Cell[,] getEntireBoard()
        {
            return gameBoard;
        }

        // Returns a cell from the array
        public Cell getCell(int row, int col)
        {
            return gameBoard[row, col];
        }
        // =================== GETTERS ===============

        // =================== SETTERS ===============
        // Set a cell inside of the 2D array
        // This can only be done if a cell has a row and column assigned to it
        public void setGameBoardCell(Cell cell)
        {
            gameBoard[cell.getRow(), cell.getColumn()] = cell;
        }
        // =================== SETTERS ===============

        // =================== ADDITIONAL FUNCTIONALITY ===============
        public int getLowestEmptyRow(int col)
        {
            //Start from bottom row (totalRows - 1) and move upwards
            for (int row = totalRows - 1; row >= 0; row--)
            {
                if (!gameBoard[row, col].getClaimedStatus()) //If the cell is unclaimed (empty)
                {
                    return row; //Return the row number of the empty cell
                }
            }

            return -1; //No empty cells in this column
        }
        // =================== ADDITIONAL FUNCTIONALITY ===============
    }
}
