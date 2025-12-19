namespace ProblemSet1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Problem1 c1 = new Problem1();
        c1.CheckDivisible(number);


        // Problem 2
        Console.WriteLine("Enter number a, b & c: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Problem2 p2 = new Problem2();
        p2.Smallest(a, b, c);


        // Problem 3
        Console.WriteLine("Enter number x, y & z: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        Problem3 p3 = new Problem3();
        p3.Largest(x, y, z);


        // Problem 4
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Problem4 p4 = new Problem4();
        p4.Natural(num);

        // Problem 5
        Console.WriteLine("Enter the age: ");
        int age = Convert.ToInt16((string)Console.ReadLine());

        Problem5 p5 = new Problem5();
        p5.Vote(age);

        // Problem 6
        Console.WriteLine("Enter number m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Problem6 p6 = new Problem6();
        p6.CheckNumber(m);


        // Problem 7
        Console.WriteLine("Enter Month and day");
        int month = Convert.ToInt16(Console.ReadLine());
        int day = Convert.ToInt16(Console.ReadLine());

        Problem7 p7 = new Problem7();
        p7.Season(month, day);


        // Problem 8
        Console.WriteLine("Enter Count Down Number o: ");
        int o = Convert.ToInt32(Console.ReadLine());

        Problem8 p8 = new Problem8();
        p8.CountDown(o);

        // Problem 9
        Console.WriteLine("Enter counter: ");
        int p = Convert.ToInt32(Console.ReadLine());

        Problem9 p9 = new Problem9();
        p9.Counter(p);

        // Problem 10
        Console.WriteLine("Enter the val: ");
        double val = Convert.ToDouble(Console.ReadLine());

        Problem10 p10 = new Problem10();
        p10.Total(val);

        // Problem 11
        Console.WriteLine("Enter the value: ");
        double value = Convert.ToDouble(Console.ReadLine());

        Problem11 p11 = new Problem11();
        p11.TotalNew(value);

        // Problem 12
        Console.WriteLine("Enter number a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Problem12 p12 = new Problem12();
        p12.NatCompare(a);

        // Problem 13
        Console.WriteLine("Enter number a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Problem13 p13 = new Problem13();
        p13.NatCompareNew(a);


        // Problem 14
        Console.WriteLine("Enter the number num: ");
         num = int.Parse(Console.ReadLine());

        Problem14 p14 = new Problem14();
        p14.Fact(num);


        // PRoblem 15
        Console.WriteLine("Enter the number : ");
        num = int.Parse(Console.ReadLine());

        Problem15 p15 = new Problem15();
        p15.Fact(num);


        // Problem 16
        Console.WriteLine("Enter the number : ");
        num = int.Parse(Console.ReadLine());

        Problem16 p16 = new Problem16();
        p16.OddEven(num);


        // Problem 17
        Console.WriteLine("Enter Salary and year of service: ");
        int salary = int.Parse(Console.ReadLine());
        int bonus = int.Parse(Console.ReadLine());

        Problem17 p17 = new Problem17();
        p17.Bonus(salary, bonus);


        // Problem 18
        Console.WriteLine("Enter the Table number: ");
         num = int.Parse(Console.ReadLine());

        Problem18 p18 = new Problem18();
        p18.Table(num);

        Console.ReadKey();
    }
}

