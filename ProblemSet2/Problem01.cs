namespace ProblemSet2;

public class Problem01
{
    public void Grade(int phy, int chem, int maths)
    {
        int totalMarks = phy + chem + maths;
        int percent = totalMarks / 3;
        Console.WriteLine(percent);

        if (percent >=  80)
        {
            Console.WriteLine("Grade is A and average marks is " + totalMarks);
        }else if (percent<=79 && percent>=70){
            Console.WriteLine("Grade is B and average marks is " + totalMarks);
        }else if (percent<= 69 &&  percent>=60)
        {
            Console.WriteLine("Grade is C and average marks is " + totalMarks);
        }else if (percent<=59 && percent>= 50)
        {
            Console.WriteLine("Grade is D and average marks is " + totalMarks);
        }else if (percent<=49 && percent>= 40)
        {
            Console.WriteLine("Grade is E and average marks is " + totalMarks);
        }
        else
        {
            Console.WriteLine("Grade is R and average marks is " + totalMarks);
        }

    }
}
