using InformationPersonel.Models;

namespace InformationPersonel.Repositories
{
    public interface IPersonInformation
    {
        Task<IEnumerable<Person>> GetAll();
        Task<Person> Get(int id);
        Task<Person> Add(Person person);
        void Remove(Person person);
        Task<Person> Update(Person person);

    }
}
