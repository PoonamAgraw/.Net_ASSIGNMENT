using Microsoft.AspNetCore.Mvc;

namespace _EF_Filter_Session_WEBApi.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
