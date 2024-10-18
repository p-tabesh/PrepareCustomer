using AspNETProj.Entities;
using AspNETProj.IRepositories;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace AspNETProj.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public void Add(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer customer)
    {
        throw new NotImplementedException();
    }

    public List<Customer> Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> Get()
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



public class CustomerPhoneRepository : IPhoneRepository
{
    public void Add(Phone phone)
    {
        throw new NotImplementedException();
    }

    public void Delete(Phone phone)
    {
        throw new NotImplementedException();
    }

    public List<Phone> Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Phone> Get()
    {
        throw new NotImplementedException();
    }

    public void Remove(Phone phone)
    {
        throw new NotImplementedException();
    }
}