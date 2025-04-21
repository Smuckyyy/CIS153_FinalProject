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
    public partial class statsAfterOnePlayerGame : Form
    {
        Singleplayer spForm;

        public statsAfterOnePlayerGame()
        {
            InitializeComponent();
        }
        public statsAfterOnePlayerGame(int winningPlayer, Color winningPlayerColor, Singleplayer p_spForm)
        {
            InitializeComponent();
            spForm = p_spForm;

            updateFormInfo(winningPlayer);
        }

        private void btnSAOPG_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void updateFormInfo(int winningPlayer)
        {
            if (winningPlayer == 1)
            {
                // Human Won
            }
            else if (winningPlayer == 2)
            {
                // AI Won
            }
            else if (winningPlayer == -1)
            {
                // Tie
            }
        }
    }
}
