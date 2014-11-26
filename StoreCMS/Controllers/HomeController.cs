using StoreCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreCMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Departments()
        {
            ViewBag.Message = "Departments";
            ViewBag.Items = "";
            //list is only for testing; need to replace with Linq
            var departments = new List<Department>{
                new Department{DeptId=1, DepartmentName="Fashion"},
                new Department{DeptId=2, DepartmentName="Sporting"},
                new Department{DeptId=3, DepartmentName="Outerwear"}
            };

            return View(departments);
        }

        public ActionResult Browse(int deptId)
        {
            //select items from database where departmentid = deptId
            var products = new List<Product> { 
                new Product{ProductName="Sash", ProductId=1, Price=5.99M}//testing only
            };
            ViewBag.DepartmentName = "Fashion"; //testing
            
            return View(products);
        }

        public ActionResult SubDepartments()
        {
            ViewBag.Message = "Sub-Departments";

            return View();
        }

        public ActionResult Item(int ProductId)
        {
            ViewBag.Message = "Item";
            var product = new Product{ProductName="Sash", ProductId=1, Price=5.99M};//testing only

            return View(product);
        }


    }
}