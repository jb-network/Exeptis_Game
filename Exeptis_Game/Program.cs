// This is challenge work for the "C# Players Guide"
// Level 35 "Exepti's Game" Challenge
// The purpose of the task is to use a try/catch block to handle an exception from a numbers gussing game



//Game Setup
Random random = new Random();
int OatmealCookie = random.Next(1, 11);
GameVars SetVars = new GameVars();
SetVars.SetPlayers();

while (SetVars.GameOn == true) SetVars.PlayRound(SetVars.Player1, SetVars.Player2, SetVars.Player1Turn, SetVars.GameOn, SetVars.NumberTracker, OatmealCookie);

public class GameVars
{
    public string Player1 = "Player1";
    public string Player2 = "Player2";
    public bool Player1Turn = true;
    public bool GameOn = true;
    public List<int> NumberTracker = new List<int>();

    public void SetPlayers()
    {
        Console.WriteLine("Welcome to the cookie game");
        Console.WriteLine("The room is full of 10 cookies");
        Console.WriteLine("Each cookie is numbered, and 9 of the cookies are Chocolate chip");
        Console.WriteLine("One of the cookies is an Oatmeal cookie");
        Console.WriteLine("The goal is to not be the person to pickup the oatmeal cookie");
        Console.WriteLine("If you get the oatmeal cookie, you lose the game");
        Console.WriteLine("Good luck!\n");

        Console.WriteLine("Player 1, Please enter your name: ");
        Player1 = Console.ReadLine();
        Console.WriteLine($"Ok, {Player1} you are all set for the game\n");

        Console.WriteLine("Player 2, Please enter your name: ");
        Player2 = Console.ReadLine();
        Console.WriteLine($"Ok, {Player2} you are all set for the game\n");

        Console.WriteLine("Press any key to start the game");
        Console.ReadKey();
        Console.Clear();
    }
     internal void PlayRound(string player1, string player2, bool player1Turn, bool gameOn, List<int> numberTracker, int RandomCookieNumber)
    {
        string PlayerName;
        bool GameLoop = false;

        if (Player1Turn == true) PlayerName = player1;
        else PlayerName = player2;

        do
        {
            Console.WriteLine($"{PlayerName} it is your turn");
            Console.WriteLine($"Guess a number from 1 to 10\n");
            int UserGuess = Convert.ToInt16(Console.ReadLine());
            bool IsPresent = numberTracker.Contains(UserGuess);
            
            //Testing Exception handling
            try
            {
                if (UserGuess == RandomCookieNumber) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("You got the oatmeal cookie");
                Console.WriteLine($"{PlayerName}, you lost the game!");
                Console.WriteLine("Better luck next time");
                GameOn = false;
                break;
            }
            if (!IsPresent)
            {
                Console.WriteLine("\nThe number you guessed, has not been guessed during this game");
                Console.WriteLine("You are lucky, the cookie you picked up was chocolate chip");
                numberTracker.Add(UserGuess);
                Console.WriteLine("Press any key to start the next move");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("\nThe number you guessed, has already been guessed.");
                Console.WriteLine("Press any key to guess another number");
                Console.ReadKey();
                Console.Clear();
                GameLoop = true;
            }
        } while (GameLoop == true);
        
        //Set to next player
        if (player1Turn == true) Player1Turn = false;
        else Player1Turn = true;
    }
}

   