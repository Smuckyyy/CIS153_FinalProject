﻿namespace Connect4_Group1
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
            SuspendLayout();
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStats.Location = new Point(27, 34);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(205, 37);
            lblStats.TabIndex = 0;
            lblStats.Text = "Shows all stats";
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(lblStats);
            Name = "Statistics";
            Text = "Connect 4: Statistics Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStats;
    }
}