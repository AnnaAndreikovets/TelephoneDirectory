using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Repository
{
    public class PersonRepository : IPerson
    {
        readonly ApplicationDbContext context;

        public PersonRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task AddPerson(string phone, string surname, string initials, int house, int? building, int? flat, int city)
        {
            throw new NotImplementedException();
        }

        public Task DeletePerson(Guid id)
        {
            throw new NotImplementedException();
        }

        public Person? GetPerson(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePerson(Guid id, string phone, string surname, string initials, int house, int? building, int? flat, int city)
        {
            throw new NotImplementedException();
        }
    }
}