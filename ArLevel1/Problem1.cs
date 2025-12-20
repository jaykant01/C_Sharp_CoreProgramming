namespace ArLevel1;

public class Problem1
{
    public void Age(int n)
    {
        
        int[] age = new int[n];

        for (int i=0; i<n; i++)
        {
            age[i] = Convert.ToInt32(Console.ReadLine());

            if (age[i] >= 18)
            {
                Console.WriteLine($"The student with the age {age[i]} can vote");
                
            }else
            {
                Console.WriteLine($"The student with the age {age[i]} cannot vote");
            }
        }
        // To Print the Array of Age
        string result = $"[{string.Join(", ", age)}]";
        Console.WriteLine(result);
    }
}
