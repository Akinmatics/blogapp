using Microsoft.AspNetCore.Mvc;

namespace mywebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}