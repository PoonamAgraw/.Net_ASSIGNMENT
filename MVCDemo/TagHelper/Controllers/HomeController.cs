using _TagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace TagHelper.Controllers
{
    public class HomeController : Controller
    {
            public IActionResult Index()
        {
            return View();
        }

            public IActionResult GetNewUserDetails(NewUser newuser)//Model Binder
            {
                return View(newuser);
            }
        }
    }
