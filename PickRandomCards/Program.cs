// See https://aka.ms/new-console-template for more information
using PickRandomCards;

    Console.Write("Enter the number of cards to pick: ");
    string line = Console.ReadLine();
    
    if (int.TryParse(line, out int numberOfCards))
    {
        string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);
        foreach (string item in pickedCards)
        {
        Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine("Invalid input, Please enter a integer value");
    }


    