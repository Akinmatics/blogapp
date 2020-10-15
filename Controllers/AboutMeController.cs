using Microsoft.AspNetCore.Mvc;

namespace mywebsite.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}