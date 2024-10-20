using AspNETProj.DatabaseContext;
using AspNETProj.Entities;
using AspNETProj.Models;
using AspNETProj.Repositories;
using AspNETProj.Utilities;
using Microsoft.EntityFrameworkCore;


namespace AspNETProj.Services;

public class CreateCustomer
{
    private Customer _customer;
    private Phone _phone;
    private CustomerRepository _customerRepository;
    private readonly Context _context;
    public CreateCustomer(string nationalCode, string phoneNumber, Context context)
    {
        if (String.IsNullOrEmpty(nationalCode) || nationalCode.Length != 10)
        {
            throw new Exception("NationalCode format is invalid.");
        }
        if (string.IsNullOrEmpty(phoneNumber))
        {
            throw new Exception("phone must have value");
        }
        _context = context;
        _customer = new Customer(nationalCode);
        _customerRepository = new CustomerRepository(_context);
        _customerRepository.Add(_customer);

    }
}