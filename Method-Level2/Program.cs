namespace Method_Level2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 Factors
        //Console.WriteLine("Enter a number:");
        //int number = Convert.ToInt32(Console.ReadLine());

        //int[] factors = FindFactors.Factors(number);
        //// Print Factors
        //Console.WriteLine("Factors are:");
        //for (int i = 0; i < factors.Length; i++)
        //{
        //    Console.Write(factors[i] + " ");
        //}
        //Console.WriteLine();

        //int sum = FindFactors.FindSum(factors);
        //long product = FindFactors.FindProduct(factors);
        //double sumOfSquares = FindFactors.FindSumOfSquares(factors);

        //Console.WriteLine($"Sum of factors = {sum}");
        //Console.WriteLine($"Product of factors = {product}");
        //Console.WriteLine($"Sum of squares of factors = {sumOfSquares}");



        // Problem 2 Natural number using Recursion
        //Console.WriteLine("Enter number n: ");
        //int n = Convert.ToInt32(Console.ReadLine());

        //NaturalNoRecursive nat = new NaturalNoRecursive();
        //int res1 = nat.Formula(n);
        //int res2 = nat.Recursion(n);
        //Console.WriteLine("Natural no From Formula " +  res1);
        //Console.WriteLine("Natural no From Recursion " +  res1);

        //if(res1 == res2)
        //{
        //    Console.WriteLine("Both are Equal");
        //}


        // Problem 3 Leap Year
        //Console.WriteLine("Enter the year:");
        //int year = Convert.ToInt32(Console.ReadLine());

        //LeapYear lp = new LeapYear();
        //bool res = lp.CheckLeapYear(year);

        //if (res)
        //{
        //    Console.WriteLine("It is a Leap year");
        //}
        //else
        //{
        //    Console.WriteLine("Not a Leap Year");
        //}


        // Problem 4 Unit Convertor
        //Console.WriteLine("Enter the km, miles, meter, feet");
        //double km = Convert.ToDouble(Console.ReadLine());
        //double miles = Convert.ToDouble(Console.ReadLine());
        //double meters = Convert.ToDouble(Console.ReadLine());
        //double feet = Convert.ToDouble(Console.ReadLine());

        //double res1 = UnitConvertor.KmToMiles(km);
        //double res2 = UnitConvertor.MilesTokm(miles);
        //double res3 = UnitConvertor.MetersToFeet(meters);
        //double res4 = UnitConvertor.FeetTometers(feet);

        //Console.WriteLine("Convert KmToMiles " + res1);
        //Console.WriteLine("Convert MilesTokm " + res2);
        //Console.WriteLine("Convert MetersToFeet " + res3);
        //Console.WriteLine("Convert FeetTometers " + res4);


        // Problem 5 
        //Console.WriteLine("Enter the yards, feet, meter, inches: ");
        //double yards = Convert.ToDouble(Console.ReadLine());
        //double feet = Convert.ToDouble(Console.ReadLine());
        //double meters = Convert.ToDouble(Console.ReadLine());
        //double inches = Convert.ToDouble(Console.ReadLine());

        //NonStaticUnitConvertor ns = new NonStaticUnitConvertor();
        //double res1 = ns.ConvertYardsToFeet(yards);
        //double res2 = ns.ConvertFeetToYards(feet);
        //double res3 = ns.ConvertMetersToInches(meters);
        //double res4 = ns.ConvertInchesToMeter(inches);
        //double res5 = ns.ConvertInchesCentiMeters(inches);

        //Console.WriteLine("Convert yards2feet " + res1);
        //Console.WriteLine("Convert feet2yards " + res2);
        //Console.WriteLine("Convert meters2inches " + res3);
        //Console.WriteLine("Convert inches2meters " + res4);
        //Console.WriteLine("Convert inches2cm " + res5);



        // Problem 6 Unit Convertor Static Method
        //Console.WriteLine("Enter Farhen, Celsius, Pounds, Kg, Gallons, Liters");
        //double farhen = Convert.ToDouble(Console.ReadLine());
        //double celsius = Convert.ToDouble(Console.ReadLine());
        //double pounds = Convert.ToDouble(Console.ReadLine());
        //double kg = Convert.ToDouble(Console.ReadLine());
        //double gallons = Convert.ToDouble(Console.ReadLine());
        //double liters = Convert.ToDouble(Console.ReadLine());


        //double res1 = StaticMethodUnitConvertor.convertFarhenheitToCelsius(farhen);
        //double res2 = StaticMethodUnitConvertor.convertCelsiusToFarhenheit(celsius);
        //double res3 = StaticMethodUnitConvertor.convertPoundsToKg(pounds);
        //double res4 = StaticMethodUnitConvertor.convertKgToPounds(kg);
        //double res5 = StaticMethodUnitConvertor.convertGallonsToLiters(gallons);
        //double res6 = StaticMethodUnitConvertor.convertLitersToGallons(liters);

        //Console.WriteLine("Convert convert Farhenheit To Celsius " + res1);
        //Console.WriteLine("Convert convert Celsius To Farhenheit " + res2);
        //Console.WriteLine("Convert convert Pounds To Kg " + res3);
        //Console.WriteLine("Convert convert Kg To Pounds " + res4);
        //Console.WriteLine("Convert convert Gallons To Liters " + res5);
        //Console.WriteLine("Convert convert Liters To Gallons " + res6);



        // Problem 7 StudentVoteChecker
        //int[] studentAges = new int[10];
        //StudentVoteChecker checker = new StudentVoteChecker();

        //for (int i = 0; i < studentAges.Length; i++)
        //{
        //    Console.Write($"Enter age of student {i + 1}: ");
        //    studentAges[i] = Convert.ToInt32(Console.ReadLine());

        //    bool canVote = checker.CanStudentVote(studentAges[i]);

        //    if (canVote)
        //    {
        //        Console.WriteLine("Student can vote");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student cannot vote");
        //    }
        //}




        // Problem 8 Friend Analyzer
        string[] friends = { "Amar", "Akbar", "Anthony" };

        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking input
        for (int i = 0; i < friends.Length; i++)
        {
            Console.Write($"Enter age of {friends[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of {friends[i]} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        FriendAnalyzer analyzer = new FriendAnalyzer();

        int youngestIndex = analyzer.FindYoungestIndex(ages);
        int tallestIndex = analyzer.FindTallestIndex(heights);

        // Display results
        Console.WriteLine($"\nYoungest Friend: {friends[youngestIndex]}");
        Console.WriteLine($"Tallest Friend: {friends[tallestIndex]}");

        Console.ReadKey();
    }
}
