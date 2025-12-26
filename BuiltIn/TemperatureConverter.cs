namespace BuiltIn;
/* Write a program that converts temperatures between Fahrenheit and Celsius.
 * */
public class TemperatureConverter
{
    public void Run()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Choose an option (1 or 2): ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double celsius = TakeInput("Enter temperature in Celsius: ");
            double fahrenheit = CelsiusToFahrenheit(celsius);
            DisplayResult(celsius + " °C = " + fahrenheit + " °F");
        }
        else if (choice == 2)
        {
            double fahrenheit = TakeInput("Enter temperature in Fahrenheit: ");
            double celsius = FahrenheitToCelsius(fahrenheit);
            DisplayResult(fahrenheit + " °F = " + celsius + " °C");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }


    double TakeInput(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine());
    }

    double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }


    double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    void DisplayResult(string message)
    {
        Console.WriteLine("Result: " + message);
    }
}
