namespace Method_Level3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 
        int n = Convert.ToInt32(Console.ReadLine());
        int[] height = new int[n];

        for(int i=0; i<n; i++)
        {
            height[i] = Convert.ToInt32(Console.ReadLine());
        }

        FootBallTeam fb = new FootBallTeam();
        int sum = fb.SumElements(height);
        Console.WriteLine("Sum of all elements is " + sum);
        fb.MeanElements(height);
        fb.SortestHeight(height);
        fb.TallestHeight(height);


        Console.ReadKey();
    }
}
