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
    }
}
