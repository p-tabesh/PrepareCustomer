using AspNETProj.DatabaseContext;
using AspNETProj.Entities;
using AspNETProj.Repositories;
using AspNETProj.Utilities;


namespace AspNETProj.Services;

public class PhoneServices
{
    private Context _context;
    private CustomerRepository _customerRepository;
    private PhoneRepository _phoneRepository;
    public PhoneServices(Context context)
    {
        _context = context;
        _customerRepository = new CustomerRepository(context);
        _phoneRepository = new PhoneRepository(context);
        
    }
    public void UpdatePhone(string oldValue, string newValue, int customerId)
    {
        if (!PhoneValidation.IsValid(oldValue) || !PhoneValidation.IsValid(newValue))
        {
            throw new ArgumentException("phone number format is invalid");
        }

        var phone = _phoneRepository.Get(oldValue);

        if (phone == null)
        {
            throw new Exception("phone number doesnt exists");
        }
        if (phone.CustomerId != customerId)
        {
            throw new Exception("phone doesnt belong to this customer");
        }
        if (_phoneRepository.Get(newValue) != null)
        {
            throw new Exception("New value already exists");
        }
        var customer = _customerRepository.Get(customerId);
        _phoneRepository.Update(phone.Id, newValue, customer.Id);
    }
    public void AddPhone(string phoneNumber, int customerId)
    {
        if (!PhoneValidation.IsValid(phoneNumber))
        {
            throw new Exception("Phone format is invalid.");
        }
        var customer = _customerRepository.Get(customerId);
        var phone = new Phone(phoneNumber, customer);
        _phoneRepository.Add(phone);
        // کلا سرویس هارو فانکشنی کنم یا تو کانستراکتور اوکی کنم؟
    }
}
