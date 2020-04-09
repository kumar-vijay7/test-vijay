using MVCArchitecture.Models;
using MVCArchitecture.Models.Repository;
using MVCArchitecture.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCArchitecture.Controllers
{
    public class HomeController : Controller
    {
        readonly IEmployeeRepository _employeeservices;
       
        public HomeController()
        {
            _employeeservices = new EmployeeServices();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Question:View
        /// </summary>
        /// <returns></returns>
        public ActionResult Ques1()
        {
            return View();
        }
           /// <summary>
           /// Question2: View
           /// </summary>
           /// <returns></returns>
        public ActionResult Ques2()
        {
            return View();
        }
        public ActionResult EmployeeData()
        {
            var result = _employeeservices.EmployeeData();
            return View(result);
        }

        public ActionResult Ques4()
        {
            return View();
        }
        public ActionResult Ques5()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Insert New Employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public ActionResult PostEmployee(TBL_EMPLOYEES emp)
        {
            var response = _employeeservices.InsertEmployee(emp);
            return RedirectToAction("Create");

        }

        public ActionResult UserLogin()
        {
            return View();
        }
        /// <summary>
        /// Perform Login Operation
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public ActionResult Login(LoginModel  user)
        {
            if (ModelState.IsValid)
            {
                var result = _employeeservices.UserLogin(user);
                TempData["username"] = result;
            }
            else
            {
                return View("UserLogin");
            }
            
            return RedirectToAction("Index", "DashBoard");
        }
    }
}