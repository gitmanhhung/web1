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
            var db = new HotelConectionDB();
            db.Insert(dANHG);
        }
        public static IEnumerable<DANHG> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<DANHG>("select * from DANHG");
        }
    }
}