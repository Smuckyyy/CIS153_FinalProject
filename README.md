# CIS153_FinalProject: Connect 4

Made by: Marcus Rollins, Matt Wishman, and Cecil Younglove  


# Program Description

In this version of Connect 4, we have 4 Main Forms:  
-Main Form: This is the games main menu. It features the title, a music feature, and 4 buttons that lead to the other forms listed below.  
-Singleplayer Form  
-Two-Player Form  
-Statistics Form  
-Exit button: The exit button is on every single form that the user enters. It full exits the entire program, no matter how far in they are. 
  
# Singleplayer and Two-Player Gamemodes

In these two forms no matter which one the player chooses, it displays a Board with 7 (width) x 6 (height) Cells. There is an exit button and main menu button in the top right. When the user clicks the main menu button during a game, it displays to them a warning message saying that if they do return to the main menu, the game will not be saved.  

Below each Cell is an "Insert" button, where the player(s) can insert their piece. If the player(s) hover over a column, it will show where the piece will go after they hit "Insert" button.  

In the bottom right of the game screen, it shows whose current turn it is in text and the current player(s) color.

The biggest difference between Singleplayer and Two-Player is the AI included in Singleplayer. The user will face a rules-based AI that is made to block the player from winning, and taking a win from the player given it's opportunity. The AI works simply; It plays it's turn on the 1st column until either:  
-The AI can take a win somewhere else  
OR  
-The player is 1 move away from a win  

The Two-Player game works the exact same; except there is no AI to face, and two real-life players take turns placing pieces.  

# Game Over Form

Once the game ends in either gamemode, a form will appear showing the player(s):  
-Who won  
-The player(s) total wins  
-The AI's total wins  
-The player(s) win percentage  
-The AI's win percentage  

The player then has 3 buttons on this form: Play Again, Review Thy Game, and Exit. 

If the player chooses to Play Again, the gameboard and cells reset to blank, and Player 1 will go first again.

If the player chooses to Review, the window moves to the side of the gameboard, and the winning pieces will blink to show the winning pieces.  

# Statistics Form

In the Statistics form, it shows some of the same stats as stated above, just in an overall window:  
-Your Wins  
-AI Wins  
-Your Win Percentage  
-AI Win Percentage  
-Game Ties  
-Total Games Played  

# Code Information  

Our Connect 4 game includes 4 classes: Board (contains all Getters and Setters for the Board), Cell (contains all Getters and Setters for each Cell and colors), Data (for persistant game data), and Game Settings (holds all settings that allow the game to be played and ran).  


Thank you for playing our Game!
--------------------------------
