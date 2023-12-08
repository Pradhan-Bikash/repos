using FirstProjectMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> emplist = new List<Employee>();
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Bikash";
            employee.Salary = 8000;
            emplist.Add(employee);
            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Prakash";
            emp2.Salary = 90000;
            emplist.Add(emp2);
            return View(emplist);
        }
        public ActionResult AddEmployee()
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            return View();
        }
        public ActionResult UpdateEmployee()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "biku";
            employee.Salary = 50000;
            return View(employee);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}