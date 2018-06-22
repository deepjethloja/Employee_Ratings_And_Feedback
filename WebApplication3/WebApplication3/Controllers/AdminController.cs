using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult RatingsView()
        {
            Db_1Entities deep = new Db_1Entities();
            return View(deep.DeveloperLoginInfoes.ToList());
        }

        public ActionResult AboutView()
        {
            Db_1Entities cbe = new Db_1Entities();
                     
            return View(cbe.Admin_Home());
        }

        
    }
}