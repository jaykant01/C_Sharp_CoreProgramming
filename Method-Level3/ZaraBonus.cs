namespace Method_Level3;
/* Create a program to find the bonus of 10 employees based on their years of service
as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus,
along with the old and new salary.
 */
public class ZaraBonus
{
    public static double[,] GenerateEmployeeData()
    {
        Random rnd = new Random();
        double[,] data = new double[10, 2];

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rnd.Next(10000, 99999); 
            data[i, 1] = rnd.Next(1, 11);        
        }
        return data;
    }

    // Calculate new salary & bonus (2D Array)
    public static double[,] CalculateBonus(double[,] data)
    {
        double[,] result = new double[10, 2]; 

        for (int i = 0; i < 10; i++)
        {
            double salary = data[i, 0];
            double years = data[i, 1];

            double bonusRate = years > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            result[i, 0] = newSalary;
            result[i, 1] = bonus;
        }
        return result;
    }

    // Display table & totals
    public static void DisplayReport(double[,] oldData, double[,] newData)
    {
        double totalOld = 0, totalNew = 0, totalBonus = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

        for (int i = 0; i < 10; i++)
        {
            double oldSalary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus = newData[i, 1];
            double newSalary = newData[i, 0];

            totalOld += oldSalary;
            totalBonus += bonus;
            totalNew += newSalary;

            Console.WriteLine(
                (i + 1) + "\t" + oldSalary + "\t\t" + years + "\t" + bonus + "\t\t" + newSalary
            );
        }

        Console.WriteLine("Total Old Salary : " + totalOld);
        Console.WriteLine("Total Bonus      : " + totalBonus);
        Console.WriteLine("Total New Salary : " + totalNew);
    }
}
