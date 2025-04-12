//REMINDER: We must include a header. - Cecil
using System.Media;
using static Connect4_Group1.Data;

namespace Connect4_Group1
{
    public partial class Form1 : Form
    {
        // Pass this to any form that needs access to this data
        Data.gameData gameData = new Data.gameData();

        //Create objects needed for sound-playing
        Stream soundFile;
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Fixed3D; // Disable the ability to resize
            this.StartPosition = FormStartPosition.CenterScreen; // Open the form at the center of the users screen

            //Begin looping the music
            checkBoxMusic.Checked = true;
            musicHandler();


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
            Statistics statisticsForm = new Statistics(this, gameData);

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

            //this.Close();
            System.Environment.Exit(0);
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

        private void checkBoxMusic_Click(object sender, EventArgs e)
        {
            musicHandler();
        }

        private void musicHandler()
        {
            if (checkBoxMusic.Checked)
            {
                // The location where the .exe is located
                player.SoundLocation = @".\Background.wav";
                player.PlayLooping();
            }
            else
            {
                player.Stop();
            }
        }
    }
}