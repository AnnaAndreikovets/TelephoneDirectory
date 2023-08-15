using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TelephoneDirectory.Data.Repository
{
    public class PersonRepository : IPerson
    {
        readonly ApplicationDbContext context;

        public PersonRepository(ApplicationDbContext context) => this.context = context;

        public async Task AddPerson(Person person)
        {
            await context.People.AddAsync(person);

            await context.SaveChangesAsync();
        }

        public async Task DeletePerson(Guid id)
        {
            Person person = GetPerson(id);

            context.People.Remove(person);

            await context.SaveChangesAsync();
        }

        public Person GetPerson(Guid id)
        {
            Person? person = context.People.FirstOrDefault(p => p.PersonId.CompareTo(id) == 0);

            if(person is null)
            {
                throw new ArgumentNullException("Wrong person Id!");
            }

            return person;
        }

        public List<Person> GetPeople(Person person)
        {
            //получить пользователя соотвественно данным переданного человека
            return context.People.ToList();
        }

        public async Task UpdatePerson(Guid id, Person person)
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
            
            if(person.Building is not null)
            {
                personOld.Building = person.Building;
            }

            if(person.Flat is not null)
            {
                personOld.Flat = person.Flat;
            }

            await context.SaveChangesAsync();
        }
    }
}