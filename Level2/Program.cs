namespace Level2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //Console.WriteLine("Enter num1 & num2: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //Problem1 p1 = new Problem1();
        //p1.Calculate(num1, num2);


        // Problem 2
        //Console.WriteLine("Enter a, b & c: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());

        //Problem2 p2 = new Problem2();
        //p2.Precedence(a, b, c);


        // Problem 3
        //Console.WriteLine("Enter x, y & z");
        //double x = Convert.ToDouble(Console.ReadLine());
        //double y = Convert.ToDouble(Console.ReadLine());
        //double z = Convert.ToDouble(Console.ReadLine());

        //Problem3 p3 = new Problem3();
        //p3.DoubleOpt(x, y, z);


        // Problem 4
        //Console.WriteLine("Enter Temperature: ");
        //double celsius = Convert.ToDouble(Console.ReadLine());

        //Problem4 p4 = new Problem4();
        //p4.CelciusToFahr(celsius);


        // Problem 5
        //Console.WriteLine("Enter Temperature: ");
        //double fahre = Convert.ToDouble(Console.ReadLine());

        //Problem5 p5 = new Problem5();
        //p5.FahrToCelsius(fahre);


        // Problem 6
        //Console.WriteLine("Enter your salary & Bonus: ");
        //int salary = Convert.ToInt32(Console.ReadLine());
        //int bonus = Convert.ToInt32(Console.ReadLine());

        //Problem6 p6 = new Problem6();
        //p6.TotalIncome(salary, bonus);


        // Problem 7 
        //Console.WriteLine("Enter num1 & num2: ");

        //Problem7 p7 = new Problem7();
        //p7.Swap(num1, num2);


        // Problem 8
        //Console.WriteLine("Enter name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity & timeTaken");
        //string name = Console.ReadLine();
        //string fromCity = Console.ReadLine();
        //string viaCity = Console.ReadLine();
        //string toCity = Console.ReadLine();

        //double fromToVia = Convert.ToDouble(Console.ReadLine());
        //double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        //double timeTaken = Convert.ToDouble(Console.ReadLine());

        //Problem8 p8 = new Problem8();
        //p8.DisplayTripResult(name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken);


        // Problem 9
        //Console.WriteLine("Enter side1 , side2 & side3: ");
        //int side1 = Convert.ToInt32(Console.ReadLine());
        //int side2 = Convert.ToInt32(Console.ReadLine());
        //int side3 = Convert.ToInt32(Console.ReadLine());

        //Problem9 p9 = new Problem9();
        //p9.TrinagularPark(side1, side2, side3);


        // Problem 10
        //Console.WriteLine("Enter noOfChocolates & noOfChildren: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int m = Convert.ToInt32(Console.ReadLine());

        //Problem10 p10 = new Problem10();
        //p10.Chocolates(n, m);


        //Problem 11
        Console.WriteLine("Enter the principal, Raate & Interest: ");
        int principal = Convert.ToInt32(Console.ReadLine());
        int rate = Convert.ToInt32(Console.ReadLine());
        int time = Convert.ToInt32(Console.ReadLine());

        Problem11 p11 = new Problem11();
        p11.SPInterest(principal, rate, time);

        Console.ReadKey();
    }
}
