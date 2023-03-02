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

///<sumary>Esse método pergunta um número para o usuário e o retorna</sumary>
///<param name="text">O texto que será perguntado ao usuário</param>
int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

///<sumary>Esse método pergunta um número para o usuário que esteja dentro de um range, caso esteja o retorna, caso não continua em loop</sumary>
///<param name="text">O texto que será perguntado ao usuário</param>
///<param name="min">O valor mínimo que pode ser digitado pelo usuário</param>
///<param name="max">O valor máximo que pode ser digitado pelo usuário</param>
int AskForNumberInRange(string text, int min, int max)
{
    int answer;
    do
    {
        Console.Write(text);
        answer = Convert.ToInt32(Console.ReadLine());
    } while (answer > max || answer < min);
    return answer;
}