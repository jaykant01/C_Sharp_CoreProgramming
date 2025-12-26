namespace BuiltIn;
/* Write a program that calculates the factorial of a number using a recursive function.
 */
public class FactorialRecursion
{
    public void Run()
    {
        int num = TakeInput();
        long result = Recursion(num);
        DisplayResult(num, result);
    }

    int TakeInput()
    {
        Console.Write("Enter a Number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    long Recursion(int num)
    {
        if(num == 0 || num == 1)
        {
            return 1;
        }

        return num * Recursion(num - 1);
    }

    void DisplayResult(int num, long result)
    {
        Console.WriteLine("Factorial of " + num + " is: " + result);
    }
}
