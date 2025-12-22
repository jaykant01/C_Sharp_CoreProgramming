namespace Method_Level1;

public class CheckNumber
{
    public int CheckSign(int num)
    {
        if (num > 0)
        {
            return 1;
        }    
        else if (num < 0)
        {
            return -1;
        }
        else
        {
            return 0;
        }     
    }
}
