namespace AspNETProj.Utilities;

public static class Validation
{
    public static bool OtpValidation(string otp)
    {
        if (otp == "12345")
            return true;
        
        return false;
    }
}