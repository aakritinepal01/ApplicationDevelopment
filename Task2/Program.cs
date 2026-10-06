namespace Task2;

class Circle
{
    // 'const' makes PI a compile-time constant; it must be given a value here
    // and can never be changed afterwards. It is implicitly static.
    public const double PI = 3.14;
}

// Program class: contains the Main method where the program starts
class Program
{
    // Main is the entry point; execution begins here
    static void Main()
    {
        // ERROR CS0131: PI is a constant, not a variable, so it cannot be
        // assigned a new value. This is like writing 3.14 = 3.14159,
        // which C# does not allow, so the build fails.
        Circle.PI = 3.14159;
    }
}