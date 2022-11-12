// ---------------------------VARIABLES------------------------------
using System;
using System.Text;

const int cityMaxHealth = 15;
const int maticoreMaxHealth = 10;
int round = 1;

int manticorePosition = 0;
int manticoreCurrentHealth = maticoreMaxHealth;
int cityCurrentHealth = cityMaxHealth;


// ---------------------------MAIN METHOD------------------------------
manticorePosition = AskForANumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", 0, 100);
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (cityCurrentHealth > 0 && manticoreCurrentHealth > 0)
{
    // Display the status for the round.
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-----------------------------------------------------------");
    DisplayStatus(round, cityCurrentHealth, manticoreCurrentHealth);

    // Display the amount of damage expected on a hit.
    int damage = DamageForRound(round);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    // Get a number from the player.
    Console.ForegroundColor = ConsoleColor.White;
    int target = AskForNumber("Enter desired cannon range: ");

    // Display the outcome of the number.
    Console.ForegroundColor = ConsoleColor.Magenta;
    DisplayOverOrUnder(target, manticorePosition);

    // Deal damage to the Manticore if it was a hit.
    if (target == manticorePosition) manticoreCurrentHealth -= damage;

    // Deal damage to the city if the Manticore is still alive.
    if (manticoreCurrentHealth > 0) cityCurrentHealth--;

    // Go on to the next round.
    round++;
}

Console.WriteLine("-----------------------------------------------------------");

// Display the outcome of the game.
bool result = cityCurrentHealth > 0;
DisplayWinOrLose(result);

// ---------------------------METHODS------------------------------

int AskForNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForANumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= min && number <= max)
            return number;
    }
}

void DisplayStatus(int round, int cityCurrentHealth, int manticoreCurrentHealth) =>
    Console.WriteLine($"STATUS: Round: {round} City: {cityCurrentHealth}/{cityMaxHealth} Manticore: {manticoreCurrentHealth}/{maticoreMaxHealth}");

int DamageForRound(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
        return 1;
    else if (round % 5 == 0 || round % 5 == 0)
        return 1;
    else
        return 1;
}

///<summary>Essa função cheva se o hit atingiu ou não a manticora.</summary>
/// <param name="taget"> Valor que o jogador acha que a manticora está posicionada.</param>
void DisplayOverOrUnder(int target, int manticorePosition)
{
    if (target > manticorePosition)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (target < manticorePosition)
    {
        Console.WriteLine("That round FEEL SHORT of the target.");
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
    }
}

void DisplayWinOrLose(bool result)
{
    if (result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }
}