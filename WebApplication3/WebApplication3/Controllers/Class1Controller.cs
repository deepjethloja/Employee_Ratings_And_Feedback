using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class Class1Controller : Controller
    {
        private Db_1Entities db = new Db_1Entities();

        // GET: Class1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Class1 model)
        {
            Db_1Entities cbe = new Db_1Entities();
            var s = cbe.GetLoginInfo(model.UserName, model.Password);
            var it = s.FirstOrDefault();
            string[] result = it.Split(' ');
            string last = result[result.Length - 2];
            string last2 = result[result.Length - 1];
            var item = result[0];
            Session["username"] = last;
            Session["name"] = last2;
            if (item == "Developer")
            {

                return View("Developer");
            }
            else if (item == "Manager")
            {
                return View("Manager");
            }
            else if (item == "Admin")
            {
                return View("Admin");
            }
            else if (item == "User Does not Exists")

            {
                ViewBag.NotValidUser = item;

            }
            else
            {
                ViewBag.Failedcount = item;
            }
            ViewBag.heading = "UserName";

            return View("Index");
        }
       
    }
}








    

