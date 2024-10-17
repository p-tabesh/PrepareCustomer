using System.Text.Json.Serialization;

namespace AspNETProj.Utilities
{
    public class RedisOtpTest
    {
        [JsonPropertyName("phone")]
        public string Phone {  get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("expireDate")]
        public DateTime ExpireDate { get; set; }
        [JsonPropertyName("isUsed")]
        public bool IsUsed { get; set; }
    }

    public class OtpResult
    {
        public IEnumerable<RedisOtpTest> Otp { get; }
        public OtpResult(IEnumerable<RedisOtpTest> otp)
        {
            Otp = otp;
        }
    }
}
