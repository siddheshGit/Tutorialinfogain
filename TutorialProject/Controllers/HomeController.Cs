using Microsoft.AspNetCore.Mvc;

namespace TutorialProject
{
    public class HomeController : Controller
    {
        [Route("home/index")]
        public IActionResult Index()
        {
            return Ok("Hello From MVC Index action");
        }
    }
}