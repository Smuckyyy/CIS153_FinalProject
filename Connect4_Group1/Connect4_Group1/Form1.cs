using static Connect4_Group1.Data;

namespace Connect4_Group1
{
    public partial class Form1 : Form
    {
        // This struct must be passed to any form that needs to read or write the persistant data
        static private Data.gameData gameData;

        public Form1()
        {
            InitializeComponent();

            readDataFromFile();
        }

        //========================================
        //Function for opening Singleplayer form
        //========================================
        public void singleplayerForm()
        {
            Singleplayer singleplayerForm = new Singleplayer(this);

            Singleplayer singlePlayerFormToLoad = new Singleplayer();

            singlePlayerFormToLoad.singleplayerFormPass(this);

            this.Hide();

            singleplayerForm.ShowDialog();

            this.Show();
        }

        //========================================
        //Function for opening Two-Player form
        //========================================
        public void twoplayerForm()
        {
            Twoplayer twoplayerForm = new Twoplayer(this);

            Twoplayer twoPlayerFormToLoad = new Twoplayer();

            twoPlayerFormToLoad.twoplayerFormPass(this);

            this.Hide();

            twoplayerForm.ShowDialog();

            this.Show();
        }

        //========================================
        //Function for opening Statistics form
        //========================================
        public void statisticsForm()
        {
            Statistics statisticsForm = new Statistics(this);

            Statistics statisticsFormToLoad = new Statistics();

            statisticsFormToLoad.statisticsFormPass(this);

            this.Hide();

            statisticsForm.ShowDialog();

            this.Show();
        }

        private void btn_Singleplayer_Click(object sender, EventArgs e)
        {
            //Opening Singleplayer form

            singleplayerForm();
        }

        private void btn_Twoplayer_Click(object sender, EventArgs e)
        {
            //Opening Twoplayer form

            twoplayerForm();
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {
            //Opening Stats form

            statisticsForm();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Opening Exit form

            this.Close();
        }

        // Read data from the file
        // line should be a CSV 0,0,0,0,0,0
        private void readDataFromFile()
        {
            // ========================== Split-Strings Reference =============================
            // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            // ================================================================================

            const string fileName = "Connect4UserStats.txt";

            try
            {
                string[] lines = File.ReadAllLines(fileName); // Returns every line(s) from the file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // It's important to note that the CSV must match this layout
                    // Convert.ToInt32 will return 0 if data is NULL
                    gameData.userWins = Convert.ToInt32(parts[0]);
                    gameData.aiWins = Convert.ToInt32(parts[1]);
                    gameData.userWinPercent = Convert.ToInt32(parts[2]);
                    gameData.aiWinPercent = Convert.ToInt32(parts[3]);
                    gameData.gameTies = Convert.ToInt32(parts[4]);
                    gameData.totalGamesPlayed = Convert.ToInt32(parts[5]);
                }
            }
            catch (Exception ex)
            {
                // This will pop if the file is not found
                MessageBox.Show(ex.Message);
            };
        }
    }
}
