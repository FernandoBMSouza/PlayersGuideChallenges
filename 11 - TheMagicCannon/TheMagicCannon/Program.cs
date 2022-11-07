for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{i}: Eletric and Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Eletric");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{i}: Normal");
    }
}

Console.ForegroundColor = ConsoleColor.White;