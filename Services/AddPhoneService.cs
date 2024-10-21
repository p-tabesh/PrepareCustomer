using AspNETProj.DatabaseContext;
using AspNETProj.Entities;
using AspNETProj.Repositories;
using AspNETProj.Utilities;

namespace AspNETProj.Services
{
    public class AddPhoneService
    {
        private Phone _phone;
        private Customer _customer;
        private CustomerRepository _customerRepository;
        private PhoneRepository _phoneRepository;
        private readonly Context _context;


        public AddPhoneService(string phoneNumber, int customerId, Context context)
        {
            _context = context;
            _phoneRepository = new PhoneRepository(_context);

            if (!PhoneValidation.IsValid(phoneNumber))
            {
                throw new Exception("Phone format is invalid.");
            }

            _customerRepository = new CustomerRepository(_context);
            _customer = _customerRepository.Get(customerId);

            _phone = new Phone(phoneNumber, _customer);
            _phoneRepository.Add(_phone);
            // کلا سرویس هارو فانکشنی کنم یا تو کانستراکتور اوکی کنم؟
        }
    }
}
