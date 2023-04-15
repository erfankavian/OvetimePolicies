using InformationPersonel.Context;
using InformationPersonel.Models;
using Microsoft.EntityFrameworkCore;

namespace InformationPersonel.Repositories
{
    public class PersonInformation : IPersonInformation
    {
        private readonly DbMainContext _context;
        public PersonInformation(DbMainContext context)
        {
            _context = context;
        }

        public async Task<Person> Add(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> Get(int id)
        {
           
            return await _context.Persons.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _context.Persons.OrderBy(a => a.FirstName).ToListAsync();
        }

        public void Remove(Person person)
        {
            _context.Persons.Remove(person);
        }

        public async Task<Person> Update(Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return person;
        }
    }
}

