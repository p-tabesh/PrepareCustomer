using AspNETProj.Entities;
using AspNETProj.IRepositories;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using AspNETProj.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
namespace AspNETProj.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly Context _context;
    public CustomerRepository(Context context) 
    {
        _context = context;
    }
    public void Add(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
    }

    public void Delete(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
        return customer ?? throw new Exception("Customer Not Found");
    }

    public List<Customer> Get()
    {
        throw new NotImplementedException();
    }

    public void Remove(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer customer, string newPhoneNumber)
    {
        throw new NotImplementedException();
    }
}



