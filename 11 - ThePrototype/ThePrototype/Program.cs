using System.Diagnostics;


Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("---------------------");
Console.WriteLine("        PILOT        ");
Console.WriteLine("---------------------");

int number = AskForANumberInRange("Enter a number between 0 and 100: ", 0, 100);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("---------------------");
Console.WriteLine("        HUNTER       ");
Console.WriteLine("---------------------");

int answer;

for(;;)
{
    answer = AskForANumber("Guess the number between 0 and 100: ");

    if (answer == number)
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


int AskForANumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= max && number >= min)
            return number;
        else
            continue;
    }
}

int AskForANumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}