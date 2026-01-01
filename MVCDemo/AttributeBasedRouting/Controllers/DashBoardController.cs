using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    [Route("[controller]")]
    public class DashBoardController : Controller
    {
        [Route("[action]")]
        public int GetNumber()
        {
            return 100;
        }
        //http://localhost:1715/DashBoard/GetSomething/1/Ran
        [Route("[action]/{id}/{nm}")]
        public string GetSomething(int id, string nm)
        {
            return $"Id : {id} , Name : {nm}";
        }
    }
}
