using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult ListStudent()
        {
            PageListStudentModel model = new PageListStudentModel();

            model.students = new List<StudentDto> { new StudentDto {Name="Du" } };

            return View(model);
        }
        public IActionResult Index()
        {
            ViewData["xxx"] = "";
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
