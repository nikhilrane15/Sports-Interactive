using System;

public enum Colors
{
    Red,
    Blue,
    Green,
    Yellow
}

class Program
{
    static void Main()
    {
        foreach (Colors color in Enum.GetValues(typeof(Colors)))
        {
            Console.WriteLine(color);
        }
    }
}
