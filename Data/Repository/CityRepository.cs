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

        public City GetCity(int id)
        {
            City? city = context.City.FirstOrDefault(c => c.Id == id);

            if(city is null)
            {
                throw new ArgumentNullException("Wrong city Id!");
            }

            return city;
        }
    }
}