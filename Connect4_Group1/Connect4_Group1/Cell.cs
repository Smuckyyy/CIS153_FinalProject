using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// This class creates each Cell

// Instead of buttons as the board we will use picture boxes
// to represent each grid on the board

// This also give us more freedom with how the pieces look.
// It does not have to be a single color, it can be any image
namespace Connect4_Group1
{
    internal class Cell
    {
        private int row; // Row POS in the 2D Array
        private int col; // Col POS in the 2D Array
        private PictureBox pictureBox;
        private bool cellClaimed; // T - Is claimed, F = Is free

        // Default Constructor
        public Cell()
        {

        }

        // Overloaded Constructor
        public Cell(int row, int col, PictureBox pictureBox, bool setClaimStatus)
        {
            this.row = row;
            this.col = col;
            this.pictureBox = pictureBox;
            this.cellClaimed = setClaimStatus;
        }

        // =================== GETTERS ===============
        // Returns what row the cell is in
        public int getRow()
        {
            return this.row;
        }
        
        // Returns what column the cell is in
        public int getColumn()
        {
            return this.col;
        }

        // Returns what picture box the cell is
        public PictureBox getPictureBox()
        {
            return this.pictureBox;
        }

        // Returns if the cell is claimed
        public bool getClaimedStatus()
        {
            return this.cellClaimed;
        }

        // Returns the color of the cells picture box
        public string getCellColor()
        {
            return this.pictureBox.BackColor.ToString();
        }
        // =================== GETTERS ===============

        // =================== SETTERS ===============
        // Set the row of a cell
        public void setRow(int row)
        {
            this.row = row;
        }
        
        // Set the column of a cell
        public void setCol(int col)
        {
            this.col = col;
        }

        // Set the claim status of a cell
        public void setClaimStatus(bool claimStatus)
        {
            this.cellClaimed = claimStatus;
        }

        // Set the color of a cells picture box
        public void setCellColor(string color)
        {
            this.pictureBox.BackColor = Color.FromName(color);
        }
        // =================== SETTERS ===============
    }
}
