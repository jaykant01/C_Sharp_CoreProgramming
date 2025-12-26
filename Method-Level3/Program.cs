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
        //int n = Convert.ToInt32(Console.ReadLine());
        //int res = NumberChecker2.CountDigit(n);
        //int[] res1 = NumberChecker2.StoreDigit(n);
        //bool res2 = NumberChecker2.Palindrome(n);

        //Console.WriteLine("Count of digit is " + res);

        //Console.Write("Digits: ");
        //foreach (int d in res1)
        //{
        //    Console.Write(d + " ");
        //}
        //Console.WriteLine();

        //Console.WriteLine("Plaindrome Number " + res2);



        // Problem 5
        //int n = int.Parse(Console.ReadLine());

        //bool res = NumberChecker3.IsPrime(n);
        //bool res1 = NumberChecker3.IsNeon(n);
        //bool res2 = NumberChecker3.IsSpy(n);
        //bool res3 = NumberChecker3.IsAutomorphic(n);
        //bool res4 = NumberChecker3.IsBuzz(n);

        //Console.WriteLine(res ? "Prime Number" : "Not a Prime Number");
        //Console.WriteLine(res1 ? "Neon Number" : "Not a Neon Number");
        //Console.WriteLine(res2 ? "Spy Number" : "Not a Spy Number");
        //Console.WriteLine(res3 ? "Automorphic Number" : "Not an Automorphic Number");
        //Console.WriteLine(res4 ? "Buzz Number" : "Not a Buzz Number");



        // Problem 6
        //int n = int.Parse(Console.ReadLine());

        //int[] factors = NumberChecker4.GetFactors(n);

        //NumberChecker4.PrintGreatestFactor(factors);
        //NumberChecker4.PrintSumOfFactors(factors);
        //NumberChecker4.PrintProductOfFactors(factors);
        //NumberChecker4.PrintProductOfCubeOfFactors(factors);

        //NumberChecker4.PrintPerfect(n, factors);
        //NumberChecker4.PrintAbundant(n, factors);
        //NumberChecker4.PrintDeficient(n, factors);
        //NumberChecker4.PrintStrong(n);


        // Problem 7
        int[] otps = GenerateOTP.GenerateOTPs();

        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        bool result = GenerateOTP.AreOTPsUnique(otps);

        Console.WriteLine(result? "All OTPs are unique": "Duplicate OTPs found");
    


    Console.ReadKey();
    }
}
