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

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 41);
            label1.TabIndex = 1;
            label1.Text = "Good Game, Knights!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(64, 111);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 2;
            label2.Text = "Winner:";
            // 
            // lblSATPG_winner
            // 
            lblSATPG_winner.AutoSize = true;
            lblSATPG_winner.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSATPG_winner.ForeColor = Color.Black;
            lblSATPG_winner.Location = new Point(215, 111);
            lblSATPG_winner.Name = "lblSATPG_winner";
            lblSATPG_winner.Size = new Size(107, 23);
            lblSATPG_winner.TabIndex = 3;
            lblSATPG_winner.Text = "winner here";
            // 
            // btnSATPG_again
            // 
            btnSATPG_again.AutoSize = true;
            btnSATPG_again.BackColor = Color.Goldenrod;
            btnSATPG_again.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSATPG_again.Location = new Point(146, 198);
            btnSATPG_again.Name = "btnSATPG_again";
            btnSATPG_again.Size = new Size(142, 44);
            btnSATPG_again.TabIndex = 4;
            btnSATPG_again.Text = "Play Again";
            btnSATPG_again.UseVisualStyleBackColor = false;
            btnSATPG_again.Click += btnSATPG_again_Click;
            // 
            // btnSATPG_review
            // 
            btnSATPG_review.AutoSize = true;
            btnSATPG_review.BackColor = Color.Goldenrod;
            btnSATPG_review.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSATPG_review.Location = new Point(122, 248);
            btnSATPG_review.Name = "btnSATPG_review";
            btnSATPG_review.Size = new Size(201, 44);
            btnSATPG_review.TabIndex = 5;
            btnSATPG_review.Text = "Review Thy Game";
            btnSATPG_review.UseVisualStyleBackColor = false;
            btnSATPG_review.Click += btnSATPG_review_Click;
            // 
            // btnSATPG_exit
            // 
            btnSATPG_exit.AutoSize = true;
            btnSATPG_exit.BackColor = Color.Goldenrod;
            btnSATPG_exit.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSATPG_exit.Location = new Point(180, 298);
            btnSATPG_exit.Name = "btnSATPG_exit";
            btnSATPG_exit.Size = new Size(70, 44);
            btnSATPG_exit.TabIndex = 6;
            btnSATPG_exit.Text = "Exit";
            btnSATPG_exit.UseVisualStyleBackColor = false;
            btnSATPG_exit.Click += btnSATPG_exit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Sword_Border_2;
            pictureBox2.Location = new Point(60, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(315, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sword_Border_1;
            pictureBox1.Location = new Point(60, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // statsAfterTwoPlayerGame
            // 
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(426, 350);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnSATPG_exit);
            Controls.Add(btnSATPG_review);
            Controls.Add(btnSATPG_again);
            Controls.Add(lblSATPG_winner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "statsAfterTwoPlayerGame";
            Text = "Two-Player Game Complete";
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label lblSATPG_winner;
        private Button btnSATPG_again;
        private Button btnSATPG_review;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
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
                lblSATPG_winner.ForeColor = Color.Gold;
            }
            else if (winner == 2)
            {
                lblSATPG_winner.Text = "Player 2";
                lblSATPG_winner.ForeColor = Color.Purple;
            }
            else
            {
                lblSATPG_winner.Text = "Game was a tie!";
                lblSATPG_winner.ForeColor = Color.Black;
            }
        }

        private void btnSATPG_again_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSATPG_review_Click(object sender, EventArgs e)
        {
            this.Location = new Point(tpForm.Location.X - 400, tpForm.Location.Y);

            btnSATPG_review.Enabled = false; // Pic boxes will just flash untill the "Play Again" or "Exit" is clicked

            if(lblSATPG_winner.Text != "Game was a tie!")
            {
                //Winning cells don't flash if the game ended in a tie - Cecil
                tpForm.displayWinningPicBoxes();
            }
        }

    }
}
