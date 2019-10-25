using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TutorialMvcApp.Models;

namespace TutorialMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {            
            return View();
        }

        [Route("home/privacy")]
        public IActionResult Privacy()
        {
            List<PersonModel> Persons = getPersonData();
            return View(Persons);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<PersonModel> getPersonData()
        {
            List<PersonModel> PersonList;

            PersonList = new List<PersonModel>()
            {
                new PersonModel()
                    { AdharId =6,FirstName="Siddhesh",LastName="Gawas", Email="siddhesh.gawas@gmail.com", Salary=24500, Company="Infosys", Dept="Cloud" },
                new PersonModel()
                    { AdharId =1,FirstName="Nidhi",LastName="Thomas", Email="Nidhi.Thomas@gmail.com", Salary=25500, Company="Wipro", Dept="Testing" }

            };

            return PersonList;
        }
    }
}
