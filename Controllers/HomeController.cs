using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Controllers
{
    public class HomeController : Controller
    {
        readonly IPerson people;

        public HomeController(IPerson people) => this.people = people;

        public IActionResult Search() => View();

        public IActionResult Table(Person person)
        {
            var people = this.people.GetPeople(person);

            return View(people);
        }
    }
}