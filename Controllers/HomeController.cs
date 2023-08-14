using Microsoft.AspNetCore.Mvc;

namespace TelephoneDirectory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}