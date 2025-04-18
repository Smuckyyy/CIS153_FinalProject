using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// This class will be used to
// save data for the program
namespace Connect4_Group1
{
    public class Data
    {
        public struct gameData
        {
            public int userWins;
            public int aiWins;
            public int userWinPercent;
            public int aiWinPercent;
            public int gameTies;
            public int totalGamesPlayed;
        };

        // Create the struct
        gameData p_data = new gameData();

        // Constructor
        public Data()
        {
            readDataFromFile();
        }


        // GETTERS
        // Get the entire struct, I don't think we will ever need this as it could possibly give us issues if overused
        public gameData getEntireStruct()
        {
            return p_data;
        }

        public int getUserWins()
        {
            return p_data.userWins;
        }

        public int getAIWins()
        {
            return p_data.aiWins;
        }

        public int getUserWinPercent()
        {
            return p_data.userWinPercent;
        }

        public int getAiWinPercent()
        {
            return p_data.aiWinPercent;
        }

        public int getGameTies()
        {
            return p_data.gameTies;
        }

        public int getTotalGamesPlayed()
        {
            return p_data.totalGamesPlayed;
        }


        // END GETTERS

        // SETTERS
        // Set user wins
        public void setUserWins(int u_wins)
        {
            p_data.userWins = u_wins;
        }
        // set ai wins
        public void setAIWins(int ai_wins)
        {
            p_data.aiWins = ai_wins;
        }
        // set user win percent
        public void setUserWinPercent(int u_win_percent)
        {
            p_data.userWinPercent = u_win_percent;
        }
        // set ai win percent
        public void setAIWinPercent(int ai_win_percent)
        {
            p_data.aiWinPercent = ai_win_percent;
        }
        // set game ties
        public void setGameTies(int game_ties)
        {
            p_data.gameTies = game_ties;
        }
        // set total games played
        public void setTotalGames(int total_games)
        {
            p_data.totalGamesPlayed = total_games;
        }

        // END SETTERS



        // Read data from the file
        // line should be a CSV 0,0,0,0,0,0
        private void readDataFromFile()
        {
            // ========================== Split-Strings Reference =============================
            // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            // ================================================================================

            const string fileName = @"..\..\..\Resources\Connect4UserStats.txt";

            try
            {
                string[] lines = File.ReadAllLines(fileName); // Returns every line(s) from the file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // It's important to note that the CSV must match this layout
                    // Convert.ToInt32 will return 0 if data is NULL
                    p_data.userWins = Convert.ToInt32(parts[0]);
                    p_data.aiWins = Convert.ToInt32(parts[1]);
                    p_data.userWinPercent = Convert.ToInt32(parts[2]);
                    p_data.aiWinPercent = Convert.ToInt32(parts[3]);
                    p_data.gameTies = Convert.ToInt32(parts[4]);
                    p_data.totalGamesPlayed = Convert.ToInt32(parts[5]);
                }
            }
            catch (Exception ex)
            {
                // This will pop if the file is not found
                MessageBox.Show(ex.Message);
            };
        }

        // Write a formatted string to the file for saving data
        public void writeToFile()
        {
            const string fileName = @"..\..\..\Resources\Connect4UserStats.txt";

            string formattedString = p_data.userWins.ToString() + ","
                + p_data.aiWins.ToString() + ","
                + p_data.userWinPercent.ToString() + ","
                + p_data.aiWinPercent.ToString() + ","
                + p_data.gameTies.ToString() + ","
                + p_data.totalGamesPlayed.ToString();

            File.WriteAllText(fileName, formattedString);
        }
    }
}
