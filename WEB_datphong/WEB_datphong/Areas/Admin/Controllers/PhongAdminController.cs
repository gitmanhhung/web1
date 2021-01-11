using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Controllers;
using WEB_datphong.Models.BUS;
using System.IO;
using System.Net.Http;
using System.Net;


namespace WEB_datphong.Areas.Admin.Controllers
{
    public class PhongAdminController : Controller
    {
        // GET: Admin/PhongAdmin
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var db = HotelOnlineClass.DanhSachPhong();
            return View(db);
        }

        // GET: Admin/PhongAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/PhongAdmin/Create
        public ActionResult Create()
        {

            ViewBag.MaLoaiPhong = new SelectList(LoaiPhongBUS.DanhSach(), "MaLoaiPhong", "TenLoaiPhong");
            ViewBag.MaKhachSan = new SelectList(KhachSanBUS.DanhSach(), "MaKhachSan", "TenKhachSan");

            return View();
        }

        // POST: Admin/PhongAdmin/Create
        [HttpPost]
        public ActionResult Create(PHONG pHONG)
        {
            try
            {


                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string filename = pHONG.MaPhong;
                    string fullpathwithfilename = "~/Asset/Image/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    pHONG.HinhChinh = "/Asset/Image/" + hpf.FileName; //pHONG.MaPhong + ".jpg"
                }
                hpf = HttpContext.Request.Files[1];
                if (hpf.ContentLength > 0)
                {
                    string filename = pHONG.MaPhong;
                    string fullpathwithfilename = "~/Asset/Image/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    pHONG.Hinh1 = "/Asset/Image/" + hpf.FileName; //pHONG.MaPhong + ".jpg"
                }
                hpf = HttpContext.Request.Files[2];
                if (hpf.ContentLength > 0)
                {
                    string filename = pHONG.MaPhong;
                    string fullpathwithfilename = "~/Asset/Image/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    pHONG.Hinh2 = "/Asset/Image/" + hpf.FileName; //pHONG.MaPhong + ".jpg"
                }
                // hpf = HttpContext.Request.Files[1];
                //if (hpf.ContentLength > 0)
                //{
                //    string fileName = pHONG.MaPhong;
                //    string fullPathWithfileName = "~/Asset/Image/" + fileName + "_1.jpg";
                //    hpf.SaveAs(Server.MapPath(fullPathWithfileName));
                //    pHONG.Hinh1 = pHONG.MaPhong + "_1.jpg";
                //}
                // hpf = HttpContext.Request.Files[2];
                //if (hpf.ContentLength > 0)
                //{
                //    string fileName = pHONG.MaPhong;
                //    string fullPathWithfileName = "~/Asset/Image/" + fileName + "_2.jpg";
                //    hpf.SaveAs(Server.MapPath(fullPathWithfileName));
                //    pHONG.Hinh2 = pHONG.MaPhong + "_2.jpg";
                //}
                pHONG.TinhTrang = "0";
                pHONG.SoLuongDaDat = 0;
                pHONG.LuotView = 0;
                // TODO: Add insert logic here
                HotelOnlineClass.InSertPhong(pHONG);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/PhongAdmin/Edit/5
        public ActionResult Edit(String id)
        {
            ViewBag.MaLoaiPhong = new SelectList(LoaiPhongBUS.DanhSach(), "MaLoaiPhong", "TenLoaiPhong", HotelOnlineClass.ChiTiet(id).MaLoaiPhong);
            ViewBag.MaKhachSan = new SelectList(KhachSanBUS.DanhSach(), "MaKhachSan", "TenKhachSan", HotelOnlineClass.ChiTiet(id).MaKhachSan);
            return View(HotelOnlineClass.ChiTiet(id));
        }

        // POST: Admin/PhongAdmin/Edit/5
        [HttpPost]

        public ActionResult Edit(String id, PHONG pHONG)
        {
            var luu = HotelOnlineClass.ChiTiet(id);
            try
            {
                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string filename = pHONG.MaPhong;
                    string fullpathwithfilename = "~/Asset/Image/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    pHONG.HinhChinh = "/Asset/Image/" + hpf.FileName; //pHONG.MaPhong + ".jpg"
                }
                else
                {
                    pHONG.HinhChinh = luu.HinhChinh;
                }
                hpf = HttpContext.Request.Files[1];
                if (hpf.ContentLength > 0)
                {
                    string filename = pHONG.MaPhong;
                    string fullpathwithfilename = "~/Asset/Image/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    pHONG.Hinh1 = "/Asset/Image/" + hpf.FileName; //pHONG.MaPhong + ".jpg"
                }
                else
                {
                    pHONG.Hinh1 = luu.Hinh1;
                }
                hpf = HttpContext.Request.Files[2];
                if (hpf.ContentLength > 0)
                {
                    string filename = pHONG.MaPhong;
                    string fullpathwithfilename = "~/Asset/Image/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    pHONG.Hinh2 = "/Asset/Image/" + hpf.FileName; //pHONG.MaPhong + ".jpg"
                }
                else
                {
                    pHONG.Hinh2 = luu.Hinh2;
                }
                pHONG.LuotView = luu.LuotView;
                pHONG.SoLuongDaDat = luu.SoLuongDaDat;
                pHONG.TinhTrang = luu.TinhTrang;
                // TODO: Add update logic here
                HotelOnlineClass.updatePhong(id, pHONG);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/PhongAdmin/Delete/5
        public ActionResult Delete(String id)
        {

            return View(HotelOnlineClass.ChiTiet(id));
        }

        // POST: Admin/PhongAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(String id, PHONG pHONG)
        {
            try
            {
                //pHONG.GhiChu = null;
                //pHONG.Gia = null;
                //pHONG.Hinh1 = null;
                //pHONG.Hinh2 = null;
                //pHONG.HinhChinh = null;
                //pHONG.LuotView = null;
                //pHONG.MaKhachSan = null;
                //pHONG.MaLoaiPhong = null;
                //pHONG.MaPhong = null;
                //pHONG.MoTa = null;
                //pHONG.SoLuongDaDat = null;
                //pHONG.TenPhong = null;
                //pHONG.TinhTrang = null;

                // TODO: Add delete logic here
                HotelOnlineClass.deletePhong(pHONG);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
