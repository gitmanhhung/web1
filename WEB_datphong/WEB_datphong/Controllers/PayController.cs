using HotelConection;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay
        public ActionResult Index()
        {
            ViewBag.TongTien = GioHangBUS.TongTien(User.Identity.GetUserId());
            return View();
        }
        public ActionResult Detail()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(THANHTOAN tHANHTOAN)
        {
            try
            {
                // TODO: Add insert logic here
                tHANHTOAN.MaTaiKhoan = User.Identity.GetUserId();
                PayBUS.them(tHANHTOAN);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("~/GioHang/Index");
            }
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CapNhat( int tongtien, String hoten, String diachi, int sdt, String email, String sothe)
        {
            try
            {
                
                // TODO: Add insert logic here
                PayBUS.CapNhat(User.Identity.GetUserId(),tongtien, hoten, diachi, sdt, email, sothe);
                return RedirectToAction("Detail");
            }
            catch
            {
                return View("~/Room/Index");
            }
        }
        [HttpGet]
        public ActionResult update(string TinhTrang)
        {
            try
            {
                // TODO: Add insert logic here
               PayBUS.update(User.Identity.GetUserId(),TinhTrang);
                return RedirectToAction("Detail");
            }
            catch
            {
                return View("../Room/Index");
            }
        }
    }
}