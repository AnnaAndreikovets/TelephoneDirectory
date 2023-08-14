using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Interfaces
{
    public interface IPerson
    {
        public Task Add(string phone, string surname, string initials, int house, int? building, int? flat, int city);
        public Person Get(Guid id);
        public Task Update(Guid id, string phone, string surname, string initials, int house, int? building, int? flat, int city);
        public Task Delete(Guid id);
    }
}