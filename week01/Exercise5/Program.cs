using System;

class Program {
    // Function to add two numbers together
    static int Add(int a, int b) {
        return a + b;
    }

    static void Main() {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = Add(num1, num2);
        Console.WriteLine($"The sum of {num1} and {num2} is {result}");
    }
}
