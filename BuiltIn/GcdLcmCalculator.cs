namespace BuiltIn;

public class GcdLcmCalculator
{
    public void Run()
    {
        int a = TakeInput("Enter first number: ");
        int b = TakeInput("Enter second number: ");

        int gcd = CalculateGCD(a, b);
        int lcm = CalculateLCM(a, b, gcd);

        DisplayResult(a, b, gcd, lcm);
    }

    int TakeInput(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    int CalculateGCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    int CalculateLCM(int x, int y, int gcd)
    {
        return (x * y) / gcd;
    }

    void DisplayResult(int a, int b, int gcd, int lcm)
    {
        Console.WriteLine("\nGCD of " + a + " and " + b + " is: " + gcd);
        Console.WriteLine("LCM of " + a + " and " + b + " is: " + lcm);
    }
}
