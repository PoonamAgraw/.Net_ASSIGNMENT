using Microsoft.AspNetCore.Mvc;

namespace _FilterSession.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
