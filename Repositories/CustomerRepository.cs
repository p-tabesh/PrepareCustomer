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

    public void Remove(Customer customer)
    {
        _context.Customers.Remove(customer);
        _context.SaveChanges();
    }

    public Customer Get(int id)
    {
        var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
        return customer ?? throw new Exception("Customer Not Found");
    }

    public List<Customer> Get()
    {
        var customers = _context.Customers.ToList();
        return customers;
    }

    public void Delete(Customer customer)
    {
        throw new NotImplementedException();
    }
}



