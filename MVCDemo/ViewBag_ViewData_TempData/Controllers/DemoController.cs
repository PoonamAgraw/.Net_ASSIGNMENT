using Microsoft.AspNetCore.Mvc;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
           
            ViewBag.message = "This is the way!";

            Emp emp = new Emp() { Id = 101, Name = "Rahul", Address = "Shrelanka" };
            ViewBag.empInfo = emp;

            ViewData["number"] = 12345;

            Emp emp1 = new Emp() { Id = 102, Name = "Prem", Address = "Mumbai" };
            ViewData["emp1"] = emp1;

            TempData["PIN"] = 223344;

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ABCD()
        {
            return View();
        }
    }
}
