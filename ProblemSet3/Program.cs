namespace ProblemSet3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //Console.WriteLine("Enter the number: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //Problem1 p1 = new Problem1();
        //p1.Armstrong(number);


        // Problem 2
        Console.WriteLine("Enter the Num: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Problem2 p2 = new Problem2();
        p2.Counter(num);



        Console.ReadKey();
    }
}
