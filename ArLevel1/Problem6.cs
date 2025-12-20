namespace ArLevel1;

public class Problem6
{
    public void Footbal()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int totalHg = 0;
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            totalHg += arr[i];
        }

        int mean = totalHg / n;
        Console.WriteLine("The Mean of Height is " + mean);
    }
}
