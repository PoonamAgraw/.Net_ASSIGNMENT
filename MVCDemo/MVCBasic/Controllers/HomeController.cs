using Microsoft.AspNetCore.Mvc;

namespace MVCBasic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
