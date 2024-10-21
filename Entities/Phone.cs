
namespace AspNETProj.Entities;
public class Phone
{
    public int Id { get; private set; }
    public string Value { get; set; }
    public int CustomerId { get; private set; }
    public bool IsDeleted { get; set; }
    public Customer customer { get; private set;}
    public DateTime CreationDate { get; private set; }
    public Phone() {} // EF CORE
    public Phone(string phoneNumber, Customer customer)
    {
        if (string.IsNullOrEmpty(phoneNumber))
        {
            throw new Exception("phone number must have value");
        }

        Value = phoneNumber;
        CustomerId = customer.Id;
        this.customer = customer;
        IsDeleted = false;
        CreationDate = DateTime.Now;
    }
}
