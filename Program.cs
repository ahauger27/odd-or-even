int number = GetUserNumber();

int GetUserNumber()
{
    Console.Write("Enter a number: ");
    
    try
    {
        string? userInput = Console.ReadLine();
        int number = int.Parse(userInput);
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Please input a number: ");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"Please enter a number between {int.MinValue} and {int.MaxValue}:");
    }
    return number;  
}