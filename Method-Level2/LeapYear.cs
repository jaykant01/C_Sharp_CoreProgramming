namespace Method_Level2;

public class LeapYear
{
    public bool CheckLeapYear(int year)
    {
        if(year <= 1582)
        {
            return false;
        }
        else
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
