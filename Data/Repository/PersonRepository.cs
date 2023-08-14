using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TelephoneDirectory.Data.Repository
{
    public class PersonRepository : IPerson
    {
        readonly ApplicationDbContext context;
        readonly ICity city;

        public PersonRepository(ApplicationDbContext context, ICity city)
        {
            this.context = context;
            this.city = city;
        }

        public async Task Add(string phone, string surname, string initials, int house, int? building, int? flat, int cityId)
        {
            City city_ = city.Get(cityId);

            Person person = new Person() {Phone = phone, Surname = surname, Initials = initials, House = house, Building = building, Flat = flat, City = city_};

            await context.Person.AddAsync(person);

            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            Person person = Get(id);

            context.Person.Remove(person);

            await context.SaveChangesAsync();
        }

        public Person Get(Guid id)
        {
            Person? person = context.Person.FirstOrDefault(p => p.PersonId.CompareTo(id) == 0);

            if(person is null)
            {
                throw new ArgumentNullException("Wrong person Id!");
            }

            return person;
        }

        public async Task Update(Guid id, string phone, string surname, string initials, int house, int? building, int? flat, int cityId)
        {
            Person person = Get(id);
            
            context.Entry(person).State = EntityState.Modified;

            City city_ = city.Get(cityId);

            person.Phone = phone;
            person.Surname = surname;
            person.Initials = initials;
            person.House = house;
            person.City = city_;
            
            if(building is not null)
            {
                person.Building = building;
            }

            if(flat is not null)
            {
                person.Flat = flat;
            }

            await context.SaveChangesAsync();
        }
    }
}