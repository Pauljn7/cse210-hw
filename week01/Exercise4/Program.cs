using System;

class Program {
    static void Main() {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++) {
            int input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(input);
        }

        int sum = 0;
        foreach (int n in numbers) {
            sum += n;
        }

        Console.WriteLine($"The total sum is {sum}");
    }
}
