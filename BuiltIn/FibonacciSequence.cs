namespace BuiltIn;

public class FibonacciSequence
{
    public void GenerateFibonacci(int n)
    {
        int first = 0, second = 1;

        if (n <= 0)
            return;

        Console.Write(first);

        for (int i = 1; i < n; i++)
        {
            Console.Write(" " + second);

            int next = first + second;
            first = second;
            second = next;
        }
    }
}
