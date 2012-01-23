using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewData["Message"] = "Hello, world! from ASP.NET MVC";

            var server = MongoServer.Create("mongodb://heroku_app522285:r1r0ig3q3fbohld0tk9tf90ccj@ds029287.mongolab.com:29287/heroku_app522285");
            var database = server.GetDatabase("heroku_app522285", server.Settings.DefaultCredentials);
            ViewData["Posts"] = database.GetCollection("posts").FindAll().SetSortOrder(SortBy.Descending("created"));

            return View();
        }

    }
}
