using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Interfaces
{
    public interface ICity
    {
        public City GetCity(int id);
    }
}