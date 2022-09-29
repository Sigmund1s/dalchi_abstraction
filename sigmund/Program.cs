/***
When approaching object oriented programming. Look at it from the spectrum of what
    certain things can be objects.

    EXAMPLE: SOCCER - Players, Ball, Goal_Posts, Field

***/
// Objects: Player, Dealer, Cards

/***
Next thing is to identify what goes within each of the objects

PLAYER
- The player starts the game with 300 points.
- The player guesses if the next one will be higher or lower.
- The player earns 100 points if they guessed correctly.
- The player loses 75 points if they guessed incorrectly.
- If a player reaches 0 points the game is over.
- If a player has more than 0 points they decide if they want to keep playing.
- If a player decides not to play again the game is over.

DEALER
- running board game

CARDS
- Individual cards are represented as a number from 1 to 13.
- The current card is displayed.
- The the next card is displayed.

***/

class Player
{

}



class Dealer
{

}


class Cards
{

    // generate the range of cards 1-13 
    // I need to know how to make 4 -> 1's, 4 -> 3's etc.
    static List<string> GetCards()
    {
        List<string> cards = new List<string>();
        for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    
                }
                cards.Add(i.ToString());
            }
        return cards;
    }

   
}



