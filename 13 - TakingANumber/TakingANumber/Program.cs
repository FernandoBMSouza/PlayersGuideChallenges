int AskForANumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForANumberInRange(string text, int min, int max)
{
    while(true)
    {
        Console.Write(text);
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= max && number >= min)
            return number;
        else
            continue;
    }
}