using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Data.Interfaces;
using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Controllers
{
    public class HomeController : Controller
    {
        readonly IPerson people;

        public HomeController(IPerson people) => this.people = people;

        [HttpGet]
        public IActionResult Search() => View();

        [HttpGet]
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

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            var person = people.GetPerson(id);

            return View(person);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            
            if(people.GetPeople(person).Count() != 0)
            {
                return RedirectToAction("Message", new { message = "Unable to update. The data matches an already existing person!" });
            }

            await people.UpdatePersonAsync(id, person);

            return RedirectToAction("Message", new { message = "Update was successful!" });
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }

            if(people.GetPeople(person).Count() != 0)
            {
                return RedirectToAction("Message", new { message = "Failed to add. The data matches an already existing person!" });
            }

            await people.AddPersonAsync(person);

            return RedirectToAction("Message", new { message = "Information successfully added!" });
        }

        [HttpGet]
        [Route("/Home/Message/{message}")]
        public IActionResult Message(string message)
        {
            ViewData["message"] = message;

            return View();
        }
    }
}