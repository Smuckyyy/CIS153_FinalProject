﻿using System;
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
        public statsAfterOnePlayerGame()
        {
            InitializeComponent();
        }

        private void btnSAOPG_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
