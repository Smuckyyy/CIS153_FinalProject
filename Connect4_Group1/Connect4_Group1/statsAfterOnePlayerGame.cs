using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4_Group1
{
    public partial class statsAfterOnePlayerGame : Form
    {
        Singleplayer spForm;
        int winningPlayer;

        public statsAfterOnePlayerGame()
        {
            InitializeComponent();
        }
        public statsAfterOnePlayerGame(int p_winningPlayer, Color winningPlayerColor, Singleplayer p_spForm)
        {
            InitializeComponent();
            spForm = p_spForm;
            winningPlayer = p_winningPlayer;

            updateFormInfo(winningPlayer);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSAOPG_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void updateFormInfo(int winningPlayer)
        {
            if (winningPlayer == 1)
            {
                // Human Won
                lblSAOPG_winner.Text = "Human has won!";
            }
            else if (winningPlayer == 2)
            {
                // AI Won
                lblSAOPG_winner.Text = "AI has won!";
            }
            else if (winningPlayer == -1)
            {
                // Tie
                lblSAOPG_winner.Text = "Game was a tie!";
            }
        }

        private void btnSAOPG_review_Click(object sender, EventArgs e)
        {
            spForm.Focus();

            if (winningPlayer != -1)
            {
                spForm.displayWinningPicBoxes();
            }
        }

        private void btnSAOPG_again_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
