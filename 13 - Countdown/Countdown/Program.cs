//RecursionVoid(10);

///<summary>Escreve na tela uma contagem regressiva do numero inserio</summary>
///<param name="number">Número em que começa a contagem regressiva</param>
///<return>Caso o numero seja 1 retorna 1, caso outro qualquer retona seu antecessor</return>
int Recursion(int number)
{
    if (number == 1) return number;
    else
    {
        Console.WriteLine(number);
        return Recursion(number - 1);
    }
}

void RecursionVoid(int number)
{
    if (number == 0) return;
    else
    {
        Console.WriteLine(number);
        RecursionVoid(number - 1);
    }
}

// 01/03/2023

int Factorial(int value)
{
    //base case
    if(value == 1) 
        return 1;

    return value * Factorial(value - 1);
}

Countdown(10);

void Countdown(int startNumber)
{
    if(startNumber == 0) return;
    Console.WriteLine(startNumber);
    Countdown(startNumber - 1);
}