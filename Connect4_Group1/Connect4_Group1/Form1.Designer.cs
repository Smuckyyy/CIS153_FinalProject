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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btn_Singleplayer.Location = new Point(9, 127);
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
            btn_Twoplayer.Location = new Point(173, 127);
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
            btn_Exit.Location = new Point(634, 127);
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
            btn_Stats.Location = new Point(470, 127);
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
            label2.Location = new Point(9, 211);
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
            checkBoxMusic.Location = new Point(690, 210);
            checkBoxMusic.Name = "checkBoxMusic";
            checkBoxMusic.Size = new Size(95, 23);
            checkBoxMusic.TabIndex = 6;
            checkBoxMusic.Text = "Play Music";
            checkBoxMusic.UseVisualStyleBackColor = true;
            checkBoxMusic.CheckedChanged += checkBoxMusic_CheckedChanged;
            checkBoxMusic.Click += checkBoxMusic_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sword_Border_1;
            pictureBox1.Location = new Point(26, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Sword_Border_2;
            pictureBox2.Location = new Point(470, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(315, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(210, 19);
            label3.TabIndex = 9;
            label3.Tag = "https://soundcloud.com/zbofficialmusic/moonlit-lake";
            label3.Text = "Art provided by: Cecil Younglove";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Tiny_Castle_1;
            pictureBox3.Location = new Point(337, 177);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Tiny_Castle_2;
            pictureBox4.Location = new Point(403, 177);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 252);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxMusic);
            Controls.Add(label2);
            Controls.Add(btn_Stats);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Twoplayer);
            Controls.Add(btn_Singleplayer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Connect 4: Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
