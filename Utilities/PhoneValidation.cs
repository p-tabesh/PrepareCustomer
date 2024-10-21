namespace AspNETProj.Utilities
{
    public static class PhoneValidation
    {
        public static bool IsValid(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 11 || !phoneNumber.StartsWith("09"))
                return false;
            return true;
        }
    }
}
