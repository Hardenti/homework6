using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("===== My Program =====");
            Console.WriteLine();
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Display Message");
            Console.WriteLine("4. Exit");
            Console.WriteLine("5. Multiply");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            string? choiceInput = Console.ReadLine();

            if (!int.TryParse(choiceInput, out int choice))
            {
                Console.WriteLine("Invalid menu choice.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Enter first number: ");
                    string? firstInput = Console.ReadLine();

                    Console.Write("Enter second number: ");
                    string? secondInput = Console.ReadLine();

                    if (double.TryParse(firstInput, out double firstNumber) &&
                        double.TryParse(secondInput, out double secondNumber))
                    {
                        double result = firstNumber + secondNumber;
                        Console.WriteLine();
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number entered.");
                    }
                    break;

                case 2:
                    Console.WriteLine();
                    Console.Write("Enter first number: ");
                    string? subFirstInput = Console.ReadLine();

                    Console.Write("Enter second number: ");
                    string? subSecondInput = Console.ReadLine();

                    if (double.TryParse(subFirstInput, out double subFirstNumber) &&
                        double.TryParse(subSecondInput, out double subSecondNumber))
                    {
                        double result = subFirstNumber - subSecondNumber;
                        Console.WriteLine();
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number entered.");
                    }
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Welcome! This is a custom message from the menu program.");
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                case 5:
                    Console.WriteLine();
                    Console.Write("Enter first number: ");
                    string? mulFirstInput = Console.ReadLine();

                    Console.Write("Enter second number: ");
                    string? mulSecondInput = Console.ReadLine();

                    if (double.TryParse(mulFirstInput, out double mulFirstNumber) &&
                        double.TryParse(mulSecondInput, out double mulSecondNumber))
                    {
                        double result = mulFirstNumber * mulSecondNumber;
                        Console.WriteLine();
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number entered.");
                    }
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid menu choice.");
                    break;
            }
        }
    }
}
