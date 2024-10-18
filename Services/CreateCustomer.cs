using AspNETProj.Entities;
using AspNETProj.Models;
using AspNETProj.Repositories;
using AspNETProj.Utilities;


namespace AspNETProj.Services;

public class CreateCustomer
{
    private Customer _customer;
    private CustomerPhone _customerPhone;
    private CustomerPhoneRepository _customerPhoneRepository;
    private CustomerRepository? _customerRepository;
    public CreateCustomer(string nationalCode, string phoneNumber)
    {
        if (String.IsNullOrEmpty(nationalCode) || nationalCode.Length < 10 || nationalCode.Length > 10)
        {
            throw new Exception("NationalCode format is invalid.");
        }
        if (string.IsNullOrEmpty(phoneNumber))
        {
            throw new Exception("phone must have value");
        }
        _customer = new Customer(nationalCode);
        _customerPhone = new CustomerPhone(phoneNumber, _customer);
        try
        {
            var customerRepo = _customerRepository;
            customerRepo.Add(_customer);
            var phoneRepo = _customerPhoneRepository;
            phoneRepo.Add(_customerPhone);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}