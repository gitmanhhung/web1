using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_datphong.Models.BUS
{
    public class KhachSanBUS
    {
        //----------khách hàng-----------
        public static IEnumerable<KHACHSAN> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<KHACHSAN>("select * from KHACHSAN where TinhTrang = 0");
        }

        public static IEnumerable<PHONG> ChiTiet(string id)
        {
            var db = new HotelConectionDB();
            return db.Query<PHONG>("select * from PHONG where MaKhachSan = '" + id + "'");
        }
        //-----------admin-----------
        public static void them(KHACHSAN kHACHSAN)
        {
            var db = new HotelConectionDB();
            db.Insert(kHACHSAN);
        }
        public static IEnumerable<KHACHSAN> DanhSachAdmin()
        {
            var db = new HotelConectionDB();
            return db.Query<KHACHSAN>("select * from KHACHSAN ");
        }
        public static KHACHSAN ChiTietAdmin(string id)
        {
            var db = new HotelConectionDB();
            return db.SingleOrDefault<KHACHSAN>("select * from KHACHSAN where MaKhachSan = '" + id + "'");
        }
        public static void updateAdmin(string id, KHACHSAN kHACHSAN)
        {
            var db = new HotelConectionDB();
            db.Update(kHACHSAN, id);
        }
    }
}