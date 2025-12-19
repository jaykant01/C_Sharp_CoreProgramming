namespace ProblemSet1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //Console.Write("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //Problem1 c1 = new Problem1();
        //c1.CheckDivisible(number);


        // Problem 2
        //Console.WriteLine("Enter number a, b & c: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());

        //Problem2 p2 = new Problem2();
        //p2.Smallest(a, b, c);


        // Problem 3
        //Console.WriteLine("Enter number x, y & z: ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //int y = Convert.ToInt32(Console.ReadLine());
        //int z = Convert.ToInt32(Console.ReadLine());

        //Problem3 p3 = new Problem3();
        //p3.Largest(x, y, z);


        // Problem 4
        //Console.WriteLine("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //Problem4 p4 = new Problem4();
        //p4.Natural(num);

        // Problem 5
        //Console.WriteLine("Enter the age: ");
        //int age = Convert.ToInt16((string)Console.ReadLine());

        //Problem5 p5 = new Problem5();
        //p5.Vote(age);

        // Problem 6
        //Console.WriteLine("Enter number m: ");
        //int m = Convert.ToInt32(Console.ReadLine());

        //Problem6 p6 = new Problem6();
        //p6.CheckNumber(m);


        // Problem 7
        Console.WriteLine("Enter Month and day");
        int month = Convert.ToInt16(Console.ReadLine());
        int day = Convert.ToInt16(Console.ReadLine());

        Problem7 p7 = new Problem7();
        p7.Season(month, day);


        Console.ReadKey();
    }
}

