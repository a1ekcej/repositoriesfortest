using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Data.Entity;
using Srtoi_tech_App.Models;

namespace Srtoi_tech_App.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db = new UsersContext();
        
        public ActionResult Index()
        {
            IEnumerable<MyUser> user = db.MyUsers;
            IEnumerable<MyAdmin> admin = db.MyAdmins;

            ViewBag.Users = user;
            ViewBag.Admins = admin;
            
            
            //var mvcName = typeof(Controller).Assembly.GetName();
            //var isMono = Type.GetType("Mono.Runtime") != null;
            //var x = 5;

            //ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            //ViewData["Runtime"] = isMono ? "Mono" : ".NET";
            //ViewBag.X = x;
            return View();
        }
    }
}
