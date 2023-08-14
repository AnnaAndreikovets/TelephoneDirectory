using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Interfaces
{
    public interface IPerson
    {
        public Task AddPerson(string phone, string surname, string initials, int house, int? building, int? flat, int city);
        public Person GetPerson(Guid id);
        public Task UpdatePerson(Guid id, string phone, string surname, string initials, int house, int? building, int? flat, int city);
        public Task DeletePerson(Guid id);
    }
}