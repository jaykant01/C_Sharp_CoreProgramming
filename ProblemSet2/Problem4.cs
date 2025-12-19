namespace ProblemSet2;

public class Problem4
{
    public void BMI(double weight, double height)
    {
        height = height / 100;
        double bmi = weight / (height * height);

        Console.WriteLine("BMI is " + bmi);

        if (bmi <= 18.4)
        {
            Console.WriteLine("UnderWeight");
        }else if (bmi <= 24.9 && bmi >= 18.5)
        {
            Console.WriteLine("Normal");
        }else if (bmi <= 39.9 && bmi >= 25.0)
        {
            Console.WriteLine("OverWeight");
        }else
        {
            Console.WriteLine("Obese");
        }
    }
}
