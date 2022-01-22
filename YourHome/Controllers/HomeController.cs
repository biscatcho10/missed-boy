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
        public ActionResult Fe2at(int Id /*id is the cityId that is countryId*/, int CategoryId)
        {
            // city is fe2a
            List<City> fe2at = db.Cities.ToList();
            ViewBag.Category = db.Categories.SingleOrDefault(e => e.Id == CategoryId);
            ViewBag.Country = db.Countries.SingleOrDefault(e => e.Id == Id);
            return View(fe2at);
        }
        public ActionResult ContactPost(Contactu model)
        {
            db.Contactus.Add(new Contactu { Mail = model.Mail, MessageContent = model.MessageContent });
            db.SaveChanges();
            return View("Contact");
        }


        //id is countryId
        public ActionResult Topics(int Id, int CategoryId, int fe2aId/*fe2a is the cityId*/)
        {
            ViewBag.Category = db.Categories.SingleOrDefault(e => e.Id == CategoryId);
            ViewBag.Country = db.Countries.SingleOrDefault(e => e.Id == Id);
            ViewBag.fe2a = fe2aId;
            var topics = db.Topics.Include("City").Where(e => e.CountryId == Id && e.CategoryId == CategoryId&& e.CityId ==fe2aId).ToList();
            return View(topics);
        }


        public ActionResult Topicss(int Id, int CategoryId, int fe2aId,string s)
        {
            ViewBag.Category = db.Categories.SingleOrDefault(e => e.Id == CategoryId);
            ViewBag.Country = db.Countries.SingleOrDefault(e => e.Id == Id);
            ViewBag.fe2a = Id;
            var topics = db.Topics.Include("City").Where(e => e.CountryId == Id && e.CategoryId == CategoryId&& e.CityId ==fe2aId &&e.DNA == s).ToList();
            return View("Topics", topics);
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

    class CityFe2aVM
    {
        public int cityId { get; set; }
        public int fe2aId { get; set; }
    }
}