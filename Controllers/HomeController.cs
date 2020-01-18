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

        public object People { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

            public IActionResult Index(string employeeName , string employeeAge)
        {
            var ViewModel = new IndexViewModel();
         

           
            if (string.IsNullOrWhiteSpace(employeeName)) 
            {
                ViewModel.People = EmployeesModel.Employees;                
            }
              
            else
            {
                ViewModel.People = EmployeesModel.Employees.Where(employee => employee.Name == employeeName).ToList();
                

            }


            var result = int.TryParse(employeeAge, out var parsedEmlpoyeeAge);

            if (result)
            {
               ViewModel.People= ViewModel.People.Where(employee => employee.Age == parsedEmlpoyeeAge).ToList();
                
            }
            else

            {
               

            }


            return View(ViewModel);
 
        }
        
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
