using System.Diagnostics;


Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("---------------------");
Console.WriteLine("        PILOT        ");
Console.WriteLine("---------------------");

int number;

do
{
    Console.Write("Enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());

} while (number < 0 || number > 100);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("---------------------");
Console.WriteLine("        HUNTER       ");
Console.WriteLine("---------------------");

int answer;

for(;;)
{
    Console.Write("Guess the number: ");
    try
    {
        answer = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Enter a valid number");
        continue;
    }

    if(answer == number)
    {
        break;
    }
    else if(answer > number)
    {
        Console.WriteLine($"No, the number is smaller then {answer}.");
        continue;
    }
    else
    {
        Console.WriteLine($"No, the number is greater then {answer}.");

    }
}

Console.WriteLine($"You found the number! It's {answer}.");
