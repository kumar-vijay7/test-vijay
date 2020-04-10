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
        
        public ActionResult Ques1()
        {
            return View();
        }
        public ActionResult Ques2()
        {
            var response = EmployeeData();
            return View(response);
        }

        [NonAction]
        public List<TBL_EMPLOYEES> EmployeeData()
        {
            var response = _employeeservices.EmployeeData();
            return response;
        }
        public ActionResult Ques3()
        {
            return View();
        }
        public ActionResult Ques4()
        {
            return View();
        }
        public ActionResult Ques5()
        {
            return View();
        }

        [ChildActionOnly]
       public ActionResult Footer()
        {
            return PartialView("_Footer");
        }
        public ActionResult Login(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                var result = _employeeservices.Login(user);

                if (result)
                {
                    return RedirectToAction("Index", "DashBoard");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }

            
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var response = _employeeservices.EmployeeDataById(id);
            return View(response);
        }

        [HttpPost]
        public ActionResult EditEmployee([Bind(Include = "EMP_ID,EMP_Name,EMP_DOB,IsTrainer")]TBL_EMPLOYEES emp)
        {
            var response = _employeeservices.UpdateEmployeeById(emp);
            return RedirectToAction("Ques2");
        }


    }
}