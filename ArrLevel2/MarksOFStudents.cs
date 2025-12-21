namespace ArrLevel2;

public class MarksOFStudents
{
    public void Marks()
    {
        int n = int.Parse(Console.ReadLine());
        int[] phy = new int[n];
        int[] chem = new int[n];
        int[] math = new int[n];
        int[] percent = new int[n];
        string[] grade = new string[n];
        
        for(int i=0; i<n; i++)
        {
            phy[i] = Convert.ToInt32(Console.ReadLine());
            chem[i] = Convert.ToInt32(Console.ReadLine());
            math[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i=0; i<n; i++)
        {
            int total = phy[i] + chem[i] + math[i];
            percent[i] = total / 3;

            if (percent[i] >= 80)
            {
                grade[i] = "A";
            }else if (percent[i] < 79 && percent[i] > 70)
            {
                grade[i] = "B";
            }
            else if (percent[i] < 69 && percent[i] > 60)
            {
                grade[i] = "C";
            }
            else if (percent[i] < 59 && percent[i] > 50)
            {
                grade[i] = "D";
            }
            else if (percent[i] < 49 && percent[i] > 40)
            {
                grade[i] = "E";
            }
            else
            {
                grade[i] = "R";
            }
        }

        // Print Percentage Marks
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{percent[i]}, ");

        }
        Console.WriteLine();

        // Print Grade Array
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{grade[i]}, ");

        }
        Console.WriteLine();
    }
}
