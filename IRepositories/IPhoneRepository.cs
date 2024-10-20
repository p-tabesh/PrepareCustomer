using AspNETProj.Entities;

namespace AspNETProj.IRepositories
{
    public interface IPhoneRepository
    {
        public void Add(Phone phone);

        public Phone Get(string phoneNumber);
        public List<Phone> Get();

    }
}
