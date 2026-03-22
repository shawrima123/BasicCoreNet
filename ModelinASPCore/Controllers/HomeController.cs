using Microsoft.AspNetCore.Mvc;
using ModelinASPCore.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace ModelinASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var students = new List<Student>
            //{

            //    new Student{ RollNo=1,Name="Rima",Gender='F',Standard=5},
            //    new Student{ RollNo=2,Name="Raam",Gender='M',Standard=5},
            //    new Student{ RollNo=3,Name="Riya",Gender='F',Standard=5}
            //};

            //ViewData["Mystudents"] = students;
            return View();
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
