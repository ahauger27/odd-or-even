Loop();
Console.WriteLine("Goodbye");

void Loop()
{
    while (true)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter a number, and I'll tell you whether it's odd or even.");
        
        int guess = GetUserNumber();
        Console.WriteLine($"The number {guess} is {CheckOddOrEven(guess)}.");
        Console.WriteLine("");
        
        if (!CheckLoop())
        {
            break;
        }
    }
}

int GetUserNumber()
{
    int number = 0;
    bool validInput = false;
    while (validInput == false)
    {
        try
        {
            Console.Write("Enter a number: ");
            string? userInput = Console.ReadLine();
            number = int.Parse(userInput);
            validInput = true;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Please input a numeric value. ");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Please enter a number between {int.MinValue} and {int.MaxValue}.");
        }
        finally
        {
            Console.WriteLine("");
        }
    }
    
    return number;  
}

string CheckOddOrEven(int number)
{
    if (number % 2 == 0)
    {
        return "even"; 
    }
    else
    {
        return "odd";
    }
}

bool CheckLoop()
{
    while (true)
    {
        Console.WriteLine("Would you like to continue? (Y/N)");
        string? response = Console.ReadLine();
    
        if (response.ToUpper() == "Y")
        {
            return true;
        }
        else if (response.ToUpper() == "N")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter Y or N.");
        }
    }
}