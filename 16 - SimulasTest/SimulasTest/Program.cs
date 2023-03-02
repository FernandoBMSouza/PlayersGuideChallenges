ChestState currentState = (ChestState) 2;
string answer;

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    answer = Console.ReadLine().ToLower();

    switch (currentState)
    {
        case ChestState.Open:
            if (answer == "unlock") 
                currentState = ChestState.Closed;
            break;    
        case ChestState.Closed:
            if(answer == "lock")
                currentState = ChestState.Locked;
            else if(answer == "open")
                currentState = ChestState.Open;
            break;
        case ChestState.Locked:
            if (answer == "unlock")
                currentState = ChestState.Closed;
            break;

        default: continue;
    }
}




void Antigo()
{
    ChestState currentChestState = ChestState.Locked;

    while (true)
    {
        Console.Write($"The chest is {currentChestState}. What do you want to do? ");
        string answer = Console.ReadLine().ToLower();

        switch (currentChestState)
        {
            case ChestState.Open:
                if (answer == "close") currentChestState = ChestState.Closed;
                break;
            case ChestState.Closed:
                if (answer == "lock") currentChestState = ChestState.Locked;
                else if (answer == "open") currentChestState = ChestState.Open;
                break;
            case ChestState.Locked:
                if (answer == "unlock") currentChestState = ChestState.Closed;
                break;
        }
    }
}

enum ChestState { Open, Closed, Locked }
