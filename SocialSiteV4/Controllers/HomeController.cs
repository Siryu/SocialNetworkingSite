using SocialSiteV4.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialSiteV4.Controllers
{
    public class HomeController : Controller
    {
        private IDAL DAL;

        public HomeController(IDAL dalParam)
        {
            DAL = dalParam;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            List<string> imagesDone = new List<string>();
            IEnumerable<string> images = Directory.EnumerateFiles(Server.MapPath("~/Images/Gallery"));
            foreach (var item in images)
            {
                imagesDone.Add("~/Images/Gallery/" + Path.GetFileName(item));
            }
            return View(imagesDone);
        }

        public ActionResult ProfilePage(string UserName)
        {
            if (User.Identity.Name == UserName)
            {
                return View("editProfile", DAL.GetProfile(UserName));
            }
            return View(DAL.GetProfile(UserName));
        }
    }
}