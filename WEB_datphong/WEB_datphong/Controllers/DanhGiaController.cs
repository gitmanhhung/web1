using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Controllers
{
    public class DanhGiaController : Controller
    {
        // GET: DanhGia

        public ActionResult Index()
        {
            
            var db = DanhGiaBUS.DanhSach();
            return View(db);
        }
        public ActionResult GuiDanhGia(DANHG dANHG)
        {
            try
            {
                // TODO: Add insert logic here
                DanhGiaBUS.GuiDanhGia(dANHG);
               
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }
    }
}