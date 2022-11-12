//Variables
int cityMaxHealth = 15;
int cityCurrentHealth = cityMaxHealth;
int maticoreMaxHealth = 10;
int manticoreCurrentHealth = maticoreMaxHealth;
int manticorePosition = 0;
int round = 1;


//Main Method
while (true)
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
    manticorePosition = Convert.ToInt32(Console.ReadLine());

    if (manticorePosition >= 0 && manticorePosition <= 100) break;

    Console.WriteLine("The number must be between 0 and 100!");
}

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("--------------------------");
GameLoop();
Console.ReadKey();


//Methods
void GameLoop()
{
    while(true)
    {
        DisplayMenu();

        cityCurrentHealth--;
        round++;

        if(cityCurrentHealth <= 0 && manticoreCurrentHealth <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Manticore has been destroyed! But the city of consolas has also been destroyed...");
            Console.WriteLine("Game Over.");
            break;
        }
        else if (cityCurrentHealth <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over.");
            break;
        }
        else if(manticoreCurrentHealth <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            break;
        }
    }
}

///<summary>
/// Essa função mostra o menu do round atual para o jogador
/// </summary>
void DisplayMenu()
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityCurrentHealth}/{cityMaxHealth} Manticore: {manticoreCurrentHealth}/{maticoreMaxHealth}");
    CannonPrint(round);
    Console.Write("Enter desired cannon range: ");
    int target = Convert.ToInt32(Console.ReadLine());
    CheckHit(target);
    Console.WriteLine("--------------------------");
}

///<summary>Essa função cheva se o hit atingiu ou não a manticora.</summary>
/// <param name="taget"> Valor que o jogador acha que a manticora está posicionada.</param>
void CheckHit(int target)
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
        manticoreCurrentHealth -= CannonDamage(round);
    }
}

void CannonPrint(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 10 damage this round.");
    }
    else if (round % 5 == 0 || round % 5 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 3 damage this round.");
    }
    else
    {
        Console.WriteLine("The cannon is expected to deal 1 damage this round.");
    }
}

int CannonDamage(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
        return 10;
    else if (round % 5 == 0 || round % 5 == 0)
        return 3;
    else
        return 1;
}


