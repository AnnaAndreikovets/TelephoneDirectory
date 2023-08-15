using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Interfaces
{
    public interface IPerson
    {
        public Task AddPerson(Person person);
        public Person GetPerson(Guid id);
        public List<Person> GetPeople(Person person);
        public Task UpdatePerson(Guid id, Person person);
        public Task DeletePerson(Guid id);
    }
}