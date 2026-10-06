namespace Task6;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List<string> with 3 favorite fruits
        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Print all fruits using foreach
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Dictionary<int, string>: key = fruit ID, value = fruit name
        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        // Add a new entry
        fruitDict.Add(4, "Orange");

        // Print all key-value pairs
        Console.WriteLine("\nFruit dictionary:");
        foreach (KeyValuePair<int, string> item in fruitDict)
        {
            Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
        }
    }
}