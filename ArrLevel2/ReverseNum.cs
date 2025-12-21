namespace ArrLevel2;

public class ReverseNum
{
    public void Reverse()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i=0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int st = 0;
        int end = n - 1;

        while (st <= end)
        {
            int temp = arr[st];
            arr[st] = arr[end];
            arr[end] = temp;
            st++;
            end--;
        }

        for(int i=0; i<n; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
    }

}
