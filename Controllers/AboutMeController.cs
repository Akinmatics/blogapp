using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mywebsite.Data;

namespace mywebsite.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public AboutMeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public IActionResult Index()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "AboutMe");
            return View(page);
        }
    }
}