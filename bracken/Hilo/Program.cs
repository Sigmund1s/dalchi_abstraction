//The cards class creates new cards and makes sure that the new random card isn't the same as the previous card.
class Cards{
    public static int cards(int previous_card){
        Random ran_num = new Random();
        int random = previous_card;
        while (random == previous_card)
            random = ran_num.Next(1,14);
        return random;
    }
}
//the text class runs through the text and responses and calls to the score class to add or subtract from the score.
class Text{
    public void text(int previous_card, int ran_num){
            int total_score = 0;
            Console.Write($"The card is: {previous_card}\nHigher or lower? [h/l] ");
            string? guess = Console.ReadLine();
            Console.WriteLine($"Next card was: {ran_num}");
            if (Equals(guess, "l") && previous_card > ran_num)
                total_score = Score.UpdateScore(100);
            else if(Equals(guess, "h") && previous_card < ran_num)
                total_score = Score.UpdateScore(100);
            else total_score = Score.UpdateScore(-75);
            Console.WriteLine($"Your score is {total_score}");
    }
}
//the score class keeps track of the score.
class Score{
    public static int score = 300;
    public static int UpdateScore(int add_sub){
        score += add_sub;
        return score;
    }
}
//gameOver class only tests if the score goes below zero and if it does then it returns true that the game is over to the gameRunner class.
class GameOver{
    public static bool IsGameOver(){
        int the_score = Score.UpdateScore(0);
        if(the_score <= 0) return true;
        return false;
    }
}
//gamRunner begins the game and loops through the other classes to make everything come together and work. It is the main for the entire file.
//It creates two cards at the beginning, for the initial card and then the new card needed for the first run through for the Text class.
class GameRunner{
    public static void Main(string[] args){
        int previous_card = Cards.cards(0);
        int next_card = Cards.cards(previous_card);
        Text t = new Text();
        string? yes_no = "y";
        while (Equals(yes_no, "y")){
            t.text(previous_card, next_card);
            Console.Write("Play again? [y/n] ");
            yes_no = Console.ReadLine();
            if (GameOver.IsGameOver()) break;
            previous_card = next_card;
            next_card = Cards.cards(previous_card);
            Console.WriteLine();
        }
        int final_score = Score.UpdateScore(0);
        Console.WriteLine($"Thanks for playing, you achieved a score of: {final_score}");
    }
}
