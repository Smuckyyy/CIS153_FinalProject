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
    public partial class statsAfterTwoPlayerGame : Form
    {
        Twoplayer tpForm;

        public statsAfterTwoPlayerGame()
        {
            InitializeComponent();
        }

        public statsAfterTwoPlayerGame(int winningPlayer, Color winningPlayerColor, Twoplayer tpForm)
        {
            InitializeComponent();
            this.tpForm = tpForm;

            updateFormInfo(winningPlayer);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblSATPG_winner = new Label();
            btnSATPG_again = new Button();
            btnSATPG_review = new Button();
            btnSATPG_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 60);
            label1.TabIndex = 1;
            label1.Text = "Good Game, Knights!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 2;
            label2.Text = "Winner:";
            // 
            // lblSATPG_winner
            // 
            lblSATPG_winner.AutoSize = true;
            lblSATPG_winner.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSATPG_winner.ForeColor = Color.White;
            lblSATPG_winner.Location = new Point(211, 69);
            lblSATPG_winner.Name = "lblSATPG_winner";
            lblSATPG_winner.Size = new Size(107, 23);
            lblSATPG_winner.TabIndex = 3;
            lblSATPG_winner.Text = "winner here";
            // 
            // btnSATPG_again
            // 
            btnSATPG_again.AutoSize = true;
            btnSATPG_again.BackColor = Color.LightGray;
            btnSATPG_again.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSATPG_again.Location = new Point(128, 95);
            btnSATPG_again.Name = "btnSATPG_again";
            btnSATPG_again.Size = new Size(141, 44);
            btnSATPG_again.TabIndex = 4;
            btnSATPG_again.Text = "Play Again";
            btnSATPG_again.UseVisualStyleBackColor = false;
            btnSATPG_again.Click += btnSATPG_again_Click;
            // 
            // btnSATPG_review
            // 
            btnSATPG_review.AutoSize = true;
            btnSATPG_review.BackColor = Color.LightGray;
            btnSATPG_review.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSATPG_review.Location = new Point(101, 145);
            btnSATPG_review.Name = "btnSATPG_review";
            btnSATPG_review.Size = new Size(197, 44);
            btnSATPG_review.TabIndex = 5;
            btnSATPG_review.Text = "Review Thy Game";
            btnSATPG_review.UseVisualStyleBackColor = false;
            // 
            // btnSATPG_exit
            // 
            btnSATPG_exit.AutoSize = true;
            btnSATPG_exit.BackColor = Color.LightGray;
            btnSATPG_exit.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSATPG_exit.Location = new Point(156, 195);
            btnSATPG_exit.Name = "btnSATPG_exit";
            btnSATPG_exit.Size = new Size(70, 44);
            btnSATPG_exit.TabIndex = 6;
            btnSATPG_exit.Text = "Exit";
            btnSATPG_exit.UseVisualStyleBackColor = false;
            btnSATPG_exit.Click += btnSATPG_exit_Click;
            // 
            // statsAfterTwoPlayerGame
            // 
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(403, 249);
            Controls.Add(btnSATPG_exit);
            Controls.Add(btnSATPG_review);
            Controls.Add(btnSATPG_again);
            Controls.Add(lblSATPG_winner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "statsAfterTwoPlayerGame";
            Text = "Two-Player Game Complete";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label lblSATPG_winner;
        private Button btnSATPG_again;
        private Button btnSATPG_review;
        private Button btnSATPG_exit;

        private void btnSATPG_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void updateFormInfo(int winner)
        {
            if (winner == 1)
            {
                lblSATPG_winner.Text = "Player 1";
            }
            else if (winner == 2)
            {
                lblSATPG_winner.Text = "Player 2";
            }
        }

        private void btnSATPG_again_Click(object sender, EventArgs e)
        {

        }
    }
}
