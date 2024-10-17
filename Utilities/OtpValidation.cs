namespace AspNETProj.Utilities;

public class OtpValidation
{
    public static bool IsValid(string otp)
    {
        if (otp == "12345")
            return true;
        
        return false;
    }
}