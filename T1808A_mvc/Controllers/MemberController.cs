using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T1808A_mvc.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Register()
        {
            
            return View();
        }
        public ActionResult Save(string name,int age)
        {
            ViewBag.name = name;
            ViewBag.age = age;

            return View();
        }
    }
}