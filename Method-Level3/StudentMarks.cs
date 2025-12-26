namespace Method_Level3;
/* Write a method to generate random 2-digit scores for Physics, Chemistry, and Math
(PCM) for the students and return the scores. This method returns a 2D array with PCM
scores for all students
 */
public class StudentMarks
{
    public static double[,] GeneratePCMMarks(int students)
    {
        Random rnd = new Random();
        double[,] marks = new double[students, 3]; 

        for (int i = 0; i < students; i++)
        {
            marks[i, 0] = rnd.Next(10, 100); 
            marks[i, 1] = rnd.Next(10, 100); 
            marks[i, 2] = rnd.Next(10, 100); 
        }
        return marks;
    }

    // Calculate Total, Average, Percentage
    public static double[,] CalculateResults(double[,] marks)
    {
        int students = marks.GetLength(0);
        double[,] result = new double[students, 3]; 

        for (int i = 0; i < students; i++)
        {
            double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            result[i, 0] = Math.Round(total, 2);
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }
        return result;
    }

    // Display scorecard in tabular format
    public static void DisplayScoreCard(double[,] marks, double[,] result)
    {
        int students = marks.GetLength(0);

        Console.WriteLine("Stu\tPhy\tChem\tMath\tTotal\tAvg\t%\n");

        for (int i = 0; i < students; i++)
        {
            Console.WriteLine((i + 1) + "\t" + marks[i, 0] + 
                "\t" + marks[i, 1] + "\t" + marks[i, 2] + "\t" + 
                result[i, 0] + "\t" + result[i, 1] + "\t" + result[i, 2]
            );
        }
    }
}
