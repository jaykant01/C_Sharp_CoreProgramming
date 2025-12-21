namespace ArrLevel2;

public class BMIOfPersons
{
    public void BmiCalc()
    {
        int n = int.Parse(Console.ReadLine());
        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for(int i=0; i<n; i++)
        {
            weight[i] = Convert.ToDouble(Console.ReadLine());
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        for(int i=0; i<n; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] <= 18.4)
            {
                status[i] = "Underweight";
            }else if (bmi[i] <= 24.9 && bmi[i] >= 18.5)
            {
                status[i] = "Normal";
            }else if (bmi[i] <= 39.9 && bmi[i] >= 25.0)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        // Print Weight Array
        for(int i=0; i<n; i++)
        {
            Console.Write($"{weight[i]}, ");

        }
        Console.WriteLine();

        // Print Height Array
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{height[i]}, ");

        }
        Console.WriteLine();

        // Print BMI Array
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{bmi[i]}, ");

        }
        Console.WriteLine();

        // Print Status Array
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{status[i]}, ");

        }
        Console.WriteLine();


    }
}
