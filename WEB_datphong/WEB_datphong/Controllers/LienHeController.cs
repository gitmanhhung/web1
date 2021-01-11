using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GuiLienHe(LIENHE lIENHE)
        {
            try
            {
                // TODO: Add insert logic here
                LienHeBUS.GuiLienHe(lIENHE);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}