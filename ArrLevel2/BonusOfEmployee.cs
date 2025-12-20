namespace ArrLevel2;

public class BonusOfEmployee
{
    /* Create a program to find the bonus of 10 employees based on their years of service and the
       total bonus amount the company Zara has to pay, along with the old and new salary. */

    public void Bonus()
    {
        int n = int.Parse(Console.ReadLine());
        double[] salary = new double[n];
        double[] year = new double[n];
        double[] newSalary = new double[n];
        double[] bonus = new double[n];
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Old Salary and Year input and Total Old Salary
        for (int i = 0; i < n; i++)
        {
            salary[i] = Convert.ToDouble(Console.ReadLine());
            year[i] = Convert.ToDouble(Console.ReadLine());
            totalOldSalary += salary[i];

        }

        // Bonus and New Salary
        for (int i = 0; i < n; i++)
        {
            if (year[i] > 5)
            {
                bonus[i] = salary[i] * 5 / 100;
                newSalary[i] = salary[i] + bonus[i];
            }
            else
            {
                bonus[i] = salary[i] * 2 / 100;
                newSalary[i] = salary[i] + bonus[i];
            }
        }

        // Total New Salary
        for (int i = 0; i < n; i++)
        {
            totalNewSalary += newSalary[i];
        }

        // Print Old Salary Array
        Console.WriteLine("Old Salary Array is");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{salary[i]}, ");
        }
        Console.WriteLine();
        Console.WriteLine("Total Old Salary is " + totalOldSalary);

        // Print Year Array
        Console.WriteLine("year Array is");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{year[i]}, ");
        }
        Console.WriteLine();

        // Print Bonus Amount Array
        Console.WriteLine("Bonus Amount Array is");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{bonus[i]}, ");
        }
        Console.WriteLine();

        // Print New Salary Array
        Console.WriteLine("New Salary Array is");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{newSalary[i]}, ");
        }
        Console.WriteLine();
        Console.WriteLine("Total New Salary is " + totalNewSalary);

    }
}
