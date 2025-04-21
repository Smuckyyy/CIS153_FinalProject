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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 60);
            label1.TabIndex = 0;
            label1.Text = "Good Game, Knight!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 1;
            label2.Text = "Winner:";
            // 
            // lblSAOPG_winner
            // 
            lblSAOPG_winner.AutoSize = true;
            lblSAOPG_winner.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSAOPG_winner.ForeColor = Color.White;
            lblSAOPG_winner.Location = new Point(199, 69);
            lblSAOPG_winner.Name = "lblSAOPG_winner";
            lblSAOPG_winner.Size = new Size(107, 23);
            lblSAOPG_winner.TabIndex = 2;
            lblSAOPG_winner.Text = "winner here";
            // 
            // btnSAOPG_again
            // 
            btnSAOPG_again.AutoSize = true;
            btnSAOPG_again.BackColor = Color.LightGray;
            btnSAOPG_again.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAOPG_again.Location = new Point(116, 242);
            btnSAOPG_again.Name = "btnSAOPG_again";
            btnSAOPG_again.Size = new Size(141, 44);
            btnSAOPG_again.TabIndex = 3;
            btnSAOPG_again.Text = "Play Again";
            btnSAOPG_again.UseVisualStyleBackColor = false;
            btnSAOPG_again.Click += btnSAOPG_again_Click;
            // 
            // btnSAOPG_review
            // 
            btnSAOPG_review.AutoSize = true;
            btnSAOPG_review.BackColor = Color.LightGray;
            btnSAOPG_review.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAOPG_review.Location = new Point(93, 292);
            btnSAOPG_review.Name = "btnSAOPG_review";
            btnSAOPG_review.Size = new Size(197, 44);
            btnSAOPG_review.TabIndex = 4;
            btnSAOPG_review.Text = "Review Thy Game";
            btnSAOPG_review.UseVisualStyleBackColor = false;
            btnSAOPG_review.Click += btnSAOPG_review_Click;
            // 
            // btnSAOPG_exit
            // 
            btnSAOPG_exit.AutoSize = true;
            btnSAOPG_exit.BackColor = Color.LightGray;
            btnSAOPG_exit.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAOPG_exit.Location = new Point(151, 342);
            btnSAOPG_exit.Name = "btnSAOPG_exit";
            btnSAOPG_exit.Size = new Size(70, 44);
            btnSAOPG_exit.TabIndex = 5;
            btnSAOPG_exit.Text = "Exit";
            btnSAOPG_exit.UseVisualStyleBackColor = false;
            btnSAOPG_exit.Click += btnSAOPG_exit_Click;
            // 
            // statsAfterOnePlayerGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(386, 396);
            Controls.Add(btnSAOPG_exit);
            Controls.Add(btnSAOPG_review);
            Controls.Add(btnSAOPG_again);
            Controls.Add(lblSAOPG_winner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "statsAfterOnePlayerGame";
            Text = "One-Player Game Complete";
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
    }
}