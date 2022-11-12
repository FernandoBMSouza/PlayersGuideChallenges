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

enum ChestState { Open, Closed, Locked };