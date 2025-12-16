Loop();
Console.WriteLine("Goodbye");

void Loop()
{
    while (true)
    {
        Console.WriteLine("Enter a number, and I'll tell you whether it's odd or even. Press 'Q' to quit.");
        string? input = Console.ReadLine();

        try
        {
            input = input.ToUpper();
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Please input a number")
        }
        if (input == "Q")
        {
            break;
        }
        else
        {
            int number = GetUserNumber();
            CheckOddOrEven(number);
            Console.WriteLine("");
        }
    }
}

int GetUserNumber()
{
    Console.Write("Enter a number: ");
    int number = 0;
    try
    {
        string? userInput = Console.ReadLine();
        number = int.Parse(userInput);
    }
    catch (FormatException)
    {
        Console.WriteLine($"Please input a number: ");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"Please enter a number between {int.MinValue} and {int.MaxValue}:");
    }
    return number;  
}

string CheckOddOrEven(int number)
{
    if (number % 2 == 0)
    {
        return "Even"; 
    }
    else
    {
        return "Odd";
    }
}