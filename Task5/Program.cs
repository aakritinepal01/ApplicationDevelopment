namespace Task5;

class Program
{
    static void Main()
    {
        // Birthdate (change to your own: year, month, day)
        DateTime birthDate = new DateTime(2003, 5, 15);

        // Current date and time
        DateTime currentDate = DateTime.Now;

        // Subtract the two dates to get a TimeSpan
        TimeSpan ageSpan = currentDate - birthDate;

        // Convert total days to years (365.25 accounts for leap years)
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        // Add 10 days to the birthdate
        DateTime birthPlus10 = birthDate.AddDays(10);

        // Print results
        Console.WriteLine($"Birthdate    : {birthDate:dd MMM yyyy}");
        Console.WriteLine($"Current date : {currentDate:dd MMM yyyy HH:mm:ss}");
        Console.WriteLine($"Days lived   : {(int)ageSpan.TotalDays}");
        Console.WriteLine($"Age in years : {ageInYears}");
        Console.WriteLine($"Birthdate + 10 days : {birthPlus10:dd MMM yyyy}");
    }
}