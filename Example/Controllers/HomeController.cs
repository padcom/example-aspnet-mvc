using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Configuration;

namespace Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewData["Message"] = "Hello, world! from ASP.NET MVC";

            var connectionString = ConfigurationManager.AppSettings["MONGOLAB_URI"];
            var uri = new MongoUrl(connectionString);
            var server = MongoServer.Create(uri);
            var database = server.GetDatabase(uri.DatabaseName, server.Settings.DefaultCredentials);
            ViewData["Posts"] = database.GetCollection("posts").FindAll().SetSortOrder(SortBy.Descending("created"));

            return View();
        }

    }
}
