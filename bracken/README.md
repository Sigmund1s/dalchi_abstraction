# HILO Project
CSE210: Bracken Sant; bracken576@outlook.com or bsant576@byui.edu

Required software:

VS Code (https://code.visualstudio.com/download) and .NET Framework (https://dotnet.microsoft.com/en-us/download/dotnet-framework).

Description: 

This program utilizes classes to run a game called HILO. It is a guessing game where you guess if the next card is higher or lower than the previous card. 




Rules:

The player starts the game with 300 points.

Individual cards are represented as a number from 1 to 13.

The current card is displayed.

The player guesses if the next one will be higher or lower.

The the next card is displayed.

The player earns 100 points if they guessed correctly.

The player loses 75 points if they guessed incorrectly.

If a player reaches 0 points the game is over.

If a player has more than 0 points they decide if they want to keep playing.

If a player decides not to play again the game is over.




Explanation:

I made 5 different classes: Cards, Text, Score, GameOver, and GameRunner. Cards utilizes a random number generator in the range of 1 to 13 and can't return the same number as the previous card. Text is in charge of the outputs and inputs for the game. Score keeps track of the score and changes the score based on if the player guessed right for the given round. GameOver keeps track of if the score gets below 0. GameRunner is the main for the program and is in charge of all the other classes.

![hilo](https://user-images.githubusercontent.com/62550662/194626166-5108ca27-9e06-4fef-a37d-592bd3b8ed41.png)
