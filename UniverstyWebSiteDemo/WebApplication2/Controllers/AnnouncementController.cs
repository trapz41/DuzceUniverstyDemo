using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AnnouncementController : Controller
    {
        // GET: Announcement
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Duyurulars.ToList();
            return View(deger);
        }

        public ActionResult AnasayfaGetir(int id)
        {
            var ag = c.Duyurulars.Find(id);
            return View("AnasayfaGetir", ag);
        }
        public ActionResult AnasayfaGuncelle(Duyurular x)
        {
            var ag = c.Duyurulars.Find(x.id);
            ag.baslik = x.baslik;
            ag.duyuru = x.duyuru;
            c.SaveChanges();
            return RedirectToAction("Admin","Admin");
        }
        public ActionResult DuyuruEkle()
        {
            return View();

        }
        public ActionResult DuyuruYaz(Duyurular p)
        {
            c.Duyurulars.Add(p);
            c.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }
        public ActionResult DuyuruSil(int id)
        {
            var sl = c.Duyurulars.Find(id);
            c.Duyurulars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }
    }
}