namespace AspNETProj.Utilities;

public static class Validation
{
    public static bool OtpValidation(string otp)
    {
        if (otp == "12345")
            return true;
        
        return false;
    }

    public static bool PhoneValidation(string phoneNumber)
    {
        if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 11 && phoneNumber.StartsWith("09"))
        {
            return true;
        }
        return false;

    }
}