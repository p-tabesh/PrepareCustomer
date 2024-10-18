using AspNETProj.Entities;

namespace AspNETProj.IRepositories;

public interface ICustomerRepository
{
    public List<Customer> Get(int id);
    public IEnumerable<Customer> Get();
    public void Add(Customer customer);
    // public void Update(Customer customer, string newPhoneNumber);
    public void Delete(Customer customer);
    public void Remove(Customer customer);
}



public interface IPhoneRepository
{
    public List<Phone> Get(int id);
    public IEnumerable<Phone> Get();
    public void Add(Phone phone);
    // public void Update(Customer customer, string newPhoneNumber);
    public void Delete(Phone phone);
    public void Remove(Phone phone);
}