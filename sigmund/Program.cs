/***
When approaching object oriented programming. Look at it from the spectrum of what
    certain things can be objects.

    EXAMPLE: SOCCER - Players, Ball, Goal_Posts, Field

***/
// Objects: Player, Dealer, Cards

/***
Next thing is to identify what goes within each of the objects

GAMERUNNER
- TEXT PROMPTS
    - Display numbers
    - The Dealer asks if the next one will be higher or lower.

PLAYER
- [DONE?]The player starts the game with 300 points.
- [DONE]Player chooses a card
- ADD/SUBTRACT POINTS
    - The player earns 100 points if they guessed correctly.
    - The player loses 75 points if they guessed incorrectly.
    - What happens if you guess the same number as the current number?


- running board game
- If a player has more than 0 points they decide if they want to keep playing. DEALER CONTINUES GAME
- If a player reaches 0 points the game is over. DEALER ENDS GAME
- If a player decides not to play again the game is over.

CARDS
- [DONE]Individual cards are represented as a number from 1 to 13. 
- [DONE]The current card is displayed.
- [DONE]The the next card is displayed.
- [CURRENT] Compare CurrentCard and NextCard

***/

class Player
{

    public static string ChoiceHL()
    {
        string choice;

        choice = Console.ReadLine();

        return choice;
    } 

/***
    public static int Points()
    {
        int startPoints = 300;
        int goodPoints = 100;
        int badPoints = 75;


        
        return points
    }
***/

}



class Dealer
{

}


class Cards // This is the class
{
    // generate the range of cards 1-13 
    // I need to know how to make 4 -> 1's, 4 -> 3's etc.
    public static List<int> GetCards() // GetCards is the method
    {
        List<int> cards = new List<int>();
        //int numbers = 0;
        for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(i);
                }
            }
        return cards;
    }

    // I'm going to call this twice
    public static int RandomCard(List<int> getCards)
    {
        Random random = new Random(); // new = makes a brand new object
        int index = random.Next(getCards.Count()-1); // This gets the range of "getCards", -1 will return the actual size.
        int card = getCards[index];

        return card;
    }


    // I want to call RandomCard method inside these two below.
    public static int CurrentCard(List<int> getCards)
    {
        int current = RandomCard(getCards);

        return current;
    }


    public static int NextCard(List<int> getCards)
    {
        int next = RandomCard(getCards);

        return next;
    }

    // When comparing CurrentCard and NextCard -> They are integers
    //      - However the ChoiceHL is a string
    //      - MY QUESTION: would I make this "public static string" or "public static int"?
    //      - I'm gonna need methods from other classes.
    //          - Classes to use: Player.ChoiceHL, Cards.CurrentCard, Cards.NextCard
    /***
    public static string CompareCards()
    {



        return comparison;
    }
    ***/

}


class GameRunner
{
       static void Main(string[] args) //string[] args is used for debugging
   {
        /***
        - Card is shown
        - Dealer asks: "Higher or Lower: H/L"
        - Player chooses option

        ***/
        
        // This prints out the random card.
        Console.WriteLine($"The Card is: {Cards.CurrentCard(Cards.GetCards())}"); // Write the line; Call the class and the method inside; "Cards.GetCards()" are the neede parameters.
        
        // Prompts and asks user for H/L
        Console.Write("Higher or Lower? [H/L] ");
        string choice = Player.ChoiceHL();
        Console.WriteLine($"Response: {choice}");

        // Shows next number; deducts or adds points based on choice
        Console.WriteLine($"Next Card: {Cards.NextCard(Cards.GetCards())}");
        // Here i'll call Player.CompareCards
   }
}
















// EXTRA CODE/LEARNING CODE
/***


   //public static int player = 300; // static in this case can be called by other classes easier. public, so that I can use it anywhere else.

        // This printed out the starting points
        //Console.WriteLine(Player.player);


        // Prompts and asks user for H/L
        //string choice;
        //choice = Console.ReadLine();


        //USED TO PRINT OUT THE LIST 
        string s ="";
        foreach(int cards in Cards.GetCards())
        {
            s += cards+" ";
        }
        Console.WriteLine(s);


        // METHODS I HAVE TRIED BUT DIDNT WORK
        //Console.WriteLine(GetCards());
        //GetCards().ToList().foreach(Console.WriteLine);
***/