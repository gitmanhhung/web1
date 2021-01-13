using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class DanhGiaAdminController : Controller
    {
        // GET: Admin/DanhGiaAdmin
        [Authorize(Roles = "Admin,Employee")]

        public ActionResult Index()
        {
            var db = DanhGiaBUS.DanhSach();
            return View(db);
        }
        [HttpGet]

        public ActionResult xoadanhgia(int id)
        {
            try
            {


                // TODO: Add delete logic here
                DanhGiaBUS.xoadanhgia(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}