namespace Task4;

class Program
{
    static void Main()
    {
        // Single-dimensional integer array with 5 favorite numbers
        int[] numbers = { 7, 3, 9, 1, 5 };

        // Sort in ascending order
        Array.Sort(numbers);
        Console.WriteLine("After Array.Sort() (ascending):");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }

        // Reverse the sorted array (now descending)
        Array.Reverse(numbers);
        Console.WriteLine("\nAfter Array.Reverse() (descending):");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }

        // Find the position of a specific number
        int target = 5;
        int position = Array.IndexOf(numbers, target);
        Console.WriteLine($"\nThe number {target} is at index {position}");
    }
}