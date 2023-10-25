using System;

class AreaCalculator
{
    // Calculate the area of a square
    public double CalculateArea(double sideLength)
    {
        return sideLength * sideLength;
    }

    // Calculate the area of a rectangle
    public double CalculateArea(double length, double width)
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator calculator = new AreaCalculator();

        // Calculate the area of a square
        double squareArea = calculator.CalculateArea(5.0);
        Console.WriteLine("Area of the square: " + squareArea);

        // Calculate the area of a rectangle
        double rectangleArea = calculator.CalculateArea(4.0, 6.0);
        Console.WriteLine("Area of the rectangle: " + rectangleArea);
    }
}
