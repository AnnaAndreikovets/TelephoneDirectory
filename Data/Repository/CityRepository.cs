using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Repository
{
    public class CityRepository : ICity
    {
        readonly ApplicationDbContext context;

        public CityRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public City Get(int id)
        {
            City? city = context.City.FirstOrDefault(c => c.Id.CompareTo(id) == 0);

            if(city is null)
            {
                throw new ArgumentNullException("Wrong city Id!");
            }

            return city;
        }
    }
}