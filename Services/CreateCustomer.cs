using AspNETProj.Entities;
using AspNETProj.Models;
using AspNETProj.Repositories;
using AspNETProj.Utilities;


namespace AspNETProj.Services;

public class CreateCustomer
{
    private Customer _customer;
    private CustomerRepository? _customerRepository;
    public CreateCustomer(string nationalCode, string phoneNumber)
    {
        if (String.IsNullOrEmpty(nationalCode) || nationalCode.Length < 10 || nationalCode.Length > 10)
        {
            throw new Exception("NationalCode format is invalid.");
        } if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 11 || !phoneNumber.StartsWith("09"))
        {
            throw new Exception("PhoneNumber format is invalid");
        }
        _customer = new Customer(nationalCode, phoneNumber);
        try
        {
            var repo = _customerRepository;
            repo.Add(_customer);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}