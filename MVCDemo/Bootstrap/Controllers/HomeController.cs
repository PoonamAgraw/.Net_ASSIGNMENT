using System.Diagnostics;
using Bootstrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> emps = new List<Emp>() {
            new Emp(){ Id= 11, Name= "Tony Stark", Address="LA"},
            new Emp(){ Id= 12, Name= "Walter Bishop", Address="New Jersey"},
            new Emp(){ Id= 13, Name= "Thor", Address="Asgard"},
            new Emp(){ Id= 14, Name= "Peter Bishop", Address="Parallel Universe"},
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View(emps);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
