using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("N should be a non-negative integer.");
        }
        else
        {
            int result = Fibonacci(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {result}");
        }
    }
}
