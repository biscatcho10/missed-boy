using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourHome.Controllers
{
    public class HomeController : Controller
    {
        HomeLessEntities db = new HomeLessEntities();

        public ActionResult Index()
        {
            var cats = db.Categories.ToList() ?? new List<Category>();
            return View(cats);
        }

        public ActionResult About()
        {
            List<AbotutU> membersList = db.AbotutUs.ToList();
            return View(membersList);
        }

        public ActionResult Countries(int Id)
        {
            List<Country> Countries = db.Countries.ToList();
            ViewBag.Category = db.Categories.SingleOrDefault(e => e.Id == Id);
            return View(Countries);
        }

        public ActionResult Topics(int Id, int CategoryId)
        {
            ViewBag.Category = db.Categories.SingleOrDefault(e => e.Id == CategoryId);
            var topics = db.Topics.Include("City").Where(e => e.City.CountryId == Id && e.CategoryId == CategoryId).ToList();
            return View(topics);
        }

        public ActionResult GetLostTopic(int Id)
        {
            var topics = db.Topics.Include("City").SingleOrDefault(e => e.Id == Id );
            return View(topics);
        }
    
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}