using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) {
            Console.WriteLine("That’s a positive number.");
        } else if (number < 0) {
            Console.WriteLine("That’s a negative number.");
        } else {
            Console.WriteLine("That’s zero.");
        }
    }
}
