using ogrenciKayitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ogrenciKayitMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ogrenciKaydet(string Ad, string Soyad, string Ders, int Not)
        {
            if (HttpRuntime.Cache["Ogrenciler"] == null)
            {
                List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
                Ogrenci ogr = new Ogrenci();
                ogr.Ad = Ad;
                ogr.Soyad = Soyad;
                ogr.Ders = Ders;
                ogr.Not = Not;

                OgrenciListesi.Add(ogr);
                HttpRuntime.Cache["Ogrenciler"] = OgrenciListesi;
            }
            else
            {
                List<Ogrenci> OgrenciListesi = (List<Ogrenci>)HttpRuntime.Cache["Ogrenciler"];
                Ogrenci ogr = new Ogrenci();
                ogr.Ad = Ad;
                ogr.Soyad = Soyad;
                ogr.Ders = Ders;
                ogr.Not = Not;
                OgrenciListesi.Add(ogr);
                HttpRuntime.Cache["Ogrenciler"] = OgrenciListesi;
            }
            return RedirectToAction("OgrenciListesi");

        }

        public ActionResult OgrenciListesi()
        {
            var model = (List<Ogrenci>)HttpRuntime.Cache["Ogrenciler"];
            return View(model);
        }
    }
}