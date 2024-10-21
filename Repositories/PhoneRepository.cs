using AspNETProj.Entities;
using AspNETProj.IRepositories;
using AspNETProj.DatabaseContext;
using System.Data;
using EntityFramework.Exceptions.Common;
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
            try
            {
                _context.Phones.Add(phone);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Phone Number Already Exists");
            }
            
        }
        public Phone Get(string phoneNumber)
        {
            var phone = _context.Phones.FirstOrDefault(p => p.Value == phoneNumber);
            return phone;
        }
        public List<Phone> Get() 
        {
            throw new NotImplementedException();
        }

        public void Update(int oldValueId, string newValue, int CustomerId)
        {
            var phone = _context.Phones.FirstOrDefault(t => t.Id == oldValueId && t.CustomerId == CustomerId);            
            phone.Value = newValue;
            _context.SaveChanges();
            // نمیدونم باید اینجا عدم وجودشو چک کنه و خطا بده یا تو همون گت بفهمه
            // بخاطر بررسی وجود داشتن نیو ولیو باید وجودشو اول چک کنم فکر کنم
        }

        
    }
}
