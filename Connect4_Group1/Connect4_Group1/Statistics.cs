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
    public partial class Statistics : Form
    {
        Form1 statisticsForm;


        public Statistics()
        {
            InitializeComponent();
        }

        public Statistics(Form1 sp)
        {
            InitializeComponent();
            statisticsForm = sp;
        }

        public void statisticsFormPass(Form1 sp)
        {
            statisticsForm = sp;
        }
    }
}
