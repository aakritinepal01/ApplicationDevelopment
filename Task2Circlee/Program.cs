namespace Task2Circlee;

using System;

// Circle class: stores a radius and calculates area and perimeter
class Circle
{
    // Constant: fixed at compile time and cannot be changed
    public const double PI = 3.14;

    // Field: stores the radius of this circle
    public double Radius;

    // Constructor: runs when you create a Circle, and sets the radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method: area = PI * radius * radius
    public double CalculateArea()
    {
        return PI * Radius * Radius;
    }

    // Method: perimeter = 2 * PI * radius
    public double CalculatePerimeter()
    {
        return 2 * PI * Radius;
    }
}

// Program class: contains the Main method where the program starts
class Program
{
    static void Main()
    {
        // Create a Circle object with radius 5
        Circle myCircle = new Circle(5);

        // Print the constant and the results of the methods
        Console.WriteLine($"PI = {Circle.PI}");
        Console.WriteLine($"Radius: {myCircle.Radius}");
        Console.WriteLine($"Area: {myCircle.CalculateArea():F2}");
        Console.WriteLine($"Perimeter: {myCircle.CalculatePerimeter():F2}");
    }
}