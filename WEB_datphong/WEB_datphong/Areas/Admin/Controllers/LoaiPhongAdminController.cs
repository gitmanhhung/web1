using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class LoaiPhongAdminController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: Admin/LoaiPhongAdmin
        public ActionResult Index()
        {
            var db = LoaiPhongBUS.DanhSachAdmin();
            return View(db);
        }

        // GET: Admin/LoaiPhongAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/LoaiPhongAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiPhongAdmin/Create
        [HttpPost]
        public ActionResult Create(LOAIPHONG lOAIPHONG)
        {
            try
            {
                // TODO: Add insert logic here
                LoaiPhongBUS.them(lOAIPHONG);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiPhongAdmin/Edit/5
        public ActionResult Edit(string id)
        {
            var db = LoaiPhongBUS.ChiTietAdmin(id);
            return View(db);
        }

        // POST: Admin/LoaiPhongAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, LOAIPHONG lOAIPHONG)
        {
            try
            {
                // TODO: Add update logic here
                LoaiPhongBUS.updateAdmin(id, lOAIPHONG);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiPhongAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/LoaiPhongAdmin/Delete/5
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
        public ActionResult XoaTamThoi(String id)
        {
            var db = LoaiPhongBUS.ChiTietAdmin(id);
            return View(db);
        }
        [HttpPost]
        public ActionResult XoaTamThoi(String id, LOAIPHONG lp)
        {
            try
            {
                // TODO: Add delete logic here
                lp.TinhTrang = "1";
                LoaiPhongBUS.updateAdmin(id, lp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
