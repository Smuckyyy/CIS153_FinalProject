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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Hollywood Hills", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 59);
            label1.Name = "label1";
            label1.Size = new Size(532, 172);
            label1.TabIndex = 0;
            label1.Text = "Welcome to \r\nConnect 4";
            // 
            // btn_Singleplayer
            // 
            btn_Singleplayer.Font = new Font("Hollywood Hills", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Singleplayer.Location = new Point(36, 318);
            btn_Singleplayer.Name = "btn_Singleplayer";
            btn_Singleplayer.Size = new Size(158, 81);
            btn_Singleplayer.TabIndex = 1;
            btn_Singleplayer.Text = "Singleplayer";
            btn_Singleplayer.UseVisualStyleBackColor = true;
            btn_Singleplayer.Click += btn_Singleplayer_Click;
            // 
            // btn_Twoplayer
            // 
            btn_Twoplayer.Font = new Font("Hollywood Hills", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Twoplayer.Location = new Point(210, 318);
            btn_Twoplayer.Name = "btn_Twoplayer";
            btn_Twoplayer.Size = new Size(158, 81);
            btn_Twoplayer.TabIndex = 2;
            btn_Twoplayer.Text = "Two Player";
            btn_Twoplayer.UseVisualStyleBackColor = true;
            btn_Twoplayer.Click += btn_Twoplayer_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Hollywood Hills", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(587, 318);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(158, 81);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Stats
            // 
            btn_Stats.Font = new Font("Hollywood Hills", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Stats.Location = new Point(411, 318);
            btn_Stats.Name = "btn_Stats";
            btn_Stats.Size = new Size(158, 81);
            btn_Stats.TabIndex = 4;
            btn_Stats.Text = "Statistics";
            btn_Stats.UseVisualStyleBackColor = true;
            btn_Stats.Click += btn_Stats_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Stats);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Twoplayer);
            Controls.Add(btn_Singleplayer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Connect 4: Home Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Singleplayer;
        private Button btn_Twoplayer;
        private Button btn_Exit;
        private Button btn_Stats;
    }
}
