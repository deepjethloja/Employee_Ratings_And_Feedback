using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParallelDots;
using Newtonsoft.Json.Linq;

namespace WebApplication3.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: Developer
        public ActionResult RatingsView()
        {
            Db_1Entities obj = new Db_1Entities();
            var inte = Session["username"];
            return View(obj.View_MyRatings(Int32.Parse(inte.ToString())));
            
        }
        public ActionResult FeedbackFormView()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FeedbackFormView([Bind(Include = "DeveloperId,SubtaskId,FeedbackStr,Positivity")] Feedback feedback)
        {
            Db_1Entities db = new Db_1Entities();
            if (ModelState.IsValid)
            {
                paralleldots pd = new paralleldots("qZA1qGaGDNNbSUGiNSEOpBjxZreiijYM7y77VLCrlvw");
                var sentiment = pd.sentiment(feedback.FeedbackStr);
                var objects = JObject.Parse(sentiment);
                var posprob = objects["probabilities"]["positive"].ToString();
                feedback.Positivity = Double.Parse(posprob);
                db.Feedbacks.Add(feedback);
                db.SaveChanges();
                return RedirectToAction("FeedbackFormView");
            }

            return View(feedback);
        }
        public ActionResult AboutView()
        {
            Db_1Entities obj = new Db_1Entities();
            var inte = Session["username"];
            return View(obj.My_Subtasks(Int32.Parse(inte.ToString())));
            
        }

        public ActionResult ChangePasswordView()
        {
            return View();
        }
        public ActionResult PreviousRecordsView()
        {
            Db_1Entities obj = new Db_1Entities();
            var inte = Session["username"];
            return View(obj.My_PreviousSubtasks(Int32.Parse(inte.ToString())));
        }
    }
}