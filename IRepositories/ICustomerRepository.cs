using AspNETProj.Entities;

namespace AspNETProj.IRepositories;

public interface ICustomerRepository
{
    public Customer Get(int id);
    public List<Customer> Get();
    public void Add(Customer customer);
    // public void Update(Customer customer, string newPhoneNumber);
    public void Delete(Customer customer);
    public void Remove(Customer customer);
}


