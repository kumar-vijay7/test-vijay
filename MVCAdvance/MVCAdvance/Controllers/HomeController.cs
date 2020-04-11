using MVCAdvance.Common;
using MVCAdvance.Models.EntityModel;
using MVCAdvance.Models.Repository;
using MVCAdvance.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAdvance.Controllers
{
    [HandleError(View = "_MvcError")]
    
    public class HomeController : Controller
    {
        readonly IEmployeeRepository _employeeservice;
        public HomeController()
        {
            _employeeservice = new EmployeeService();
        }
        // GET: Home
        [CustomFilter(Order =2)]
        [CustomFilter2(Order = 1)]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //GET:Login
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// This method performing the Login operation
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [OutputCache(Duration =20)]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var response = _employeeservice.UserLogin(user);
                if (response) {
                    FormsAuthentication.SetAuthCookie(user.Username,false);
                    return RedirectToAction("GetEmployeeData");
                }
                return View();
            }
            else
            {
                return View();
            }
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        [Authorize(Roles = "Admin,User")]
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult GetEmployeeData(TBL_EMPLOYEES emp)
        {
             var response = _employeeservice.GetEmployeeData();
            return View(response);
        }

        //GET:Edit
        [Authorize(Roles ="Admin")]
        public ActionResult Edit()
        {
            return View();
        }

        /// <summary>
        /// This Method help us to insert the data in employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        [Authorize(Roles ="Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostEmployeeData(TBL_EMPLOYEES emp)
        {
            if (ModelState.IsValid)
            {
                var result = _employeeservice.InsertEmployee(emp);
                return View("GetEmployeeData");
            }
            else
            {
                return View();
            }
            
        }

        [Route("{Id}")]
        [Route("{Id}/Details")]
        public ActionResult Details(int id)
        {
            var response = _employeeservice.EmployeById(id);
            return View(response);
        }

        public ActionResult Ques5()
        {
            return View();
        }


    }
}