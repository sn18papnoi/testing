using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepo = new EmployeeRepository();
        public ActionResult Index()
        {
            List<Employee> lstEmployee = employeeRepo.GetEmployee();
            return View(lstEmployee);
        }
        public ActionResult Add()
        {
            ViewBag.Country = employeeRepo.GetCountries();
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee e)
        {
            bool isSuccess = employeeRepo.InserEmployee(e);
            return RedirectToAction("Index", "Employee");
        }
    }
}