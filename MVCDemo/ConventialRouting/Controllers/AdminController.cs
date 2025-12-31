using Microsoft.AspNetCore.Mvc;

namespace ConventialRouting.Controllers
{
    public class AdminController : Controller
    {
        public string Index(string name)
        {
            return name;
        }
    }
}
