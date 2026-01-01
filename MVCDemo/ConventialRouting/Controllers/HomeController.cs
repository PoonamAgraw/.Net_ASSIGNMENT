using Microsoft.AspNetCore.Mvc;

namespace ConventialRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult<string> UserCredential(string unm,string pwd)
        { 
            return $"Username {unm}, Password {pwd}";
        }
    }
}
