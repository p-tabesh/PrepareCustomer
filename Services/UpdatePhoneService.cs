
using AspNETProj.DatabaseContext;
using AspNETProj.Entities;
using AspNETProj.IRepositories;
using AspNETProj.Repositories;
using AspNETProj.Utilities;

namespace AspNETProj.Services;

public class UpdatePhoneService
{
    private readonly Context _context;
    private readonly PhoneRepository _phoneRepository;
    private readonly CustomerRepository _customerRepository;
    public UpdatePhoneService(Context context)
    {
        
        _context = context;
        _phoneRepository = new PhoneRepository(context);
        _customerRepository = new CustomerRepository(context);
        
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
}
