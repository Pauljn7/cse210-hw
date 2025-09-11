using System;
class Program {
    static void Main() {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("How old are you? ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }
}
