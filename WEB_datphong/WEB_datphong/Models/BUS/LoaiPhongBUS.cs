using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_datphong.Models.BUS
{
    public class LoaiPhongBUS
    {
        //---------Khách hàng---------------
        public static IEnumerable<LOAIPHONG> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<LOAIPHONG>("select * from LOAIPHONG where TinhTrang = 0");
        }
        public static IEnumerable<PHONG> ChiTiet(string id)
        {
            var db = new HotelConectionDB();
            return db.Query<PHONG>("select * from PHONG where MaLoaiPhong = '" + id + "'");
        }
        //-----------Admin------------
        public static IEnumerable<LOAIPHONG> DanhSachAdmin()
        {
            var db = new HotelConectionDB();
            return db.Query<LOAIPHONG>("select * from LoaiPhong ");
        }
        public static void them(LOAIPHONG lp)
        {
            var db = new HotelConectionDB();
            db.Insert(lp);
        }
        public static void updateAdmin(string id, LOAIPHONG lp)
        {
            var db = new HotelConectionDB();
            db.Update(lp, id);
        }
        public static LOAIPHONG ChiTietAdmin(string id)
        {
            var db = new HotelConectionDB();
            return db.SingleOrDefault<LOAIPHONG>("select * from LOAIPHONG where MaLoaiPhong = '" + id + "'");
        }
    }
}