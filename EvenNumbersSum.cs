using System;

class Program
{
    public static int SumEvenNumbers(int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                total += number;
            }
        }
        return total;
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int evenTotal = SumEvenNumbers(numbers);
        Console.WriteLine("Sum of even numbers: " + evenTotal);
    }
}
