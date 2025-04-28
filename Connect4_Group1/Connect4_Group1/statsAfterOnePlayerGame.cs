using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            setStatsOnSAOPG();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSAOPG_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void setStatsOnSAOPG()
        {
            //Applied code from statistics form to this one. -Cecil
            // Create a formatted string that will be passed to a single label
            Data c_data;
            string formattedString = String.Format(
            "Your Wins : {0,0}\n" +
            "AI Wins : {1,0}\n" +
            "Your Win Percent : {2,0}% \n" +
            "AI Win Percent : {3,0}% \n" +
            "Game Ties : {4,0}\n" +
            "Total Games Played : {5,0}\n", c_data.getUserWins(), c_data.getAIWins(), c_data.getUserWinPercent(), c_data.getAiWinPercent(), c_data.getGameTies(), c_data.getTotalGamesPlayed());
            sAOPG_stats.Text = formattedString;
            this.AutoSize = true;
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
                btnSAOPG_review.Visible = false;
            }
        }

        private void btnSAOPG_review_Click(object sender, EventArgs e)
        {
            spForm.Focus();

            // Move this form to the left of the game board form
            this.Location = new Point(spForm.Location.X - 400, spForm.Location.Y);

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
