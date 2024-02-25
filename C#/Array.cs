using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = (i + 1) * (i + 1); // Formula: n^2
        }

        Console.WriteLine("Array elements: " + string.Join(" ", numbers));

        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest element in the array is: {max}");
    }
}
