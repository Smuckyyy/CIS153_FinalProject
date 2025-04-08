namespace Connect4_Group1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //========================================
        //Function for opening singleplayer form
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
        //Function for opening singleplayer form
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


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Opening Exit form

            this.Close();
        }
    }
}
