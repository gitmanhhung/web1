using HotelConection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WEB_datphong.Models.BUS
{
    public class GioHangBUS
    {
        public static void Them(String mataikhoan, String maphong, String tenphong, DateTime ngaydat, int songay, int gia, String tinhtrang)
        {
            using (var db = new HotelConectionDB())
            {
                var x = db.Query<GioHang>("Select * from GioHang Where MaTaiKhoan='" + mataikhoan + "'and MaPhong='" + maphong + "' ").ToList();
                if (x.Count > 0)
                {
                  
                    int a = (int)x.ElementAt(0).SoNgay + songay;
                
                    CapNhat(mataikhoan, maphong, tenphong, ngaydat, a, gia,tinhtrang);
                }
                else
                {
                    GioHang giohang = new GioHang()

                    {

                        MaTaiKhoan = mataikhoan,
                        MaPhong = maphong,
                        TenPhong = tenphong,
                        NgayDat = ngaydat,
                        SoNgay = songay,
                        Gia = gia,
                        TongTien = gia * songay,
                        TinhTrang = "0",


                    };
                    db.Insert(giohang);
                }
            }
        }
        public static void CapNhat(String mataikhoan, String maphong, String tenphong, DateTime ngaydat, int songay, int gia,String tinhtrang)
        {
            using (var db = new HotelConectionDB())
            {
                GioHang giohang = new GioHang()
                {
                    MaPhong = maphong,
                    MaTaiKhoan = mataikhoan,
                    TenPhong = tenphong,
                    NgayDat = ngaydat,
                    SoNgay = songay,
                    Gia = gia,
                    TongTien = gia * songay,
                    TinhTrang = "0",
                };
                var tamp = db.Query<GioHang>("Select id from GioHang Where MaTaiKhoan='" + mataikhoan + "'and MaPhong='" + maphong + "' ").FirstOrDefault();
                db.Update(giohang, tamp.id);
            }
        }
        public static IEnumerable<GioHang> DanhSach(String mataikhoan)
        {
            using (var db=new HotelConectionDB())
            {
                return  db.Query<GioHang>("select * from GioHang where MaTaiKhoan='" + mataikhoan + "' and TinhTrang=0" );
            }
        }
        
        public static int TongTien(String mataikhoan)
        {
            using (var db=new HotelConectionDB())
            {
                return db.Query<int>("select sum(TongTien) from GioHang where MaTaiKhoan='" + mataikhoan + "'and TinhTrang=0 " ).FirstOrDefault();
            }
        }
        public static void Xoa(String mataikhoan, String maphong)
        {
            using (var db = new HotelConectionDB())
            {
               
                var a = db.Query<GioHang>("Select * from GioHang Where MaTaiKhoan='" + mataikhoan + "'and MaPhong='" + maphong + "' ").FirstOrDefault();
                db.Delete(a);
            }
        }
        //thay doi tinh trang
        public static void update(String mataikhoan)
        {
            using (var db = new HotelConectionDB())
            {

                 db.Query<GioHang>("UPDATE GioHang SET TinhTrang='1'   Where MaTaiKhoan='" + mataikhoan + "'and TinhTrang=0 ");
                
            }
        }
        //public static String chuoidatphong(String mataikhoan)
        //{
        //    using (var db = new HotelConectionDB())
        //    {
        //        return db.Query<String>("select TenPhong from GioHang where MaTaiKhoan='" + mataikhoan + "'").FirstOrDefault();
        //    }
        //}
    } 
}