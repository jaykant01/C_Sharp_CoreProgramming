using System.Security.AccessControl;

namespace BuiltIn;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //Console.WriteLine("Think of a number between 1 and 100.");
        //Console.WriteLine("Give feedback:");
        //Console.WriteLine("H = Too High, L = Too Low, C = Correct\n");

        //GuessingGame game = new GuessingGame();
        //game.PlayGame();



        // Problem 2
        //MaxThreeNumbers mx = new MaxThreeNumbers();
        //mx.FindMaximum();


        // Problem 3
        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());

        //PrimeNumber checker = new PrimeNumber();
        //bool isPrime = checker.CheckPrime(number);

        //if (isPrime)
        //    Console.WriteLine("The number is Prime.");
        //else
        //    Console.WriteLine("The number is NOT Prime.");



        // Problem 4
        //Console.Write("Enter number of terms: ");
        //int terms = int.Parse(Console.ReadLine());

        //FibonacciSequence fib = new FibonacciSequence();
        //fib.GenerateFibonacci(terms);


        // Problem 5
        //PalindromeChecker checker = new PalindromeChecker();
        //checker.Run();


        // Problem 6
        //FactorialRecursion fact = new FactorialRecursion();
        //fact.Run();



        // Problem 7
        //GcdLcmCalculator calculator = new GcdLcmCalculator();
        //calculator.Run();


        // Problem 8
        //TemperatureConverter converter = new TemperatureConverter();
        //converter.Run();


        // Problem 9
        Calculator calc = new Calculator();
        calc.Run();

        Console.ReadKey();
    }
}
