using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employees.Models;
using Employees.ViewModels;

namespace Employees.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    var ViewModel = new IndexViewModel() {People=EmployeesModel.Employees }; 
        //    return View(ViewModel);
        //}

        public IActionResult Index(string employeeName)
        {

            var ViewModel = new IndexViewModel() 
             foreach (var ) 
            { People = EmployeesModel.Employees.Where(employee=> employee.Name == employeeName).ToList() };
            return View(ViewModel);
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
