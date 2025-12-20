namespace ArLevel1;

public class Problem5
{
    public void Multiple()
    {
        int t = int.Parse(Console.ReadLine());
        int[] arr = new int[4];

        for (int i = 0; i < 4; i++)
        {
            arr[i] = (i + 6) * t;
            Console.WriteLine($"{t} * {i + 6} = {arr[i]}");
        }
    }
}
