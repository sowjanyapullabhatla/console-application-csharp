using System;

public class AdditionApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Addition App!");

        // Get the first number from the user
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        double number1;

        // Validate the first input
        while (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the first number: ");
            input1 = Console.ReadLine();
        }

        // Get the second number from the user
        Console.Write("Enter the second number 1: ");
        string input2 = Console.ReadLine();
        double number2;

        // Validate the second input
        while (!double.TryParse(input2, out number2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the second number: ");
            input2 = Console.ReadLine();
        }

        // Calculate the sum
        double sum = number1 + number2;

        // Display the result
        Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}