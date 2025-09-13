using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Add + or - except for F and A+ over 100
        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7 && grade < 100)
            {
                letter += "+";
            }
            else if (lastDigit < 3)
            {
                letter += "-";
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
