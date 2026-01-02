using _FilterSession.Models;
using Microsoft.AspNetCore.Mvc;

namespace _FilterSession.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            if (user.USerName == "admin" && user.Password == "1234")
            {
                HttpContext.Session.SetString("token", user.USerName);
                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.message = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Signout()
        {
            HttpContext.Session.Remove("token");
            return Redirect("/Login/SignIn");
        }
    }
}
