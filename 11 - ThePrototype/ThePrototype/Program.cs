using System.Diagnostics;


Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("---------------------");
Console.WriteLine("        PILOT        ");
Console.WriteLine("---------------------");

int number = AskForNumberInRange("Enter a number between 0 and 100: ", 0, 100);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("---------------------");
Console.WriteLine("        HUNTER       ");
Console.WriteLine("---------------------");

int answer;

for(;;)
{
    answer = AskForNumber("Guess the number between 0 and 100: ");

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


int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    int answer;
    do
    {
        Console.Write(text);
        answer = Convert.ToInt32(Console.ReadLine());
    } while (answer >= max || answer <= min);
    return answer;
}