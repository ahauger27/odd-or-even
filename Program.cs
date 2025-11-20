// we'll use the Random class later to fill an array with randomly generated numbers.
Random numberGenerator = new Random();

// declare an array, 'numbers', and set each entry to 0.
int[] numbers = [0, 0, 0, 0, 0, 0, 0];
// store the length of 'numbers' in a variable, arrayLength.
int arrayLength = numbers.Length;

// starting at index 0, we'll iterate through the array
for (int i = 0; i < arrayLength; i++)
{
    // each iteration, the array item will be assigned a random number.
    numbers[i] = numberGenerator.Next(1, 101);
    
    // then check wheter each generated number is evenly divisble by 0.
    if ((numbers[i] % 2) == 0)
    {
        // if true, the number is even.
        Console.WriteLine($"The number {numbers[i]} is even.");
    }
    else
    {
        // if not, then the number is odd.
        Console.WriteLine($"The number {numbers[i]} is odd.");
    }
}