using System.Collections;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> empList = new List<Emp>()
            {
                new Emp(){ Id= 101, Name= "Pinky", Address="Pune"},
                new Emp(){ Id= 102, Name= "Sakshi", Address="Nagpur"},
                new Emp(){ Id= 103, Name= "Taniyaa", Address="Mumbai"},
                new Emp(){ Id= 104, Name= "Bablu", Address="Pune"},
                new Emp(){ Id= 105, Name= "Dhruv", Address="Nagpur"},

            };

        List<Customer> customerList = new List<Customer>() {
         new Customer(){CId= 1, CName="Rama", BillNo= 1234 },
         new Customer(){CId= 2, CName="Sakshi", BillNo= 5678 },
         new Customer(){CId= 3, CName="Roshani", BillNo= 2468 },
        };

        public IActionResult Index()
        {
            //string name = "Iron Man";
            //return View("Index", name);
            long phNo = 8275006278;
            return View(phNo);
        }
        public IActionResult GetEmps()
        {
            return View(empList);
        }
        public IActionResult GetRecords()
        {
            DACViewModel vmmodel = new DACViewModel()
            {
                allEmps = empList,
                allCusts = customerList
            };
            return View(vmmodel);
        }
        public IActionResult Display()
        {
            Emp emp = new Emp() { Id = 44, Name = "Rahul", Address = "Pune" };
            Customer cust = new Customer() { CId = 88, CName = "Raju", BillNo = 007 };
            ArrayList arr = new ArrayList() { emp, cust };
            return View(arr);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
