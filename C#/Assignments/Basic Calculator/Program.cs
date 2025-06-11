using System;

class SimpleCalculator
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("=== Simple Calculator ===");

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // menu
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            double result = 0;
            bool validChoice = true;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    validChoice = false;
                    break;
            }

            if (validChoice)
                Console.WriteLine("Result: " + result);

            Console.Write("Do you want to continue? (y/n): ");
            string again = Console.ReadLine().ToLower();
            if (again != "y")
                keepRunning = false;

            Console.WriteLine(); // for spacing
        }

        Console.WriteLine("Thanks for using the calculator!");
    }
}