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
            btnStats_exitProgram = new Button();
            statsBtn_menu = new Button();
            SuspendLayout();
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStats.ForeColor = Color.Black;
            lblStats.Location = new Point(25, 9);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(186, 31);
            lblStats.TabIndex = 0;
            lblStats.Text = "Shows all stats";
            lblStats.Click += lblStats_Click;
            // 
            // btnStats_exitProgram
            // 
            btnStats_exitProgram.AutoSize = true;
            btnStats_exitProgram.BackColor = Color.Goldenrod;
            btnStats_exitProgram.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStats_exitProgram.ForeColor = Color.Black;
            btnStats_exitProgram.Location = new Point(82, 252);
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
            statsBtn_menu.BackColor = Color.Goldenrod;
            statsBtn_menu.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statsBtn_menu.ForeColor = Color.Black;
            statsBtn_menu.Location = new Point(100, 212);
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
            ClientSize = new Size(292, 312);
            Controls.Add(statsBtn_menu);
            Controls.Add(btnStats_exitProgram);
            Controls.Add(lblStats);
            Name = "Statistics";
            Text = "Connect 4: Statistics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStats;
        private Button btnStats_exitProgram;
        private Button statsBtn_menu;
    }
}