using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_datphong.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult Index(String maphong, String tenphong, DateTime ngaydat, int songay, int gia)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here
        //        GioHangBUS.CapNhat(User.Identity.GetUserId(), maphong, tenphong, ngaydat, songay, gia);
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View("~/Room/Index");
        //    }
        //}
    }
}