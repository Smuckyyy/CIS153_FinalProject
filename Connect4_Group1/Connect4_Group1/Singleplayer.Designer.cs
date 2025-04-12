namespace Connect4_Group1
{
    partial class Singleplayer
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
            singleBtn_Exit = new Button();
            SuspendLayout();
            // 
            // singleBtn_Exit
            // 
            singleBtn_Exit.BackColor = Color.Silver;
            singleBtn_Exit.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            singleBtn_Exit.ForeColor = Color.MediumBlue;
            singleBtn_Exit.Location = new Point(630, 12);
            singleBtn_Exit.Name = "singleBtn_Exit";
            singleBtn_Exit.Size = new Size(158, 39);
            singleBtn_Exit.TabIndex = 4;
            singleBtn_Exit.Text = "Exit";
            singleBtn_Exit.UseVisualStyleBackColor = false;
            singleBtn_Exit.Click += singleBtn_Exit_Click;
            // 
            // Singleplayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(singleBtn_Exit);
            Name = "Singleplayer";
            Text = "Connect 4: Singleplayer Game";
            ResumeLayout(false);
        }

        #endregion

        private Button singleBtn_Exit;
    }
}