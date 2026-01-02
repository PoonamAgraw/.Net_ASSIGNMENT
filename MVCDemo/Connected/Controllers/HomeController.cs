using System.Diagnostics;
using _Connected.Models;
using Microsoft.AspNetCore.Mvc;

namespace Connected.Controllers
{
    public class HomeController : Controller
    {
        private readonly DACContext _DbContext;

        public HomeController(DACContext context)
        {
            _DbContext = context;
        }

        public IActionResult Index()
        {
            var allEmps = _DbContext.GetAllEmps();
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
