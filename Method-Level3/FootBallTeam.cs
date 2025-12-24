namespace Method_Level3;
/* Create a program to find the shortest, tallest, and mean height of players present in a
football team.
 */
public class FootBallTeam
{
    public int SumElements(int[] height)
    {
        int sum = 0;
        for(int i=0; i<height.Length; i++)
        {
            sum += height[i];
        }

        return sum;
    }


    public double MeanElements(int[] height)
    {
        double mean = SumElements(height) / height.Length;

        Console.WriteLine("Mean of elements is " + mean);
        return mean;
    }


     public int SortestHeight(int[] height)
    {
        int shortest = int.MaxValue;
        for(int i=0; i<height.Length; i++)
        {
            if(shortest > height[i])
            {
                shortest = height[i];
            }
        }
        Console.WriteLine("Shortest elements is " + shortest);
        return shortest;
    }


    public int TallestHeight(int[] height)
    {
        int tall = int.MinValue;
        for (int i = 0; i < height.Length; i++)
        {
            if (tall < height[i])
            {
                tall = height[i];
            }
        }
        Console.WriteLine("Tallest elements is " + tall);
        return tall;
    }


}
