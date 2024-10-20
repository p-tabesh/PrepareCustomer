using AspNETProj.Entities;
using AspNETProj.IRepositories;
using AspNETProj.DatabaseContext;
namespace AspNETProj.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly Context _context;
        public PhoneRepository(Context context)
        {
            _context = context;
        }
        public void Add(Phone phone)
        {
            _context.Phones.Add(phone);
            _context.SaveChanges();
        }
        public Phone Get(string phoneNumber)
        {
            throw new NotImplementedException();
        }
        public List<Phone> Get() 
        {
            throw new NotImplementedException();
        }
    }
}
