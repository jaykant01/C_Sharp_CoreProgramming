namespace ArLevel1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        Console.WriteLine("Enter the size of an Array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the age for {n} persons: ");
        Problem1 p1 = new Problem1();
        p1.Age(n);



        // Problem 2
        Console.WriteLine("Enter size of array and arrays");
        Problem2 p2 = new Problem2();
        p2.Compare();



        // Problem 3
        Console.WriteLine("Enter Table to Print & Enter range: ");
        Problem3 p3 = new Problem3();
        p3.Table();



        // Problem 4
        Console.WriteLine("Enter the array elem: ");
        Problem4 p4 = new Problem4();
        p4.Stop();



        // Problem 5
        Console.WriteLine("Enter Table no to print: ");
        Problem5 p5 = new Problem5();
        p5.Multiple();



        // Problem 6
        Console.WriteLine("Enter the height of players in array: ");
        Problem6 p6 = new Problem6();
        p6.Footbal();



        // Problem 7
        Console.WriteLine("Enter the number ");
        Problem7 p7 = new Problem7();
        p7.EvenOdd();



        // Problem 8
        Console.WriteLine("Enter the number: ");
        Problem8 p8 = new Problem8();
        p8.Factors();




        // Problem 9
        Console.WriteLine("Enter the  number: ");
        Problem9 p9 = new Problem9();
        p9.TwoDArray();



        // Problem 10
        Console.WriteLine("Enter the number: ");
        Problem10 p10 = new Problem10();
        p10.FizzBuzz();



        Console.ReadKey();
    }
}
