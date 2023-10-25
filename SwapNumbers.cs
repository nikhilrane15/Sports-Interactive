using System;

class Program
{
    static void Main()
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

        num1 = num1 ^ num2;
        num2 = num1 ^ num2;
        num1 = num1 ^ num2;

        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
    }
}
