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
    public partial class Statistics : Form
    {
        Form1 mainMenuForm;

        // Will hold the info from the Data class
        Data c_data;


        public Statistics()
        {
            InitializeComponent();
        }

        public Statistics(Form1 stp, Data p_data)
        {
            InitializeComponent();
            mainMenuForm = stp;

            // Pass the p_data to the c_data variable
            c_data = p_data;

            displayStatsToUser();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void displayStatsToUser()
        {
            // Create a formatted string that will be passed to a single label
            string formattedString = String.Format(
            "Your Wins: {0,0}\n" +
            "AI Wins: {1,0}\n" +
            "Your Win Percent: {2,0}% \n" +
            "AI Win Percent: {3,0}% \n" +
            "Game Ties: {4,0}\n" +
            "Total Games Played: {5,0}\n", c_data.getUserWins(), c_data.getAIWins(), c_data.getUserWinPercent(), c_data.getAiWinPercent(), c_data.getGameTies(), c_data.getTotalGamesPlayed());
            lblStats.Text = formattedString;
            this.AutoSize = true;

            //Set the text on the individual labels on the right - Cecil
            /*statLbl_yourWins.Text = c_data.getUserWins().ToString();
            statLbl_AIwins.Text = c_data.getAIWins().ToString();
            statLbl_yourWinPercentage.Text = c_data.getUserWinPercent().ToString() + "%";
            statLbl_AIwinPercentage.Text = c_data.getAiWinPercent().ToString() + "%";
            statLbl_NOT.Text = c_data.getGameTies().ToString();
            statLbl_totalGamesPlayed.Text = c_data.getTotalGamesPlayed().ToString();*/
        }

        private void lblStats_Click(object sender, EventArgs e)
        {

        }

        private void btnStats_exitProgram_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void statsBtn_menu_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}
