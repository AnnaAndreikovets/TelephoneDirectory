using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TelephoneDirectory.Data.Repository
{
    public class PersonRepository : IPerson
    {
        readonly ApplicationDbContext context;

        public PersonRepository(ApplicationDbContext context) => this.context = context;

        public async Task AddPersonAsync(Person person)
        {
            await context.People.AddAsync(person);

            await context.SaveChangesAsync();
        }

        public async Task DeletePersonAsync(Guid id)
        {
            Person person = GetPerson(id);

            context.People.Remove(person);

            await context.SaveChangesAsync();
        }

        public Person GetPerson(Guid id) => context.People.Include(p => p.City).FirstOrDefault(p => p.PersonId.CompareTo(id) == 0) ?? throw new KeyNotFoundException("Wrong person Id!");

        public List<Person> GetPeople(Person person)
        {
            IEnumerable<Person> people = context.People.Include(c => c.City);

            if(person.Phone is not null)
            {
                people = people.Where(p => p.Phone!.Equals(person.Phone));
            }
            
            if(!string.IsNullOrWhiteSpace(person.Surname) && people.Count() > 0)
            {
                people = people.Where(p => p.Surname!.Equals(person.Surname));
            }

            if(person.Initials is not null && people.Count() > 0)
            {
                people = people.Where(p => p.Initials!.Equals(person.Initials));
            }

            if(person.House is not null && people.Count() > 0)
            {
                people = people.Where(p => p.House == person.House);
            }

            if(person.Building is not null && people.Count() > 0)
            {
                people = people.Where(p => p.Building == person.Building);
            }

            if(person.Flat is not null && people.Count() > 0)
            {
                people = people.Where(p => p.Flat == person.Flat);
            }

            if(person.City.CityName != "None" && people.Count() > 0)
            {
                people = people.Where(p => p.City.CityName.Equals(person.City.CityName));
            }

            return people.ToList();
        }

        public async Task UpdatePersonAsync(Guid id, Person person)
        {
            Person personOld = GetPerson(id);
            
            context.Entry(personOld).State = EntityState.Modified;

            if(personOld.Phone != person.Phone)
            {
                personOld.Phone = person.Phone;
            }

            if(personOld.Surname != person.Surname)
            {
                personOld.Surname = person.Surname;
            }

            if(personOld.Initials != person.Initials)
            {
                personOld.Initials = person.Initials;
            }

            if(personOld.House != person.House)
            {
                personOld.House = person.House;
            }
            
            if(personOld.Building != person.Building)
            {
                personOld.Building = person.Building;
            }

            if(personOld.Flat != person.Flat)
            {
                personOld.Flat = person.Flat;
            }
            
            string name = person.City.CityName;
            City city = context.City.FirstOrDefault(c => c.CityName == name) ?? throw new ArgumentNullException("Wrong city name!");

            if (personOld.City.CityName != name)
            {
                personOld.CityId = city.Id;
                personOld.City.CityName = name;
            }

            await context.SaveChangesAsync();
        }
    }
}