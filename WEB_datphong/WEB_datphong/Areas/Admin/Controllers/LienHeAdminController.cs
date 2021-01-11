using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class LienHeAdminController : Controller
    {
        // GET: Admin/LienHeAdmin
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var db = LienHeBUS.DanhSach();
            return View(db);
        }
    }
}