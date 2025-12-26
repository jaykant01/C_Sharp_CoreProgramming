namespace BuiltIn;
/* Write a program that performs basic mathematical operations (addition, subtraction,
multiplication, division) based on user input.
 */
public class Calculator
{
    public void Run()
    {
        double num1 = TakeInput("Enter first number: ");
        double num2 = TakeInput("Enter second number: ");

        Console.WriteLine("\nChoose Operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter choice (1-4): ");

        int choice = int.Parse(Console.ReadLine());

        double result = 0;

        if (choice == 1)
            result = Add(num1, num2);
        else if (choice == 2)
            result = Subtract(num1, num2);
        else if (choice == 3)
            result = Multiply(num1, num2);
        else if (choice == 4)
            result = Divide(num1, num2);
        else
            Console.WriteLine("Invalid choice!");

        Console.WriteLine("Result: " + result);
    }

    double TakeInput(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine());
    }

    double Add(double a, double b)
    {
        return a + b;
    }

    double Subtract(double a, double b)
    {
        return a - b;
    }

    double Multiply(double a, double b)
    {
        return a * b;
    }

    double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }
}
