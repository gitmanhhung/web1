using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class KhachSanAdminController : Controller
    {
        [Authorize(Roles ="Admin")]
        // GET: Admin/KhachSanAdmin
        public ActionResult Index()
        {
            var ds = KhachSanBUS.DanhSachAdmin();
            return View(ds);
        }

        // GET: Admin/KhachSanAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/KhachSanAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KhachSanAdmin/Create
        [HttpPost]
        public ActionResult Create(KHACHSAN kHACHSAN)
        {
            try
            {
                // TODO: Add insert logic here
                KhachSanBUS.them(kHACHSAN);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/KhachSanAdmin/Edit/5
        public ActionResult Edit(string id)
        {
            return View(KhachSanBUS.ChiTietAdmin(id));
        }
        public ActionResult XoaTamThoi(String id)
        {
            return View(KhachSanBUS.ChiTietAdmin(id));
        }
        // POST: Admin/KhachSanAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, KHACHSAN kHACHSAN)
        {
            try
            {
                // TODO: Add update logic here
                KhachSanBUS.updateAdmin(id, kHACHSAN);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult XoaTamThoi(String id, KHACHSAN kHACHSAN)
        {
            try
            {
                // TODO: Add delete logic here
                kHACHSAN.TinhTrang = "1";
                KhachSanBUS.updateAdmin(id, kHACHSAN);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Admin/KhachSanAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/KhachSanAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
