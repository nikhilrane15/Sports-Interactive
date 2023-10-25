using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the base: ");
        double baseNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        double result = CalculatePower(baseNumber, exponent);
        Console.WriteLine($"{baseNumber} ^ {exponent} = {result}");
    }

    static double CalculatePower(double baseNumber, int exponent, double partialResult = 1)
    {
        if (exponent == 0)
            return partialResult;

        return CalculatePower(baseNumber, exponent - 1, partialResult * baseNumber);
    }
}
