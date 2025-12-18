namespace Level2;

class Program
{
    static void Main(string[] args)
    {
        ////Problem 1
        Console.WriteLine("Enter num1 & num2: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Problem1 p1 = new Problem1();
        p1.Calculate(num1, num2);


        //Console.ReadKey();

        // Problem 2
        Console.WriteLine("Enter a, b & c: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Problem2 p2 = new Problem2();
        p2.Precedence(a, b, c);
    }
}
