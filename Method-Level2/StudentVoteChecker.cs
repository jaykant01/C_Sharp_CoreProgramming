namespace Method_Level2;
/*Write a program to take user input for the age of all 10 students in a class and check
whether the student can vote depending on his/her age is greater or equal to 18.
 */
public class StudentVoteChecker
{
    public bool CanStudentVote(int age)
    {
        // Validate negative age
        if (age < 0)
        {
            return false;
        }

        // Check voting eligibility
        if (age >= 18)
        {
            return true;
        }

        return false;
    }
}
