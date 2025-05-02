namespace Connect4_Group1
{
    partial class Statistics
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
            lblStats = new Label();
            label1 = new Label();
            label2 = new Label();
            statLbl_yourWins = new Label();
            label3 = new Label();
            statLbl_AIwins = new Label();
            label4 = new Label();
            statLbl_yourWinPercentage = new Label();
            label5 = new Label();
            statLbl_AIwinPercentage = new Label();
            label6 = new Label();
            statLbl_NOT = new Label();
            label7 = new Label();
            statLbl_totalGamesPlayed = new Label();
            btnStats_exitProgram = new Button();
            statsBtn_menu = new Button();
            SuspendLayout();
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStats.ForeColor = Color.Gainsboro;
            lblStats.Location = new Point(25, 9);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(221, 44);
            lblStats.TabIndex = 0;
            lblStats.Text = "Shows all stats";
            lblStats.Click += lblStats_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(299, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 34);
            label1.TabIndex = 1;
            label1.Text = "Ye Olde Statistics";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(276, 49);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "Your Wins:";
            label2.Visible = false;
            // 
            // statLbl_yourWins
            // 
            statLbl_yourWins.AutoSize = true;
            statLbl_yourWins.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statLbl_yourWins.ForeColor = Color.DarkBlue;
            statLbl_yourWins.Location = new Point(453, 49);
            statLbl_yourWins.Name = "statLbl_yourWins";
            statLbl_yourWins.Size = new Size(41, 21);
            statLbl_yourWins.TabIndex = 3;
            statLbl_yourWins.Text = "YW";
            statLbl_yourWins.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(276, 70);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "AI Wins:";
            label3.Visible = false;
            // 
            // statLbl_AIwins
            // 
            statLbl_AIwins.AutoSize = true;
            statLbl_AIwins.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statLbl_AIwins.ForeColor = Color.DarkBlue;
            statLbl_AIwins.Location = new Point(453, 70);
            statLbl_AIwins.Name = "statLbl_AIwins";
            statLbl_AIwins.Size = new Size(47, 21);
            statLbl_AIwins.TabIndex = 5;
            statLbl_AIwins.Text = "AIW";
            statLbl_AIwins.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(276, 91);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 6;
            label4.Text = "Your Win Percentage:";
            label4.Visible = false;
            // 
            // statLbl_yourWinPercentage
            // 
            statLbl_yourWinPercentage.AutoSize = true;
            statLbl_yourWinPercentage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statLbl_yourWinPercentage.ForeColor = Color.DarkBlue;
            statLbl_yourWinPercentage.Location = new Point(453, 91);
            statLbl_yourWinPercentage.Name = "statLbl_yourWinPercentage";
            statLbl_yourWinPercentage.Size = new Size(52, 21);
            statLbl_yourWinPercentage.TabIndex = 7;
            statLbl_yourWinPercentage.Text = "YWP";
            statLbl_yourWinPercentage.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(276, 112);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 8;
            label5.Text = "AI Win Percentage:";
            label5.Visible = false;
            // 
            // statLbl_AIwinPercentage
            // 
            statLbl_AIwinPercentage.AutoSize = true;
            statLbl_AIwinPercentage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statLbl_AIwinPercentage.ForeColor = Color.DarkBlue;
            statLbl_AIwinPercentage.Location = new Point(453, 112);
            statLbl_AIwinPercentage.Name = "statLbl_AIwinPercentage";
            statLbl_AIwinPercentage.Size = new Size(58, 21);
            statLbl_AIwinPercentage.TabIndex = 9;
            statLbl_AIwinPercentage.Text = "AIWP";
            statLbl_AIwinPercentage.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(276, 133);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 10;
            label6.Text = "Number of Ties:";
            label6.Visible = false;
            // 
            // statLbl_NOT
            // 
            statLbl_NOT.AutoSize = true;
            statLbl_NOT.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statLbl_NOT.ForeColor = Color.DarkBlue;
            statLbl_NOT.Location = new Point(453, 133);
            statLbl_NOT.Name = "statLbl_NOT";
            statLbl_NOT.Size = new Size(49, 21);
            statLbl_NOT.TabIndex = 11;
            statLbl_NOT.Text = "NOT";
            statLbl_NOT.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(276, 154);
            label7.Name = "label7";
            label7.Size = new Size(164, 21);
            label7.TabIndex = 12;
            label7.Text = "Total Games Played:";
            label7.Visible = false;
            // 
            // statLbl_totalGamesPlayed
            // 
            statLbl_totalGamesPlayed.AutoSize = true;
            statLbl_totalGamesPlayed.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statLbl_totalGamesPlayed.ForeColor = Color.DarkBlue;
            statLbl_totalGamesPlayed.Location = new Point(453, 154);
            statLbl_totalGamesPlayed.Name = "statLbl_totalGamesPlayed";
            statLbl_totalGamesPlayed.Size = new Size(47, 21);
            statLbl_totalGamesPlayed.TabIndex = 13;
            statLbl_totalGamesPlayed.Text = "TGP";
            statLbl_totalGamesPlayed.Visible = false;
            // 
            // btnStats_exitProgram
            // 
            btnStats_exitProgram.AutoSize = true;
            btnStats_exitProgram.BackColor = Color.Gainsboro;
            btnStats_exitProgram.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStats_exitProgram.ForeColor = Color.DimGray;
            btnStats_exitProgram.Location = new Point(55, 315);
            btnStats_exitProgram.Name = "btnStats_exitProgram";
            btnStats_exitProgram.Size = new Size(167, 34);
            btnStats_exitProgram.TabIndex = 14;
            btnStats_exitProgram.Text = "Exit Program";
            btnStats_exitProgram.UseVisualStyleBackColor = false;
            btnStats_exitProgram.Click += btnStats_exitProgram_Click;
            // 
            // statsBtn_menu
            // 
            statsBtn_menu.AutoSize = true;
            statsBtn_menu.BackColor = Color.Gainsboro;
            statsBtn_menu.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statsBtn_menu.ForeColor = Color.DimGray;
            statsBtn_menu.Location = new Point(75, 355);
            statsBtn_menu.Name = "statsBtn_menu";
            statsBtn_menu.Size = new Size(129, 34);
            statsBtn_menu.TabIndex = 15;
            statsBtn_menu.Text = "Main Menu";
            statsBtn_menu.UseVisualStyleBackColor = false;
            statsBtn_menu.Click += statsBtn_menu_Click;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(537, 417);
            Controls.Add(statsBtn_menu);
            Controls.Add(btnStats_exitProgram);
            Controls.Add(statLbl_totalGamesPlayed);
            Controls.Add(label7);
            Controls.Add(statLbl_NOT);
            Controls.Add(label6);
            Controls.Add(statLbl_AIwinPercentage);
            Controls.Add(label5);
            Controls.Add(statLbl_yourWinPercentage);
            Controls.Add(label4);
            Controls.Add(statLbl_AIwins);
            Controls.Add(label3);
            Controls.Add(statLbl_yourWins);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStats);
            Name = "Statistics";
            Text = "Connect 4: Statistics Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStats;
        private Label label1;
        private Label label2;
        private Label statLbl_yourWins;
        private Label label3;
        private Label statLbl_AIwins;
        private Label label4;
        private Label statLbl_yourWinPercentage;
        private Label label5;
        private Label statLbl_AIwinPercentage;
        private Label label6;
        private Label statLbl_NOT;
        private Label label7;
        private Label statLbl_totalGamesPlayed;
        private Button btnStats_exitProgram;
        private Button statsBtn_menu;
    }
}