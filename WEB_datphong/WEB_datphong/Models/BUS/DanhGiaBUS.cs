using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_datphong.Models.BUS
{
    public class DanhGiaBUS
    {
        public static void GuiDanhGia(DANHG dANHG)
        {
            dANHG.NgayDanhGia=DateTime.Now;
            var db = new HotelConectionDB();
            db.Insert(dANHG);
        }
        public static IEnumerable<DANHG> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<DANHG>("select * from DANHG");
        }
        public static void xoadanhgia(int id)
        {

            var db = new HotelConectionDB();
            var a = db.Query<DANHG>("Select * from DANHG Where id='" + id + "' ").FirstOrDefault();
            db.Delete(a);
        }
    }
}