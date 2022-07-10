// This is challenge work for the "C# Players Guide"
// Level 35 "Exepti's Game" Challenge
// The purpose of the task is to use a try/catch block to handle an exception from a numbers gussing game

bool GameOn = true;

int OatmealCookie;
int PlayerTurn = 1;
(string Player1, string Player2, bool Player1Turn) player;



//Game Setup
Random random = new Random();
OatmealCookie = random.Next(0, 10);
player = SetPlayerName();

//Test Setup
Console.WriteLine($"{player.Player1}, {player.Player2}, {player.Player1Turn}");

while (GameOn = true)
{
    
   GameOn = false;
}





//Get Player Name Method
(string Player1, string Player2, bool Player1Turn) SetPlayerName()
{
    Console.WriteLine("Player 1, Please enter your name: ");
    player.Player1 = Console.ReadLine();
    Console.WriteLine($"Ok, {player.Player1} you are all set for the game\n");

    Console.WriteLine("Player 2, Please enter your name: ");
    player.Player2 = Console.ReadLine();
    Console.WriteLine($"Ok, {player.Player2} you are all set for the game\n");

    return (player.Player1, player.Player2, player.Player1Turn = true);


}