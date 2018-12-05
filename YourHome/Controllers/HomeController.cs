using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public ActionResult AllIwaas()
        {
            var places = db.AytamPlaces.Include("City").ToList();
          
            foreach (var item in places)
            {
                var arr = JArray.Parse(item.Photos).ToList();
                List<string> imagesList = new List<string>();
                foreach (var x in arr)
                {
                    imagesList.Add(x.First.ToString().Substring(12).Replace("\"", ""));
                }

                item.imagesList = imagesList;
            }




            return View(places);
        }
        public ActionResult GetLostTopic(int Id)
        {
            var topic = db.Topics.Include("City").SingleOrDefault(e => e.Id == Id);
            //ViewBag.images = JArray.FromObject(topic.Photos);
            var arr = JArray.Parse(topic.Photos).ToList();
            List<string> imagesList = new List<string>();
            foreach (var item in arr)
            {
                imagesList.Add(item.First.ToString().Substring(12).Replace("\"", ""));
            }
            ViewBag.images = imagesList;
            return View(topic);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}