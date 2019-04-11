using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogProject.Models;

namespace BlogProject.Areas.AdminPaneli.Controllers
{
    public class KategorilerController : Controller
    {
        Blog304DBEntities1 db = new Blog304DBEntities1();
        // GET: AdminPaneli/Kategoriler
        public ActionResult KategorilerIndex()
        {
            return View(db.Kategoriler.ToList());
        }
        public ActionResult KategoriEkleIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkleIndex(string KategoriAdi, string Aciklama)
        {
            KategoriEkle(KategoriAdi, Aciklama);

            return View();
        }
        public ActionResult KategoriGuncelleIndex(int KategorilerID)
        {
            return View(KategoriBul(KategorilerID));
        }
        [HttpPost]
        public ActionResult KategoriGuncelleIndex(int KategorilerID, string KategoriAdi, string Aciklama)
        {
            KategoriGuncelle(KategorilerID, KategoriAdi, Aciklama);
            return View(KategoriBul(KategorilerID));
        }
        public ActionResult KategoriSil(int KategorilerID)
        {
            KategoriSil1(KategorilerID);
            return RedirectToAction("KategorilerIndex");
        }
        






        public Kategoriler KategoriBul(int id)
        {
            return db.Kategoriler.Where(k => k.KategorilerID == id).FirstOrDefault();
        }
                          
        public void KategoriEkle(string kategoriAdi, string aciklama)
        {
            Kategoriler kategori = new Kategoriler();

            kategori.KategoriAdi = kategoriAdi;
            kategori.Aciklama = aciklama;

            db.Kategoriler.Add(kategori);
            db.SaveChanges();


        }
        public void KategoriGuncelle(int id, string kategoriAdi, string aciklama)
        {
            Kategoriler kategori = KategoriBul(id);

            if (kategori != null)
            {
                kategori.KategoriAdi = kategoriAdi;
                kategori.Aciklama = aciklama;

                db.SaveChanges();
            }



        }

        public void KategoriSil1(int id)
        {
            Kategoriler kategori = KategoriBul(id);

            if (kategori != null)
            {
                 db.Kategoriler.Remove(kategori);
                db.SaveChanges();
            }
        }

    }
}