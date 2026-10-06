namespace Task3;

class Program
{
    static void Main()
    {
        // Declare and initialize one variable of each type
        byte byteValue = 200;              // 0 to 255
        short shortValue = 30000;          // -32,768 to 32,767
        int intValue = 42;                 // whole number, about +/- 2.1 billion
        long longValue = 9000000000L;      // very large whole number (needs L suffix)
        float floatValue = 3.14f;          // decimal, ~7 digits (needs f suffix)
        double doubleValue = 3.14159265;   // decimal, ~15 digits (default decimal type)
        decimal decimalValue = 99.99m;     // exact decimal, used for money (needs m suffix)
        char charValue = 'A';              // single character, in single quotes
        bool boolValue = true;             // true or false

        // Convert int 42 to a string
        string intAsString = intValue.ToString();

        // Convert string "3.14" to a double
        string text = "3.14";
        double stringAsDouble = Convert.ToDouble(text);

        // Print all variables with labels showing type and value
        Console.WriteLine($"byte    : {byteValue}");
        Console.WriteLine($"short   : {shortValue}");
        Console.WriteLine($"int     : {intValue}");
        Console.WriteLine($"long    : {longValue}");
        Console.WriteLine($"float   : {floatValue}");
        Console.WriteLine($"double  : {doubleValue}");
        Console.WriteLine($"decimal : {decimalValue}");
        Console.WriteLine($"char    : {charValue}");
        Console.WriteLine($"bool    : {boolValue}");
        Console.WriteLine($"int 42 converted to string : \"{intAsString}\"");
        Console.WriteLine($"string \"3.14\" converted to double : {stringAsDouble}");
    }
}