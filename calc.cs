Copy code
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                Console.WriteLine("Enter the first number:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter the second number:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Choose an operation (+, -, *, /):");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose a valid operation.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string answer = Console.ReadLine().ToLower();
                if (answer != "yes")
                    break;
            }
        }
    }
}
