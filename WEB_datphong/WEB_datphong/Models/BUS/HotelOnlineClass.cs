using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WEB_datphong.Models.BUS
{
    public class HotelOnlineClass
    {
        public static IEnumerable<PHONG> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<PHONG>("select * from PHONG where TinhTrang = 0");
        }
        public static PHONG ChiTiet(String a)
        {
            var db = new HotelConectionDB();
            return db.SingleOrDefault<PHONG>("select * from PHONG where MaPhong=@0", a);
        }
        public static IEnumerable<PHONG> newPhong()
        {
            var db = new HotelConectionDB();
            return db.Query<PHONG>("select * from PHONG where GhiChu = N'new'");
        }
        public static IEnumerable<PHONG> DanhSachPhong()
        {
            var db = new HotelConectionDB();
            return db.Query<PHONG>("select * from PHONG");
        }
        public static void InSertPhong(PHONG pHONG)
        {
            var db = new HotelConectionDB();
            db.Insert(pHONG);
        }
        public static void updatePhong(String id, PHONG pHONG)
        {
            var db = new HotelConectionDB();
            db.Update(pHONG, id);
        }
        public static void deletePhong(PHONG pHONG)
        {

            var db = new HotelConectionDB();
            db.Delete<PHONG>(pHONG);
        }
    }
}
