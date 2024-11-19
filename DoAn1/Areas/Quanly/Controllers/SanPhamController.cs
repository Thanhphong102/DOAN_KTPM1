using DoAn1.Areas.Quanly.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn1.Areas.Quanly.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Quanly/SanPham
        public ActionResult Sanpham()
        {
            WebP2HEntities db = new WebP2HEntities();
            List<SANPHAM> dssanpham = db.SANPHAMs.ToList();
            return View(dssanpham);
        }
        public ActionResult ChitietSP()
        {
            WebP2HEntities db = new WebP2HEntities();
            List<SANPHAM> dssanpham = db.SANPHAMs.ToList();
            return View(dssanpham);
        }
        public ActionResult ThemSP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemSP(SANPHAM model)
        {
            WebP2HEntities db = new WebP2HEntities();
            db.SANPHAMs.Add(model);
            db.SaveChanges();
            return RedirectToAction("SanPham", "SanPham");
        }
        public ActionResult Danhmuc()
        {
            WebP2HEntities db = new WebP2HEntities();
            List<SANPHAM> dssanpham = db.SANPHAMs.ToList();
            return View(dssanpham);
        }
        public ActionResult ThemDM()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ThemDM(DANHMUC model)
        {
            WebP2HEntities db = new WebP2HEntities();
            db.DANHMUCs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Danhmuc","SanPham");
        }
        public ActionResult Khachhang()
        {
            WebP2HEntities db = new WebP2HEntities();
            List<KHACHHANG> dssanpham = db.KHACHHANGs.ToList();
            return View(dssanpham);
        }
        public ActionResult Donhang()
        {
            WebP2HEntities db = new WebP2HEntities();
            List<DONHANG> dssanpham = db.DONHANGs.ToList();
            return View(dssanpham);
        }
    }
}