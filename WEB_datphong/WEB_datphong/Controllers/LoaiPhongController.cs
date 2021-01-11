using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Controllers
{
    public class LoaiPhongController : Controller
    {
        // GET: LoaiPhong
        public ActionResult Index(string id)
        {
            var ds = LoaiPhongBUS.ChiTiet(id);
            return View(ds);
        }
    }
}