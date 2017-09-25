using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Employee> employees = employeecontext.Employees.ToList();
            //public int EmployeeId { get; private set; }
            //public string Name { get; private set; }
            //public string Gender { get; private set; }
            //public string City { get; private set; }
            return View(employees);
        }

            // GET: Employee
            public ActionResult Details(int ID)
        {
            EmployeeContext employeecontext = new EmployeeContext();
            Employee employee = employeecontext.Employees.Single(emp => emp.EmployeeId == ID.ToString());
            //Employee employee = new Employee();
            //{
            //    EmployeeId = 101;
            //    Name = "Pranav";
            //    Gender = "Male";
            //    City = "Noida";
            //};


            return View(employee);
        }
        public ActionResult addEmp()

        {
            EmployeeContext employeecontext = new EmployeeContext();
            Employee emp = new Employee() {
            EmployeeId = "5",
            Name = "Prem",
            Gender = "Male",
            City = "Noida"
        };
            employeecontext.Employees.Add(emp);//saves in heap memory...
            employeecontext.SaveChanges();//persist changes in database..

        //Employee employee = employeecontext.Employees
            //Employee employee = new Employee();
            //{
            //    EmployeeId = 101;
            //    Name = "Pranav";
            //    Gender = "Male";
            //    City = "Noida";
            //};


            return View();
    }
}
}