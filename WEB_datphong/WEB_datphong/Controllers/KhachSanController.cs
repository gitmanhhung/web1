using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Controllers
{
    public class KhachSanController : Controller
    {
        // GET: KhachSan
        public ActionResult Index(string id)
        {
            var ds = KhachSanBUS.ChiTiet(id);
            return View(ds);
        }
    }
}