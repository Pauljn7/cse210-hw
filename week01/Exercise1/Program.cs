using System;
class Program
{
    static void Main()
    {
        // Ask for the user’s name
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        // Ask for their favorite color
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

        // Output a sentence using variables
        Console.WriteLine($"{name}, your favorite color is {color}!");
    }
}
