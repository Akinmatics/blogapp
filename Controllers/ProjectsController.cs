using Microsoft.AspNetCore.Mvc;

namespace mywebsite.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}