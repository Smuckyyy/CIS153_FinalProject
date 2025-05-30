//==================================================================================
//Names         :   Marcus Rollins, Matthew Wishman, Cecil Younglove
//Date          :   April 8th, 2025
//Description   :   Connect 4 program that can support a game between a single player and an AI or a game between two players,
//                  while allowing users to view game statistics
//==================================================================================
using System.Media;
using System.Resources;
using static Connect4_Group1.Data;

namespace Connect4_Group1
{
    public partial class Form1 : Form
    {
        // Create a new data struct from the class
        Data c_data;

        //Create objects needed for sound-playing
        Stream soundFile;
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Fixed3D; // Disable the ability to resize
            this.StartPosition = FormStartPosition.CenterScreen; // Open the form at the center of the users screen

            // Try reading data from the file before proceeding
            try
            {
                c_data = new Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Begin looping the music
            checkBoxMusic.Checked = false; //Change this to true for the music to loop automatically once the program is opened
            musicHandler();

        }

        //========================================
        //Function for opening Singleplayer form
        //========================================
        public void singleplayerForm()
        {
            Singleplayer singleplayerForm = new Singleplayer(this, c_data);

            this.Hide();

            singleplayerForm.ShowDialog();

            this.Show();
        }

        //========================================
        //Function for opening Two-Player form
        //========================================
        public void twoplayerForm()
        {
            Twoplayer twoplayerForm = new Twoplayer(this, c_data);

            this.Hide();

            twoplayerForm.ShowDialog();

            this.Show();
        }

        //========================================
        //Function for opening Statistics form
        //========================================
        public void statisticsForm()
        {
            Statistics statisticsForm = new Statistics(this, c_data);

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

            System.Environment.Exit(0);
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
                player.SoundLocation = @"..\..\..\Resources\Background.wav";

                player.PlayLooping();
            }
            else
            {
                player.Stop();
            }
        }

        private void checkBoxMusic_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}