namespace ArLevel1;

public class Problem8
{
    public void Factors()
    {
        int num = int.Parse(Console.ReadLine());
        int maxFactor = 10;
        int[] arr = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= num; i++)
        {

            if (num % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor = maxFactor * 2;
                    int[] temp = new int[maxFactor];

                    for (int j = 0; j < arr.Length; j++)
                    {
                        temp[j] = arr[j];
                    }

                    arr = temp;
                }

                arr[index] = i;
                index++;
            }

        }

        string result = $"[{string.Join(", ", arr)}]";
        Console.WriteLine(result);
    }
}
