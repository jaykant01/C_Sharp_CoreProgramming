namespace ProblemSet3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Problem1 p1 = new Problem1();
        p1.Armstrong(number);


        // Problem 2
        Console.WriteLine("Enter the Num: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Problem2 p2 = new Problem2();
        p2.Counter(num);



        // Problem 3
        Console.WriteLine("Enter the n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Problem3 p3 = new Problem3();
        p3.HarshadNum(n);


        // Problem 4
        Console.WriteLine("Enter number no");
        int no = Convert.ToInt32(Console.ReadLine());

        Problem4 p4 = new Problem4();
        p4.AbundantNum(no);



        // Problem 5
        Console.WriteLine("Enter the day, month and year: ");

        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        Problem5 p5 = new Problem5();
        int result = p5.DayOfWeek(d, m, y);
        Console.WriteLine(result);


        // Problem 6
        Console.WriteLine("Enter first & second number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        string op = Console.ReadLine();

        Problem6 p6 = new Problem6();
        p6.Calculator(first, second, op);




        Console.ReadKey();
    }
}
