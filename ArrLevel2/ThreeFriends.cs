namespace ArrLevel2;

public class ThreeFriends
{
    /*
     Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on
     their ages and the tallest among the friends based on their heights
    */
    public void Friends()
    {
        int n = 3;
        int[] age = new int[n];
        int[] height = new int[n];

        // Input of Age and Height
        for (int i=0;  i<n; i++)
        {
            age[i] = Convert.ToInt32(Console.ReadLine());
            height[i] = Convert.ToInt32(Console.ReadLine());
        }
         
        // Compare Age 
        if( age[0] < age[1] && age[0] < age[2])
        {
            Console.WriteLine("Amar is the Youngest");
        }else if (age[1] < age[0] && age[1] < age[2])
        {
            Console.WriteLine("Akbar is the Youngest");
        }
        else
        {
            Console.WriteLine("Anthony is the Youngest");
        }


        // Compare by Height
        if (height[0] > height[1] && height[0] > height[2])
        {
            Console.WriteLine("Amar is the Tallest");
        }
        else if (height[1] > height[0] && height[1] > height[2])
        {
            Console.WriteLine("Akbar is the Tallest");
        }
        else
        {
            Console.WriteLine("Anthony is the Tallest");
        }
    }
}
