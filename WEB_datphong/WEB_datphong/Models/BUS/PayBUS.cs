using HotelConection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WEB_datphong.Models.BUS
{
    public class PayBUS
    {
        public static void them(THANHTOAN tHANHTOAN)
        {
            var db = new HotelConectionDB();

            db.Insert(tHANHTOAN);
        }

        public static void CapNhat(String mataikhoan,int tongtien , String hoten, String diachi, int sdt, String email, String sothe)
        {
            using (var db = new HotelConectionDB())
            {
                THANHTOAN tHANHTOAN = new THANHTOAN()
                {

                    MaTaiKhoan = mataikhoan,
                    NgayThanhToan = DateTime.Now,
                    HoTen = hoten,
                    DiaChi = diachi,
                    Sdt = sdt,
                    Email = email,
                    TongTien = tongtien,
                    SoThe = sothe,
                };
                var tamp = db.Query<THANHTOAN>("Select id from THANHTOAN Where MaTaiKhoan='" + mataikhoan + "' ").FirstOrDefault();
                
                db.Update(tHANHTOAN, tamp.id);
            }
        }
        public static void update(String mataikhoan,String TinhTrang)
        {
            using (var db = new HotelConectionDB())
            {
                GioHang gioHang = new GioHang()
                {

                    MaTaiKhoan = mataikhoan,
                    TinhTrang = "1",
                };
                var tamp = db.Query<GioHang>("Select id from GioHang Where MaTaiKhoan='" + mataikhoan + "' TinhTrang='" + TinhTrang + "' ").FirstOrDefault();

                db.Update(gioHang, tamp.id);
            }

        }
    }
}