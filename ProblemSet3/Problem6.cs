namespace ProblemSet3;

public class Problem6
{
    public void Calculator(double first, double second, string op)
    {
        switch (op)
        {
            case "+":
                Console.WriteLine("Result = " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result = " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result = " + (first * second));
                break;

            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result = " + (first / second));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
