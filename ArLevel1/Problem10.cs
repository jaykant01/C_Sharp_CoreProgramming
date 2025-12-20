namespace ArLevel1;

public class Problem10
{
    public void FizzBuzz()
    {
        int num = int.Parse(Console.ReadLine());
        string[] arr = new string[num+1];

        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
            for(int i = 1; i <= num; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    arr[i] = "FizzBuzz";
                }else if ( i % 5 == 0)
                {
                    arr[i] = "Buzz";
                }else if (i % 3 == 0)
                {
                    arr[i] = "Fizz";
                }
                else
                {
                arr[i] = i.ToString();
                }
            }
        

        for(int i=1; i <= num; i++)
        {
            Console.WriteLine($"Postion {i} = {arr[i]}");
        }
    }
}
