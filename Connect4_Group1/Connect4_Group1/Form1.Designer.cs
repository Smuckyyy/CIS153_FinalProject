namespace Connect4_Group1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Singleplayer = new Button();
            btn_Twoplayer = new Button();
            btn_Exit = new Button();
            btn_Stats = new Button();
            label2 = new Label();
            checkBoxMusic = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(698, 54);
            label1.TabIndex = 0;
            label1.Text = "Ye Olde Connect Four Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Singleplayer
            // 
            btn_Singleplayer.BackColor = Color.Goldenrod;
            btn_Singleplayer.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Singleplayer.ForeColor = Color.Black;
            btn_Singleplayer.Location = new Point(51, 76);
            btn_Singleplayer.Name = "btn_Singleplayer";
            btn_Singleplayer.Size = new Size(158, 81);
            btn_Singleplayer.TabIndex = 1;
            btn_Singleplayer.Text = "Single Player";
            btn_Singleplayer.UseVisualStyleBackColor = false;
            btn_Singleplayer.Click += btn_Singleplayer_Click;
            // 
            // btn_Twoplayer
            // 
            btn_Twoplayer.BackColor = Color.Goldenrod;
            btn_Twoplayer.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Twoplayer.ForeColor = Color.Black;
            btn_Twoplayer.Location = new Point(215, 76);
            btn_Twoplayer.Name = "btn_Twoplayer";
            btn_Twoplayer.Size = new Size(158, 81);
            btn_Twoplayer.TabIndex = 2;
            btn_Twoplayer.Text = "Two Players";
            btn_Twoplayer.UseVisualStyleBackColor = false;
            btn_Twoplayer.Click += btn_Twoplayer_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Goldenrod;
            btn_Exit.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.Black;
            btn_Exit.Location = new Point(587, 76);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(158, 81);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Stats
            // 
            btn_Stats.BackColor = Color.Goldenrod;
            btn_Stats.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Stats.ForeColor = Color.Black;
            btn_Stats.Location = new Point(423, 76);
            btn_Stats.Name = "btn_Stats";
            btn_Stats.Size = new Size(158, 81);
            btn_Stats.TabIndex = 4;
            btn_Stats.Text = "Statistics";
            btn_Stats.UseVisualStyleBackColor = false;
            btn_Stats.Click += btn_Stats_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 160);
            label2.Name = "label2";
            label2.Size = new Size(239, 19);
            label2.TabIndex = 5;
            label2.Tag = "https://soundcloud.com/zbofficialmusic/moonlit-lake";
            label2.Text = "Music provided by: ZB - SoundCloud";
            // 
            // checkBoxMusic
            // 
            checkBoxMusic.AutoSize = true;
            checkBoxMusic.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMusic.Location = new Point(693, 163);
            checkBoxMusic.Name = "checkBoxMusic";
            checkBoxMusic.Size = new Size(95, 23);
            checkBoxMusic.TabIndex = 6;
            checkBoxMusic.Text = "Play Music";
            checkBoxMusic.UseVisualStyleBackColor = true;
            checkBoxMusic.Click += checkBoxMusic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 192);
            Controls.Add(checkBoxMusic);
            Controls.Add(label2);
            Controls.Add(btn_Stats);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Twoplayer);
            Controls.Add(btn_Singleplayer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Connect 4: Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Singleplayer;
        private Button btn_Twoplayer;
        private Button btn_Exit;
        private Button btn_Stats;
        private Label label2;
        private CheckBox checkBoxMusic;
    }
}
