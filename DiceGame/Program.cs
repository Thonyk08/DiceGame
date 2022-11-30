using System.ComponentModel.DataAnnotations;

int length = 11; //number of rounds

int playerRandomNum; //player - random number
int enemyRandomNum;  // PC - random number

int playerPoints = 0;  // player points
int enemyPoints = 0;    // PC points

Random rand= new Random();

for (int i=0; i<length; i++)
{
    Console.WriteLine("Press any key to roll the dice.");

    Console.ReadKey();

    playerRandomNum= rand.Next(1,7); // random number from 1 to 6
    Console.WriteLine("You rolled a " + playerRandomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1500); // pause

    enemyRandomNum = rand.Next(1,7);    // random number from 1 to 6
    Console.WriteLine("Enemy rolled a " + enemyRandomNum);

    if (playerRandomNum > enemyRandomNum)
    {
        playerPoints++; // increase player points
    }
    else if(playerRandomNum<enemyRandomNum)
    {
        enemyPoints++;  // increase PC points
    }
    else
    {
        Console.WriteLine("DRAW");
    }

    Console.WriteLine($"Current score: You - " + playerPoints + "  CPU - " + enemyPoints);

}

Console.WriteLine("");
Console.WriteLine("");

if (playerPoints > enemyPoints)
{
    Console.WriteLine("YOU WIN!!!!");
}
else if (playerPoints < enemyPoints) 
{ Console.WriteLine("YOU LOOOOSE!!!!!!!");
}
else { Console.WriteLine("IT´S DEFINETLY DRAW!"); }

Console.ReadKey();