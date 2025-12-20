namespace ArLevel1;

public class Problem3
{
    public void Table()
    {
        int t = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i=0; i<n; i++)
        {
            arr[i] = (i + 1) * t;
            Console.WriteLine($"{t} * {i + 1} = {arr[i]}");
        }
    }
}
