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
    public partial class Singleplayer : Form
    {
        Form1 singleplayerForm;

        public Singleplayer()
        {
            InitializeComponent();
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
    }
}
