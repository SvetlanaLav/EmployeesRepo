using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public static class EmployeesModel
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>()
            {
                new Employee()
                {
                    Name = "A",
                    Age = 18,
                    Rank = 1
                },
                new Employee ()
                 {
                    Name = "С",
                    Age = 21,
                    Rank = 2
                },
                 new Employee ()
                 {
                    Name = "B",
                    Age = 26,
                    Rank = 1
                },
                  new Employee ()
                 {
                    Name = "D",
                    Age = 26,
                    Rank = 4
                },
               new Employee ()
                 {
                    Name = "E",
                    Age = 26,
                    Rank = 4
                }
            };
    }
}
