using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Controllers
{
    [Authorize]
    public class GioHangController : Controller
    {
        // GET: GioHang
        public ActionResult Index()
         
        {
           
            ViewBag.TongTien = GioHangBUS.TongTien(User.Identity.GetUserId());
            //ViewBag.chuoidatphong = GioHangBUS.chuoidatphong(User.Identity.GetUserId());
         
            return View(GioHangBUS.DanhSach(User.Identity.GetUserId()));
           
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Them(String maphong,String tenphong,DateTime ngaydat,int songay,int gia,String tinhtrang)
        {
            try
            {
                // TODO: Add insert logic here
                GioHangBUS.Them(User.Identity.GetUserId(), maphong, tenphong, ngaydat, songay, gia,tinhtrang);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("~/Room/Index");
            }
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CapNhat(String maphong, String tenphong, DateTime ngaydat, int songay, int gia,String tinhtrang)
        {
            try
            {
                // TODO: Add insert logic here
                GioHangBUS.CapNhat(User.Identity.GetUserId(), maphong, tenphong, ngaydat, songay, gia,tinhtrang);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("~/Room/Index");
            }
        }
        [HttpGet]
        public ActionResult Xoa(String maphong)
        {
            try
            {
                // TODO: Add insert logic here
                GioHangBUS.Xoa(User.Identity.GetUserId(), maphong);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("../Room/Index");
            }
        }
        //update gio hang
        [HttpGet]
        public ActionResult update()
        {
            try
            {
                // TODO: Add insert logic here
                GioHangBUS.update(User.Identity.GetUserId());
                return RedirectToAction("Detail");
            }
            catch
            {
                return View("../Room/Index");
            }
        }
    }
}