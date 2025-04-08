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
    public partial class Twoplayer : Form
    {
        Form1 twoplayerForm;

        public Twoplayer()
        {
            InitializeComponent();
        }

        public Twoplayer(Form1 tp)
        {
            InitializeComponent();
            twoplayerForm = tp;
        }

        public void twoplayerFormPass(Form1 tp)
        {
            twoplayerForm = tp;
        }   

    }
}
