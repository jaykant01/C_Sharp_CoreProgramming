namespace Method_Level3;
/* Write a program to generate a six-digit OTP number using Math.Random() method.
Validate the numbers are unique by generating the OTP number 10 times and ensuring all
the 10 OTPs are not the same
 */
public class GenerateOTP
{
    public static int OTPGenerator()
    {
        Random rand = new Random();
        return rand.Next(100000, 1000000);
    }

    // Generate 10 OTPs and store in array
    public static int[] GenerateOTPs()
    {
        int[] otps = new int[10];

        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = OTPGenerator();
        }

        return otps;
    }

    // Check uniqueness of OTPs
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }
}
