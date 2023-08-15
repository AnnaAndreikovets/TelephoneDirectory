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

        public IActionResult Update(Guid id)
        {
            var person = people.GetPerson(id);

            return View(person);
        }

        public async Task<IActionResult> UpdatePerson(Guid id, Person person)
        {
            await people.UpdatePersonAsync(id, person);

            return RedirectToAction("Message", new { message = "Update was successful!" });
        }

        public IActionResult Add() => View();

        public async Task<IActionResult> AddPerson(Person person)
        {
            await people.AddPersonAsync(person);

            return RedirectToAction("Message", new { message = "Information successfully added!" });
        }
        
        public IActionResult Table(Person person)
        {
            var people = this.people.GetPeople(person);

            return View(people);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await people.DeletePersonAsync(id);

            return RedirectToAction("Message", new { message = "Information successfully removed!" });
        }

        [Route("/Home/Message/{message}")]
        public IActionResult Message(string message)
        {
            ViewData["message"] = message;

            return View();
        }
    }
}