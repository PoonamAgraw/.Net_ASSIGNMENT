using System.Diagnostics;
using _DbFirst.Models;

using Microsoft.AspNetCore.Mvc;

namespace _DbFirst.Controllers
{
    public class HomeController : Controller
    {
        public readonly DACContext _dbcontext;
        public HomeController(DACContext dbcontext)
        {
            _dbcontext = dbcontext; 
        }
        public IActionResult Index()
        {
            var allEmps = _dbcontext.Emps.ToList();
            return View(allEmps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
