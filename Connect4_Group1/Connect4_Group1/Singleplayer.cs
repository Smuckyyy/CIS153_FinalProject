using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Connect4_Group1
{
    public partial class Singleplayer : Form
    {
        Form1 singleplayerForm;

        public Singleplayer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D; // Disable the ability to resize
            this.StartPosition = FormStartPosition.CenterScreen; // Open the form at the center of the users screen
        }

        public Singleplayer(Form1 sp)
        {
            InitializeComponent();
            singleplayerForm = sp;
        }

        public void singleplayerFormPass(Form1 sp)
        {
            singleplayerForm = sp;
        }

        private void singleBtn_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
