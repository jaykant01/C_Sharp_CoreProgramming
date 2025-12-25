namespace Method_Level3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] height = new int[n];

        //for(int i=0; i<n; i++)
        //{
        //    height[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //FootBallTeam fb = new FootBallTeam();
        //int sum = fb.SumElements(height);
        //Console.WriteLine("Sum of all elements is " + sum);
        //fb.MeanElements(height);
        //fb.SortestHeight(height);
        //fb.TallestHeight(height);



        // Problem 2
        //int n = Convert.ToInt32(Console.ReadLine());
        //NumberChecker nm = new NumberChecker();
        //Console.WriteLine("Count of digit is " + nm.CountDigit(n));

        //Console.WriteLine("DuckNumber is " + nm.DuckNumber(n));
        //Console.WriteLine("Armstrong Number is " + nm.ArmstrongNumber(n));
        //nm.LargestNumber(n);
        //nm.SmallestNumber(n);


        // Problem 3
        //int n = Convert.ToInt32(Console.ReadLine());
        //NumberChecker1 n1 = new NumberChecker1();
        //Console.WriteLine("Count of digit is " + n1.CountDigit(n));
        //Console.WriteLine("Sum of digit is " + n1.SumNumber(n));
        //Console.WriteLine("Sum of Square is " + n1.SumSquare(n));
        //Console.WriteLine("Is it a Harshad Number " + n1.HarshadNumber(n));


        // Problem 4
        int n = Convert.ToInt32(Console.ReadLine());
        int res = NumberChecker2.CountDigit(n);
        int[] res1 = NumberChecker2.StoreDigit(n);
        bool res2 = NumberChecker2.Palindrome(n);

        Console.WriteLine("Count of digit is " + res);

        Console.Write("Digits: ");
        foreach (int d in res1)
        {
            Console.Write(d + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Plaindrome Number " + res2);


        Console.ReadKey();
    }
}
