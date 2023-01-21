using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c= new Context();
        [Authorize]
        public ActionResult Admin()
        {
            var deger = c.Duyurulars.ToList();
            return View(deger);
        }
     
    }
}