using CoreStructureMapExample.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreStructureMapExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMisnamedRepository _stuffRepository;

        public HomeController(
            IPersonRepository personRepository,
            IMisnamedRepository stuffRepository
            )
        {
            _personRepository = personRepository;
            _stuffRepository = stuffRepository;
        }

        public IActionResult Index()
        {
            var person = _personRepository.GetPerson();
            var stuff = _stuffRepository.DoStuff();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
