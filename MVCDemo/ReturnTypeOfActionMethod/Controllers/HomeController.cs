using Microsoft.AspNetCore.Mvc;

namespace ReturnTypeOfActionMethod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult<int> GetNumber()
        {
            return 111;
        }

        public ViewResult M1()
        {
            return View("~/Views/Home/About.cshtml");
        }

        public string GetSomething(string unm,string pwd)
        {
            return $"Username : {unm}, Password : {pwd}";
        }

        public JsonResult GetData()
        {
            var data = new
            {
                Id = 45,
                Name = "Rahul",
                Address ="Pune"
            };
            return Json(data);
        }

        public ObjectResult GetObject()
        {
            var data = new
            {
                Id = 45,
                Name = "Rahul",
                Address = "Pune"

            };
            return new ObjectResult(data);
        }

        public StatusCodeResult GetStatus()
        {
            return StatusCode(200);
        }

        public EmptyResult GetEmptyResult()
        { 
            return new EmptyResult();    
        }

        public async Task<ViewResult> GetTask()
        {
            await Task.Delay(1000);
            return View("~/Views/Home/GetData.cshtml");
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"C:\Users\IET\Desktop\250845920050\.Net\MVCDemo\ReturnTypeOfActionMethod\Data\quote.pdf");
            return File(byteArray, "application/pdf", "quote.pdf");
        }
    }
}
