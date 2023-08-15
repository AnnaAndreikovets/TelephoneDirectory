using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Interfaces
{
    public interface IPerson
    {
        Task AddPersonAsync(Person person);
        Person GetPerson(Guid id);
        List<Person> GetPeople(Person person);
        Task UpdatePersonAsync(Guid id, Person person);
        Task DeletePersonAsync(Guid id);
    }
}