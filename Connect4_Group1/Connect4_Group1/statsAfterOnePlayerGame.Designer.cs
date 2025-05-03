namespace Connect4_Group1
{
    partial class statsAfterOnePlayerGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblSAOPG_winner = new Label();
            btnSAOPG_again = new Button();
            btnSAOPG_review = new Button();
            btnSAOPG_exit = new Button();
            label3 = new Label();
            sAOPG_stats = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(381, 41);
            label1.TabIndex = 0;
            label1.Text = "Good Game, Knight!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 115);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 1;
            label2.Text = "Winner:";
            // 
            // lblSAOPG_winner
            // 
            lblSAOPG_winner.AutoSize = true;
            lblSAOPG_winner.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSAOPG_winner.ForeColor = Color.Black;
            lblSAOPG_winner.Location = new Point(197, 115);
            lblSAOPG_winner.Name = "lblSAOPG_winner";
            lblSAOPG_winner.Size = new Size(107, 23);
            lblSAOPG_winner.TabIndex = 2;
            lblSAOPG_winner.Text = "winner here";
            // 
            // btnSAOPG_again
            // 
            btnSAOPG_again.AutoSize = true;
            btnSAOPG_again.BackColor = Color.Goldenrod;
            btnSAOPG_again.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAOPG_again.Location = new Point(133, 288);
            btnSAOPG_again.Name = "btnSAOPG_again";
            btnSAOPG_again.Size = new Size(142, 44);
            btnSAOPG_again.TabIndex = 3;
            btnSAOPG_again.Text = "Play Again";
            btnSAOPG_again.UseVisualStyleBackColor = false;
            btnSAOPG_again.Click += btnSAOPG_again_Click;
            // 
            // btnSAOPG_review
            // 
            btnSAOPG_review.AutoSize = true;
            btnSAOPG_review.BackColor = Color.Goldenrod;
            btnSAOPG_review.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAOPG_review.Location = new Point(107, 338);
            btnSAOPG_review.Name = "btnSAOPG_review";
            btnSAOPG_review.Size = new Size(201, 44);
            btnSAOPG_review.TabIndex = 4;
            btnSAOPG_review.Text = "Review Thy Game";
            btnSAOPG_review.UseVisualStyleBackColor = false;
            btnSAOPG_review.Click += btnSAOPG_review_Click;
            // 
            // btnSAOPG_exit
            // 
            btnSAOPG_exit.AutoSize = true;
            btnSAOPG_exit.BackColor = Color.Goldenrod;
            btnSAOPG_exit.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAOPG_exit.Location = new Point(103, 386);
            btnSAOPG_exit.Name = "btnSAOPG_exit";
            btnSAOPG_exit.Size = new Size(210, 44);
            btnSAOPG_exit.TabIndex = 5;
            btnSAOPG_exit.Text = "Exit the Program";
            btnSAOPG_exit.UseVisualStyleBackColor = false;
            btnSAOPG_exit.Click += btnSAOPG_exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 138);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 6;
            label3.Text = "Stats:";
            // 
            // sAOPG_stats
            // 
            sAOPG_stats.AutoSize = true;
            sAOPG_stats.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sAOPG_stats.ForeColor = Color.Black;
            sAOPG_stats.Location = new Point(168, 138);
            sAOPG_stats.Name = "sAOPG_stats";
            sAOPG_stats.Size = new Size(87, 23);
            sAOPG_stats.TabIndex = 7;
            sAOPG_stats.Text = "stats here";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sword_Border_1;
            pictureBox1.Location = new Point(49, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Sword_Border_2;
            pictureBox2.Location = new Point(49, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(315, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // statsAfterOnePlayerGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(400, 444);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(sAOPG_stats);
            Controls.Add(label3);
            Controls.Add(btnSAOPG_exit);
            Controls.Add(btnSAOPG_review);
            Controls.Add(btnSAOPG_again);
            Controls.Add(lblSAOPG_winner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "statsAfterOnePlayerGame";
            Text = "Connect 4: Single-Player Game Complete";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSAOPG_winner;
        private Button btnSAOPG_again;
        private Button btnSAOPG_review;
        private Button btnSAOPG_exit;
        private Label label3;
        private Label sAOPG_stats;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}