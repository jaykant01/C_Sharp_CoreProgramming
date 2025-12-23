namespace Method_Level2;
/* An organization took up the exercise to find the Body Mass Index (BMI) of all the
persons in the team of 10 members. For this create a program to find the BMI and display
the height, weight, BMI and status of each individual
 */
public class BMICalculator
{
    public void Calculator(double[,] arr)
    {
        for(int i=0; i<10; i++)
        {
            double height = arr[i, 1] / 100;
            // bmi calculation
            arr[i, 2] = arr[i, 0] / (height * height);
        }
        
    }

    public string[] GetBMIStatus(double[,] arr)
    {
        string[] status = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = arr[i, 2];

            if (bmi < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi < 25)
            {
                status[i] = "Normal";
            }
            else if (bmi < 30)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        return status;
    }
}
