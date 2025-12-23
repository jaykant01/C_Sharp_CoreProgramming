namespace Method_Level2;
/* Create a program to find the youngest friends among 3 Amar, Akbar and Anthony
based on their ages and tallest among the friends based on their heights and display it
 */
public class FriendAnalyzer
{
    // Method to find the youngest friend
    public int FindYoungestIndex(int[] ages)
    {
        int youngestIndex = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        return youngestIndex;
    }

    // Method to find the tallest friend
    public int FindTallestIndex(double[] heights)
    {
        int tallestIndex = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        return tallestIndex;
    }
}
