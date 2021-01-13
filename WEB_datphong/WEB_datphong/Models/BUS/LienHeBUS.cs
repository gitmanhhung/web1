using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_datphong.Models.BUS
{
    public class LienHeBUS
    {
        public static void GuiLienHe(LIENHE lIENHE)
        {
            var db = new HotelConectionDB();
            db.Insert(lIENHE);
        }
        public static IEnumerable<LIENHE> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<LIENHE>("select * from LIENHE");
        }
        public static void xoalienhe(int idLienHe)
        {

            var db = new HotelConectionDB();
            var a = db.Query<LIENHE>("Select * from LIENHE Where idLienHe='" + idLienHe + "' ").FirstOrDefault();
            db.Delete(a);
        }
    }
}