using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.model
{
    public class tourdetail
    {
        public string Idtour { set; get; }
        public string Ten { set; get; }
        public string Hanhtrinh { set; get; }
        public string Thoigian { set; get; }
        public string Khoihanh { set; get; }
        public string Vanchuyen { set; get; }
        public string Diemnoibat { set; get; }
        public string Giatien { set; get; }
        public string Ngay1 { set; get; }
        public string Ngay2 { set; get; }
        public string Ngay3 { set; get; }
        public string Ngay4 { set; get; }
        public string Ngay5 { set; get; }
        public string Ngay6 { set; get; }
        public tourdetail(string idtour, string ten, string hanhtrinh, string thoigian, string khoihanh, string vanchuyen, string diemnoibat, string giatien, string ngay1, string ngay2, string ngay3, string ngay4, string ngay5, string ngay6)
        {
            Idtour = idtour;
            Ten = ten;
            Hanhtrinh = hanhtrinh;
            Thoigian = thoigian;
            Khoihanh = khoihanh;
            Vanchuyen = vanchuyen;
            Diemnoibat = diemnoibat;
            Giatien = giatien;
            Ngay1 = ngay1;
            Ngay2 = ngay2;
            Ngay3 = ngay3;
            Ngay4 = ngay4;
            Ngay5 = ngay5;
            Ngay6 = ngay6;
        }
    }
}
