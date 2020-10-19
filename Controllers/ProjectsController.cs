using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mywebsite.Data;

namespace mywebsite.Controllers
{
    public class ProjectsController : Controller
    {
       
         private readonly ApplicationDbContext _dbContext;
        public ProjectsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public IActionResult Index()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "Projects");

            return View(page);
        }
    }
}