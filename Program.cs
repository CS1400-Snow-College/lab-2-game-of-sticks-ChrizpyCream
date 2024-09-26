// See https://aka.ms/new-console-template for more information


const int MinSticks = 1;
const int MaxSticks = 3;
int totalSticks = 20;
int currentPlayer = 1;
        
Console.WriteLine("----------------------------------");
Console.WriteLine("- Welcome to the game of sticks! -");
Console.WriteLine("----------------------------------");
Console.WriteLine("\nPlayers will take turns removing between 1 and 3 of the remaining sticks.");
Console.WriteLine("The player that removes the last stick loses.\n");

 while (totalSticks > 0)
{
 Console.WriteLine($"Sticks left: {totalSticks}");
 Console.Write($"Player {currentPlayer}, how many sticks would you like to take? ");
            
int sticksTaken;
while (!int.TryParse(Console.ReadLine(), out sticksTaken) || sticksTaken < MinSticks || sticksTaken > MaxSticks || sticksTaken > totalSticks)
{
if (sticksTaken > totalSticks)
 {
Console.WriteLine($"Sorry, there are not {sticksTaken} sticks left.");
}
else if (sticksTaken < MinSticks)
{
Console.WriteLine("Please choose at least 1 stick.");
}
else if (sticksTaken > MaxSticks)
{
Console.WriteLine($"Please choose a number between {MinSticks} and {MaxSticks}.");
}
                
Console.Write($"Player {currentPlayer}, how many sticks would you like to take? ");
}
totalSticks -= sticksTaken;

if (totalSticks == 0)
{
 Console.WriteLine("\n/---------------\\");
 Console.WriteLine($"| Player {(currentPlayer == 1 ? 2 : 1)} won! |");
 Console.WriteLine("\\---------------/");
break;
}

 currentPlayer = currentPlayer == 1 ? 2 : 1; // Switch players
        }

