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
        Form1 statisticsForm;
        Data.gameData gameData;


        public Statistics()
        {
            InitializeComponent();
        }

        public Statistics(Form1 sp, Data.gameData dataStruct)
        {
            InitializeComponent();
            statisticsForm = sp;

            gameData = dataStruct;

            displayStatsToUser();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        // Do we need this? We already pass sp from the main call
        public void statisticsFormPass(Form1 sp)
        {
            statisticsForm = sp;
        }

        private void displayStatsToUser()
        {
            // Create a formatted string that will be passed to a single label
            string formattedString = String.Format(
            "Your Wins : {0,0}\n" +
            "AI Wins : {1,0}\n" +
            "Your Win Percent : {2,0}\n" +
            "AI Win Percent : {3,0}\n" +
            "Game Ties : {4,0}\n" +
            "Total Games Played : {5,0}\n\n", gameData.userWins, gameData.aiWins, gameData.userWinPercent, gameData.aiWinPercent, gameData.gameTies, gameData.totalGamesPlayed);
            lblStats.Text = formattedString;
            this.AutoSize = true;


        }
    }
}
